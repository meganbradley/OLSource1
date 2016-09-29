---
title: "How to: Access XML Child Elements (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
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
  - "XML axis [Visual Basic], child"
  - "child axis property [Visual Basic]"
  - "XML child axis property [Visual Basic]"
  - "XML [Visual Basic], accessing"
ms.assetid: 6689eb36-c471-469f-a82d-099ab8197b25
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Access XML Child Elements (Visual Basic)
This example shows how to use a child axis property to access all XML child elements that have a specified name in an XML element. In particular, it uses the <xref:System.Xml.Linq.XElement.Value*> property to get the value of the first element in the collection that the `name` child axis property returns. The `name` child axis property gets all child elements named `phone` in the `contact` object. This example also uses the `phone` child axis property to access all child elements named `phone` that are contained in the `contact` object.  
  
## Example  
 [!code[VbXMLSamples#10](../VS_csharp/codesnippet/VisualBasic/how-to--access-xml-child-elements--visual-basic-_1.vb)]  
  
## Compiling the Code  
 This example requires:  
  
-   A reference to the <xref:System.Xml.Linq*> namespace.  
  
## See Also  
 <xref:System.Xml.Linq.XContainer.Elements*?displayProperty=fullName>   
 [XML Child Axis Property](../VS_csharp/xml-child-axis-property--visual-basic-.md)   
 [XML Value Property](../VS_csharp/xml-value-property--visual-basic-.md)   
 [Accessing XML Elements with Visual Basic](../VS_csharp/accessing-xml-in-visual-basic.md)   
 [Learning LINQ to XML Using Visual Basic](../VS_csharp/xml-in-visual-basic.md)