---
title: "How to: Retrieve a Single Child Element (LINQ to XML) (C#)"
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
ms.assetid: ce37db9e-76fa-46eb-b4cc-e8f32d22ad90
caps.latest.revision: 7
---
# How to: Retrieve a Single Child Element (LINQ to XML) (C#)
This topic explains how to retrieve a single child element, given the name of the child element. When you know the name of the child element and that there is only one element that has this name, it can be convenient to retrieve just one element, instead of a collection.  
  
 The \<xref:System.Xml.Linq.XContainer.Element*> method returns the first child \<xref:System.Xml.Linq.XElement*> with the specified \<xref:System.Xml.Linq.XName*>.  
  
 If you want to retrieve a single child element in Visual Basic, a common approach is to use the XML property, and then retrieve the first element using array indexer notation.  
  
## Example  
 The following example demonstrates the use of the \<xref:System.Xml.Linq.XContainer.Element*> method. This example takes the XML tree named <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and finds the first element named <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 The Visual Basic example shows using array indexer notation to retrieve a single element.  
  
 This example uses the following XML document: [Sample XML File: Typical Purchase Order (LINQ to XML)](../vs140/sample-xml-file--typical-purchase-order--linq-to-xml-1.md).  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The following example shows the same code for XML that is in a namespace. For more information, see [Working with XML Namespaces (C#)](../vs140/working-with-xml-namespaces--csharp-.md).  
  
 This example uses the following XML document: [Sample XML File: Typical Purchase Order in a Namespace](../vs140/sample-xml-file--typical-purchase-order-in-a-namespace1.md).  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [LINQ to XML Axes (C#)](../vs140/linq-to-xml-axes--csharp-.md)