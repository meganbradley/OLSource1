---
title: "How to: Find Descendants of a Child Element (XPath-LINQ to XML) (Visual Basic)"
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
ms.assetid: a958af40-f754-4409-85f9-7746978d4cb3
caps.latest.revision: 7
---
# How to: Find Descendants of a Child Element (XPath-LINQ to XML) (Visual Basic)
This topic shows how to get the descendant elements of a child element with a particular name.  
  
 The XPath expression is:  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
## Example  
 This example simulates the problems of extracting text from an XML representation of a word processing document. It first selects all <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> elements, and then it selects all <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> descendant elements of each <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> element. This doesn't select the descendant <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> elements of the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> element.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [LINQ to XML for XPath Users (Visual Basic)](../vs140/linq-to-xml-for-xpath-users--visual-basic-.md)