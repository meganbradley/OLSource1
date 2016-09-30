---
title: "How to: Create a Tree from an XmlReader (Visual Basic)"
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
ms.assetid: 6de683d8-177d-402b-b0de-d0539f1ce5d8
caps.latest.revision: 5
---
# How to: Create a Tree from an XmlReader (Visual Basic)
This topic shows how to create an XML tree directly from an \<xref:System.Xml.XmlReader*>. To create an \<xref:System.Xml.Linq.XElement*> from an \<xref:System.Xml.XmlReader*>, you must position the \<xref:System.Xml.XmlReader*> on an element node. The \<xref:System.Xml.XmlReader*> will skip comments and processing instructions, but if the \<xref:System.Xml.XmlReader*> is positioned on a text node, an error will be thrown. To avoid such errors, always position the \<xref:System.Xml.XmlReader*> on an element before you create an XML tree from the \<xref:System.Xml.XmlReader*>.  
  
## Example  
 This example uses the following XML document: [Sample XML File: Books (LINQ to XML)](../vs140/sample-xml-file--books--linq-to-xml-3.md).  
  
 The following code creates an <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object, and then reads nodes until it finds the first element node. It then loads the \<xref:System.Xml.Linq.XElement*> object.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Parsing XML (Visual Basic)](../vs140/parsing-xml--visual-basic-.md)