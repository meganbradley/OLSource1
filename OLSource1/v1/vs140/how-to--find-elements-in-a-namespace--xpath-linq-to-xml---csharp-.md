---
title: "How to: Find Elements in a Namespace (XPath-LINQ to XML) (C#)"
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
ms.assetid: cae1c4ac-6cd5-46cf-9b1c-bd85bc9b7ea9
caps.latest.revision: 7
---
# How to: Find Elements in a Namespace (XPath-LINQ to XML) (C#)
XPath expressions can find nodes in a particular namespace. XPath expressions use namespace prefixes for specifying namespaces. To parse an XPath expression that contains namespace prefixes, you must pass an object to the XPath methods that implements \<xref:System.Xml.IXmlNamespaceResolver*>. This example uses \<xref:System.Xml.XmlNamespaceManager*>.  
  
 The XPath expression is:  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
## Example  
 The following example reads an XML tree that contains two namespaces. It uses an \<xref:System.Xml.XmlReader*> to read the XML document. It then gets an \<xref:System.Xml.XmlNameTable*> from the \<xref:System.Xml.XmlReader*>, and an \<xref:System.Xml.XmlNamespaceManager*> from the \<xref:System.Xml.XmlNameTable*>. It uses the \<xref:System.Xml.XmlNamespaceManager*> when selecting elements.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [LINQ to XML for XPath Users (C#)](../vs140/linq-to-xml-for-xpath-users--csharp-.md)