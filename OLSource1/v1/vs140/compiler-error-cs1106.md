---
title: "Compiler Error CS1106"
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
  - "CS1106"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1106"
ms.assetid: 3585600a-6b2c-47aa-a418-ef049f07c107
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1106
Extension methods must be defined in a non generic static class.  
  
 Extension methods must be defined as static methods in a non-generic static class.  
  
## Example  
 The following example generates CS1106 because the class `Extensions` is not defined as `static`:  
  
```  
// cs1106.cs  
public class Extensions // CS1106  
{  
    public  static void Test<T>(this System.String s) {}  
}  
```  
  
## See Also  
 [Extension Methods (C# Programming Guide)](../vs140/extension-methods--csharp-programming-guide-.md)   
 [static (C# Reference)](../vs140/static--csharp-reference-.md)