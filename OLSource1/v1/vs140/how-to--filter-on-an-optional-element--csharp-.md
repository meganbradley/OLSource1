---
title: "How to: Filter on an Optional Element (C#)"
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
ms.assetid: f99e2f93-fca5-403f-8a0c-770761d4905a
caps.latest.revision: 8
---
# How to: Filter on an Optional Element (C#)
Sometimes you want to filter for an element even though you are not sure it exists in your XML document. The search should be executed so that if the particular element does not have the child element, you do not trigger a null reference exception by filtering for it. In the following example, the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> element does not have a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> child element, but the query still executes correctly.  
  
## Example  
 This example uses the \<xref:System.Xml.Linq.Extensions.Elements*> extension method.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This code produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The following example shows the same query for XML that is in a namespace. For more information, see [Working with XML Namespaces (C#)](../vs140/working-with-xml-namespaces--csharp-.md).  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 This code produces the following output:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 \<xref:System.Xml.Linq.XElement.Attribute*?displayProperty=fullName>   
 \<xref:System.Xml.Linq.XContainer.Elements*?displayProperty=fullName>   
 \<xref:System.Xml.Linq.Extensions.Elements*?displayProperty=fullName>   
 [Basic Queries (LINQ to XML) (C#)](../vs140/basic-queries--linq-to-xml---csharp-.md)   
 [Standard Query Operators Overview (C#)](../vs140/standard-query-operators-overview--csharp-.md)   
 [Projection Operations (C#)](../vs140/projection-operations--csharp-.md)