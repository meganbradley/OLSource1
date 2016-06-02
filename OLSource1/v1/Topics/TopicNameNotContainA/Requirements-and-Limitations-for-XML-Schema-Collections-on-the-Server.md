---
title: Requirements and Limitations for XML Schema Collections on the Server
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-xml
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: c2314fd5-4c6d-40cb-a128-07e532b40946
---
# Requirements and Limitations for XML Schema Collections on the Server
  The XML schema definition language \(XSD\) validation has some limitations regarding SQL columns that use the **xml** data type. The following table provides details about those limitations and guidelines for modifying your XSD schema so it can work with [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)]. The topics in this section provide additional information about specific limitations and guidance for working with them.  
  
|Item|Limitation|  
|----------|----------------|  
|**minOccurs** and **maxOccurs**|The values for **minOccurs** and **maxOccurs** attributes must fit into 4\-byte integers. Schemas that do not conform are rejected by the server.|  
|**\<xsd:choice\>**|[!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] rejects schemas that have an **\<xsd:choice\>** particle without children, unless the particle is defined with a **minOccurs** attribute value of zero.|  
|**\<xsd:include\>**|Currently, [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] does not support this element. XML schemas that include this element are rejected by the server.<br /><br /> As a solution, XML schemas that include the **\<xsd:include\>** directive can be preprocessed to copy and merge the contents of any included schemas into a single schema for upload to the server. For more information, see [Preprocess a Schema to Merge Included Schemas](../../Topics\TopicNameContainA/Preprocess-a-Schema-to-Merge-Included-Schemas.md).|  
|**\<xsd:key\>**, **\<xsd:keyref\>**, and **\<xsd:unique\>**|Currently, [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] does not support these XSD\-based constraints for enforcing uniqueness or establishing keys and key references. XML schemas that contain these elements cannot be registered.|  
|**\<xsd:redefine\>**|[!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] does not support this element. For information about another way to update schemas, see [The &#60;xsd:redefine&#62; Element](../Topic/The%20%3Cxsd:redefine%3E%20Element.md).|  
|**\<xsd:simpleType\>** values|[!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] only supports millisecond precision for simple types that have second components other than **xs:time** and **xs:dateTime**, and 100\-nanosecond precision for **xs:time** and **xs:dateTime**. [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] puts limitations on all recognized XSD simple type enumerations.<br /><br /> [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] does not support using the "NaN" value in **\<xsd:simpleType\>** declarations.<br /><br /> For more information, see[Values for &#60;xsd:simpleType&#62; Declarations](../Topic/Values%20for%20%3Cxsd:simpleType%3E%20Declarations.md).|  
|**xsi:schemaLocation** and **xsi:noNamespaceSchemaLocation**|[!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] ignores these attributes if they are present in the XML instance data inserted into a column or variable of **xml** data type.|  
|**xs:QName**|[!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] does not support types derived from **xs:QName** that use an XML Schema restriction element.<br /><br /> [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] does not support union types with **xs:QName** as a member element.<br /><br /> For more information, see [The xs:QName Type](../Topic/The%20xs:QName%20Type.md).|  
|Adding members to an existing substitution group|You cannot add members to an existing substitution group in an XML schema collection. A substitution group in an XML schema is restricted in that the head element and all its member elements must be defined in the same {CREATE &#124; ALTER} XML SCHEMA COLLECTION statement.|  
|Canonical forms and pattern restrictions|The canonical representation of a value cannot violate the pattern restriction for its type. For more information, see [Canonical Forms and Pattern Restrictions](../../Topics\TopicNameNotContainA/Canonical-Forms-and-Pattern-Restrictions.md).|  
|Enumeration facets|[!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] does not support XML schemas with types that have pattern facets or enumerations that violate those facets.|  
|Facet length|The **length**, **minLength**, and **maxLength** facets are stored as a **long** type. This type is a 32\-bit type. Therefore, the range of acceptable values for these values is 2^31.|  
|ID attribute|Each XML schema component can have an ID attribute on it. [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] enforces uniqueness for **\<xsd:attribute\>** declarations of **ID** type, but does not store these values. The scope for enforcement of uniqueness is the {CREATE &#124; ALTER} XML SCHEMA COLLECTION statement.|  
|ID type|[!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] does not support elements of type **xs:ID**, **xs:IDREF**, or **xs:IDREFS**. A schema may not declare elements of this type, or elements derived by restriction or extension from this type.|  
|Local namespace|The local namespace has to be explicitly specified for the **\<xsd:any\>** element. [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] rejects schemas that use an empty string \(""\) as a value for the namespace attribute. Instead, [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] requires the explicit use of "\#\#local" to indicate an unqualified element or attribute as the instance of the wildcard character.|  
|Mixed type and simple content|[!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] does not support restricting a mixed type to a simple content. For more information, see [Mixed Type and Simple Content](../../Topics\TopicNameNotContainA/Mixed-Type-and-Simple-Content.md).|  
|NOTATION type|[!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] does not support the NOTATION type.|  
|Out\-of\-memory conditions|In working with large XML schema collections, an out\-of\-memory condition might occur. For solutions to this problem, see [Large XML Schema Collections and Out-of-Memory Conditions](../../Topics\TopicNameNotContainA/Large-XML-Schema-Collections-and-Out-of-Memory-Conditions.md).|  
|Repeated values|[!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] rejects schemas in which the block or final attribute has repeated values such as "restriction restriction" and "extension extension".|  
|Schema component identifiers|[!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] limits identifiers of schema components to a maximum length of 1000 Unicode characters. Also,  surrogate character pairs within identifiers are not supported.|  
|Time zone information|In [!INCLUDE[ssKatmai](../../Token\Other/ssKatmai_md.md)] and later versions, time zone information is fully supported for **xs:date**, **xs:time**, and **xs:dateTime** values for XML Schema validation. With [!INCLUDE[ssVersion2005](../../Token\Other/ssVersion2005_md.md)] backwards\-compatibility mode, time zone information is always normalized to Coordinated Universal Time \(Greenwich Mean Time\). For elements of **dateTime** type, the server converts the time provided to GMT by using the offset value \("\-05:00"\) and returning the corresponding GMT time.|  
|Union types|[!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] does not support restrictions from union types.|  
|Variable precision decimals|[!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] does not support variable precision decimals. The **xs:decimal** type represents arbitrary precision decimal numbers. Minimally conforming XML processors must support decimal numbers with a minimum of `totalDigits=18`. [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] supports `totalDigits=38,` but limits the fractional digits to 10. All **xs:decimal** instanced values are represented internally by the server by using the SQL type numeric \(38, 10\).|  
  
## In This Section  
  
|Topic|Description|  
|-----------|-----------------|  
|[Canonical Forms and Pattern Restrictions](../../Topics\TopicNameNotContainA/Canonical-Forms-and-Pattern-Restrictions.md)|Explains canonical forms and pattern restrictions.|  
|[Wildcard Components and Content Validation](../../Topics\TopicNameNotContainA/Wildcard-Components-and-Content-Validation.md)|Describes the limitations of using wildcard characters, lax validation, and anyType Elements with XML schema collections.|  
|[The &#60;xsd:redefine&#62; Element](../Topic/The%20%3Cxsd:redefine%3E%20Element.md)|Explains the limitation of using the \<xsd:redefine\> element and describes a workaround.|  
|[The xs:QName Type](../Topic/The%20xs:QName%20Type.md)|Describes the limitation regarding the xs:QName type.|  
|[Values for &#60;xsd:simpleType&#62; Declarations](../Topic/Values%20for%20%3Cxsd:simpleType%3E%20Declarations.md)|Describes the restrictions that are applied to \<xsd:simpleType\> declarations.|  
|[Enumeration Facets](../../Topics\TopicNameNotContainA/Enumeration-Facets.md)|Describes the limitation regarding enumeration facets.|  
|[Mixed Type and Simple Content](../../Topics\TopicNameNotContainA/Mixed-Type-and-Simple-Content.md)|Describes the limitation on restricting a mixed type to a simple content.|  
|[Large XML Schema Collections and Out-of-Memory Conditions](../../Topics\TopicNameNotContainA/Large-XML-Schema-Collections-and-Out-of-Memory-Conditions.md)|Provides solutions for the out\-of\-memory condition that sometimes occurs with large schema collections.|  
|[Non-Deterministic Content Models](../../Topics\TopicNameNotContainA/Non-Deterministic-Content-Models.md)|Describes the limitations regarding non\-deterministic content models.|  
  
## See Also  
 [XML Data &#40;SQL Server&#41;](../Topic/XML%20Data%20\(SQL%20Server\).md)   
 [Compare Typed XML to Untyped XML](../../Topics\TopicNameNotContainA/Compare-Typed-XML-to-Untyped-XML.md)   
 [Grant Permissions on an XML Schema Collection](../../Topics\TopicNameNotContainA/Grant-Permissions-on-an-XML-Schema-Collection.md)   
 [Unique Particle Attribution Constraint](../../Topics\TopicNameNotContainA/Unique-Particle-Attribution-Constraint.md)   
 [XML Schema Collections &#40;SQL Server&#41;](../Topic/XML%20Schema%20Collections%20\(SQL%20Server\).md)  
  
  