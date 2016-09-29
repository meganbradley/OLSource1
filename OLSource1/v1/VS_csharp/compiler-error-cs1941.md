---
title: "Compiler Error CS1941"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS1941"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1941"
ms.assetid: 503054d6-9553-4a2a-9b68-4ccfdeccca22
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1941
The type of one of the expressions in the 'clause' clause is incorrect. Type inference failed in the call to 'method'.  
  
 Type inference in query expressions flows from the type of the elements in the data source(s).  
  
### To correct this error  
  
1.  If it is not immediately obvious why the error is occurring, examine the query carefully and trace the type of the result of each clause from the data source to the point where the error is occurring.  
  
## Example  
 The following code generates CS1941 because the `equals` operator is being asked to compare an `int` to a `string`.  
  
```  
// cs1941.cs  
using System.Collections;  
using System.Linq;  
class Test  
{  
    static int Main()  
    {  
        var nums = new[] { 1, 2, 3, 4, 5, 6 };  
        var words = new string[] { "lake", "mountain", "sky" };  
        IEnumerable e = from n in nums  
                        join w in words on n equals w // CS1941  
                        select w;  
        return 0;  
    }  
}  
```  
  
 The method in which type inference fails is the method that the query clause is translated to at compile time.  
  
## See Also  
 [LINQ Query Expressions (C# Programming Guide)](../VS_csharp/linq-query-expressions--csharp-programming-guide-.md)   
 [Type Relationships in Query Operations (LINQ)](../VS_csharp/type-relationships-in-linq-query-operations--csharp-.md)