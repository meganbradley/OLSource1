---
title: "Deferred Execution Example (C#)"
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
ms.assetid: 50f4fbac-81fe-4f26-aedf-506e21419b19
caps.latest.revision: 7
---
# Deferred Execution Example (C#)
This topic shows how deferred execution and lazy evaluation affect the execution of your LINQ to XML queries.  
  
## Example  
 The following example shows the order of execution when using an extension method that uses deferred execution. The example declares an array of three strings. It then iterates through the collection returned by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Notice that when iterating through the collection returned by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, each item is retrieved from the source string array and converted to uppercase before the next item is retrieved from the source string array.  
  
 You can see that the entire array of strings is not converted to uppercase before each item in the returned collection is processed in the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> loop in <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 The next topic in this tutorial illustrates chaining queries together:  
  
-   [Chaining Queries Example (C#)](../vs140/chaining-queries-example--csharp-.md)  
  
## See Also  
 [Tutorial: Chaining Queries Together (C#)](../vs140/tutorial--chaining-queries-together--csharp-.md)