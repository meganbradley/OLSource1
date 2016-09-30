---
title: "How to: Find Descendants of a Child Element (XPath-LINQ to XML) (C#)"
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
ms.assetid: 505b7512-bb8b-4f85-abbf-491f039c961e
caps.latest.revision: 7
---
# How to: Find Descendants of a Child Element (XPath-LINQ to XML) (C#)
This topic shows how to get the descendant elements of a child element with a particular name.  
  
 The XPath expression is:  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
## Example  
 This example simulates the problems of extracting text from an XML representation of a word processing document. It first selects all <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> elements, and then it selects all <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> descendant elements of each <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> element. This doesn't select the descendant <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> elements of the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> element.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [LINQ to XML for XPath Users (C#)](../vs140/linq-to-xml-for-xpath-users--csharp-.md)