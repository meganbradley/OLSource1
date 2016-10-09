---
title: "How to: Access XML Descendant Elements (Visual Basic)"
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
  - "XML descendent axis property [Visual Basic]"
  - "XML axis [Visual Basic], descendent"
  - "descendent axis property [Visual Basic]"
  - "XML [Visual Basic], accessing"
ms.assetid: aabfa258-4112-4e7e-bab9-403f96072ef7
caps.latest.revision: 19
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
# How to: Access XML Descendant Elements (Visual Basic)
This example shows how to use a descendant axis property to access all XML elements that have a specified name and that are contained under an XML element. In particular, it uses the `Value` property to get the value of the first element in the collection that the `name` descendant axis property returns. The `name` descendant axis property gets all elements named `name` that are contained in the `contacts` object. This example also uses the `phone` descendant axis property to access all descendants named `phone` that are contained in the `contacts` object.  
  
## Example  
 [!code[VbXMLSamples#31](../VS_visualbasic/codesnippet/VisualBasic/how-to--access-xml-descendant-elements--visual-basic-_1.vb)]  
  
## Compiling the Code  
 This example requires:  
  
-   A reference to the \<xref:System.Xml.Linq> namespace.  
  
## See Also  
 \<xref:System.Xml.Linq.XContainer.Descendants*?displayProperty=fullName>   
 [XML Descendant Axis Property](../VS_visualbasic/xml-descendant-axis-property--visual-basic-.md)   
 [XML Value Property](../VS_visualbasic/xml-value-property--visual-basic-.md)   
 [Accessing XML in Visual Basic](../VS_visualbasic/accessing-xml-in-visual-basic.md)   
 [XML](../VS_visualbasic/xml-in-visual-basic.md)