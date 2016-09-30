---
title: "How to: Write Queries with Complex Filtering (C#)"
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
ms.assetid: 4065d901-cf89-4e47-8bf9-abb65acfb003
caps.latest.revision: 3
---
# How to: Write Queries with Complex Filtering (C#)
Sometimes you want to write LINQ to XML queries with complex filters. For example, you might have to find all elements that have a child element with a particular name and value. This topic gives an example of writing a query with complex filtering.  
  
## Example  
 This example shows how to find all <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> elements that have a child <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> element that has a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> attribute equal to "Shipping" and a child <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> element equal to "NY". It uses a nested query in the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> clause, and the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> operator returns <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> if the collection has any elements in it. For information about using method-based query syntax, see [Query Syntax and Method Syntax in LINQ (C#)](../vs140/query-syntax-and-method-syntax-in-linq--csharp-.md).  
  
 This example uses the following XML document: [Sample XML File: Multiple Purchase Orders (LINQ to XML)](../vs140/sample-xml-file--multiple-purchase-orders--linq-to-xml-2.md).  
  
 For more information about the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> operator, see [Quantifier Operations (C#)](../vs140/quantifier-operations--csharp-.md).  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This code produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The following example shows the same query for XML that is in a namespace. For more information, see [Working with XML Namespaces (C#)](../vs140/working-with-xml-namespaces--csharp-.md).  
  
 This example uses the following XML document: [Sample XML File: Multiple Purchase Orders in a Namespace](../vs140/sample-xml-file--multiple-purchase-orders-in-a-namespace2.md).  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 This code produces the following output:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 \<xref:System.Xml.Linq.XElement.Attribute*>   
 \<xref:System.Xml.Linq.XContainer.Elements*>   
 [Basic Queries (LINQ to XML) (C#)](../vs140/basic-queries--linq-to-xml---csharp-.md)   
 [Projection Operations (C#)](../vs140/projection-operations--csharp-.md)   
 [Quantifier Operations (C#)](../vs140/quantifier-operations--csharp-.md)