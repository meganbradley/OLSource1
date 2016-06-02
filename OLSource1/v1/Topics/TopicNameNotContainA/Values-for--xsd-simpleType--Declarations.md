---
title: Values for &lt;xsd:simpleType&gt; Declarations
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-xml
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 557b972d-3af9-40bf-8382-72b05c9de1c1
---
# Values for &lt;xsd:simpleType&gt; Declarations
  The following table outlines the restrictions that are applied, based on all recognized XSD simple type enumerations.  
  
 Also, [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] does not support the NaN value in **\<xsd:simpleType\>** declarations. Schemas that include NaN values are rejected by the server.  
  
|Simple type|Limitation|  
|-----------------|----------------|  
|**duration**|The year part has to be within the range of \-2^31 to 2^31\-1. The month, day, hour, minute, and second must all be within the range of 0 to 9999. The seconds part has an additional three digits of precision to the right of the decimal point.|  
|**dateTime**|The hour part in the time zone subfield must be within the accepted range of \-14 to \+14. The year part must be within the range of 1 to 9999. The month part must be within the range of 1 to 12. The day part must be within the range of 1 to 31 and must be a valid calendar date. For example, [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] detects and returns an error for an invalid date, such as 1974\-02\-31, because the month of February does not have 31 days.<br /><br /> The second component supports 100\-nanosecond precision. The timezone indication is optional.<br /><br /> SQL Server 2005 supported years in the range \-9999 to 9999. SQL Server now supports a more restricted range of years. For more information, see [Compare Typed XML to Untyped XML](../../Topics\TopicNameNotContainA/Compare-Typed-XML-to-Untyped-XML.md).|  
|**date**|The year part must be within the range of 1 to 9999. The month part must be within the range of 1 to 12. The day part must be within the range of 1 to 31 and must be a valid calendar date. For example, [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] detects and returns an error for an invalid date, such as 1974\-02\-31, because the month of February does not have 31 days.<br /><br /> SQL Server 2005 supported years in the range \-9999 to 9999. SQL Server now supports a more restricted range of years. For more information, see [Compare Typed XML to Untyped XML](../../Topics\TopicNameNotContainA/Compare-Typed-XML-to-Untyped-XML.md).|  
|**gYearMonth**|The year part must be within the range of \-9999 to 9999.|  
|**gYear**|The year part must be within the range of \-9999 to 9999.|  
|**gMonthDay**|The month part must be within the range of 1 to 12. The day part must be within the range of 1 to 31.|  
|**gDay**|The day part must be within the range of 1 to 31|  
|**gMonth**|The month part must be within the range of 1 to 12.|  
|**decimal**|Values of this type must comply with the format of the SQL numeric type. This type internally represents the support of numbers up to a total of 38 digits, with 10 of those digit positions reserved for fractional precision.|  
|**float**|Values of this type must comply with the format of the SQL **real** type.|  
|**double**|Values of this type must comply with the format of the SQL **float** type.|  
|**string**|Values of this type must comply with the format of the SQL **nvarchar\(max\)** type.|  
|**anyURI**|Values of this type can be no more than 4000 Unicode characters in length.|  
  
## See Also  
 [Requirements and Limitations for XML Schema Collections on the Server](../../Topics\TopicNameNotContainA/Requirements-and-Limitations-for-XML-Schema-Collections-on-the-Server.md)  
  
  