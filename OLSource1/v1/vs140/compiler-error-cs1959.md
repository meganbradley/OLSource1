---
title: "Compiler Error CS1959"
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
  - CS1959
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - CS1959
ms.assetid: 20a31619-3e30-446a-becc-a7f8cfcec66d
caps.latest.revision: 9
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error CS1959
'name' is of type 'type'. The type specified in a constant declaration must be sbyte, byte, short, ushort, int, uint, long, ulong, char, float, double, decimal, bool, string, an enum-type, or a reference-type.  
  
 The types permitted in a const declaration are limited to those described in this message.  
  
### To correct this error  
  
1.  Declare the constant with an allowed type.  
  
## Example  
 The following code produces CS1959 because `null` is not a type.  
  
```  
// cs1959.cs  
class Program  
    {  
        static void Test<T>() where T : class  
        {  
            const T x = null; // CS1959  
        }  
    }  
```  
  
## See Also  
 [Constants (C# Programming Guide)](../vs140/constants--csharp-programming-guide-.md)   
 [null (C# Reference)](../vs140/null--csharp-reference-.md)