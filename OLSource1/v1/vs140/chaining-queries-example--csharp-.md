---
title: "Chaining Queries Example (C#)"
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
ms.assetid: abbca162-d95e-43af-b92c-e46e6aa2540e
caps.latest.revision: 7
---
# Chaining Queries Example (C#)
This example builds on the previous example and shows what happens when you chain together two queries that both use deferred execution and lazy evaluation.  
  
## Example  
 In this example, another extension method is introduced, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, which appends a specified string onto every string in the source collection, and then yields the new strings.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 In this example, you can see that each extension method operates one at a time for each item in the source collection.  
  
 What should be clear from this example is that even though we have chained together queries that yield collections, no intermediate collections are materialized. Instead, each item is passed from one lazy method to the next. This results in a much smaller memory footprint than an approach that would first take one array of strings, then create a second array of strings that have been converted to uppercase, and finally create a third array of strings where each string has the exclamation points appended to it.  
  
 The next topic in this tutorial illustrates intermediate materialization:  
  
-   [Intermediate Materialization (C#)](../vs140/intermediate-materialization--csharp-.md)  
  
## See Also  
 [Tutorial: Chaining Queries Together (C#)](../vs140/tutorial--chaining-queries-together--csharp-.md)