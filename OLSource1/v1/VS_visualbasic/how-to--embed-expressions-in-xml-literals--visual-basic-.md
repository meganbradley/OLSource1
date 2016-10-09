---
title: "How to: Embed Expressions in XML Literals (Visual Basic)"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "embedded expressions [Visual Basic]"
  - "XML literals [Visual Basic], embedded expressions"
ms.assetid: 75016fad-0141-42de-8564-5051be29487e
caps.latest.revision: 16
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# How to: Embed Expressions in XML Literals (Visual Basic)
You can combine XML literals with embedded expressions to create an XML document, fragment, or element that contains content created at run time. The following examples demonstrate how to use embedded expressions to populate element content, attributes, and element names at run time.  
  
 The syntax for an embedded expression is `<%=` `exp` `%>`, which is the same syntax that [!INCLUDE[vstecasp](../VS_visualbasic/includes/vstecasp_md.md)] uses. For more information, see [Embedded Expressions in XML](../VS_visualbasic/embedded-expressions-in-xml--visual-basic-.md).  
  
 You can also use the [!INCLUDE[sqltecxlinq](../VS_visualbasic/includes/sqltecxlinq_md.md)] APIs to create [!INCLUDE[sqltecxlinq](../VS_visualbasic/includes/sqltecxlinq_md.md)] objects. For more information, see \<xref:System.Xml.Linq.XElement>.  
  
## Procedures  
  
#### To insert text as element content  
  
-   The following example shows how to insert the text that is contained in the `contactName` variable between the opening and closing name elements.  
  
     [!code[VbXMLSamples#39](../VS_visualbasic/codesnippet/VisualBasic/how-to--embed-expressions-in-xml-literals--visual-basic-_1.vb)]  
  
     This example produces the following output:  
  
    ```  
    <contact>  
      <name>Patrick Hines</name>  
    </contact>  
    ```  
  
#### To insert text as an attribute value  
  
-   The following example shows how to insert the text that is contained in the `phoneType` variable as the value of the `type` attribute.  
  
     [!code[VbXMLSamples#40](../VS_visualbasic/codesnippet/VisualBasic/how-to--embed-expressions-in-xml-literals--visual-basic-_2.vb)]  
  
     This example produces the following output:  
  
    ```  
    <contact>  
      <phone type="home">206-555-0144</phone>  
    </contact>  
    ```  
  
#### To insert text for an element name  
  
-   The following example shows how to insert the text that is contained in the `elementName` variable as the name of an element.  
  
     When creating elements by using this technique, you must close them with the \</> tag.  
  
     [!code[VbXMLSamples#41](../VS_visualbasic/codesnippet/VisualBasic/how-to--embed-expressions-in-xml-literals--visual-basic-_3.vb)]  
  
     This example produces the following output:  
  
    ```  
    <contact>  
      <name>Patrick Hines</name>  
    </contact>  
    ```  
  
## See Also  
 [How to: Create XML Literals](../VS_visualbasic/how-to--create-xml-literals--visual-basic-.md)   
 [Embedded Expressions in XML](../VS_visualbasic/embedded-expressions-in-xml--visual-basic-.md)   
 [Creating XML in Visual Basic](../VS_visualbasic/creating-xml-in-visual-basic.md)   
 [XML](../VS_visualbasic/xml-in-visual-basic.md)