---
title: "How to: Find Descendants with a Specific Element Name (C#)"
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
ms.assetid: f684da20-bee9-47f5-9607-7e3fd7e67470
caps.latest.revision: 7
---
# How to: Find Descendants with a Specific Element Name (C#)
Sometimes you want to find all descendants with a particular name. You could write code to iterate through all of the descendants, but it is easier to use the \<xref:System.Xml.Linq.XContainer.Descendants*> axis.  
  
## Example  
 The following example shows how to find descendants based on the element name.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This code produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The following example shows the same query for XML that is in a namespace. For more information, see [Working with XML Namespaces (C#)](../vs140/working-with-xml-namespaces--csharp-.md).  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 This code produces the following output:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 \<xref:System.Xml.Linq.XContainer.Descendants*>   
 [Basic Queries (LINQ to XML) (C#)](../vs140/basic-queries--linq-to-xml---csharp-.md)