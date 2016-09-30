---
title: "How to: Chain Axis Method Calls (LINQ to XML) (Visual Basic)"
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
ms.assetid: e4e22942-39bd-460f-b3c0-9f09e53d3aa9
caps.latest.revision: 7
---
# How to: Chain Axis Method Calls (LINQ to XML) (Visual Basic)
A common pattern that you will use in your code is to call an axis method, then call one of the extension method axes.  
  
 There are two axes with the name of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> that return a collection of elements: the \<xref:System.Xml.Linq.XContainer.Elements*?displayProperty=fullName> method and the \<xref:System.Xml.Linq.Extensions.Elements*?displayProperty=fullName> method. You can combine these two axes to find all elements of a specified name at a given depth in the tree.  
  
## Example  
 This example uses \<xref:System.Xml.Linq.XContainer.Elements*?displayProperty=fullName> and \<xref:System.Xml.Linq.Extensions.Elements*?displayProperty=fullName> to find all <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> elements in all <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> elements in all <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> elements.  
  
 This example uses the following XML document: [Sample XML File: Multiple Purchase Orders (LINQ to XML)](../vs140/sample-xml-file--multiple-purchase-orders--linq-to-xml-3.md).  
  
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
 The following example shows the same technique for XML that is in a namespace. For more information, see [Working with XML Namespaces (Visual Basic)](../vs140/working-with-xml-namespaces--visual-basic-.md).  
  
 This example uses the following XML document: [Sample XML File: Multiple Purchase Orders in a Namespace](../vs140/sample-xml-file--multiple-purchase-orders-in-a-namespace3.md).  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
## See Also  
 [LINQ to XML Axes (Visual Basic)](../vs140/linq-to-xml-axes--visual-basic-.md)