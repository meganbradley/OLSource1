---
title: "How to: Project a New Type (LINQ to XML) (C#)"
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
ms.assetid: 48145cf9-1e0b-4e73-bbfd-28fc04800dc4
caps.latest.revision: 5
---
# How to: Project a New Type (LINQ to XML) (C#)
Other examples in this section have shown queries that return results as <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>1*> of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, and <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>int<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>1*> of some other type.  
  
## Example  
 This example shows how to instantiate objects in the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> clause. The code first defines a new class with a constructor, and then modifies the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> statement so that the expression is a new instance of the new class.  
  
 This example uses the following XML document: [Sample XML File: Typical Purchase Order (LINQ to XML)](../vs140/sample-xml-file--typical-purchase-order--linq-to-xml-1.md).  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example uses the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> method that was introduced in the topic [How to: Retrieve a Single Child Element (LINQ to XML) (C#)](../vs140/how-to--retrieve-a-single-child-element--linq-to-xml---csharp-.md). It also uses casts to retrieve the values of the elements that are returned by the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> method.  
  
 This example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Projections and Transformations (LINQ to XML) (C#)](../vs140/projections-and-transformations--linq-to-xml---csharp-.md)