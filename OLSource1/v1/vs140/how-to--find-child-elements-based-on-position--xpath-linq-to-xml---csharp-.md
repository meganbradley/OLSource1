---
title: "How to: Find Child Elements Based on Position (XPath-LINQ to XML) (C#)"
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
ms.assetid: e35bb269-ec86-4c96-8321-12491a0eb2c3
caps.latest.revision: 7
---
# How to: Find Child Elements Based on Position (XPath-LINQ to XML) (C#)
Sometimes you want to find elements based on their position. You might want to find the second element, or you might want to find the third through the fifth element.  
  
 The XPath expression is:  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 There are two approaches to writing this [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] query in a lazy way. You can use the \<xref:System.Linq.Enumerable.Skip*> and \<xref:System.Linq.Enumerable.Take*> operators, or you can use the \<xref:System.Linq.Enumerable.Where*> overload that takes an index. When you use the \<xref:System.Linq.Enumerable.Where*> overload, you use a lambda expression that takes two arguments. The following example shows both methods of selecting based on position.  
  
## Example  
 This example finds the second through the fourth <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> element. The result is a collection of elements.  
  
 This example uses the following XML document: [Sample XML File: Test Configuration (LINQ to XML)](../vs140/sample-xml-file--test-configuration--linq-to-xml-1.md).  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [LINQ to XML for XPath Users (C#)](../vs140/linq-to-xml-for-xpath-users--csharp-.md)