---
title: "How to: Create a Tree from an XmlReader (C#)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
ms.assetid: 60951c9c-7087-406c-b5bb-c60e58609b21
caps.latest.revision: 7
---
# How to: Create a Tree from an XmlReader (C#)
This topic shows how to create an XML tree directly from an \<xref:System.Xml.XmlReader*>. To create an \<xref:System.Xml.Linq.XElement*> from an \<xref:System.Xml.XmlReader*>, you must position the \<xref:System.Xml.XmlReader*> on an element node. The \<xref:System.Xml.XmlReader*> will skip comments and processing instructions, but if the \<xref:System.Xml.XmlReader*> is positioned on a text node, an error will be thrown. To avoid such errors, always position the \<xref:System.Xml.XmlReader*> on an element before you create an XML tree from the \<xref:System.Xml.XmlReader*>.  
  
## Example  
 This example uses the following XML document: [Sample XML File: Books (LINQ to XML)](../vs140/sample-xml-file--books--linq-to-xml-1.md).  
  
 The following code creates an <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object, and then reads nodes until it finds the first element node. It then loads the \<xref:System.Xml.Linq.XElement*> object.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Parsing XML (C#)](../vs140/parsing-xml--csharp-.md)