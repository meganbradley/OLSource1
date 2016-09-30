---
title: "How to: Find the Immediate Preceding Sibling (XPath-LINQ to XML) (C#)"
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
ms.assetid: 74c06201-0b1b-4b5e-b3ac-0092980614e6
caps.latest.revision: 3
---
# How to: Find the Immediate Preceding Sibling (XPath-LINQ to XML) (C#)
Sometimes you want to find the immediate preceding sibling to a node. Due to the difference in the semantics of positional predicates for the preceding sibling axes in XPath as opposed to [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)], this is one of the more interesting comparisons.  
  
## Example  
 In this example, the [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] query uses the \<xref:System.Linq.Enumerable.Last*> operator to find the last node in the collection returned by \<xref:System.Xml.Linq.XNode.ElementsBeforeSelf*>. By contrast, the XPath expression uses a predicate with a value of 1 to find the immediately preceding element.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [LINQ to XML for XPath Users (C#)](../vs140/linq-to-xml-for-xpath-users--csharp-.md)