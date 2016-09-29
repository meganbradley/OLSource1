---
title: "Compiler Error CS1930"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CS1930"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1930"
ms.assetid: d28d2334-825c-4ffc-b9e9-f5d61f44d672
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1930
The range variable 'name' has already been declared  
  
 The range variable in a query expression is in scope until the query expression terminates. It must therefore have a unique identifier.  
  
### To correct this error  
  
1.  Give a unique name to each range variable that is introduced in a query expression.  
  
## Example  
 The following example generates CS1930 because the identifier `num` is used for the range variable in the `from` clause and for the range variable introduced by the `let` clause.  
  
```  
// cs1930.cs  
using System.Linq;  
class Program  
{  
    static void Main()  
    {  
        int[] nums = { 0, 1, 2, 3, 4, 5 };  
        var query = from num in nums  
                    let num = 3 // CS1930  
                    select num;   
    }  
}  
```  
  
## See Also  
 [LINQ Query Expressions (C# Programming Guide)](../vs140/linq-query-expressions--csharp-programming-guide-.md)