---
title: "How to: Write a Query that Finds Elements Based on Context (C#)"
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
ms.assetid: 3ff79ef0-fc8b-42fe-8cc0-10dc32b06b4e
caps.latest.revision: 5
---
# How to: Write a Query that Finds Elements Based on Context (C#)
Sometimes you might have to write a query that selects elements based on their context. You might want to filter based on preceding or following sibling elements. You might want to filter based on child or ancestor elements.  
  
 You can do this by writing a query and using the results of the query in the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> clause. If you have to first test against null, and then test the value, it is more convenient to do the query in a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> clause, and then use the results in the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> clause.  
  
## Example  
 The following example selects all <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> elements that are immediately followed by a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> element.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This code produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The following example shows the same query for XML that is in a namespace. For more information, see [Working with XML Namespaces (C#)](../vs140/working-with-xml-namespaces--csharp-.md).  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 This code produces the following output:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 \<xref:System.Xml.Linq.XElement.Parse*>   
 \<xref:System.Xml.Linq.XContainer.Descendants*>   
 \<xref:System.Xml.Linq.XNode.ElementsAfterSelf*>   
 \<xref:System.Linq.Enumerable.FirstOrDefault*>   
 [Basic Queries (LINQ to XML) (C#)](../vs140/basic-queries--linq-to-xml---csharp-.md)