---
title: "Compiler Error CS1921"
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
  - "CS1921"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1921"
ms.assetid: 0e8326dc-4ad9-49b6-948c-d37f10e6abaf
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1921
The best overloaded method match for 'method' has wrong signature for the initializer element. The initializable Add must be an accessible instance method.  
  
 This error is generated when you try to use a collection initializer with a class that has no public non-static `Add` method. If the `Add` method is not accessible because of its protection level (`private`, `protected`, `internal`) then you will get CS0122, so that this error probably means that the method is defined as `static`.  
  
## Example  
 The following example generates CS1921:  
  
```  
// cs1921.cs  
using System.Collections;  
public class C : CollectionBase  
{  
    public static void Add(int i)  
    {  
    }  
}  
public class Test  
{  
    public static void Main()  
    {  
        var collection = new C { 1, 2, 3 }; // CS1921  
    }  
}  
```  
  
## See Also  
 [Object and Collection Initializers (C# Programming Guide)](../vs140/object-and-collection-initializers--csharp-programming-guide-.md)