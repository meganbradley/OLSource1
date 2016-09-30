---
title: "How to: Find Related Elements (XPath-LINQ to XML) (C#)"
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
ms.assetid: 41b386ee-562d-4841-bd6b-e44a7eb69f26
caps.latest.revision: 7
---
# How to: Find Related Elements (XPath-LINQ to XML) (C#)
This topic shows how to get an element selecting on an attribute that is referred to by the value of another element.  
  
 The XPath expression is:  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
## Example  
 This example finds the 12th <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> element, and then finds the customer for that order.  
  
 Note that indexing into a list in .Net is 'zero' based. Indexing into a collection of nodes in an XPath predicate is 'one' based. This example reflects this difference.  
  
 This example uses the following XML document: [Sample XML File: Customers and Orders (LINQ to XML)](../vs140/sample-xml-file--customers-and-orders--linq-to-xml-2.md).  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [LINQ to XML for XPath Users (C#)](../vs140/linq-to-xml-for-xpath-users--csharp-.md)