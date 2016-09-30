---
title: "How to: Find Attributes of Siblings with a Specific Name (XPath-LINQ to XML) (C#)"
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
ms.assetid: c3133d64-523f-422d-8838-73d36b945ca0
caps.latest.revision: 7
---
# How to: Find Attributes of Siblings with a Specific Name (XPath-LINQ to XML) (C#)
This topic shows how to find all attributes of the siblings of the context node. Only attributes with a specific name are returned in the collection.  
  
 The XPath expression is:  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
## Example  
 This example first finds a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> element, and then finds all sibling elements named <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, and then finds all attributes named <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. The result is a collection of attributes.  
  
 This example uses the following XML document: [Sample XML File: Books (LINQ to XML)](../vs140/sample-xml-file--books--linq-to-xml-1.md).  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [LINQ to XML for XPath Users (C#)](../vs140/linq-to-xml-for-xpath-users--csharp-.md)