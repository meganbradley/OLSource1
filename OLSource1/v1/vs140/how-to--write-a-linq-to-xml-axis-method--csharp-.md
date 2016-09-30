---
title: "How to: Write a LINQ to XML Axis Method (C#)"
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
ms.assetid: 50aef06b-1d22-4718-a18a-21237e26d7c1
caps.latest.revision: 7
---
# How to: Write a LINQ to XML Axis Method (C#)
You can write your own axis methods to retrieve collections from an XML tree. One of the best ways to do this is to write an extension method that returns a collection of elements or attributes. You can write your extension method to return specific subsets of elements or attributes, based on the requirements of your application.  
  
## Example  
 The following example uses two extension methods. The first extension method, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, operates on \<xref:System.Xml.Linq.XObject*>, and returns an XPath expression that when evaluated will return the node or attribute. The second extension method, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, operates on \<xref:System.Xml.Linq.XElement*>. It returns a collection of \<xref:System.Xml.Linq.XAttribute*> objects and \<xref:System.Xml.Linq.XElement*> objects that contain some specified text.  
  
 This example uses the following XML document: [Sample XML File: Multiple Purchase Orders (LINQ to XML)](../vs140/sample-xml-file--multiple-purchase-orders--linq-to-xml-2.md).  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This code produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Advanced Query Techniques (LINQ to XML) (C#)](../vs140/advanced-query-techniques--linq-to-xml---csharp-.md)