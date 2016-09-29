---
title: "Compiler Error CS1017"
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
  - "CS1017"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1017"
ms.assetid: e0902e8a-b042-4711-a8a6-83456a3f88cb
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1017
Catch clauses cannot follow the general catch clause of a try statement  
  
 A `catch` block that does not take any parameters must be the last in a series of `catch` blocks. For more information on exceptions, see [Exception Handling Statements](../vs140/exception-handling-statements--csharp-reference-.md).  
  
## Example  
 The following sample generates CS1017:  
  
```  
// CS1017.cs  
using System;  
  
namespace x  
{  
    public class b : Exception  
    {  
    }  
  
    public class a  
    {  
        public static void Main()  
        {  
            try  
            {  
            }  
  
            catch   // CS1017, must be last catch  
            {  
            }  
  
            catch(b)  
            {  
                throw;  
            }  
        }  
    }  
}  
```