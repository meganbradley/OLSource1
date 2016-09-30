---
title: "How to: Filter on Element Names (LINQ to XML) (C#)"
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
ms.assetid: 1849fb03-f075-421f-863c-e8fb32773cdf
caps.latest.revision: 7
---
# How to: Filter on Element Names (LINQ to XML) (C#)
When you call one of the methods that return <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>1*> of \<xref:System.Xml.Linq.XElement*> collections follow the same pattern. Their signatures are similar to \<xref:System.Xml.Linq.XContainer.Elements*> and \<xref:System.Xml.Linq.XContainer.Descendants*>. The following is the complete list of methods that have similar method signatures:  
  
-   \<xref:System.Xml.Linq.XNode.Ancestors*>  
  
-   \<xref:System.Xml.Linq.XContainer.Descendants*>  
  
-   \<xref:System.Xml.Linq.XContainer.Elements*>  
  
-   \<xref:System.Xml.Linq.XNode.ElementsAfterSelf*>  
  
-   \<xref:System.Xml.Linq.XNode.ElementsBeforeSelf*>  
  
-   \<xref:System.Xml.Linq.XElement.AncestorsAndSelf*>  
  
-   \<xref:System.Xml.Linq.XElement.DescendantsAndSelf*>  
  
## Example  
 The following example shows the same query for XML that is in a namespace. For more information, see [Working with XML Namespaces (C#)](../vs140/working-with-xml-namespaces--csharp-.md).  
  
 This example uses the following XML document: [Sample XML File: Typical Purchase Order in a Namespace](../vs140/sample-xml-file--typical-purchase-order-in-a-namespace1.md).  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 This code produces the following output:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [LINQ to XML Axes (C#)](../vs140/linq-to-xml-axes--csharp-.md)