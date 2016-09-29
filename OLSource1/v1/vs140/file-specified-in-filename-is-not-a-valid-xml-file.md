---
title: "File specified in FileName is not a valid XML file"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: c4c30bf3-e0ad-4bc8-89e0-2c3e49e9793b
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# File specified in FileName is not a valid XML file
The file name that you supplied is not a valid XML file. To specify the allowed structure and content of an XML document, you can use a Document Type Definition (DTD), a Microsoft XML-Data Reduced (XDR) schema, or an XML Schema definition language (XSD) schema. XSD schemas are the preferred way to specify XML grammars in the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)].  
  
> [!NOTE]
>  In some earlier versions of Visual Studio, the **XML Designer** is the designer for typed datasets and XML schema. The **XML Designer** can still be used to create and edit XML schema files. However, in [!INCLUDE[vs_current_long](../vs140/includes/vs_current_long_md.md)], the designer for creating and editing typed datasets is the **Dataset Designer**. For more information, see [Dataset Designer Overview](assetId:///cd0dbe93-be9b-41e4-bc39-e9300678c1f2).  
  
### To correct this error  
  
-   Check that you are supplying the correct file name.  
  
-   Check that the specified file contains valid XML by loading the XML file that you want to check into the **XML Designer**. From the **XML** menu, click **Validate XML**. Errors are displayed in the **Task List**.  
  
-   If the XML file has an associated XML Schema, check that the elements appear in the defined structure and that the content of the individual elements conforms to the declared data types specified in the schema.  
  
## See Also  
 <xref:System.Xml*>   
 [How to: Parse File Paths in Visual Basic](../vs140/how-to--parse-file-paths-in-visual-basic.md)