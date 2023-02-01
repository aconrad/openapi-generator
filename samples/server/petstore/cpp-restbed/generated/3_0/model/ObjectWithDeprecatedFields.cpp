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



#include "ObjectWithDeprecatedFields.h"

#include <string>
#include <vector>
#include <map>
#include <sstream>
#include <stdexcept>
#include <regex>
#include <boost/lexical_cast.hpp>
#include <boost/property_tree/ptree.hpp>
#include <boost/property_tree/json_parser.hpp>
#include "helpers.h"

using boost::property_tree::ptree;
using boost::property_tree::read_json;
using boost::property_tree::write_json;

namespace org {
namespace openapitools {
namespace server {
namespace model {

ObjectWithDeprecatedFields::ObjectWithDeprecatedFields(boost::property_tree::ptree const& pt)
{
        fromPropertyTree(pt);
}


std::string ObjectWithDeprecatedFields::toJsonString(bool prettyJson /* = false */) const
{
	std::stringstream ss;
	write_json(ss, this->toPropertyTree(), prettyJson);
    // workaround inspired by: https://stackoverflow.com/a/56395440
    std::regex reg("\\\"([0-9]+\\.{0,1}[0-9]*)\\\"");
    std::string result = std::regex_replace(ss.str(), reg, "$1");
    return result;
}

void ObjectWithDeprecatedFields::fromJsonString(std::string const& jsonString)
{
	std::stringstream ss(jsonString);
	ptree pt;
	read_json(ss,pt);
	this->fromPropertyTree(pt);
}

ptree ObjectWithDeprecatedFields::toPropertyTree() const
{
	ptree pt;
	ptree tmp_node;
	pt.put("uuid", m_Uuid);
	pt.put("id", m_Id);
	pt.add_child("deprecatedRef", m_DeprecatedRef.toPropertyTree());
	// generate tree for Bars
    tmp_node.clear();
	if (!m_Bars.empty()) {
        tmp_node = toPt(m_Bars);
		pt.add_child("bars", tmp_node);
		tmp_node.clear();
	}
	return pt;
}

void ObjectWithDeprecatedFields::fromPropertyTree(ptree const &pt)
{
	ptree tmp_node;
	m_Uuid = pt.get("uuid", "");
	m_Id = pt.get("id", 0.0);
	if (pt.get_child_optional("deprecatedRef")) {
        m_DeprecatedRef = fromPt<DeprecatedObject>(pt.get_child("deprecatedRef"));
	}
	// push all items of Bars into member
	if (pt.get_child_optional("bars")) {
        m_Bars = fromPt<std::vector<std::string>>(pt.get_child("bars"));
	}
}

std::string ObjectWithDeprecatedFields::getUuid() const
{
    return m_Uuid;
}

void ObjectWithDeprecatedFields::setUuid(std::string value)
{
    m_Uuid = value;
}


double ObjectWithDeprecatedFields::getId() const
{
    return m_Id;
}

void ObjectWithDeprecatedFields::setId(double value)
{
    m_Id = value;
}


DeprecatedObject ObjectWithDeprecatedFields::getDeprecatedRef() const
{
    return m_DeprecatedRef;
}

void ObjectWithDeprecatedFields::setDeprecatedRef(DeprecatedObject value)
{
    m_DeprecatedRef = value;
}


std::vector<std::string> ObjectWithDeprecatedFields::getBars() const
{
    return m_Bars;
}

void ObjectWithDeprecatedFields::setBars(std::vector<std::string> value)
{
    m_Bars = value;
}



std::vector<ObjectWithDeprecatedFields> createObjectWithDeprecatedFieldsVectorFromJsonString(const std::string& json)
{
    std::stringstream sstream(json);
    boost::property_tree::ptree pt;
    boost::property_tree::json_parser::read_json(sstream,pt);

    auto vec = std::vector<ObjectWithDeprecatedFields>();
    for (const auto& child: pt) {
        vec.emplace_back(ObjectWithDeprecatedFields(child.second));
    }

    return vec;
}

}
}
}
}

