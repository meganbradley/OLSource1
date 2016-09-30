---
title: "How to: Change the Namespace for an Entire XML Tree (C#)"
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
ms.assetid: 1584ff3b-c77d-4241-ab62-80adfb7bfc1b
caps.latest.revision: 5
---
# How to: Change the Namespace for an Entire XML Tree (C#)
You sometimes have to programmatically change the namespace for an element or an attribute. LINQ to XML makes this easy. The \<xref:System.Xml.Linq.XElement.Name*?displayProperty=fullName> property can be set. The \<xref:System.Xml.Linq.XAttribute.Name*?displayProperty=fullName> property cannot be set, but you can easily copy the attributes into a \<xref:System.Collections.Generic.List`1*?displayProperty=fullName>, remove the existing attributes, and then add new attributes that are in the new desired namespace.  
  
 For more information, see [Working with XML Namespaces (C#)](../vs140/working-with-xml-namespaces--csharp-.md).  
  
## Example  
 The following code creates two XML trees in no namespace. It then changes the namespace of each of the trees, and combines them into a single tree.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Modifying XML Trees (LINQ to XML) (C#)](../vs140/modifying-xml-trees--linq-to-xml---csharp-.md)