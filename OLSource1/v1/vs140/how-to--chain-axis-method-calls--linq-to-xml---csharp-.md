---
title: "How to: Chain Axis Method Calls (LINQ to XML) (C#)"
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
ms.assetid: 067e6da2-ee32-486d-803c-e611b328e39a
caps.latest.revision: 7
---
# How to: Chain Axis Method Calls (LINQ to XML) (C#)
A common pattern that you will use in your code is to call an axis method, then call one of the extension method axes.  
  
 There are two axes with the name of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> that return a collection of elements: the \<xref:System.Xml.Linq.XContainer.Elements*?displayProperty=fullName> method and the \<xref:System.Xml.Linq.Extensions.Elements*?displayProperty=fullName> method. You can combine these two axes to find all elements of a specified name at a given depth in the tree.  
  
## Example  
 This example uses \<xref:System.Xml.Linq.XContainer.Elements*?displayProperty=fullName> and \<xref:System.Xml.Linq.Extensions.Elements*?displayProperty=fullName> to find all <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> elements in all <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> elements in all <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> elements.  
  
 This example uses the following XML document: [Sample XML File: Multiple Purchase Orders (LINQ to XML)](../vs140/sample-xml-file--multiple-purchase-orders--linq-to-xml-2.md).  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 This works because one of the implementations of the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> axis is as an extension method on <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>ConfigParameter<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>Customer<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>ConfigParameter<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>Root` element.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 To do this, you can use the \<xref:System.Xml.Linq.Extensions.Elements*?displayProperty=fullName> axis, as follows:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## Example  
 The following example shows the same technique for XML that is in a namespace. For more information, see [Working with XML Namespaces (C#)](../vs140/working-with-xml-namespaces--csharp-.md).  
  
 This example uses the following XML document: [Sample XML File: Multiple Purchase Orders in a Namespace](../vs140/sample-xml-file--multiple-purchase-orders-in-a-namespace2.md).  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
## See Also  
 [LINQ to XML Axes (C#)](../vs140/linq-to-xml-axes--csharp-.md)