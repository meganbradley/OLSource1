---
title: "Chaining Standard Query Operators Together (C#)"
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
ms.assetid: 66f2b0a9-2c23-4735-988e-bbc9dfb55c7b
caps.latest.revision: 7
---
# Chaining Standard Query Operators Together (C#)
This is the final topic in the [Tutorial: Chaining Queries Together (C#)](../vs140/tutorial--chaining-queries-together--csharp-.md) tutorial.  
  
 The standard query operators can also be chained together. For example, you can interject the \<xref:System.Linq.Enumerable.Where*?displayProperty=fullName> operator, and it also operates in a lazy fashion. No intermediate results are materialized by it.  
  
## Example  
 In this example, the \<xref:System.Linq.Enumerable.Where*> method is called before calling <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. The \<xref:System.Linq.Enumerable.Where*> method operates in almost exactly the same way as the lazy methods used in previous examples in this tutorial, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 One difference is that in this case, the \<xref:System.Linq.Enumerable.Where*> method iterates through its source collection, determines that the first item does not pass the predicate, and then gets the next item, which does pass. It then yields the second item.  
  
 However, the basic idea is the same: Intermediate collections are not materialized unless they have to be.  
  
 When query expressions are used, they are converted to calls to the standard query operators, and the same principles apply.  
  
 All of the examples in this section that are querying Office Open XML documents use the same principle. Deferred execution and lazy evaluation are some of the fundamental concepts that you must understand  to use LINQ (and LINQ to XML) effectively.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Tutorial: Chaining Queries Together (C#)](../vs140/tutorial--chaining-queries-together--csharp-.md)