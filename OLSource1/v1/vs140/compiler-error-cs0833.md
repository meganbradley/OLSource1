---
title: "Compiler Error CS0833"
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
  - CS0833
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - CS0833
ms.assetid: 4ae32454-265f-47aa-bf2a-ee1d702330b7
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error CS0833
An anonymous type cannot have multiple properties with the same name.  
  
 An anonymous type, just like any type, cannot have two properties that have the same name.  
  
### To correct this error  
  
1.  Give each property in the type a unique name.  
  
## Example  
 The following example generates CS0833:  
  
```  
// cs0833.cs  
using System;  
  
public class C  
{  
    public static int Main()  
    {  
        var c = new { p1 = 1, p1 = 2 }; // CS0833  
        return 1;  
    }  
}  
```  
  
## See Also  
 [Anonymous Types (C# Programming Guide)](../vs140/anonymous-types--csharp-programming-guide-.md)