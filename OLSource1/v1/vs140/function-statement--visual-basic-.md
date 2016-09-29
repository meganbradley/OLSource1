---
title: "Function Statement (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vb.Function"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "procedures, creating"
  - "Function procedures, Function statement syntax"
  - "functions [Visual Basic], function procedures"
  - "ParamArray keyword, Function statements"
  - "Private keyword, Function statements"
  - "declarations, procedures"
  - "procedures, declaration"
  - "Public keyword, in Function statement"
  - "ByVal keyword, Function statements"
  - "procedures, recursive"
  - "Implements keyword, Function statements"
  - "procedures, returning values"
  - "Exit statement, in Function procedures"
  - "recursive procedures"
  - "As keyword, in Function statement"
  - "Optional keyword, Function statements"
  - "Function statement"
  - "Visual Basic code, Function procedures"
  - "procedures, function"
  - "ByRef keyword, Function statements"
  - "Friend keyword, Function statements"
  - "End keyword, Function statements"
  - "Handles keyword, Function statements"
ms.assetid: a4497077-0f46-4ede-a27f-9e8670df52b9
caps.latest.revision: 66
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Function Statement (Visual Basic)
Declares the name, parameters, and code that define a `Function` procedure.  
  
## Syntax  
  
```  
[ <attributelist> ] [ accessmodifier ] [ proceduremodifiers ] [ Shared ] [ Shadows ] [ Async | Iterator ]  
Function name [ (Of typeparamlist) ] [ (parameterlist) ] [ As returntype ] [ Implements implementslist | Handles eventlist ]  
    [ statements ]  
    [ Exit Function ]  
    [ statements ]  
End Function  
```  
  
## Parts  
  
-   `attributelist`  
  
     Optional. See [Attribute List](../vs140/attribute-list--visual-basic-.md).  
  
-   `accessmodifier`  
  
     Optional. Can be one of the following:  
  
    -   [Public](../vs140/public--visual-basic-.md)  
  
    -   [Protected](../vs140/protected--visual-basic-.md)  
  
    -   [Friend](../vs140/friend--visual-basic-.md)  
  
    -   [Private](../vs140/private--visual-basic-.md)  
  
    -   `Protected Friend`  
  
     See [Access Levels in Visual Basic](../vs140/access-levels-in-visual-basic.md).  
  
-   `proceduremodifiers`  
  
     Optional. Can be one of the following:  
  
    -   [Overloads](../vs140/overloads--visual-basic-.md)  
  
    -   [Overrides](../vs140/overrides--visual-basic-.md)  
  
    -   [Overridable](../vs140/overridable--visual-basic-.md)  
  
    -   [NotOverridable](../vs140/notoverridable--visual-basic-.md)  
  
    -   [MustOverride](../vs140/mustoverride--visual-basic-.md)  
  
    -   `MustOverride Overrides`  
  
    -   `NotOverridable Overrides`  
  
-   `Shared`  
  
     Optional. See [Shared](../vs140/shared--visual-basic-.md).  
  
-   `Shadows`  
  
     Optional. See [Shadows](../vs140/shadows--visual-basic-.md).  
  
-   `Async`  
  
     Optional. See [Async](../vs140/async--visual-basic-.md).  
  
-   `Iterator`  
  
     Optional. See [Iterator](../vs140/iterator--visual-basic-.md).  
  
-   `name`  
  
     Required. Name of the procedure. See [Declared Element Names](../vs140/declared-element-names--visual-basic-.md).  
  
-   `typeparamlist`  
  
     Optional. List of type parameters for a generic procedure. See [Type List](../vs140/type-list--visual-basic-.md).  
  
-   `parameterlist`  
  
     Optional. List of local variable names representing the parameters of this procedure. See [Parameter List](../vs140/parameter-list--visual-basic-.md).  
  
-   `returntype`  
  
     Required if `Option Strict` is `On`. Data type of the value returned by this procedure.  
  
-   `Implements`  
  
     Optional. Indicates that this procedure implements one or more `Function` procedures, each one defined in an interface implemented by this procedure's containing class or structure. See [Implements Statement](../vs140/implements-statement.md).  
  
-   `implementslist`  
  
     Required if `Implements` is supplied. List of `Function` procedures being implemented.  
  
     `implementedprocedure [ , implementedprocedure ... ]`  
  
     Each `implementedprocedure` has the following syntax and parts:  
  
     `interface.definedname`  
  
    |||  
    |-|-|  
    |Part|Description|  
    |`interface`|Required. Name of an interface implemented by this procedure's containing class or structure.|  
    |`definedname`|Required. Name by which the procedure is defined in `interface`.|  
  
-   `Handles`  
  
     Optional. Indicates that this procedure can handle one or more specific events. See [Handles](../vs140/handles-clause--visual-basic-.md).  
  
-   `eventlist`  
  
     Required if `Handles` is supplied. List of events this procedure handles.  
  
     `eventspecifier [ , eventspecifier ... ]`  
  
     Each `eventspecifier` has the following syntax and parts:  
  
     `eventvariable.event`  
  
    |||  
    |-|-|  
    |Part|Description|  
    |`eventvariable`|Required. Object variable declared with the data type of the class or structure that raises the event.|  
    |`event`|Required. Name of the event this procedure handles.|  
  
-   `statements`  
  
     Optional. Block of statements to be executed within this procedure.  
  
-   `End Function`  
  
     Terminates the definition of this procedure.  
  
## Remarks  
 All executable code must be inside a procedure. Each procedure, in turn, is declared within a class, a structure, or a module that is referred to as the containing class, structure, or module.  
  
 To return a value to the calling code, use a `Function` procedure; otherwise, use a `Sub` procedure.  
  
## Defining a Function  
 You can define a `Function` procedure only at the module level. Therefore, the declaration context for a function must be a class, a structure, a module, or an interface and can't be a source file, a namespace, a procedure, or a block. For more information, see [Declaration Contexts and Default Access Levels](../vs140/declaration-contexts-and-default-access-levels--visual-basic-.md).  
  
 `Function` procedures default to public access. You can adjust their access levels with the access modifiers.  
  
 A `Function` procedure can declare the data type of the value that the procedure returns. You can specify any data type or the name of an enumeration, a structure, a class, or an interface. If you don't specify the `returntype` parameter, the procedure returns `Object`.  
  
 If this procedure uses the `Implements` keyword, the containing class or structure must also have an `Implements` statement that immediately follows its `Class` or `Structure` statement. The `Implements` statement must include each interface that's specified in `implementslist`. However, the name by which an interface defines the `Function` (in `definedname`) doesn't need to match the name of this procedure (in `name`).  
  
> [!NOTE]
>  You can use lambda expressions to define function expressions inline. For more information, see [Function Expression](../vs140/function-expression--visual-basic-.md) and [Lambda Expressions](../vs140/lambda-expressions--visual-basic-.md).  
  
## Returning from a Function  
 When the `Function` procedure returns to the calling code, execution continues with the statement that follows the statement that called the procedure.  
  
 To return a value from a function, you can either assign the value to the function name or include it in a `Return` statement.  
  
 The `Return` statement simultaneously assigns the return value and exits the function, as the following example shows.  
  
 [!code[VbVbalrStatements#24](../vs140/codesnippet/VisualBasic/function-statement--visual-basic-_1.vb)]  
  
 The following example assigns the return value to the function name `myFunction` and then uses the `Exit Function` statement to return.  
  
 [!code[VbVbalrStatements#23](../vs140/codesnippet/VisualBasic/function-statement--visual-basic-_2.vb)]  
  
 The `Exit Function` and `Return` statements cause an immediate exit from a `Function` procedure. Any number of `Exit Function` and `Return` statements can appear anywhere in the procedure, and you can mix `Exit Function` and `Return` statements.  
  
 If you use `Exit Function` without assigning a value to `name`, the procedure returns the default value for the data type that's specified in `returntype`. If `returntype` isn't specified, the procedure returns `Nothing`, which is the default value for `Object`.  
  
## Calling a Function  
 You call a `Function` procedure by using the procedure name, followed by the argument list in parentheses, in an expression. You can omit the parentheses only if you aren't supplying any arguments. However, your code is more readable if you always include the parentheses.  
  
 You call a `Function` procedure the same way that you call any library function such as `Sqrt`, `Cos`, or `ChrW`.  
  
 You can also call a function by using the `Call` keyword. In that case, the return value is ignored. Use of the `Call` keyword isn't recommended in most cases. For more information, see [Call Statement (Visual Basic)](../vs140/call-statement--visual-basic-.md).  
  
 Visual Basic sometimes rearranges arithmetic expressions to increase internal efficiency. For that reason, you shouldn't use a `Function` procedure in an arithmetic expression when the function changes the value of variables in the same expression.  
  
## Async Functions  
 The *Async* feature allows you to invoke asynchronous functions without using explicit callbacks or manually splitting your code across multiple functions or lambda expressions.  
  
 If you mark a function with the [Async](../vs140/async--visual-basic-.md) modifier, you can use the [Await](../vs140/await-operator--visual-basic-.md) operator in the function. When control reaches an `Await` expression in the `Async` function, control returns to the caller, and progress in the function is suspended until the awaited task completes. When the task is complete, execution can resume in the function.  
  
> [!NOTE]
>  An `Async` procedure returns to the caller when either it encounters the first awaited object that’s not yet complete, or it gets to the end of the `Async` procedure, whichever occurs first.  
  
 An `Async` function can have a return type of <xref:System.Threading.Tasks.Task`1*> or <xref:System.Threading.Tasks.Task*>. An example of an `Async` function that has a return type of <xref:System.Threading.Tasks.Task`1*> is provided below.  
  
 An `Async` function cannot declare any [ByRef](../vs140/byref--visual-basic-.md) parameters.  
  
 A [Sub Statement (Visual Basic)](../vs140/sub-statement--visual-basic-.md) can also be marked with the `Async` modifier. This is primarily used for event handlers, where a value cannot be returned. An `Async``Sub` procedure can't be awaited, and the caller of an `Async``Sub` procedure can't catch exceptions that are thrown by the `Sub` procedure.  
  
 For more information about `Async` functions, see [Asynchronous Programming with Async and Await (C# and Visual Basic)](../vs140/asynchronous-programming-with-async-and-await--csharp-and-visual-basic-.md), [Control Flow in Async Programs (C# and Visual Basic)](../vs140/control-flow-in-async-programs--csharp-and-visual-basic-.md), and [Async Return Types (C# and Visual Basic)](../vs140/async-return-types--csharp-and-visual-basic-.md).  
  
## Iterator Functions  
 An *iterator* function performs a custom iteration over a collection, such as a list or array. An iterator function uses the [Yield](../vs140/yield-statement--visual-basic-.md) statement to return each element one at a time. When a [Yield](../vs140/yield-statement--visual-basic-.md) statement is reached, the current location in code is remembered. Execution is restarted from that location the next time the iterator function is called.  
  
 You call an iterator from client code by using a [For Each…Next](../vs140/for-each...next-statement--visual-basic-.md) statement.  
  
 The return type of an iterator function can be <xref:System.Collections.IEnumerable*>, <xref:System.Collections.Generic.IEnumerable`1*>, <xref:System.Collections.IEnumerator*>, or <xref:System.Collections.Generic.IEnumerator`1*>.  
  
 For more information, see [Iterators (C# and Visual Basic)](../vs140/iterators--csharp-and-visual-basic-.md).  
  
## Example  
 The following example uses the `Function` statement to declare the name, parameters, and code that form the body of a `Function` procedure. The `ParamArray` modifier enables the function to accept a variable number of arguments.  
  
 [!code[VbVbalrStatements#25](../vs140/codesnippet/VisualBasic/function-statement--visual-basic-_3.vb)]  
  
## Example  
 The following example invokes the function declared in the preceding example.  
  
 [!code[VbVbalrStatements#26](../vs140/codesnippet/VisualBasic/function-statement--visual-basic-_4.vb)]  
  
## Example  
 In the following example, `DelayAsync` is an `Async``Function` that has a return type of <xref:System.Threading.Tasks.Task`1*>. `DelayAsync` has a `Return` statement that returns an integer. Therefore the function declaration of `DelayAsync` needs to have a return type of `Task(Of Integer)`. Because the return type is `Task(Of Integer)`, the evaluation of the `Await` expression in `DoSomethingAsync` produces an integer. This is demonstrated in this statement: `Dim result As Integer = Await delayTask`.  
  
 The `startButton_Click` procedure is an example of an `Async Sub` procedure. Because `DoSomethingAsync` is an `Async` function, the task for the call to `DoSomethingAsync` must be awaited, as the following statement demonstrates: `Await DoSomethingAsync()`. The `startButton_Click``Sub` procedure must be defined with the `Async` modifier because it has an `Await` expression.  
  
 [!code[csAsyncMethod#1](../vs140/codesnippet/VisualBasic/function-statement--visual-basic-_5.vb)]  
  
## See Also  
 [Sub Statement](../vs140/sub-statement--visual-basic-.md)   
 [Function Procedures (Visual Basic)](../vs140/function-procedures--visual-basic-.md)   
 [Parameter List](../vs140/parameter-list--visual-basic-.md)   
 [Dim Statement](../vs140/dim-statement--visual-basic-.md)   
 [Call Statement](../vs140/call-statement--visual-basic-.md)   
 [Of](../vs140/of-clause--visual-basic-.md)   
 [Parameter Arrays](../vs140/parameter-arrays--visual-basic-.md)   
 [How to: Use a Generic Class](../vs140/how-to--use-a-generic-class--visual-basic-.md)   
 [Troubleshooting Procedures](../vs140/troubleshooting-procedures--visual-basic-.md)   
 [Lambda Expressions](../vs140/lambda-expressions--visual-basic-.md)   
 [Function Expression](../vs140/function-expression--visual-basic-.md)