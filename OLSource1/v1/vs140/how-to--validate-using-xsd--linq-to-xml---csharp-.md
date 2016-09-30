---
title: "How to: Validate Using XSD (LINQ to XML) (C#)"
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
ms.assetid: 6a7f83a9-2d74-4c2b-8417-0a8595879516
caps.latest.revision: 7
---
# How to: Validate Using XSD (LINQ to XML) (C#)
The \<xref:System.Xml.Schema*> namespace contains extension methods that make it easy to validate an XML tree against an XML Schema Definition Language (XSD) file. For more information, see the \<xref:System.Xml.Schema.Extensions.Validate*> method documentation.  
  
## Example  
 The following example creates an \<xref:System.Xml.Schema.XmlSchemaSet*>, then validates two \<xref:System.Xml.Linq.XDocument*> objects against the schema set. One of the documents is valid, the other is not.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The following example validates that the XML document from [Sample XML File: Customers and Orders (LINQ to XML)](../vs140/sample-xml-file--customers-and-orders--linq-to-xml-2.md) is valid per the schema from [Sample XSD File: Customers and Orders](../vs140/sample-xsd-file--customers-and-orders1.md). It then modifies the source XML document. It changes the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> attribute on the first customer. After the change, orders will then refer to a customer that does not exist, so the XML document will no longer validate.  
  
 This example uses the following XML document: [Sample XML File: Customers and Orders (LINQ to XML)](../vs140/sample-xml-file--customers-and-orders--linq-to-xml-2.md).  
  
 This example uses the following XSD schema: [Sample XSD File: Customers and Orders](../vs140/sample-xsd-file--customers-and-orders1.md).  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 \<xref:System.Xml.Schema.Extensions.Validate*>   
 [Creating XML Trees (C#)](../vs140/creating-xml-trees--csharp-.md)