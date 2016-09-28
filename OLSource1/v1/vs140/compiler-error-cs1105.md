---
title: "Compiler Error CS1105"
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
  - "CS1105"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1105"
ms.assetid: fcbd91ad-a76a-4b22-868d-16824fa96f85
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1105
Extension methods must be static.  
  
 Extension methods must be declared as static methods in a non-generic static class.  
  
## Example  
 The following example generates CS1105 because `Test` is not static:  
  
```  
// cs1105.cs  
// Compile with: /target:library  
public class Extensions  
{  
  
    // Single type parameter.  
        public void Test<T>(this System.String s) {} //CS1105  
  
}  
```  
  
## See Also  
 [Extension Methods (C# Programming Guide)](../vs140/extension-methods--csharp-programming-guide-.md)   
 [static (C# Reference)](../vs140/static--csharp-reference-.md)