---
title: "How to: Retrieve Paragraphs from an Office Open XML Document (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
ms.assetid: 66053f21-9217-473c-a6f3-a0897be07756
caps.latest.revision: 5
---
# How to: Retrieve Paragraphs from an Office Open XML Document (Visual Basic)
This topic presents an example that opens an Office Open XML document, and retrieves a collection of all of the paragraphs in the document.  
  
 For more information on Office Open XML, see [www.openxmldeveloper.org](http://go.microsoft.com/fwlink/?LinkID=95573).  
  
## Example  
 This example opens an Office Open XML package, uses the relationships within the Open XML package to find the document and the style parts. It then queries the document, projecting a collection of an anonymous type that contains the paragraph \<xref:System.Xml.Linq.XElement*> node, the style name of each paragraph, and the text of each paragraph.  
  
 The example uses an extension method named <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, which is also supplied in the example.  
  
 For a detailed tutorial that explains how this example works, see [Pure Functional Transformations of XML (Visual Basic)](../vs140/pure-functional-transformations-of-xml--visual-basic-.md).  
  
 This example uses classes found in the WindowsBase assembly. It uses types in the \<xref:System.IO.Packaging*?displayProperty=fullName> namespace.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 When run with the sample Open XML document described in [Creating the Source Office Open XML Document (Visual Basic)](../vs140/creating-the-source-office-open-xml-document--visual-basic-.md), this example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Advanced Query Techniques (LINQ to XML) (Visual Basic)](../vs140/advanced-query-techniques--linq-to-xml---visual-basic-.md)