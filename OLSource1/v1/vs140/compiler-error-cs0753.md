---
title: "Compiler Error CS0753"
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
  - "CS0753"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0753"
ms.assetid: 287dd9da-da74-4290-9fa1-21ef1a8150fe
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0753
Only methods, classes, structs, or interfaces may be partial.  
  
 The [partial](../vs140/partial--type---csharp-reference-.md) modifier can only be used with classes, structs, interfaces, and methods.  
  
### To correct this error  
  
1.  Remove the `partial` modifier from the variable or language construct.  
  
## Example  
 The following code generates CS0753:  
  
```  
// cs0753.cs  
using System;  
  
    public partial class C  
    {  
        partial int num; // CS0753  
        public static int Main()  
        {  
            return 1;  
        }  
    }  
```  
  
## See Also  
 [Partial Classes and Methods (C# Programming Guide)](../vs140/partial-classes-and-methods--csharp-programming-guide-.md)