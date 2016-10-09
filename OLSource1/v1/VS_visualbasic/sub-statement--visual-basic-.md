---
title: "Sub Statement (Visual Basic)"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vb.Sub"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Public keyword, Sub statements"
  - "procedures, creating"
  - "declaring procedures, Sub statement"
  - "arguments [Visual Basic], Sub procedures"
  - "As keyword, Sub statements"
  - "Optional keyword, Sub statements"
  - "declarations, procedures"
  - "Sub keyword"
  - "Handles keyword, Sub statements"
  - "Protected Friend keyword"
  - "ParamArray keyword, Sub statements"
  - "Implements keyword, Sub statements"
  - "Sub statement"
  - "subroutines"
  - "ByRef keyword, Sub statements"
  - "Sub procedures, Sub statement"
  - "recursive procedures"
  - "Private keyword, Sub statements"
  - "Friend keyword, Sub statements"
  - "Exit statement, Sub statements"
  - "procedures, Sub"
  - "End keyword, Sub statements"
  - "ByVal keyword, Sub statements"
  - "Visual Basic code, Sub procedures"
ms.assetid: e347d700-d06c-405b-b302-e9b1edb57dfc
caps.latest.revision: 52
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Sub Statement (Visual Basic)
Declares the name, parameters, and code that define a `Sub` procedure.  
  
## Syntax  
  
```  
[ <attributelist> ] [ Partial ] [ accessmodifier ] [ proceduremodifiers ] [ Shared ] [ Shadows ] [ Async ]  
Sub name [ (Of typeparamlist) ] [ (parameterlist) ] [ Implements implementslist | Handles eventlist ]  
    [ statements ]  
    [ Exit Sub ]  
    [ statements ]  
End Sub  
```  
  
## Parts  
  
-   `attributelist`  
  
     Optional. See [Attribute List](../VS_visualbasic/attribute-list--visual-basic-.md).  
  
-   `Partial`  
  
     Optional. Indicates definition of a partial method. See [Partial Methods](../VS_visualbasic/partial-methods--visual-basic-.md).  
  
-   `accessmodifier`  
  
     Optional. Can be one of the following:  
  
    -   [Public](../VS_visualbasic/public--visual-basic-.md)  
  
    -   [Protected](../VS_visualbasic/protected--visual-basic-.md)  
  
    -   [Friend](../VS_visualbasic/friend--visual-basic-.md)  
  
    -   [Private](../VS_visualbasic/private--visual-basic-.md)  
  
    -   `Protected Friend`  
  
     See [Access Levels in Visual Basic](../VS_visualbasic/access-levels-in-visual-basic.md).  
  
-   `proceduremodifiers`  
  
     Optional. Can be one of the following:  
  
    -   [Overloads](../VS_visualbasic/overloads--visual-basic-.md)  
  
    -   [Overrides](../VS_visualbasic/overrides--visual-basic-.md)  
  
    -   [Overridable](../VS_visualbasic/overridable--visual-basic-.md)  
  
    -   [NotOverridable](../VS_visualbasic/notoverridable--visual-basic-.md)  
  
    -   [MustOverride](../VS_visualbasic/mustoverride--visual-basic-.md)  
  
    -   `MustOverride Overrides`  
  
    -   `NotOverridable Overrides`  
  
-   `Shared`  
  
     Optional. See [Shared](../VS_visualbasic/shared--visual-basic-.md).  
  
-   `Shadows`  
  
     Optional. See [Shadows](../VS_visualbasic/shadows--visual-basic-.md).  
  
-   `Async`  
  
     Optional. See [Async](../VS_visualbasic/async--visual-basic-.md).  
  
-   `name`  
  
     Required. Name of the procedure. See [Declared Element Names](../VS_visualbasic/declared-element-names--visual-basic-.md). To create a constructor procedure for a class, set the name of a `Sub` procedure to the `New` keyword. For more information, see [Object Lifetime: How Objects Are Created and Destroyed](../VS_visualbasic/object-lifetime--how-objects-are-created-and-destroyed--visual-basic-.md).  
  
-   `typeparamlist`  
  
     Optional. List of type parameters for a generic procedure. See [Type List](../VS_visualbasic/type-list--visual-basic-.md).  
  
-   `parameterlist`  
  
     Optional. List of local variable names representing the parameters of this procedure. See [Parameter List](../VS_visualbasic/parameter-list--visual-basic-.md).  
  
-   `Implements`  
  
     Optional. Indicates that this procedure implements one or more `Sub` procedures, each one defined in an interface implemented by this procedure's containing class or structure. See [Implements Statement](../VS_visualbasic/implements-statement.md).  
  
-   `implementslist`  
  
     Required if `Implements` is supplied. List of `Sub` procedures being implemented.  
  
     `implementedprocedure [ , implementedprocedure ... ]`  
  
     Each `implementedprocedure` has the following syntax and parts:  
  
     `interface.definedname`  
  
    |||  
    |-|-|  
    |Part|Description|  
    |`interface`|Required. Name of an interface implemented by this procedure's containing class or structure.|  
    |`definedname`|Required. Name by which the procedure is defined in `interface`.|  
  
-   `Handles`  
  
     Optional. Indicates that this procedure can handle one or more specific events. See [Handles](../VS_visualbasic/handles-clause--visual-basic-.md).  
  
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
  
     Optional. Block of statements to run within this procedure.  
  
-   `End Sub`  
  
     Terminates the definition of this procedure.  
  
## Remarks  
 All executable code must be inside a procedure. Use a `Sub` procedure when you don't want to return a value to the calling code. Use a `Function` procedure when you want to return a value.  
  
## Defining a Sub Procedure  
 You can define a `Sub` procedure only at the module level. The declaration context for a sub procedure must, therefore, be a class, a structure, a module, or an interface and can't be a source file, a namespace, a procedure, or a block. For more information, see [Declaration Contexts and Default Access Levels](../VS_visualbasic/declaration-contexts-and-default-access-levels--visual-basic-.md).  
  
 `Sub` procedures default to public access. You can adjust their access levels by using the access modifiers.  
  
 If the procedure uses the `Implements` keyword, the containing class or structure must have an `Implements` statement that immediately follows its `Class` or `Structure` statement. The `Implements` statement must include each interface that's specified in `implementslist`. However, the name by which an interface defines the `Sub` (in `definedname`) doesn't have to match the name of this procedure (in `name`).  
  
## Returning from a Sub Procedure  
 When a `Sub` procedure returns to the calling code, execution continues with the statement after the statement that called it.  
  
 The following example shows a return from a `Sub` procedure.  
  
```vb#  
Sub mySub(ByVal q As String)  
    Return  
End Sub   
```  
  
 The `Exit Sub` and `Return` statements cause an immediate exit from a `Sub` procedure. Any number of `Exit Sub` and `Return` statements can appear anywhere in the procedure, and you can mix `Exit Sub` and `Return` statements.  
  
## Calling a Sub Procedure  
 You call a `Sub` procedure by using the procedure name in a statement and then following that name with its argument list in parentheses. You can omit the parentheses only if you don't supply any arguments. However, your code is more readable if you always include the parentheses.  
  
 A `Sub` procedure and a `Function` procedure  can have parameters and perform a series of statements. However, a `Function` procedure returns a value, and a `Sub` procedure doesn't. Therefore, you can't use a `Sub` procedure in an expression.  
  
 You can use the `Call` keyword when you call a `Sub` procedure, but that keyword isn't recommended for most uses. For more information, see [Call Statement](../VS_visualbasic/call-statement--visual-basic-.md).  
  
 Visual Basic sometimes rearranges arithmetic expressions to increase internal efficiency. For that reason, if your argument list includes expressions that call other procedures, you shouldn't assume that those expressions will be called in a particular order.  
  
## Async Sub Procedures  
 By using the Async feature, you can invoke asynchronous functions without using explicit callbacks or manually splitting your code across multiple functions or lambda expressions.  
  
 If you mark a procedure with the [Async](../VS_visualbasic/async--visual-basic-.md) modifier, you can use the [Await](../VS_visualbasic/await-operator--visual-basic-.md) operator in the procedure. When control reaches an `Await` expression in the `Async` procedure, control returns to the caller, and progress in the procedure is suspended until the awaited task completes. When the task is complete, execution can resume in the procedure.  
  
> [!NOTE]
>  An `Async` procedure returns to the caller when either the first awaited object that’s not yet complete is encountered or the end of the `Async` procedure is reached, whichever occurs first.  
  
 You can also mark a [Function Statement](../VS_visualbasic/function-statement--visual-basic-.md) with the `Async` modifier. An `Async` function can have a return type of <xref:System.Threading.Tasks.Task`1> or <xref:System.Threading.Tasks.Task>. An example later in this topic shows an `Async` function that has a return type of <xref:System.Threading.Tasks.Task`1>.  
  
 `Async` `Sub` procedures are primarily used for event handlers, where a value can't be returned. An `Async``Sub` procedure can't be awaited, and the caller of an `Async``Sub` procedure can't catch exceptions that the `Sub` procedure throws.  
  
 An `Async` procedure can't declare any [ByRef](../VS_visualbasic/byref--visual-basic-.md) parameters.  
  
 For more information about `Async` procedures, see [Asynchronous Programming with Async and Await](../Topic/Asynchronous%20Programming%20with%20Async%20and%20Await%20\(C%23%20and%20Visual%20Basic\).md), [Control Flow in Async Programs](../Topic/Control%20Flow%20in%20Async%20Programs%20\(C%23%20and%20Visual%20Basic\).md), and [Async Return Types](../Topic/Async%20Return%20Types%20\(C%23%20and%20Visual%20Basic\).md).  
  
## Example  
 The following example uses the `Sub` statement to define the name, parameters, and code that form the body of a `Sub` procedure.  
  
 [!code[VbVbalrStatements#58](../VS_visualbasic/codesnippet/VisualBasic/sub-statement--visual-basic-_1.vb)]  
  
## Example  
 In the following example, `DelayAsync` is an an `Async``Function` that has a return type of <xref:System.Threading.Tasks.Task`1>. `DelayAsync` has a `Return` statement that returns an integer. Therefore, the function declaration of `DelayAsync` must have a return type of `Task(Of Integer)`. Because the return type is `Task(Of Integer)`, the evaluation of the `Await` expression in `DoSomethingAsync` produces an integer, as the following statement shows: `Dim result As Integer = Await delayTask`.  
  
 The `startButton_Click` procedure is an example of an `Async Sub` procedure. Because `DoSomethingAsync` is an `Async` function, the task for the call to `DoSomethingAsync` must be awaited, as the following statement shows: `Await DoSomethingAsync()`. The `startButton_Click``Sub` procedure must be defined with the `Async` modifier because it has an `Await` expression.  
  
 [!code[csAsyncMethod#1](../VS_visualbasic/codesnippet/VisualBasic/sub-statement--visual-basic-_2.vb)]  
  
## See Also  
 [Implements Statement](../VS_visualbasic/implements-statement.md)   
 [Function Statement](../VS_visualbasic/function-statement--visual-basic-.md)   
 [Parameter List](../VS_visualbasic/parameter-list--visual-basic-.md)   
 [Dim Statement](../VS_visualbasic/dim-statement--visual-basic-.md)   
 [Call Statement](../VS_visualbasic/call-statement--visual-basic-.md)   
 [Of](../VS_visualbasic/of-clause--visual-basic-.md)   
 [Parameter Arrays](../VS_visualbasic/parameter-arrays--visual-basic-.md)   
 [How to: Use a Generic Class](../VS_visualbasic/how-to--use-a-generic-class--visual-basic-.md)   
 [Troubleshooting Procedures](../VS_visualbasic/troubleshooting-procedures--visual-basic-.md)   
 [Partial Methods](../VS_visualbasic/partial-methods--visual-basic-.md)