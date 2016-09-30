---
title: "How to: Project a New Type (LINQ to XML) (Visual Basic)"
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
ms.assetid: 8cfb24f5-89b2-4cfb-b85d-e7963f8f1845
caps.latest.revision: 7
---
# How to: Project a New Type (LINQ to XML) (Visual Basic)
Other examples in this section have shown queries that return results as <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>1*> of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, and <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>int<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>1*> of some other type.  
  
## Example  
 This example shows how to instantiate objects in the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> clause. The code first defines a new class with a constructor, and then modifies the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> statement so that the expression is a new instance of the new class.  
  
 This example uses the following XML document: [Sample XML File: Typical Purchase Order (LINQ to XML)](../vs140/sample-xml-file--typical-purchase-order--linq-to-xml-2.md).  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example uses the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> method that was introduced in the topic [How to: Retrieve a Single Child Element (LINQ to XML) (Visual Basic)](../vs140/how-to--retrieve-a-single-child-element--linq-to-xml---visual-basic-.md). It also uses casts to retrieve the values of the elements that are returned by the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> method.  
  
 This example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Projections and Transformations (LINQ to XML) (Visual Basic)](../vs140/projections-and-transformations--linq-to-xml---visual-basic-.md)