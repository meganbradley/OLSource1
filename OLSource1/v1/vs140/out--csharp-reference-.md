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
You can use the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> contextual keyword in two contexts (each is a link to detailed information), as a [parameter modifier](../vs140/out-parameter-modifier--csharp-reference-.md) or in [generic type parameter declarations](../vs140/out--generic-modifier---csharp-reference-.md) in interfaces and delegates.  This topic discusses the parameter modifier, but you can see [this other topic](../vs140/out--generic-modifier---csharp-reference-.md) for information on the generic type parameter declarations.  
  
 The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> keyword causes arguments to be passed by reference. This is like the [ref](../vs140/ref--csharp-reference-.md) keyword, except that <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> requires that the variable be initialized before it is passed. To use an <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter, both the method definition and the calling method must explicitly use the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> keyword. For example:  
  
 [!code[csrefKeywordsMethodParams#1](../vs140/codesnippet/CSharp/out--csharp-reference-_1.cs)]  
  
 Although variables passed as <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> arguments do not have to be initialized before being passed, the called method is required to assign a value before the method returns.  
  
 Although the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> keywords cause different run-time behavior, they are not considered part of the method signature at compile time. Therefore, methods cannot be overloaded if the only difference is that one method takes a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> argument and the other takes an <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> argument. The following code, for example, will not compile:  
  
 [!code[csrefKeywordsMethodParams#2](../vs140/codesnippet/CSharp/out--csharp-reference-_2.cs)]  
  
 Overloading can be done, however, if one method takes a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> argument and the other uses neither, like this:  
  
 [!code[csrefKeywordsMethodParams#3](../vs140/codesnippet/CSharp/out--csharp-reference-_3.cs)]  
  
 Properties are not variables and therefore cannot be passed as <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> parameters.  
  
 For information about passing arrays, see [Passing Arrays Using ref and out](../vs140/passing-arrays-using-ref-and-out--csharp-programming-guide-.md).  
  
 You can't use the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> keywords for the following kinds of methods:  
  
-   Async methods, which you define by using the [async](../vs140/async--csharp-reference-.md) modifier.  
  
-   Iterator methods, which include a [yield return](../vs140/yield--csharp-reference-.md) or <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> statement.  
  
## Example  
 Declaring an <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> method is useful when you want a method to return multiple values. The following example uses <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> to return three variables with a single method call. Note that the third argument is assigned to null. This enables methods to return values optionally.  
  
 [!code[csrefKeywordsMethodParams#4](../vs140/codesnippet/CSharp/out--csharp-reference-_4.cs)]  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)