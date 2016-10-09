---
title: "How to: Create XML Literals (Visual Basic)"
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
  - "XML literals [Visual Basic], creating"
ms.assetid: 573a6db5-b14d-4e42-b356-8cc7e2d77745
caps.latest.revision: 17
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
# How to: Create XML Literals (Visual Basic)
You can create an XML document, fragment, or element directly in code by using an XML literal. The examples in this topic demonstrate how to create an XML element that has three child elements, and how to create an XML document.  
  
 You can also use the [!INCLUDE[sqltecxlinq](../VS_visualbasic/includes/sqltecxlinq_md.md)] APIs to create [!INCLUDE[sqltecxlinq](../VS_visualbasic/includes/sqltecxlinq_md.md)] objects. For more information, see \<xref:System.Xml.Linq.XElement>.  
  
### To create an XML element  
  
-   Create the XML inline by using the XML literal syntax, which is the same as the actual XML syntax.  
  
     [!code[VbXMLSamples#5](../VS_visualbasic/codesnippet/VisualBasic/how-to--create-xml-literals--visual-basic-_1.vb)]  
  
     Run the code. The output of this code is:  
  
     `<contact>`  
  
     `<name>Patrick Hines</name>`  
  
     `<phone type="home">206-555-0144</phone>`  
  
     `<phone type="work">425-555-0145</phone>`  
  
     `</contact>`  
  
### To create an XML document  
  
-   Create the XML document inline. The following code creates an XML document that has literal syntax, an XML declaration, a processing instruction, a comment, and an element that contains another element.  
  
     [!code[VbXMLSamples#30](../VS_visualbasic/codesnippet/VisualBasic/how-to--create-xml-literals--visual-basic-_2.vb)]  
  
     Run the code. The output of this code is:  
  
     `<?xml-stylesheet type="text/xsl" href="show_book.xsl"?>`  
  
     `<!-- Tests that the application works. -->`  
  
     `<books>`  
  
     `<book/>`  
  
     `</books>`  
  
## See Also  
 [XML](../VS_visualbasic/xml-in-visual-basic.md)   
 [Creating XML in Visual Basic](../VS_visualbasic/creating-xml-in-visual-basic.md)   
 [XML Element Literal](../VS_visualbasic/xml-element-literal--visual-basic-.md)   
 [XML Document Literal](../VS_visualbasic/xml-document-literal--visual-basic-.md)