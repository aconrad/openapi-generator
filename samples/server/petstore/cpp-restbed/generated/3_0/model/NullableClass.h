/**
 * OpenAPI Petstore
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI-Generator 6.3.0.
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

/*
 * NullableClass.h
 *
 * 
 */

#ifndef NullableClass_H_
#define NullableClass_H_



#include <string>
#include <map>
#include <vector>
#include <memory>
#include <vector>
#include <boost/property_tree/ptree.hpp>
#include "helpers.h"

namespace org {
namespace openapitools {
namespace server {
namespace model {

/// <summary>
/// 
/// </summary>
class  NullableClass 
{
public:
    NullableClass() = default;
    explicit NullableClass(boost::property_tree::ptree const& pt);
    virtual ~NullableClass() = default;

    NullableClass(const NullableClass& other) = default; // copy constructor
    NullableClass(NullableClass&& other) noexcept = default; // move constructor

    NullableClass& operator=(const NullableClass& other) = default; // copy assignment
    NullableClass& operator=(NullableClass&& other) noexcept = default; // move assignment

    std::string toJsonString(bool prettyJson = false) const;
    void fromJsonString(std::string const& jsonString);
    boost::property_tree::ptree toPropertyTree() const;
    void fromPropertyTree(boost::property_tree::ptree const& pt);


    /////////////////////////////////////////////
    /// NullableClass members

    /// <summary>
    /// 
    /// </summary>
    int32_t getIntegerProp() const;
    void setIntegerProp(int32_t value);

    /// <summary>
    /// 
    /// </summary>
    double getNumberProp() const;
    void setNumberProp(double value);

    /// <summary>
    /// 
    /// </summary>
    bool isBooleanProp() const;
    void setBooleanProp(bool value);

    /// <summary>
    /// 
    /// </summary>
    std::string getStringProp() const;
    void setStringProp(std::string value);

    /// <summary>
    /// 
    /// </summary>
    std::string getDateProp() const;
    void setDateProp(std::string value);

    /// <summary>
    /// 
    /// </summary>
    std::string getDatetimeProp() const;
    void setDatetimeProp(std::string value);

    /// <summary>
    /// 
    /// </summary>
    std::vector<std::string> getArrayNullableProp() const;
    void setArrayNullableProp(std::vector<std::string> value);

    /// <summary>
    /// 
    /// </summary>
    std::vector<std::string> getArrayAndItemsNullableProp() const;
    void setArrayAndItemsNullableProp(std::vector<std::string> value);

    /// <summary>
    /// 
    /// </summary>
    std::vector<std::string> getArrayItemsNullable() const;
    void setArrayItemsNullable(std::vector<std::string> value);

    /// <summary>
    /// 
    /// </summary>
    std::map<std::string, std::string> getObjectNullableProp() const;
    void setObjectNullableProp(std::map<std::string, std::string> value);

    /// <summary>
    /// 
    /// </summary>
    std::map<std::string, std::string> getObjectAndItemsNullableProp() const;
    void setObjectAndItemsNullableProp(std::map<std::string, std::string> value);

    /// <summary>
    /// 
    /// </summary>
    std::map<std::string, std::string> getObjectItemsNullable() const;
    void setObjectItemsNullable(std::map<std::string, std::string> value);

protected:
    int32_t m_Integer_prop = 0;
    double m_Number_prop = 0.0;
    bool m_Boolean_prop = false;
    std::string m_String_prop = "";
    std::string m_Date_prop = "";
    std::string m_Datetime_prop = "";
    std::vector<std::string> m_Array_nullable_prop;
    std::vector<std::string> m_Array_and_items_nullable_prop;
    std::vector<std::string> m_Array_items_nullable;
    std::map<std::string, std::string> m_Object_nullable_prop;
    std::map<std::string, std::string> m_Object_and_items_nullable_prop;
    std::map<std::string, std::string> m_Object_items_nullable;
};

std::vector<NullableClass> createNullableClassVectorFromJsonString(const std::string& json);

template<>
inline boost::property_tree::ptree toPt<NullableClass>(const NullableClass& val) {
    return val.toPropertyTree();
}

template<>
inline NullableClass fromPt<NullableClass>(const boost::property_tree::ptree& pt) {
    NullableClass ret;
    ret.fromPropertyTree(pt);
    return ret;
}

}
}
}
}

#endif /* NullableClass_H_ */
