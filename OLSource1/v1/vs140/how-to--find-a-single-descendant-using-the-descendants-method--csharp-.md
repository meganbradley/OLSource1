---
title: "How to: Find a Single Descendant Using the Descendants Method (C#)"
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
ms.assetid: 6f735be9-0293-4680-8007-ca9d96bfebed
caps.latest.revision: 7
---
# How to: Find a Single Descendant Using the Descendants Method (C#)
You can use the \<xref:System.Xml.Linq.XContainer.Descendants*> axis method to quickly write code to find a single uniquely named element. This technique is especially useful when you want to find a particular descendant with a specific name. You could write the code to navigate to the desired element, but it is often faster and easier to write the code using the \<xref:System.Xml.Linq.XContainer.Descendants*> axis.  
  
## Example  
 This example uses the \<xref:System.Linq.Enumerable.First*> standard query operator.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This code produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The following example shows the same query for XML that is in a namespace. For more information, see [Working with XML Namespaces (C#)](../vs140/working-with-xml-namespaces--csharp-.md).  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 This code produces the following output:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Basic Queries (LINQ to XML) (C#)](../vs140/basic-queries--linq-to-xml---csharp-.md)