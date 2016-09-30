---
title: "How to: Find a Single Descendant Using the Descendants Method (Visual Basic)"
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
ms.assetid: 0c03468c-efc8-4140-98f3-fb67acd9e8e1
caps.latest.revision: 7
---
# How to: Find a Single Descendant Using the Descendants Method (Visual Basic)
You can use the \<xref:System.Xml.Linq.XContainer.Descendants*> axis method to quickly write code to find a single uniquely named element. This technique is especially useful when you want to find a particular descendant with a specific name. You could write the code to navigate to the desired element, but it is often faster and easier to write the code using the \<xref:System.Xml.Linq.XContainer.Descendants*> axis.  
  
## Example  
 This example uses the \<xref:System.Linq.Enumerable.First*> standard query operator.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This code produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The following example shows the same query for XML that is in a namespace. For more information, see [Working with XML Namespaces (Visual Basic)](../vs140/working-with-xml-namespaces--visual-basic-.md).  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 This code produces the following output:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Basic Queries (LINQ to XML) (Visual Basic)](../vs140/basic-queries--linq-to-xml---visual-basic-.md)