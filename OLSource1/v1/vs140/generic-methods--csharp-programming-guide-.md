---
title: "Generic Methods (C# Programming Guide)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "generics [C#], methods"
ms.assetid: 673eeea2-4b48-4faa-9c4e-2e89449221b9
caps.latest.revision: 31
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Generic Methods (C# Programming Guide)
A generic method is a method that is declared with type parameters, as follows:  
  
 [!code[csProgGuideGenerics#22](../vs140/codesnippet/CSharp/generic-methods--csharp-programming-guide-_1.cs)]  
  
 The following code example shows one way to call the method by using `int` for the type argument:  
  
 [!code[csProgGuideGenerics#23](../vs140/codesnippet/CSharp/generic-methods--csharp-programming-guide-_2.cs)]  
  
 You can also omit the type argument and the compiler will infer it. The following call to `Swap` is equivalent to the previous call:  
  
 [!code[csProgGuideGenerics#24](../vs140/codesnippet/CSharp/generic-methods--csharp-programming-guide-_3.cs)]  
  
 The same rules for type inference apply to static methods and instance methods. The compiler can infer the type parameters based on the method arguments you pass in; it cannot infer the type parameters only from a constraint or return value. Therefore type inference does not work with methods that have no parameters. Type inference occurs at compile time before the compiler tries to resolve overloaded method signatures. The compiler applies type inference logic to all generic methods that share the same name. In the overload resolution step, the compiler includes only those generic methods on which type inference succeeded.  
  
 Within a generic class, non-generic methods can access the class-level type parameters, as follows:  
  
 [!code[csProgGuideGenerics#25](../vs140/codesnippet/CSharp/generic-methods--csharp-programming-guide-_4.cs)]  
  
 If you define a generic method that takes the same type parameters as the containing class, the compiler generates warning CS0693 because within the method scope, the argument supplied for the inner `T` hides the argument supplied for the outer `T`. If you require the flexibility of calling a generic class method with type arguments other than the ones provided when the class was instantiated, consider providing another identifier for the type parameter of the method, as shown in `GenericList2<T>` in the following example.  
  
 [!code[csProgGuideGenerics#26](../vs140/codesnippet/CSharp/generic-methods--csharp-programming-guide-_5.cs)]  
  
 Use constraints to enable more specialized operations on type parameters in methods. This version of `Swap<T>`, now named `SwapIfGreater<T>`, can only be used with type arguments that implement <xref:System.IComparable`1*>.  
  
 [!code[csProgGuideGenerics#27](../vs140/codesnippet/CSharp/generic-methods--csharp-programming-guide-_6.cs)]  
  
 Generic methods can be overloaded on several type parameters. For example, the following methods can all be located in the same class:  
  
 [!code[csProgGuideGenerics#28](../vs140/codesnippet/CSharp/generic-methods--csharp-programming-guide-_7.cs)]  
  
## C# Language Specification  
 For more information, see the [C# Language Specification](../vs140/csharp-language-specification.md).  
  
## See Also  
 <xref:System.Collections.Generic*>   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Generics (C#)](../vs140/introduction-to-generics--csharp-programming-guide-.md)   
 [Methods (C# Programming Guide)](../vs140/methods--csharp-programming-guide-.md)