---
title: "Compiler Error CS0743"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - CS0743
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - CS0743
ms.assetid: 0dc8040a-a12f-4da6-9ed0-c0284905ee83
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error CS0743
Expected contextual keyword 'on'  
  
 The pattern for a `join` clause is `join`...`in`...`on`...`equals`, as shown in this example:  
  
```  
var query = from x in array1  
            join y in array2 on x equals y  
            select x;  
```  
  
### To correct this error  
  
1.  Add the `on` keyword to the `join` clause.  
  
## Example  
 The following code generates CS0743:  
  
```  
// cs0743.cs  
using System;  
using System.Linq;  
  
public class C  
{  
    public static int Main()  
    {  
        int[] array1 = { 1, 2, 3 ,4, 5, 6,};  
        int[] array2 = { 5, 6, 7, 8, 9 };  
        var c = from x in array1  
                join y in array2 x equals y // CS0743  
                select x;  
        return 1;  
    }  
}  
```  
  
## See Also  
 [LINQ Query Expressions (C# Programming Guide)](../vs140/linq-query-expressions--csharp-programming-guide-.md)   
 [join clause (C# Reference)](../vs140/join-clause--csharp-reference-.md)