---
title: "How to: Find Related Elements (XPath-LINQ to XML) (Visual Basic)"
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
ms.assetid: 6b0ef058-d704-48a5-98cd-33f00d088af9
caps.latest.revision: 7
---
# How to: Find Related Elements (XPath-LINQ to XML) (Visual Basic)
This topic shows how to get an element selecting on an attribute that is referred to by the value of another element.  
  
 The XPath expression is:  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
## Example  
 This example finds the 12th <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> element, and then finds the customer for that order.  
  
 Note that indexing into a list in .Net is 'zero' based. Indexing into a collection of nodes in an XPath predicate is 'one' based. This example reflects this difference.  
  
 This example uses the following XML document: [Sample XML File: Customers and Orders (LINQ to XML)](../vs140/sample-xml-file--customers-and-orders--linq-to-xml-1.md).  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [LINQ to XML for XPath Users (Visual Basic)](../vs140/linq-to-xml-for-xpath-users--visual-basic-.md)