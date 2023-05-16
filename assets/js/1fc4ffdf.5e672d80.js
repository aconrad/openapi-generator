"use strict";(self.webpackChunk=self.webpackChunk||[]).push([[9777],{3905:function(t,a,e){e.d(a,{Zo:function(){return m},kt:function(){return g}});var l=e(7294);function n(t,a,e){return a in t?Object.defineProperty(t,a,{value:e,enumerable:!0,configurable:!0,writable:!0}):t[a]=e,t}function r(t,a){var e=Object.keys(t);if(Object.getOwnPropertySymbols){var l=Object.getOwnPropertySymbols(t);a&&(l=l.filter((function(a){return Object.getOwnPropertyDescriptor(t,a).enumerable}))),e.push.apply(e,l)}return e}function i(t){for(var a=1;a<arguments.length;a++){var e=null!=arguments[a]?arguments[a]:{};a%2?r(Object(e),!0).forEach((function(a){n(t,a,e[a])})):Object.getOwnPropertyDescriptors?Object.defineProperties(t,Object.getOwnPropertyDescriptors(e)):r(Object(e)).forEach((function(a){Object.defineProperty(t,a,Object.getOwnPropertyDescriptor(e,a))}))}return t}function u(t,a){if(null==t)return{};var e,l,n=function(t,a){if(null==t)return{};var e,l,n={},r=Object.keys(t);for(l=0;l<r.length;l++)e=r[l],a.indexOf(e)>=0||(n[e]=t[e]);return n}(t,a);if(Object.getOwnPropertySymbols){var r=Object.getOwnPropertySymbols(t);for(l=0;l<r.length;l++)e=r[l],a.indexOf(e)>=0||Object.prototype.propertyIsEnumerable.call(t,e)&&(n[e]=t[e])}return n}var p=l.createContext({}),k=function(t){var a=l.useContext(p),e=a;return t&&(e="function"==typeof t?t(a):i(i({},a),t)),e},m=function(t){var a=k(t.components);return l.createElement(p.Provider,{value:a},t.children)},d="mdxType",o={inlineCode:"code",wrapper:function(t){var a=t.children;return l.createElement(l.Fragment,{},a)}},N=l.forwardRef((function(t,a){var e=t.components,n=t.mdxType,r=t.originalType,p=t.parentName,m=u(t,["components","mdxType","originalType","parentName"]),d=k(e),N=n,g=d["".concat(p,".").concat(N)]||d[N]||o[N]||r;return e?l.createElement(g,i(i({ref:a},m),{},{components:e})):l.createElement(g,i({ref:a},m))}));function g(t,a){var e=arguments,n=a&&a.mdxType;if("string"==typeof t||n){var r=e.length,i=new Array(r);i[0]=N;var u={};for(var p in a)hasOwnProperty.call(a,p)&&(u[p]=a[p]);u.originalType=t,u[d]="string"==typeof t?t:n,i[1]=u;for(var k=2;k<r;k++)i[k]=e[k];return l.createElement.apply(null,i)}return l.createElement.apply(null,e)}N.displayName="MDXCreateElement"},387:function(t,a,e){e.r(a),e.d(a,{assets:function(){return m},contentTitle:function(){return p},default:function(){return N},frontMatter:function(){return u},metadata:function(){return k},toc:function(){return d}});var l=e(7462),n=e(3366),r=(e(7294),e(3905)),i=["components"],u={title:"Documentation for the fsharp-giraffe-server Generator"},p=void 0,k={unversionedId:"generators/fsharp-giraffe-server",id:"generators/fsharp-giraffe-server",title:"Documentation for the fsharp-giraffe-server Generator",description:"METADATA",source:"@site/../docs/generators/fsharp-giraffe-server.md",sourceDirName:"generators",slug:"/generators/fsharp-giraffe-server",permalink:"/docs/generators/fsharp-giraffe-server",draft:!1,editUrl:"https://github.com/OpenAPITools/openapi-generator/edit/master/website/../docs/generators/fsharp-giraffe-server.md",tags:[],version:"current",lastUpdatedBy:"J\xe9r\xf4me Tama",lastUpdatedAt:1683708697,formattedLastUpdatedAt:"May 10, 2023",frontMatter:{title:"Documentation for the fsharp-giraffe-server Generator"}},m={},d=[{value:"METADATA",id:"metadata",level:2},{value:"CONFIG OPTIONS",id:"config-options",level:2},{value:"IMPORT MAPPING",id:"import-mapping",level:2},{value:"INSTANTIATION TYPES",id:"instantiation-types",level:2},{value:"LANGUAGE PRIMITIVES",id:"language-primitives",level:2},{value:"RESERVED WORDS",id:"reserved-words",level:2},{value:"FEATURE SET",id:"feature-set",level:2},{value:"Client Modification Feature",id:"client-modification-feature",level:3},{value:"Data Type Feature",id:"data-type-feature",level:3},{value:"Documentation Feature",id:"documentation-feature",level:3},{value:"Global Feature",id:"global-feature",level:3},{value:"Parameter Feature",id:"parameter-feature",level:3},{value:"Schema Support Feature",id:"schema-support-feature",level:3},{value:"Security Feature",id:"security-feature",level:3},{value:"Wire Format Feature",id:"wire-format-feature",level:3}],o={toc:d};function N(t){var a=t.components,e=(0,n.Z)(t,i);return(0,r.kt)("wrapper",(0,l.Z)({},o,e,{components:a,mdxType:"MDXLayout"}),(0,r.kt)("h2",{id:"metadata"},"METADATA"),(0,r.kt)("table",null,(0,r.kt)("thead",{parentName:"table"},(0,r.kt)("tr",{parentName:"thead"},(0,r.kt)("th",{parentName:"tr",align:null},"Property"),(0,r.kt)("th",{parentName:"tr",align:null},"Value"),(0,r.kt)("th",{parentName:"tr",align:null},"Notes"))),(0,r.kt)("tbody",{parentName:"table"},(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"generator name"),(0,r.kt)("td",{parentName:"tr",align:null},"fsharp-giraffe-server"),(0,r.kt)("td",{parentName:"tr",align:null},"pass this to the generate command after -g")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"generator stability"),(0,r.kt)("td",{parentName:"tr",align:null},"BETA"),(0,r.kt)("td",{parentName:"tr",align:null})),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"generator type"),(0,r.kt)("td",{parentName:"tr",align:null},"SERVER"),(0,r.kt)("td",{parentName:"tr",align:null})),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"generator language"),(0,r.kt)("td",{parentName:"tr",align:null},"F#"),(0,r.kt)("td",{parentName:"tr",align:null})),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"generator default templating engine"),(0,r.kt)("td",{parentName:"tr",align:null},"mustache"),(0,r.kt)("td",{parentName:"tr",align:null})),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"helpTxt"),(0,r.kt)("td",{parentName:"tr",align:null},"Generates a F# Giraffe server (beta)."),(0,r.kt)("td",{parentName:"tr",align:null})))),(0,r.kt)("h2",{id:"config-options"},"CONFIG OPTIONS"),(0,r.kt)("p",null,"These options may be applied as additional-properties (cli) or configOptions (plugins). Refer to ",(0,r.kt)("a",{parentName:"p",href:"https://openapi-generator.tech/docs/configuration"},"configuration docs")," for more details."),(0,r.kt)("table",null,(0,r.kt)("thead",{parentName:"table"},(0,r.kt)("tr",{parentName:"thead"},(0,r.kt)("th",{parentName:"tr",align:null},"Option"),(0,r.kt)("th",{parentName:"tr",align:null},"Description"),(0,r.kt)("th",{parentName:"tr",align:null},"Values"),(0,r.kt)("th",{parentName:"tr",align:null},"Default"))),(0,r.kt)("tbody",{parentName:"table"},(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"buildTarget"),(0,r.kt)("td",{parentName:"tr",align:null},"Target the build for a program or library."),(0,r.kt)("td",{parentName:"tr",align:null}),(0,r.kt)("td",{parentName:"tr",align:null},"program")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"generateBody"),(0,r.kt)("td",{parentName:"tr",align:null},"Generates method body."),(0,r.kt)("td",{parentName:"tr",align:null}),(0,r.kt)("td",{parentName:"tr",align:null},"true")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"licenseName"),(0,r.kt)("td",{parentName:"tr",align:null},"The name of the license"),(0,r.kt)("td",{parentName:"tr",align:null}),(0,r.kt)("td",{parentName:"tr",align:null},"NoLicense")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"licenseUrl"),(0,r.kt)("td",{parentName:"tr",align:null},"The URL of the license"),(0,r.kt)("td",{parentName:"tr",align:null}),(0,r.kt)("td",{parentName:"tr",align:null},"http://localhost")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"packageAuthors"),(0,r.kt)("td",{parentName:"tr",align:null},"Specifies Authors property in the .NET Core project file."),(0,r.kt)("td",{parentName:"tr",align:null}),(0,r.kt)("td",{parentName:"tr",align:null},"OpenAPI")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"packageCopyright"),(0,r.kt)("td",{parentName:"tr",align:null},"Specifies an AssemblyCopyright for the .NET Framework global assembly attributes stored in the AssemblyInfo file."),(0,r.kt)("td",{parentName:"tr",align:null}),(0,r.kt)("td",{parentName:"tr",align:null},"No Copyright")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"packageGuid"),(0,r.kt)("td",{parentName:"tr",align:null},"The GUID that will be associated with the C# project"),(0,r.kt)("td",{parentName:"tr",align:null}),(0,r.kt)("td",{parentName:"tr",align:null},"null")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"packageName"),(0,r.kt)("td",{parentName:"tr",align:null},"F# module name (convention: Title.Case)."),(0,r.kt)("td",{parentName:"tr",align:null}),(0,r.kt)("td",{parentName:"tr",align:null},"OpenAPI")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"packageTitle"),(0,r.kt)("td",{parentName:"tr",align:null},"Specifies an AssemblyTitle for the .NET Framework global assembly attributes stored in the AssemblyInfo file."),(0,r.kt)("td",{parentName:"tr",align:null}),(0,r.kt)("td",{parentName:"tr",align:null},"OpenAPI Library")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"packageVersion"),(0,r.kt)("td",{parentName:"tr",align:null},"F# package version."),(0,r.kt)("td",{parentName:"tr",align:null}),(0,r.kt)("td",{parentName:"tr",align:null},"1.0.0")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"returnICollection"),(0,r.kt)("td",{parentName:"tr",align:null},"Return ICollection","<","T",">"," instead of the concrete type."),(0,r.kt)("td",{parentName:"tr",align:null}),(0,r.kt)("td",{parentName:"tr",align:null},"false")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"sortParamsByRequiredFlag"),(0,r.kt)("td",{parentName:"tr",align:null},"Sort method arguments to place required parameters before optional parameters."),(0,r.kt)("td",{parentName:"tr",align:null}),(0,r.kt)("td",{parentName:"tr",align:null},"true")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"sourceFolder"),(0,r.kt)("td",{parentName:"tr",align:null},"source folder for generated code"),(0,r.kt)("td",{parentName:"tr",align:null}),(0,r.kt)("td",{parentName:"tr",align:null},"OpenAPI/src")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"useCollection"),(0,r.kt)("td",{parentName:"tr",align:null},"Deserialize array types to Collection","<","T",">"," instead of List","<","T",">","."),(0,r.kt)("td",{parentName:"tr",align:null}),(0,r.kt)("td",{parentName:"tr",align:null},"false")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"useDateTimeOffset"),(0,r.kt)("td",{parentName:"tr",align:null},"Use DateTimeOffset to model date-time properties"),(0,r.kt)("td",{parentName:"tr",align:null}),(0,r.kt)("td",{parentName:"tr",align:null},"false")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"useSwashbuckle"),(0,r.kt)("td",{parentName:"tr",align:null},"Uses the Swashbuckle.AspNetCore NuGet package for documentation."),(0,r.kt)("td",{parentName:"tr",align:null}),(0,r.kt)("td",{parentName:"tr",align:null},"false")))),(0,r.kt)("h2",{id:"import-mapping"},"IMPORT MAPPING"),(0,r.kt)("table",null,(0,r.kt)("thead",{parentName:"table"},(0,r.kt)("tr",{parentName:"thead"},(0,r.kt)("th",{parentName:"tr",align:null},"Type/Alias"),(0,r.kt)("th",{parentName:"tr",align:null},"Imports"))),(0,r.kt)("tbody",{parentName:"table"},(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"IDictionary"),(0,r.kt)("td",{parentName:"tr",align:null},"System.Collections.Generic")))),(0,r.kt)("h2",{id:"instantiation-types"},"INSTANTIATION TYPES"),(0,r.kt)("table",null,(0,r.kt)("thead",{parentName:"table"},(0,r.kt)("tr",{parentName:"thead"},(0,r.kt)("th",{parentName:"tr",align:null},"Type/Alias"),(0,r.kt)("th",{parentName:"tr",align:null},"Instantiated By"))),(0,r.kt)("tbody",{parentName:"table"},(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"array"),(0,r.kt)("td",{parentName:"tr",align:null},"list")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"list"),(0,r.kt)("td",{parentName:"tr",align:null},"list")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"map"),(0,r.kt)("td",{parentName:"tr",align:null},"IDictionary")))),(0,r.kt)("h2",{id:"language-primitives"},"LANGUAGE PRIMITIVES"),(0,r.kt)("ul",{class:"column-ul"},(0,r.kt)("li",null,"Collection"),(0,r.kt)("li",null,"DataTimeOffset"),(0,r.kt)("li",null,"DateTime"),(0,r.kt)("li",null,"Dictionary"),(0,r.kt)("li",null,"Double"),(0,r.kt)("li",null,"ICollection"),(0,r.kt)("li",null,"Int32"),(0,r.kt)("li",null,"Int64"),(0,r.kt)("li",null,"List"),(0,r.kt)("li",null,"String"),(0,r.kt)("li",null,"System.IO.Stream"),(0,r.kt)("li",null,"bool"),(0,r.kt)("li",null,"byte[]"),(0,r.kt)("li",null,"char"),(0,r.kt)("li",null,"decimal"),(0,r.kt)("li",null,"dict"),(0,r.kt)("li",null,"double"),(0,r.kt)("li",null,"float"),(0,r.kt)("li",null,"float32"),(0,r.kt)("li",null,"int"),(0,r.kt)("li",null,"int16"),(0,r.kt)("li",null,"int64"),(0,r.kt)("li",null,"list"),(0,r.kt)("li",null,"nativeint"),(0,r.kt)("li",null,"obj"),(0,r.kt)("li",null,"seq"),(0,r.kt)("li",null,"single"),(0,r.kt)("li",null,"string"),(0,r.kt)("li",null,"uint16"),(0,r.kt)("li",null,"uint32"),(0,r.kt)("li",null,"uint64"),(0,r.kt)("li",null,"unativeint")),(0,r.kt)("h2",{id:"reserved-words"},"RESERVED WORDS"),(0,r.kt)("ul",{class:"column-ul"},(0,r.kt)("li",null,"abstract"),(0,r.kt)("li",null,"and"),(0,r.kt)("li",null,"as"),(0,r.kt)("li",null,"assert"),(0,r.kt)("li",null,"async"),(0,r.kt)("li",null,"await"),(0,r.kt)("li",null,"base"),(0,r.kt)("li",null,"begin"),(0,r.kt)("li",null,"bool"),(0,r.kt)("li",null,"break"),(0,r.kt)("li",null,"byte"),(0,r.kt)("li",null,"case"),(0,r.kt)("li",null,"catch"),(0,r.kt)("li",null,"char"),(0,r.kt)("li",null,"checked"),(0,r.kt)("li",null,"class"),(0,r.kt)("li",null,"const"),(0,r.kt)("li",null,"continue"),(0,r.kt)("li",null,"decimal"),(0,r.kt)("li",null,"default"),(0,r.kt)("li",null,"delegate"),(0,r.kt)("li",null,"do"),(0,r.kt)("li",null,"done"),(0,r.kt)("li",null,"double"),(0,r.kt)("li",null,"downcast"),(0,r.kt)("li",null,"downto"),(0,r.kt)("li",null,"dynamic"),(0,r.kt)("li",null,"elif"),(0,r.kt)("li",null,"else"),(0,r.kt)("li",null,"end"),(0,r.kt)("li",null,"enum"),(0,r.kt)("li",null,"event"),(0,r.kt)("li",null,"exception"),(0,r.kt)("li",null,"explicit"),(0,r.kt)("li",null,"extern"),(0,r.kt)("li",null,"false"),(0,r.kt)("li",null,"finally"),(0,r.kt)("li",null,"fixed"),(0,r.kt)("li",null,"float"),(0,r.kt)("li",null,"for"),(0,r.kt)("li",null,"foreach"),(0,r.kt)("li",null,"fun"),(0,r.kt)("li",null,"function"),(0,r.kt)("li",null,"if"),(0,r.kt)("li",null,"in"),(0,r.kt)("li",null,"inherit"),(0,r.kt)("li",null,"inline"),(0,r.kt)("li",null,"int"),(0,r.kt)("li",null,"interface"),(0,r.kt)("li",null,"internal"),(0,r.kt)("li",null,"is"),(0,r.kt)("li",null,"lazy"),(0,r.kt)("li",null,"let"),(0,r.kt)("li",null,"let!"),(0,r.kt)("li",null,"localVarFileParams"),(0,r.kt)("li",null,"localVarFormParams"),(0,r.kt)("li",null,"localVarHeaderParams"),(0,r.kt)("li",null,"localVarHttpContentType"),(0,r.kt)("li",null,"localVarHttpContentTypes"),(0,r.kt)("li",null,"localVarHttpHeaderAccept"),(0,r.kt)("li",null,"localVarHttpHeaderAccepts"),(0,r.kt)("li",null,"localVarPath"),(0,r.kt)("li",null,"localVarPathParams"),(0,r.kt)("li",null,"localVarPostBody"),(0,r.kt)("li",null,"localVarQueryParams"),(0,r.kt)("li",null,"localVarResponse"),(0,r.kt)("li",null,"localVarStatusCode"),(0,r.kt)("li",null,"lock"),(0,r.kt)("li",null,"match"),(0,r.kt)("li",null,"match!"),(0,r.kt)("li",null,"member"),(0,r.kt)("li",null,"module"),(0,r.kt)("li",null,"mutable"),(0,r.kt)("li",null,"namespace"),(0,r.kt)("li",null,"new"),(0,r.kt)("li",null,"not"),(0,r.kt)("li",null,"null"),(0,r.kt)("li",null,"of"),(0,r.kt)("li",null,"open"),(0,r.kt)("li",null,"option"),(0,r.kt)("li",null,"or"),(0,r.kt)("li",null,"override"),(0,r.kt)("li",null,"params"),(0,r.kt)("li",null,"private"),(0,r.kt)("li",null,"public"),(0,r.kt)("li",null,"raise"),(0,r.kt)("li",null,"rec"),(0,r.kt)("li",null,"return"),(0,r.kt)("li",null,"return!"),(0,r.kt)("li",null,"sealed"),(0,r.kt)("li",null,"select"),(0,r.kt)("li",null,"static"),(0,r.kt)("li",null,"string"),(0,r.kt)("li",null,"struct"),(0,r.kt)("li",null,"then"),(0,r.kt)("li",null,"to"),(0,r.kt)("li",null,"true"),(0,r.kt)("li",null,"try"),(0,r.kt)("li",null,"type"),(0,r.kt)("li",null,"upcast"),(0,r.kt)("li",null,"use"),(0,r.kt)("li",null,"use!"),(0,r.kt)("li",null,"val"),(0,r.kt)("li",null,"void"),(0,r.kt)("li",null,"volatile"),(0,r.kt)("li",null,"when"),(0,r.kt)("li",null,"while"),(0,r.kt)("li",null,"with"),(0,r.kt)("li",null,"yield"),(0,r.kt)("li",null,"yield!")),(0,r.kt)("h2",{id:"feature-set"},"FEATURE SET"),(0,r.kt)("h3",{id:"client-modification-feature"},"Client Modification Feature"),(0,r.kt)("table",null,(0,r.kt)("thead",{parentName:"table"},(0,r.kt)("tr",{parentName:"thead"},(0,r.kt)("th",{parentName:"tr",align:null},"Name"),(0,r.kt)("th",{parentName:"tr",align:null},"Supported"),(0,r.kt)("th",{parentName:"tr",align:null},"Defined By"))),(0,r.kt)("tbody",{parentName:"table"},(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"BasePath"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2717"),(0,r.kt)("td",{parentName:"tr",align:null},"ToolingExtension")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"Authorizations"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2717"),(0,r.kt)("td",{parentName:"tr",align:null},"ToolingExtension")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"UserAgent"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2717"),(0,r.kt)("td",{parentName:"tr",align:null},"ToolingExtension")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"MockServer"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2717"),(0,r.kt)("td",{parentName:"tr",align:null},"ToolingExtension")))),(0,r.kt)("h3",{id:"data-type-feature"},"Data Type Feature"),(0,r.kt)("table",null,(0,r.kt)("thead",{parentName:"table"},(0,r.kt)("tr",{parentName:"thead"},(0,r.kt)("th",{parentName:"tr",align:null},"Name"),(0,r.kt)("th",{parentName:"tr",align:null},"Supported"),(0,r.kt)("th",{parentName:"tr",align:null},"Defined By"))),(0,r.kt)("tbody",{parentName:"table"},(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"Custom"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2717"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS2,OAS3")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"Int32"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS2,OAS3")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"Int64"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS2,OAS3")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"Float"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS2,OAS3")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"Double"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS2,OAS3")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"Decimal"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"ToolingExtension")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"String"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS2,OAS3")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"Byte"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS2,OAS3")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"Binary"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS2,OAS3")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"Boolean"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS2,OAS3")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"Date"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS2,OAS3")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"DateTime"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS2,OAS3")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"Password"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS2,OAS3")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"File"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS2")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"Uuid"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2717"),(0,r.kt)("td",{parentName:"tr",align:null})),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"Array"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS2,OAS3")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"Null"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2717"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS3")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"AnyType"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2717"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS2,OAS3")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"Object"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS2,OAS3")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"Maps"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"ToolingExtension")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"CollectionFormat"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS2")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"CollectionFormatMulti"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS2")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"Enum"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS2,OAS3")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"ArrayOfEnum"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"ToolingExtension")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"ArrayOfModel"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"ToolingExtension")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"ArrayOfCollectionOfPrimitives"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"ToolingExtension")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"ArrayOfCollectionOfModel"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"ToolingExtension")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"ArrayOfCollectionOfEnum"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"ToolingExtension")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"MapOfEnum"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"ToolingExtension")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"MapOfModel"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"ToolingExtension")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"MapOfCollectionOfPrimitives"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"ToolingExtension")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"MapOfCollectionOfModel"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"ToolingExtension")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"MapOfCollectionOfEnum"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"ToolingExtension")))),(0,r.kt)("h3",{id:"documentation-feature"},"Documentation Feature"),(0,r.kt)("table",null,(0,r.kt)("thead",{parentName:"table"},(0,r.kt)("tr",{parentName:"thead"},(0,r.kt)("th",{parentName:"tr",align:null},"Name"),(0,r.kt)("th",{parentName:"tr",align:null},"Supported"),(0,r.kt)("th",{parentName:"tr",align:null},"Defined By"))),(0,r.kt)("tbody",{parentName:"table"},(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"Readme"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"ToolingExtension")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"Model"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"ToolingExtension")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"Api"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"ToolingExtension")))),(0,r.kt)("h3",{id:"global-feature"},"Global Feature"),(0,r.kt)("table",null,(0,r.kt)("thead",{parentName:"table"},(0,r.kt)("tr",{parentName:"thead"},(0,r.kt)("th",{parentName:"tr",align:null},"Name"),(0,r.kt)("th",{parentName:"tr",align:null},"Supported"),(0,r.kt)("th",{parentName:"tr",align:null},"Defined By"))),(0,r.kt)("tbody",{parentName:"table"},(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"Host"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS2,OAS3")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"BasePath"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS2,OAS3")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"Info"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS2,OAS3")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"Schemes"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2717"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS2,OAS3")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"PartialSchemes"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS2,OAS3")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"Consumes"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS2")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"Produces"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS2")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"ExternalDocumentation"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS2,OAS3")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"Examples"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS2,OAS3")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"XMLStructureDefinitions"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2717"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS2,OAS3")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"MultiServer"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2717"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS3")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"ParameterizedServer"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2717"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS3")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"ParameterStyling"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2717"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS3")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"Callbacks"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS3")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"LinkObjects"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2717"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS3")))),(0,r.kt)("h3",{id:"parameter-feature"},"Parameter Feature"),(0,r.kt)("table",null,(0,r.kt)("thead",{parentName:"table"},(0,r.kt)("tr",{parentName:"thead"},(0,r.kt)("th",{parentName:"tr",align:null},"Name"),(0,r.kt)("th",{parentName:"tr",align:null},"Supported"),(0,r.kt)("th",{parentName:"tr",align:null},"Defined By"))),(0,r.kt)("tbody",{parentName:"table"},(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"Path"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS2,OAS3")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"Query"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS2,OAS3")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"Header"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS2,OAS3")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"Body"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS2")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"FormUnencoded"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS2")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"FormMultipart"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS2")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"Cookie"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS3")))),(0,r.kt)("h3",{id:"schema-support-feature"},"Schema Support Feature"),(0,r.kt)("table",null,(0,r.kt)("thead",{parentName:"table"},(0,r.kt)("tr",{parentName:"thead"},(0,r.kt)("th",{parentName:"tr",align:null},"Name"),(0,r.kt)("th",{parentName:"tr",align:null},"Supported"),(0,r.kt)("th",{parentName:"tr",align:null},"Defined By"))),(0,r.kt)("tbody",{parentName:"table"},(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"Simple"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS2,OAS3")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"Composite"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS2,OAS3")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"Polymorphism"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS2,OAS3")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"Union"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2717"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS3")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"allOf"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2717"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS2,OAS3")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"anyOf"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2717"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS3")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"oneOf"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2717"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS3")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"not"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2717"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS3")))),(0,r.kt)("h3",{id:"security-feature"},"Security Feature"),(0,r.kt)("table",null,(0,r.kt)("thead",{parentName:"table"},(0,r.kt)("tr",{parentName:"thead"},(0,r.kt)("th",{parentName:"tr",align:null},"Name"),(0,r.kt)("th",{parentName:"tr",align:null},"Supported"),(0,r.kt)("th",{parentName:"tr",align:null},"Defined By"))),(0,r.kt)("tbody",{parentName:"table"},(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"BasicAuth"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS2,OAS3")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"ApiKey"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS2,OAS3")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"OpenIDConnect"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS3")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"BearerToken"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS3")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"OAuth2_Implicit"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS2,OAS3")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"OAuth2_Password"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS2,OAS3")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"OAuth2_ClientCredentials"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS2,OAS3")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"OAuth2_AuthorizationCode"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS2,OAS3")))),(0,r.kt)("h3",{id:"wire-format-feature"},"Wire Format Feature"),(0,r.kt)("table",null,(0,r.kt)("thead",{parentName:"table"},(0,r.kt)("tr",{parentName:"thead"},(0,r.kt)("th",{parentName:"tr",align:null},"Name"),(0,r.kt)("th",{parentName:"tr",align:null},"Supported"),(0,r.kt)("th",{parentName:"tr",align:null},"Defined By"))),(0,r.kt)("tbody",{parentName:"table"},(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"JSON"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS2,OAS3")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"XML"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2713"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS2,OAS3")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"PROTOBUF"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2717"),(0,r.kt)("td",{parentName:"tr",align:null},"ToolingExtension")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:null},"Custom"),(0,r.kt)("td",{parentName:"tr",align:null},"\u2717"),(0,r.kt)("td",{parentName:"tr",align:null},"OAS2,OAS3")))))}N.isMDXComponent=!0}}]);