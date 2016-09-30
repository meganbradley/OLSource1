---
title: "Sub Statement (Visual Basic)"
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
caps.latest.revision: 56
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Sub Statement (Visual Basic)
Declares the name, parameters, and code that define a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> procedure.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
  
-   <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
     Optional. See [Attribute List](../vs140/attribute-list--visual-basic-.md).  
  
-   <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
     Optional. Indicates definition of a partial method. See [Partial Methods](../vs140/partial-methods--visual-basic-.md).  
  
-   <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
     Optional. Can be one of the following:  
  
    -   [Public](../vs140/public--visual-basic-.md)  
  
    -   [Protected](../vs140/protected--visual-basic-.md)  
  
    -   [Friend](../vs140/friend--visual-basic-.md)  
  
    -   [Private](../vs140/private--visual-basic-.md)  
  
    -   <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
     See [Access Levels in Visual Basic](../vs140/access-levels-in-visual-basic.md).  
  
-   <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
     Optional. Can be one of the following:  
  
    -   [Overloads](../vs140/overloads--visual-basic-.md)  
  
    -   [Overrides](../vs140/overrides--visual-basic-.md)  
  
    -   [Overridable](../vs140/overridable--visual-basic-.md)  
  
    -   [NotOverridable](../vs140/notoverridable--visual-basic-.md)  
  
    -   [MustOverride](../vs140/mustoverride--visual-basic-.md)  
  
    -   <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
    -   <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
     Optional. See [Shared](../vs140/shared--visual-basic-.md).  
  
-   <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
     Optional. See [Shadows](../vs140/shadows--visual-basic-.md).  
  
-   <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
     Optional. See [Async](../vs140/async--visual-basic-.md).  
  
-   <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
     Required. Name of the procedure. See [Declared Element Names](../vs140/declared-element-names--visual-basic-.md). To create a constructor procedure for a class, set the name of a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> procedure to the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> keyword. For more information, see [Object Lifetime: How Objects Are Created and Destroyed](../vs140/object-lifetime--how-objects-are-created-and-destroyed--visual-basic-.md).  
  
-   <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  
     Optional. List of type parameters for a generic procedure. See [Type List](../vs140/type-list--visual-basic-.md).  
  
-   <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
     Optional. List of local variable names representing the parameters of this procedure. See [Parameter List](../vs140/parameter-list--visual-basic-.md).  
  
-   <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
     Optional. Indicates that this procedure implements one or more <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> procedures, each one defined in an interface implemented by this procedure's containing class or structure. See [Implements Statement](../vs140/implements-statement.md).  
  
-   <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  
     Required if <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is supplied. List of <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> procedures being implemented.  
  
     <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  
     Each <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> has the following syntax and parts:  
  
     <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
  
    |||  
    |-|-|  
    |Part|Description|  
    |<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|Required. Name of an interface implemented by this procedure's containing class or structure.|  
    |<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|Required. Name by which the procedure is defined in <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.|  
  
-   <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
  
     Optional. Indicates that this procedure can handle one or more specific events. See [Handles](../vs140/handles-clause--visual-basic-.md).  
  
-   <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
  
     Required if <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> is supplied. List of events this procedure handles.  
  
     <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
  
     Each <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> has the following syntax and parts:  
  
     <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
  
    |||  
    |-|-|  
    |Part|Description|  
    |<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|Required. Object variable declared with the data type of the class or structure that raises the event.|  
    |<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|Required. Name of the event this procedure handles.|  
  
-   <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
  
     Optional. Block of statements to run within this procedure.  
  
-   <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
  
     Terminates the definition of this procedure.  
  
## Remarks  
 All executable code must be inside a procedure. Use a <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> procedure when you don't want to return a value to the calling code. Use a <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> procedure when you want to return a value.  
  
## Defining a Sub Procedure  
 You can define a <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> procedure only at the module level. The declaration context for a sub procedure must, therefore, be a class, a structure, a module, or an interface and can't be a source file, a namespace, a procedure, or a block. For more information, see [Declaration Contexts and Default Access Levels](../vs140/declaration-contexts-and-default-access-levels--visual-basic-.md).  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> procedures default to public access. You can adjust their access levels by using the access modifiers.  
  
 If the procedure uses the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> keyword, the containing class or structure must have an <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> statement that immediately follows its <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> statement. The <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> statement must include each interface that's specified in <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>. However, the name by which an interface defines the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> (in <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>) doesn't have to match the name of this procedure (in <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>).  
  
## Returning from a Sub Procedure  
 When a <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> procedure returns to the calling code, execution continues with the statement after the statement that called it.  
  
 The following example shows a return from a <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> procedure.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> statements cause an immediate exit from a <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> procedure. Any number of <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> statements can appear anywhere in the procedure, and you can mix <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> statements.  
  
## Calling a Sub Procedure  
 You call a <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> procedure by using the procedure name in a statement and then following that name with its argument list in parentheses. You can omit the parentheses only if you don't supply any arguments. However, your code is more readable if you always include the parentheses.  
  
 A <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> procedure and a <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> procedure  can have parameters and perform a series of statements. However, a <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> procedure returns a value, and a <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> procedure doesn't. Therefore, you can't use a <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> procedure in an expression.  
  
 You can use the <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> keyword when you call a <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> procedure, but that keyword isn't recommended for most uses. For more information, see [Call Statement (Visual Basic)](../vs140/call-statement--visual-basic-.md).  
  
 Visual Basic sometimes rearranges arithmetic expressions to increase internal efficiency. For that reason, if your argument list includes expressions that call other procedures, you shouldn't assume that those expressions will be called in a particular order.  
  
## Async Sub Procedures  
 By using the Async feature, you can invoke asynchronous functions without using explicit callbacks or manually splitting your code across multiple functions or lambda expressions.  
  
 If you mark a procedure with the [Async](../vs140/async--visual-basic-.md) modifier, you can use the [Await](../vs140/await-operator--visual-basic-.md) operator in the procedure. When control reaches an <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> expression in the <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> procedure, control returns to the caller, and progress in the procedure is suspended until the awaited task completes. When the task is complete, execution can resume in the procedure.  
  
> [!NOTE]
>  An <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> procedure returns to the caller when either the first awaited object that’s not yet complete is encountered or the end of the <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> procedure is reached, whichever occurs first.  
  
 You can also mark a [Function Statement (Visual Basic)](../vs140/function-statement--visual-basic-.md) with the <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> modifier. An <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> function can have a return type of <xref:System.Threading.Tasks.Task<CodeContentPlaceHolder>75\</CodeContentPlaceHolder>Async<CodeContentPlaceHolder>76\</CodeContentPlaceHolder>1*>.  
  
 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> procedures are primarily used for event handlers, where a value can't be returned. An <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> procedure can't be awaited, and the caller of an <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> procedure can't catch exceptions that the <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> procedure throws.  
  
 An <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> procedure can't declare any [ByRef](../vs140/byref--visual-basic-.md) parameters.  
  
 For more information about <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> procedures, see [Asynchronous Programming with Async and Await (C# and Visual Basic)](../vs140/asynchronous-programming-with-async-and-await--csharp-and-visual-basic-.md), [Control Flow in Async Programs (C# and Visual Basic)](../vs140/control-flow-in-async-programs--csharp-and-visual-basic-.md), and [Async Return Types (C# and Visual Basic)](../vs140/async-return-types--csharp-and-visual-basic-.md).  
  
## Example  
 The following example uses the <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> statement to define the name, parameters, and code that form the body of a <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> procedure.  
  
 [!code[VbVbalrStatements#58](../vs140/codesnippet/VisualBasic/sub-statement--visual-basic-_1.vb)]  
  
## Example  
 In the following example, <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> is an an <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> that has a return type of <xref:System.Threading.Tasks.Task<CodeContentPlaceHolder>88\</CodeContentPlaceHolder>DelayAsync<CodeContentPlaceHolder>89\</CodeContentPlaceHolder>Return<CodeContentPlaceHolder>90\</CodeContentPlaceHolder>DelayAsync<CodeContentPlaceHolder>91\</CodeContentPlaceHolder>Task(Of Integer)<CodeContentPlaceHolder>92\</CodeContentPlaceHolder>Task(Of Integer)<CodeContentPlaceHolder>93\</CodeContentPlaceHolder>Await<CodeContentPlaceHolder>94\</CodeContentPlaceHolder>DoSomethingAsync<CodeContentPlaceHolder>95\</CodeContentPlaceHolder>Dim result As Integer = Await delayTask<CodeContentPlaceHolder>96\</CodeContentPlaceHolder>startButton_Click<CodeContentPlaceHolder>97\</CodeContentPlaceHolder>Async Sub<CodeContentPlaceHolder>98\</CodeContentPlaceHolder>DoSomethingAsync<CodeContentPlaceHolder>99\</CodeContentPlaceHolder>Async<CodeContentPlaceHolder>100\</CodeContentPlaceHolder>DoSomethingAsync<CodeContentPlaceHolder>101\</CodeContentPlaceHolder>Await DoSomethingAsync()<CodeContentPlaceHolder>102\</CodeContentPlaceHolder>startButton_Click<CodeContentPlaceHolder>103\</CodeContentPlaceHolder> procedure must be defined with the <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> modifier because it has an <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> expression.  
  
 [!code[csAsyncMethod#1](../vs140/codesnippet/VisualBasic/sub-statement--visual-basic-_2.vb)]  
  
## See Also  
 [Implements Statement](../vs140/implements-statement.md)   
 [Function Statement](../vs140/function-statement--visual-basic-.md)   
 [Parameter List](../vs140/parameter-list--visual-basic-.md)   
 [Dim Statement](../vs140/dim-statement--visual-basic-.md)   
 [Call Statement](../vs140/call-statement--visual-basic-.md)   
 [Of](../vs140/of-clause--visual-basic-.md)   
 [Parameter Arrays](../vs140/parameter-arrays--visual-basic-.md)   
 [How to: Use a Generic Class](../vs140/how-to--use-a-generic-class--visual-basic-.md)   
 [Troubleshooting Procedures](../vs140/troubleshooting-procedures--visual-basic-.md)   
 [Partial Methods](../vs140/partial-methods--visual-basic-.md)