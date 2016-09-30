---
title: "How to: Find Sibling Nodes (XPath-LINQ to XML) (Visual Basic)"
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
ms.assetid: 73082738-2113-4438-8545-98d5df0927cb
caps.latest.revision: 7
---
# How to: Find Sibling Nodes (XPath-LINQ to XML) (Visual Basic)
You might want to find all siblings of a node that have a specific name. The resulting collection might include the context node if the context node also has the specific name.  
  
 The XPath expression is:  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
## Example  
 This example first finds a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> element, and then finds all sibling elements named <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. The resulting collection includes the context node.  
  
 This example uses the following XML document: [Sample XML File: Books (LINQ to XML)](../vs140/sample-xml-file--books--linq-to-xml-3.md).  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [LINQ to XML for XPath Users (Visual Basic)](../vs140/linq-to-xml-for-xpath-users--visual-basic-.md)