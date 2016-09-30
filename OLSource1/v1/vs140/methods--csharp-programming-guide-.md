---
title: "Methods (C# Programming Guide)"
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
  - "methods [C#]"
  - "C# language, methods"
ms.assetid: cc738f07-e8cd-4683-9585-9f40c0667c37
caps.latest.revision: 45
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Methods (C# Programming Guide)
A method is a code block that contains a series of statements. A program causes the statements to be executed by calling the method and specifying any required method arguments. In C#, every executed instruction is performed in the context of a method. The Main method is the entry point for every C# application and it is called by the common language runtime (CLR) when the program is started.  
  
> [!NOTE]
>  This topic discusses named methods. For information about anonymous functions, see [Anonymous Functions (C# Programming Guide)](../vs140/anonymous-functions--csharp-programming-guide-.md).  
  
## Method Signatures  
 Methods are declared in a [class](../vs140/class--csharp-reference-.md) or [struct](../vs140/struct--csharp-reference-.md) by specifying the access level such as <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, optional modifiers such as <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, the return value, the name of the method, and any method parameters. These parts together are the signature of the method.  
  
> [!NOTE]
>  A return type of a method is not part of the signature of the method for the purposes of method overloading. However, it is part of the signature of the method when determining the compatibility between a delegate and the method that it points to.  
  
 Method parameters are enclosed in parentheses and are separated by commas. Empty parentheses indicate that the method requires no parameters. This class contains three methods:  
  
 [!code[csProgGuideObjects#40](../vs140/codesnippet/CSharp/methods--csharp-programming-guide-_1.cs)]  
  
## Method Access  
 Calling a method on an object is like accessing a field. After the object name, add a period, the name of the method, and parentheses. Arguments are listed within the parentheses, and are separated by commas. The methods of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> class can therefore be called as in the following example:  
  
 [!code[csProgGuideObjects#41](../vs140/codesnippet/CSharp/methods--csharp-programming-guide-_2.cs)]  
  
## Method Parameters vs. Arguments  
 The method definition specifies the names and types of any parameters that are required. When calling code calls the method, it provides concrete values called arguments for each parameter. The arguments must be compatible with the parameter type but the argument name (if any) used in the calling code does not have to be the same as the parameter named defined in the method. For example:  
  
 [!code[csProgGuideObjects#74](../vs140/codesnippet/CSharp/methods--csharp-programming-guide-_3.cs)]  
  
## Passing by Reference vs. Passing by Value  
 By default, when a value type is passed to a method, a copy is passed instead of the object itself. Therefore, changes to the argument have no effect on the original copy in the calling method. You can pass a value-type by reference by using the ref keyword. For more information, see [Passing Value-Type Parameters (C# Programmer's Reference)](../vs140/passing-value-type-parameters--csharp-programming-guide-.md). For a list of built-in value types, see [Value Types Table (C# Programmer's Reference)](../vs140/value-types-table--csharp-reference-.md).  
  
 When an object of a reference type is passed to a method, a reference to the object is passed. That is, the method receives not the object itself but an argument that indicates the location of the object. If you change a member of the object by using this reference, the change is reflected in the argument in the calling method, even if you pass the object by value.  
  
 You create a reference type by using the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> keyword, as the following example shows.  
  
 [!code[csProgGuideObjects#42](../vs140/codesnippet/CSharp/methods--csharp-programming-guide-_4.cs)]  
  
 Now, if you pass an object that is based on this type to a method, a reference to the object is passed. The following example passes an object of type <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to method <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 [!code[csProgGuideObjects#75](../vs140/codesnippet/CSharp/methods--csharp-programming-guide-_5.cs)]  
  
 The example does essentially the same thing as the previous example in that it passes an argument by value to a method. But, because a reference type is used, the result is different. The modification that is made in <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> field of the parameter, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, also changes the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> field of the argument, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, in the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> method. The <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> method displays 33 as the output.  
  
 For more information about how to pass reference types by reference and by value, see [Passing Reference-Type Parameters (C# Programmer's Reference)](../vs140/passing-reference-type-parameters--csharp-programming-guide-.md) and [Reference Types  (C# Programmer's Reference)](../vs140/reference-types--csharp-reference-.md).  
  
## Return Values  
 Methods can return a value to the caller. If the return type, the type listed before the method name, is not <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, the method can return the value by using the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> keyword. A statement with the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> keyword followed by a value that matches the return type will return that value to the method caller. The <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> keyword also stops the execution of the method. If the return type is <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, a <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> statement without a value is still useful to stop the execution of the method. Without the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> keyword, the method will stop executing when it reaches the end of the code block. Methods with a non-void return type are required to use the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> keyword to return a value. For example, these two methods use the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> keyword to return integers:  
  
 [!code[csProgGuideObjects#44](../vs140/codesnippet/CSharp/methods--csharp-programming-guide-_6.cs)]  
  
 To use a value returned from a method, the calling method can use the method call itself anywhere a value of the same type would be sufficient. You can also assign the return value to a variable. For example, the following two code examples accomplish the same goal:  
  
 [!code[csProgGuideObjects#45](../vs140/codesnippet/CSharp/methods--csharp-programming-guide-_7.cs)]  
  
 [!code[csProgGuideObjects#46](../vs140/codesnippet/CSharp/methods--csharp-programming-guide-_8.cs)]  
  
 Using a local variable, in this case, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, to store a value is optional. It may help the readability of the code, or it may be necessary if you need to store the original value of the argument for the entire scope of the method.  
  
 Returning a multi-dimensional array from a method, M, that modifies the array's contents is not necessary if the calling function passed the array into M.  You may return the resulting array from M for good style or functional flow of values, but it is not necessary.  The reason you do not need to return the modified array is that C# passes all reference types by value, and the value of an array reference is the pointer to the array. In the method M, any changes to the array's contents are observable by any code that has a reference to the array, as shown in the following example.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 For more information, see [return](../vs140/return--csharp-reference-.md).  
  
## Async Methods  
 By using the async feature, you can invoke asynchronous methods without using explicit callbacks or manually splitting your code across multiple methods or lambda expressions. The async feature was introduced [!INCLUDE[vs_dev11_long](../vs140/includes/vs_dev11_long_md.md)].  
  
 If you mark a method with the [async](../vs140/async--csharp-reference-.md) modifier, you can use the [await](../vs140/await--csharp-reference-.md) operator in the method. When control reaches an await expression in the async method, control returns to the caller, and progress in the method is suspended until the awaited task completes. When the task is complete, execution can resume in the method.  
  
> [!NOTE]
>  An async method returns to the caller when either it encounters the first awaited object that’s not yet complete or it gets to the end of the async method, whichever occurs first.  
  
 An async method can have a return type of <xref:System.Threading.Tasks.Task<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>DelayAsync<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>1*>. <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> has a <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> statement that returns an integer. Therefore the method declaration of <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> must have a return type of <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>. Because the return type is <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, the evaluation of the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> expression in <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> produces an integer as the following statement demonstrates: <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.  
  
 The <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> method is an example of an async method that has a return type of void. Because <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> is an async method, the task for the call to <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> must be awaited, as the following statement shows: <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> method must be defined with the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> modifier because the method has an <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> expression.  
  
 [!code[csAsyncMethod#2](../vs140/codesnippet/CSharp/methods--csharp-programming-guide-_9.cs)]  
  
 An async method can't declare any [ref](../vs140/ref--csharp-reference-.md) or [out](../vs140/out--csharp-reference-.md) parameters, but it can call methods that have such parameters.  
  
 For more information about async methods, see [Asynchronous Programming with Async and Await (C# and Visual Basic)](../vs140/asynchronous-programming-with-async-and-await--csharp-and-visual-basic-.md), [Control Flow in Async Programs (C# and Visual Basic)](../vs140/control-flow-in-async-programs--csharp-and-visual-basic-.md), and [Async Return Types (C# and Visual Basic)](../vs140/async-return-types--csharp-and-visual-basic-.md).  
  
## Expression Body Definitions  
 It is common to have method definitions that simply return immediately with the result of an expression, or that have a single statement as the body of the method.  There is a syntax shortcut for defining such methods using <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 If the method returns <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> or is an async method, then the body of the method must be a statement expression (same as with lambdas).  For properties and indexers, they must be read only, and you do not use the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> accessor keyword.  
  
## Iterators  
 An iterator performs a custom iteration over a collection, such as a list or an array. An iterator uses the [yield return](../vs140/yield--csharp-reference-.md) statement to return each element one at a time. When a [yield return](../vs140/yield--csharp-reference-.md) statement is reached, the current location in code is remembered. Execution is restarted from that location when the iterator is called the next time.  
  
 You call an iterator from client code by using a [foreach](../vs140/foreach--in--csharp-reference-.md) statement.  
  
 The return type of an iterator can be \<xref:System.Collections.IEnumerable*>, <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>1*>.  
  
 For more information, see [Iterators (C# and Visual Basic)](../vs140/iterators--csharp-and-visual-basic-.md).  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Classes and Structs (Visual C#)](../vs140/classes-and-structs--csharp-programming-guide-.md)   
 [Access Modifiers (Visual C#)](../vs140/access-modifiers--csharp-programming-guide-.md)   
 [Static Classes and Static Class Members](../vs140/static-classes-and-static-class-members--csharp-programming-guide-.md)   
 [Inheritance (Visual C#)](../vs140/inheritance--csharp-programming-guide-.md)   
 [Abstract and Sealed Classes and Class Members (C# Programming Guide)](../vs140/abstract-and-sealed-classes-and-class-members--csharp-programming-guide-.md)   
 [params](../vs140/params--csharp-reference-.md)   
 [return](../vs140/return--csharp-reference-.md)   
 [out (C# Programmer's Reference)](../vs140/out--csharp-reference-.md)   
 [ref (C# Programmer's Reference)](../vs140/ref--csharp-reference-.md)   
 [Passing Parameters (C# Programming Guide)](../vs140/passing-parameters--csharp-programming-guide-.md)