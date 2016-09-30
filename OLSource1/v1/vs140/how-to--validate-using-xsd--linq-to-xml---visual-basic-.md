---
title: "How to: Validate Using XSD (LINQ to XML) (Visual Basic)"
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
ms.assetid: a0fe88d4-4e77-49e7-90de-8953feeccc21
caps.latest.revision: 8
---
# How to: Validate Using XSD (LINQ to XML) (Visual Basic)
The \<xref:System.Xml.Schema*> namespace contains extension methods that make it easy to validate an XML tree against an XML Schema Definition Language (XSD) file. For more information, see the \<xref:System.Xml.Schema.Extensions.Validate*> method documentation.  
  
## Example  
 The following example creates an \<xref:System.Xml.Schema.XmlSchemaSet*>, then validates two \<xref:System.Xml.Linq.XDocument*> objects against the schema set. One of the documents is valid, the other is not.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The following example validates that the XML document from [Sample XML File: Customers and Orders (LINQ to XML)](../vs140/sample-xml-file--customers-and-orders--linq-to-xml-1.md) is valid per the schema from [Sample XSD File: Customers and Orders](../vs140/sample-xsd-file--customers-and-orders2.md). It then modifies the source XML document. It changes the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> attribute on the first customer. After the change, orders will then refer to a customer that does not exist, so the XML document will no longer validate.  
  
 This example uses the following XML document: [Sample XML File: Customers and Orders (LINQ to XML)](../vs140/sample-xml-file--customers-and-orders--linq-to-xml-1.md).  
  
 This example uses the following XSD schema: [Sample XSD File: Customers and Orders](../vs140/sample-xsd-file--customers-and-orders2.md).  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 \<xref:System.Xml.Schema.Extensions.Validate*>   
 [Creating XML Trees (Visual Basic)](../vs140/creating-xml-trees--visual-basic-.md)