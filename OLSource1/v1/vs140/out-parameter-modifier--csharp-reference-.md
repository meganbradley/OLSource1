---
title: "out parameter modifier (C# Reference)"
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
  - "parameters [C#], out"
  - "out parameters [C#]"
ms.assetid: 3fce0dc5-03f4-4faa-bd61-36c41bc6baf1
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# out parameter modifier (C# Reference)
The `out` keyword causes arguments to be passed by reference. This is like the [ref](../vs140/ref--csharp-reference-.md) keyword, except that `ref` requires that the variable be initialized before it is passed. To use an `out` parameter, both the method definition and the calling method must explicitly use the `out` keyword. For example:  
  
 [!code[csrefKeywordsMethodParams#1](../vs140/codesnippet/CSharp/out-parameter-modifier--csharp-reference-_1.cs)]  
  
 Although variables passed as `out` arguments do not have to be initialized before being passed, the called method is required to assign a value before the method returns.  
  
 Although the `ref` and `out` keywords cause different run-time behavior, they are not considered part of the method signature at compile time. Therefore, methods cannot be overloaded if the only difference is that one method takes a `ref` argument and the other takes an `out` argument. The following code, for example, will not compile:  
  
 [!code[csrefKeywordsMethodParams#2](../vs140/codesnippet/CSharp/out-parameter-modifier--csharp-reference-_2.cs)]  
  
 Overloading can be done, however, if one method takes a `ref` or `out` argument and the other uses neither, like this:  
  
 [!code[csrefKeywordsMethodParams#3](../vs140/codesnippet/CSharp/out-parameter-modifier--csharp-reference-_3.cs)]  
  
 Properties are not variables and therefore cannot be passed as `out` parameters.  
  
 For information about passing arrays, see [Passing Arrays Using ref and out](../vs140/passing-arrays-using-ref-and-out--csharp-programming-guide-.md).  
  
 You can't use the `ref` and `out` keywords for the following kinds of methods:  
  
-   Async methods, which you define by using the [async](../vs140/async--csharp-reference-.md) modifier.  
  
-   Iterator methods, which include a [yield return](../vs140/yield--csharp-reference-.md) or `yield break` statement.  
  
## Example  
 Declaring an `out` method is useful when you want a method to return multiple values. The following example uses `out` to return three variables with a single method call. Note that the third argument is assigned to null. This enables methods to return values optionally.  
  
 [!code[csrefKeywordsMethodParams#4](../vs140/codesnippet/CSharp/out-parameter-modifier--csharp-reference-_4.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [Method Parameters](../vs140/method-parameters--csharp-reference-.md)