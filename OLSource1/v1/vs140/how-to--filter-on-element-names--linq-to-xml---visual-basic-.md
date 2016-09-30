---
title: "How to: Filter on Element Names (LINQ to XML) (Visual Basic)"
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
ms.assetid: b1437b4a-48aa-4546-834a-d6d3ab015fe1
caps.latest.revision: 7
---
# How to: Filter on Element Names (LINQ to XML) (Visual Basic)
When you call one of the methods that return <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>1*> of \<xref:System.Xml.Linq.XElement*> collections follow the same pattern. Their signatures are similar to \<xref:System.Xml.Linq.XContainer.Elements*> and \<xref:System.Xml.Linq.XContainer.Descendants*>. The following is the complete list of methods that have similar method signatures:  
  
-   \<xref:System.Xml.Linq.XNode.Ancestors*>  
  
-   \<xref:System.Xml.Linq.XContainer.Descendants*>  
  
-   \<xref:System.Xml.Linq.XContainer.Elements*>  
  
-   \<xref:System.Xml.Linq.XNode.ElementsAfterSelf*>  
  
-   \<xref:System.Xml.Linq.XNode.ElementsBeforeSelf*>  
  
-   \<xref:System.Xml.Linq.XElement.AncestorsAndSelf*>  
  
-   \<xref:System.Xml.Linq.XElement.DescendantsAndSelf*>  
  
## Example  
 The following example shows the same query for XML that is in a namespace. For more information, see [Working with XML Namespaces (Visual Basic)](../vs140/working-with-xml-namespaces--visual-basic-.md).  
  
 This example uses the following XML document: [Sample XML File: Typical Purchase Order in a Namespace](../vs140/sample-xml-file--typical-purchase-order-in-a-namespace3.md).  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 This code produces the following output:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [LINQ to XML Axes (Visual Basic)](../vs140/linq-to-xml-axes--visual-basic-.md)