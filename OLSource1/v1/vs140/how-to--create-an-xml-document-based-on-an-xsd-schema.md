---
title: "How to: Create an XML Document Based on an XSD Schema"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 193b195f-e918-4c79-a1a1-8096a1433bde
caps.latest.revision: 6
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Create an XML Document Based on an XSD Schema
The **Generate Sample XML** feature generates a sample XML file based on your XML Schema (XSD) file.  
  
 You can use this option for the following scenarios:  
  
-   To understand the use of various constructs in your schema.  
  
-   To confirm that the schema does what it is intended to do.  
  
 The **Generate Sample XML** feature is only available on global elements, and requires a valid XML schema set.  
  
 This feature typically generates valid XML documents. However, if the schema contains one or more of the following, the sample might not be valid:  
  
-   The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> identity constraints.  
  
-   <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> facets.  
  
-   Enumerations of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> type.  
  
-   <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> types.  
  
 Also, note that <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> content will be generated only if enumerations occur in the schema for that type.  
  
### To generate an XML instance document based on the XSD file  
  
1.  Follow the steps in [How to: Create and Edit an XSD Schema File](../vs140/how-to--create-and-edit-an-xsd-schema-file.md).  
  
2.  In the [XML Schema Explorer](../vs140/xml-schema-explorer.md), right-click the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> global element. Select **Generate Sample XML**.  
  
     When you select this option, the PurchaseOrder.xml file with the following sample XML content will be generated and opened in the XML Editor:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Working with XML Data](../vs140/working-with-xml-data.md)