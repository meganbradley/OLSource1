---
title: "out (C# Reference)"
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
  - "out_CSharpKeyword"
  - "out"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "out [C#]"
  - "out keyword [C#]"
ms.assetid: 7e911a0c-3f98-4536-87be-d539b7536ca8
caps.latest.revision: 34
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# out (C# Reference)
You can use the `out` contextual keyword in two contexts (each is a link to detailed information), as a [parameter modifier](../VS_csharp/out-parameter-modifier--csharp-reference-.md) or in [generic type parameter declarations](../VS_csharp/out--generic-modifier---csharp-reference-.md) in interfaces and delegates.  This topic discusses the parameter modifier, but you can see [this other topic](../VS_csharp/out--generic-modifier---csharp-reference-.md) for information on the generic type parameter declarations.  
  
 The `out` keyword causes arguments to be passed by reference. This is like the [ref](../VS_csharp/ref--csharp-reference-.md) keyword, except that `ref` requires that the variable be initialized before it is passed. To use an `out` parameter, both the method definition and the calling method must explicitly use the `out` keyword. For example:  
  
 [!code[csrefKeywordsMethodParams#1](../VS_csharp/codesnippet/CSharp/out--csharp-reference-_1.cs)]  
  
 Although variables passed as `out` arguments do not have to be initialized before being passed, the called method is required to assign a value before the method returns.  
  
 Although the `ref` and `out` keywords cause different run-time behavior, they are not considered part of the method signature at compile time. Therefore, methods cannot be overloaded if the only difference is that one method takes a `ref` argument and the other takes an `out` argument. The following code, for example, will not compile:  
  
 [!code[csrefKeywordsMethodParams#2](../VS_csharp/codesnippet/CSharp/out--csharp-reference-_2.cs)]  
  
 Overloading can be done, however, if one method takes a `ref` or `out` argument and the other uses neither, like this:  
  
 [!code[csrefKeywordsMethodParams#3](../VS_csharp/codesnippet/CSharp/out--csharp-reference-_3.cs)]  
  
 Properties are not variables and therefore cannot be passed as `out` parameters.  
  
 For information about passing arrays, see [Passing Arrays Using ref and out](../VS_csharp/passing-arrays-using-ref-and-out--csharp-programming-guide-.md).  
  
 You can't use the `ref` and `out` keywords for the following kinds of methods:  
  
-   Async methods, which you define by using the [async](../VS_csharp/async--csharp-reference-.md) modifier.  
  
-   Iterator methods, which include a [yield return](../VS_csharp/yield--csharp-reference-.md) or `yield break` statement.  
  
## Example  
 Declaring an `out` method is useful when you want a method to return multiple values. The following example uses `out` to return three variables with a single method call. Note that the third argument is assigned to null. This enables methods to return values optionally.  
  
 [!code[csrefKeywordsMethodParams#4](../VS_csharp/codesnippet/CSharp/out--csharp-reference-_4.cs)]  
  
## See Also  
 [C# Reference](../VS_csharp/csharp-reference.md)