---
title: "Compiler Error CS0310"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS0310"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0310"
ms.assetid: f7db7e56-f51f-406f-a54b-48ea61b5cb3e
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0310
The type 'typename' must be a non-abstract type with a public parameterless constructor in order to use it as parameter 'parameter' in the generic type or method 'generic'  
  
 The generic type or method defines a new constraint in its where clause, so any type must have a public parameterless constructor in order to be used as a type argument for that generic type or method. To avoid this error, make sure that the type has the correct constructor, or modify the constraint clause of the generic type or method.  
  
## Example  
 The following sample generates CS0310:  
  
```  
// CS0310.cs  
using System;  
  
class G<T> where T : new()  
{  
    T t;  
  
    public G()  
    {  
        t = new T();  
        Console.WriteLine(t);  
    }  
}  
  
class B  
{  
    private B() { }  
    // Try this instead:  
    // public B() { }  
}  
  
class CMain  
{  
    public static void Main()  
    {  
        G<B> g = new G<B>();   // CS0310  
        Console.WriteLine(g.ToString());  
    }  
}  
```