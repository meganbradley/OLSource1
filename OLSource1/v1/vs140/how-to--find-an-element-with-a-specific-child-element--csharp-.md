---
title: "How to: Find an Element with a Specific Child Element (C#)"
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
ms.assetid: 00cf5555-374e-4369-bf93-7bd2e7f21db3
caps.latest.revision: 5
---
# How to: Find an Element with a Specific Child Element (C#)
This topic shows how to find a particular element that has a child element with a specific value.  
  
## Example  
 The example finds the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> element that has a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> child element with the value of "Examp2.EXE".  
  
 This example uses the following XML document: [Sample XML File: Test Configuration (LINQ to XML)](../vs140/sample-xml-file--test-configuration--linq-to-xml-1.md).  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This code produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The following example shows the same query for XML that is in a namespace. For more information, see [Working with XML Namespaces (C#)](../vs140/working-with-xml-namespaces--csharp-.md).  
  
 This example uses the following XML document: [Sample XML File: Test Configuration in a Namespace](../vs140/sample-xml-file--test-configuration-in-a-namespace1.md).  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 This code produces the following output:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 \<xref:System.Xml.Linq.XElement.Attribute*>   
 \<xref:System.Xml.Linq.XContainer.Elements*>   
 [Basic Queries (LINQ to XML) (C#)](../vs140/basic-queries--linq-to-xml---csharp-.md)   
 [Standard Query Operators Overview (C#)](../vs140/standard-query-operators-overview--csharp-.md)   
 [Projection Operations (C#)](../vs140/projection-operations--csharp-.md)