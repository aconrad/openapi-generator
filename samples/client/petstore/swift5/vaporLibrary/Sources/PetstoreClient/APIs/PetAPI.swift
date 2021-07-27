//
// PetAPI.swift
//
// Generated by openapi-generator
// https://openapi-generator.tech
//

import Foundation
import Vapor
#if canImport(AnyCodable)
import AnyCodable
#endif

open class PetAPI {

    /**
     Add a new pet to the store
     POST /pet
     - OAuth:
       - type: oauth2
       - name: petstore_auth
     - parameter body: (body) Pet object that needs to be added to the store 
     - returns: `EventLoopFuture` of `ClientResponse` 
     */
    open class func addPetRaw(body: Pet, headers: HTTPHeaders = PetstoreClient.customHeaders, beforeSend: (inout ClientRequest) throws -> () = { _ in }) -> EventLoopFuture<ClientResponse> {
        let localVariablePath = "/pet"
        let localVariableURLString = PetstoreClient.basePath + localVariablePath

        guard let localVariableApiClient = Configuration.apiClient else {
            fatalError("Configuration.apiClient is not set.")
        }

        return localVariableApiClient.send(.POST, headers: headers, to: URI(string: localVariableURLString)) { localVariableRequest in
            try Configuration.apiWrapper(&localVariableRequest)
            
            
            try localVariableRequest.content.encode(body, using: Configuration.contentConfiguration.requireEncoder(for: Pet.defaultContentType))
            
            try beforeSend(&localVariableRequest)
        }
    }

    public enum AddPet {
        case http200(raw: ClientResponse)
        case http405(raw: ClientResponse)
        case http0(raw: ClientResponse)
    }

    /**
     Add a new pet to the store
     POST /pet
     - OAuth:
       - type: oauth2
       - name: petstore_auth
     - parameter body: (body) Pet object that needs to be added to the store 
     - returns: `EventLoopFuture` of `AddPet` 
     */
    open class func addPet(body: Pet, headers: HTTPHeaders = PetstoreClient.customHeaders, beforeSend: (inout ClientRequest) throws -> () = { _ in }) -> EventLoopFuture<AddPet> {
        return addPetRaw(body: body, headers: headers, beforeSend: beforeSend).flatMapThrowing { response -> AddPet in
            switch response.status.code {
            case 200:
                return .http200(raw: response)
            case 405:
                return .http405(raw: response)
            default:
                return .http0(raw: response)
            }
        }
    }


    /**
     Deletes a pet
     DELETE /pet/{petId}
     - OAuth:
       - type: oauth2
       - name: petstore_auth
     - parameter petId: (path) Pet id to delete 
     - parameter apiKey: (header)  (optional)
     - returns: `EventLoopFuture` of `ClientResponse` 
     */
    open class func deletePetRaw(petId: Int64, apiKey: String? = nil, headers: HTTPHeaders = PetstoreClient.customHeaders, beforeSend: (inout ClientRequest) throws -> () = { _ in }) -> EventLoopFuture<ClientResponse> {
        var localVariablePath = "/pet/{petId}"
        let petIdPreEscape = String(describing: petId)
        let petIdPostEscape = petIdPreEscape.addingPercentEncoding(withAllowedCharacters: .urlPathAllowed) ?? ""
        localVariablePath = localVariablePath.replacingOccurrences(of: "{petId}", with: petIdPostEscape, options: .literal, range: nil)
        let localVariableURLString = PetstoreClient.basePath + localVariablePath

        guard let localVariableApiClient = Configuration.apiClient else {
            fatalError("Configuration.apiClient is not set.")
        }

        return localVariableApiClient.send(.DELETE, headers: headers, to: URI(string: localVariableURLString)) { localVariableRequest in
            try Configuration.apiWrapper(&localVariableRequest)
            
            localVariableRequest.headers.add(name: "api_key", value: apiKey?.description ?? "")
            
            
            
            try beforeSend(&localVariableRequest)
        }
    }

    public enum DeletePet {
        case http200(raw: ClientResponse)
        case http400(raw: ClientResponse)
        case http0(raw: ClientResponse)
    }

    /**
     Deletes a pet
     DELETE /pet/{petId}
     - OAuth:
       - type: oauth2
       - name: petstore_auth
     - parameter petId: (path) Pet id to delete 
     - parameter apiKey: (header)  (optional)
     - returns: `EventLoopFuture` of `DeletePet` 
     */
    open class func deletePet(petId: Int64, apiKey: String? = nil, headers: HTTPHeaders = PetstoreClient.customHeaders, beforeSend: (inout ClientRequest) throws -> () = { _ in }) -> EventLoopFuture<DeletePet> {
        return deletePetRaw(petId: petId, apiKey: apiKey, headers: headers, beforeSend: beforeSend).flatMapThrowing { response -> DeletePet in
            switch response.status.code {
            case 200:
                return .http200(raw: response)
            case 400:
                return .http400(raw: response)
            default:
                return .http0(raw: response)
            }
        }
    }


    /**
     * enum for parameter status
     */
    public enum Status_findPetsByStatus: String, CaseIterable, Content {
        case available = "available"
        case pending = "pending"
        case sold = "sold"
    }

    /**
     Finds Pets by status
     GET /pet/findByStatus
     Multiple status values can be provided with comma separated strings
     - OAuth:
       - type: oauth2
       - name: petstore_auth
     - parameter status: (query) Status values that need to be considered for filter 
     - returns: `EventLoopFuture` of `ClientResponse` 
     */
    open class func findPetsByStatusRaw(status: [Status_findPetsByStatus], headers: HTTPHeaders = PetstoreClient.customHeaders, beforeSend: (inout ClientRequest) throws -> () = { _ in }) -> EventLoopFuture<ClientResponse> {
        let localVariablePath = "/pet/findByStatus"
        let localVariableURLString = PetstoreClient.basePath + localVariablePath

        guard let localVariableApiClient = Configuration.apiClient else {
            fatalError("Configuration.apiClient is not set.")
        }

        return localVariableApiClient.send(.GET, headers: headers, to: URI(string: localVariableURLString)) { localVariableRequest in
            try Configuration.apiWrapper(&localVariableRequest)
            
            struct QueryParams: Content {
                var status: [Status_findPetsByStatus]

                enum CodingKeys: String, CodingKey {
                    case status = "status"
                }
            }
            try localVariableRequest.query.encode(QueryParams(status: status))
            
            try beforeSend(&localVariableRequest)
        }
    }

    public enum FindPetsByStatus {
        case http200(value: [Pet], raw: ClientResponse)
        case http400(raw: ClientResponse)
        case http0(raw: ClientResponse)
    }

    /**
     Finds Pets by status
     GET /pet/findByStatus
     Multiple status values can be provided with comma separated strings
     - OAuth:
       - type: oauth2
       - name: petstore_auth
     - parameter status: (query) Status values that need to be considered for filter 
     - returns: `EventLoopFuture` of `FindPetsByStatus` 
     */
    open class func findPetsByStatus(status: [Status_findPetsByStatus], headers: HTTPHeaders = PetstoreClient.customHeaders, beforeSend: (inout ClientRequest) throws -> () = { _ in }) -> EventLoopFuture<FindPetsByStatus> {
        return findPetsByStatusRaw(status: status, headers: headers, beforeSend: beforeSend).flatMapThrowing { response -> FindPetsByStatus in
            switch response.status.code {
            case 200:
                return .http200(value: try response.content.decode([Pet].self, using: Configuration.contentConfiguration.requireDecoder(for: [Pet].defaultContentType)), raw: response)
            case 400:
                return .http400(raw: response)
            default:
                return .http0(raw: response)
            }
        }
    }


    /**
     Finds Pets by tags
     GET /pet/findByTags
     Multiple tags can be provided with comma separated strings. Use tag1, tag2, tag3 for testing.
     - OAuth:
       - type: oauth2
       - name: petstore_auth
     - parameter tags: (query) Tags to filter by 
     - returns: `EventLoopFuture` of `ClientResponse` 
     */
    @available(*, deprecated, message: "This operation is deprecated.")
    open class func findPetsByTagsRaw(tags: Set<String>, headers: HTTPHeaders = PetstoreClient.customHeaders, beforeSend: (inout ClientRequest) throws -> () = { _ in }) -> EventLoopFuture<ClientResponse> {
        let localVariablePath = "/pet/findByTags"
        let localVariableURLString = PetstoreClient.basePath + localVariablePath

        guard let localVariableApiClient = Configuration.apiClient else {
            fatalError("Configuration.apiClient is not set.")
        }

        return localVariableApiClient.send(.GET, headers: headers, to: URI(string: localVariableURLString)) { localVariableRequest in
            try Configuration.apiWrapper(&localVariableRequest)
            
            struct QueryParams: Content {
                var tags: Set<String>

                enum CodingKeys: String, CodingKey {
                    case tags = "tags"
                }
            }
            try localVariableRequest.query.encode(QueryParams(tags: tags))
            
            try beforeSend(&localVariableRequest)
        }
    }

    public enum FindPetsByTags {
        case http200(value: Set<Pet>, raw: ClientResponse)
        case http400(raw: ClientResponse)
        case http0(raw: ClientResponse)
    }

    /**
     Finds Pets by tags
     GET /pet/findByTags
     Multiple tags can be provided with comma separated strings. Use tag1, tag2, tag3 for testing.
     - OAuth:
       - type: oauth2
       - name: petstore_auth
     - parameter tags: (query) Tags to filter by 
     - returns: `EventLoopFuture` of `FindPetsByTags` 
     */
    @available(*, deprecated, message: "This operation is deprecated.")
    open class func findPetsByTags(tags: Set<String>, headers: HTTPHeaders = PetstoreClient.customHeaders, beforeSend: (inout ClientRequest) throws -> () = { _ in }) -> EventLoopFuture<FindPetsByTags> {
        return findPetsByTagsRaw(tags: tags, headers: headers, beforeSend: beforeSend).flatMapThrowing { response -> FindPetsByTags in
            switch response.status.code {
            case 200:
                return .http200(value: try response.content.decode(Set<Pet>.self, using: Configuration.contentConfiguration.requireDecoder(for: Set<Pet>.defaultContentType)), raw: response)
            case 400:
                return .http400(raw: response)
            default:
                return .http0(raw: response)
            }
        }
    }


    /**
     Find pet by ID
     GET /pet/{petId}
     Returns a single pet
     - API Key:
       - type: apiKey api_key 
       - name: api_key
     - parameter petId: (path) ID of pet to return 
     - returns: `EventLoopFuture` of `ClientResponse` 
     */
    open class func getPetByIdRaw(petId: Int64, headers: HTTPHeaders = PetstoreClient.customHeaders, beforeSend: (inout ClientRequest) throws -> () = { _ in }) -> EventLoopFuture<ClientResponse> {
        var localVariablePath = "/pet/{petId}"
        let petIdPreEscape = String(describing: petId)
        let petIdPostEscape = petIdPreEscape.addingPercentEncoding(withAllowedCharacters: .urlPathAllowed) ?? ""
        localVariablePath = localVariablePath.replacingOccurrences(of: "{petId}", with: petIdPostEscape, options: .literal, range: nil)
        let localVariableURLString = PetstoreClient.basePath + localVariablePath

        guard let localVariableApiClient = Configuration.apiClient else {
            fatalError("Configuration.apiClient is not set.")
        }

        return localVariableApiClient.send(.GET, headers: headers, to: URI(string: localVariableURLString)) { localVariableRequest in
            try Configuration.apiWrapper(&localVariableRequest)
            
            
            
            try beforeSend(&localVariableRequest)
        }
    }

    public enum GetPetById {
        case http200(value: Pet, raw: ClientResponse)
        case http400(raw: ClientResponse)
        case http404(raw: ClientResponse)
        case http0(raw: ClientResponse)
    }

    /**
     Find pet by ID
     GET /pet/{petId}
     Returns a single pet
     - API Key:
       - type: apiKey api_key 
       - name: api_key
     - parameter petId: (path) ID of pet to return 
     - returns: `EventLoopFuture` of `GetPetById` 
     */
    open class func getPetById(petId: Int64, headers: HTTPHeaders = PetstoreClient.customHeaders, beforeSend: (inout ClientRequest) throws -> () = { _ in }) -> EventLoopFuture<GetPetById> {
        return getPetByIdRaw(petId: petId, headers: headers, beforeSend: beforeSend).flatMapThrowing { response -> GetPetById in
            switch response.status.code {
            case 200:
                return .http200(value: try response.content.decode(Pet.self, using: Configuration.contentConfiguration.requireDecoder(for: Pet.defaultContentType)), raw: response)
            case 400:
                return .http400(raw: response)
            case 404:
                return .http404(raw: response)
            default:
                return .http0(raw: response)
            }
        }
    }


    /**
     Update an existing pet
     PUT /pet
     - OAuth:
       - type: oauth2
       - name: petstore_auth
     - parameter body: (body) Pet object that needs to be added to the store 
     - returns: `EventLoopFuture` of `ClientResponse` 
     */
    open class func updatePetRaw(body: Pet, headers: HTTPHeaders = PetstoreClient.customHeaders, beforeSend: (inout ClientRequest) throws -> () = { _ in }) -> EventLoopFuture<ClientResponse> {
        let localVariablePath = "/pet"
        let localVariableURLString = PetstoreClient.basePath + localVariablePath

        guard let localVariableApiClient = Configuration.apiClient else {
            fatalError("Configuration.apiClient is not set.")
        }

        return localVariableApiClient.send(.PUT, headers: headers, to: URI(string: localVariableURLString)) { localVariableRequest in
            try Configuration.apiWrapper(&localVariableRequest)
            
            
            try localVariableRequest.content.encode(body, using: Configuration.contentConfiguration.requireEncoder(for: Pet.defaultContentType))
            
            try beforeSend(&localVariableRequest)
        }
    }

    public enum UpdatePet {
        case http200(raw: ClientResponse)
        case http400(raw: ClientResponse)
        case http404(raw: ClientResponse)
        case http405(raw: ClientResponse)
        case http0(raw: ClientResponse)
    }

    /**
     Update an existing pet
     PUT /pet
     - OAuth:
       - type: oauth2
       - name: petstore_auth
     - parameter body: (body) Pet object that needs to be added to the store 
     - returns: `EventLoopFuture` of `UpdatePet` 
     */
    open class func updatePet(body: Pet, headers: HTTPHeaders = PetstoreClient.customHeaders, beforeSend: (inout ClientRequest) throws -> () = { _ in }) -> EventLoopFuture<UpdatePet> {
        return updatePetRaw(body: body, headers: headers, beforeSend: beforeSend).flatMapThrowing { response -> UpdatePet in
            switch response.status.code {
            case 200:
                return .http200(raw: response)
            case 400:
                return .http400(raw: response)
            case 404:
                return .http404(raw: response)
            case 405:
                return .http405(raw: response)
            default:
                return .http0(raw: response)
            }
        }
    }


    /**
     Updates a pet in the store with form data
     POST /pet/{petId}
     - OAuth:
       - type: oauth2
       - name: petstore_auth
     - parameter petId: (path) ID of pet that needs to be updated 
     - parameter name: (form) Updated name of the pet (optional)
     - parameter status: (form) Updated status of the pet (optional)
     - returns: `EventLoopFuture` of `ClientResponse` 
     */
    open class func updatePetWithFormRaw(petId: Int64, name: String? = nil, status: String? = nil, headers: HTTPHeaders = PetstoreClient.customHeaders, beforeSend: (inout ClientRequest) throws -> () = { _ in }) -> EventLoopFuture<ClientResponse> {
        var localVariablePath = "/pet/{petId}"
        let petIdPreEscape = String(describing: petId)
        let petIdPostEscape = petIdPreEscape.addingPercentEncoding(withAllowedCharacters: .urlPathAllowed) ?? ""
        localVariablePath = localVariablePath.replacingOccurrences(of: "{petId}", with: petIdPostEscape, options: .literal, range: nil)
        let localVariableURLString = PetstoreClient.basePath + localVariablePath

        guard let localVariableApiClient = Configuration.apiClient else {
            fatalError("Configuration.apiClient is not set.")
        }

        return localVariableApiClient.send(.POST, headers: headers, to: URI(string: localVariableURLString)) { localVariableRequest in
            try Configuration.apiWrapper(&localVariableRequest)
            
            
            struct FormParams: Content {
                static let defaultContentType = Vapor.HTTPMediaType.formData
                var name: String?
                var status: String?
            }
            try localVariableRequest.content.encode(FormParams(name: name, status: status), using: Configuration.contentConfiguration.requireEncoder(for: FormParams.defaultContentType))
            try beforeSend(&localVariableRequest)
        }
    }

    public enum UpdatePetWithForm {
        case http405(raw: ClientResponse)
        case http0(raw: ClientResponse)
    }

    /**
     Updates a pet in the store with form data
     POST /pet/{petId}
     - OAuth:
       - type: oauth2
       - name: petstore_auth
     - parameter petId: (path) ID of pet that needs to be updated 
     - parameter name: (form) Updated name of the pet (optional)
     - parameter status: (form) Updated status of the pet (optional)
     - returns: `EventLoopFuture` of `UpdatePetWithForm` 
     */
    open class func updatePetWithForm(petId: Int64, name: String? = nil, status: String? = nil, headers: HTTPHeaders = PetstoreClient.customHeaders, beforeSend: (inout ClientRequest) throws -> () = { _ in }) -> EventLoopFuture<UpdatePetWithForm> {
        return updatePetWithFormRaw(petId: petId, name: name, status: status, headers: headers, beforeSend: beforeSend).flatMapThrowing { response -> UpdatePetWithForm in
            switch response.status.code {
            case 405:
                return .http405(raw: response)
            default:
                return .http0(raw: response)
            }
        }
    }


    /**
     uploads an image
     POST /pet/{petId}/uploadImage
     - OAuth:
       - type: oauth2
       - name: petstore_auth
     - parameter petId: (path) ID of pet to update 
     - parameter additionalMetadata: (form) Additional data to pass to server (optional)
     - parameter file: (form) file to upload (optional)
     - returns: `EventLoopFuture` of `ClientResponse` 
     */
    open class func uploadFileRaw(petId: Int64, additionalMetadata: String? = nil, file: Data? = nil, headers: HTTPHeaders = PetstoreClient.customHeaders, beforeSend: (inout ClientRequest) throws -> () = { _ in }) -> EventLoopFuture<ClientResponse> {
        var localVariablePath = "/pet/{petId}/uploadImage"
        let petIdPreEscape = String(describing: petId)
        let petIdPostEscape = petIdPreEscape.addingPercentEncoding(withAllowedCharacters: .urlPathAllowed) ?? ""
        localVariablePath = localVariablePath.replacingOccurrences(of: "{petId}", with: petIdPostEscape, options: .literal, range: nil)
        let localVariableURLString = PetstoreClient.basePath + localVariablePath

        guard let localVariableApiClient = Configuration.apiClient else {
            fatalError("Configuration.apiClient is not set.")
        }

        return localVariableApiClient.send(.POST, headers: headers, to: URI(string: localVariableURLString)) { localVariableRequest in
            try Configuration.apiWrapper(&localVariableRequest)
            
            
            struct FormParams: Content {
                static let defaultContentType = Vapor.HTTPMediaType.formData
                var additionalMetadata: String?
                var file: Data?
            }
            try localVariableRequest.content.encode(FormParams(additionalMetadata: additionalMetadata, file: file), using: Configuration.contentConfiguration.requireEncoder(for: FormParams.defaultContentType))
            try beforeSend(&localVariableRequest)
        }
    }

    public enum UploadFile {
        case http200(value: ApiResponse, raw: ClientResponse)
        case http0(raw: ClientResponse)
    }

    /**
     uploads an image
     POST /pet/{petId}/uploadImage
     - OAuth:
       - type: oauth2
       - name: petstore_auth
     - parameter petId: (path) ID of pet to update 
     - parameter additionalMetadata: (form) Additional data to pass to server (optional)
     - parameter file: (form) file to upload (optional)
     - returns: `EventLoopFuture` of `UploadFile` 
     */
    open class func uploadFile(petId: Int64, additionalMetadata: String? = nil, file: Data? = nil, headers: HTTPHeaders = PetstoreClient.customHeaders, beforeSend: (inout ClientRequest) throws -> () = { _ in }) -> EventLoopFuture<UploadFile> {
        return uploadFileRaw(petId: petId, additionalMetadata: additionalMetadata, file: file, headers: headers, beforeSend: beforeSend).flatMapThrowing { response -> UploadFile in
            switch response.status.code {
            case 200:
                return .http200(value: try response.content.decode(ApiResponse.self, using: Configuration.contentConfiguration.requireDecoder(for: ApiResponse.defaultContentType)), raw: response)
            default:
                return .http0(raw: response)
            }
        }
    }


    /**
     uploads an image (required)
     POST /fake/{petId}/uploadImageWithRequiredFile
     - OAuth:
       - type: oauth2
       - name: petstore_auth
     - parameter petId: (path) ID of pet to update 
     - parameter requiredFile: (form) file to upload 
     - parameter additionalMetadata: (form) Additional data to pass to server (optional)
     - returns: `EventLoopFuture` of `ClientResponse` 
     */
    open class func uploadFileWithRequiredFileRaw(petId: Int64, requiredFile: Data, additionalMetadata: String? = nil, headers: HTTPHeaders = PetstoreClient.customHeaders, beforeSend: (inout ClientRequest) throws -> () = { _ in }) -> EventLoopFuture<ClientResponse> {
        var localVariablePath = "/fake/{petId}/uploadImageWithRequiredFile"
        let petIdPreEscape = String(describing: petId)
        let petIdPostEscape = petIdPreEscape.addingPercentEncoding(withAllowedCharacters: .urlPathAllowed) ?? ""
        localVariablePath = localVariablePath.replacingOccurrences(of: "{petId}", with: petIdPostEscape, options: .literal, range: nil)
        let localVariableURLString = PetstoreClient.basePath + localVariablePath

        guard let localVariableApiClient = Configuration.apiClient else {
            fatalError("Configuration.apiClient is not set.")
        }

        return localVariableApiClient.send(.POST, headers: headers, to: URI(string: localVariableURLString)) { localVariableRequest in
            try Configuration.apiWrapper(&localVariableRequest)
            
            
            struct FormParams: Content {
                static let defaultContentType = Vapor.HTTPMediaType.formData
                var additionalMetadata: String?
                var requiredFile: Data
            }
            try localVariableRequest.content.encode(FormParams(additionalMetadata: additionalMetadata, requiredFile: requiredFile), using: Configuration.contentConfiguration.requireEncoder(for: FormParams.defaultContentType))
            try beforeSend(&localVariableRequest)
        }
    }

    public enum UploadFileWithRequiredFile {
        case http200(value: ApiResponse, raw: ClientResponse)
        case http0(raw: ClientResponse)
    }

    /**
     uploads an image (required)
     POST /fake/{petId}/uploadImageWithRequiredFile
     - OAuth:
       - type: oauth2
       - name: petstore_auth
     - parameter petId: (path) ID of pet to update 
     - parameter requiredFile: (form) file to upload 
     - parameter additionalMetadata: (form) Additional data to pass to server (optional)
     - returns: `EventLoopFuture` of `UploadFileWithRequiredFile` 
     */
    open class func uploadFileWithRequiredFile(petId: Int64, requiredFile: Data, additionalMetadata: String? = nil, headers: HTTPHeaders = PetstoreClient.customHeaders, beforeSend: (inout ClientRequest) throws -> () = { _ in }) -> EventLoopFuture<UploadFileWithRequiredFile> {
        return uploadFileWithRequiredFileRaw(petId: petId, requiredFile: requiredFile, additionalMetadata: additionalMetadata, headers: headers, beforeSend: beforeSend).flatMapThrowing { response -> UploadFileWithRequiredFile in
            switch response.status.code {
            case 200:
                return .http200(value: try response.content.decode(ApiResponse.self, using: Configuration.contentConfiguration.requireDecoder(for: ApiResponse.defaultContentType)), raw: response)
            default:
                return .http0(raw: response)
            }
        }
    }

}