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
Declares the name, parameters, and code that define a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> procedure.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
  
-   <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
     Optional. See [Attribute List](../vs140/attribute-list--visual-basic-.md).  
  
-   <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
     Optional. Can be one of the following:  
  
    -   [Public](../vs140/public--visual-basic-.md)  
  
    -   [Protected](../vs140/protected--visual-basic-.md)  
  
    -   [Friend](../vs140/friend--visual-basic-.md)  
  
    -   [Private](../vs140/private--visual-basic-.md)  
  
    -   <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
     See [Access Levels in Visual Basic](../vs140/access-levels-in-visual-basic.md).  
  
-   <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
     Optional. Can be one of the following:  
  
    -   [Overloads](../vs140/overloads--visual-basic-.md)  
  
    -   [Overrides](../vs140/overrides--visual-basic-.md)  
  
    -   [Overridable](../vs140/overridable--visual-basic-.md)  
  
    -   [NotOverridable](../vs140/notoverridable--visual-basic-.md)  
  
    -   [MustOverride](../vs140/mustoverride--visual-basic-.md)  
  
    -   <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
    -   <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
     Optional. See [Shared](../vs140/shared--visual-basic-.md).  
  
-   <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
     Optional. See [Shadows](../vs140/shadows--visual-basic-.md).  
  
-   <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
     Optional. See [Async](../vs140/async--visual-basic-.md).  
  
-   <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
     Optional. See [Iterator](../vs140/iterator--visual-basic-.md).  
  
-   <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
     Required. Name of the procedure. See [Declared Element Names](../vs140/declared-element-names--visual-basic-.md).  
  
-   <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
     Optional. List of type parameters for a generic procedure. See [Type List](../vs140/type-list--visual-basic-.md).  
  
-   <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
     Optional. List of local variable names representing the parameters of this procedure. See [Parameter List](../vs140/parameter-list--visual-basic-.md).  
  
-   <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
     Required if <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. Data type of the value returned by this procedure.  
  
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
  
     Optional. Block of statements to be executed within this procedure.  
  
-   <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
  
     Terminates the definition of this procedure.  
  
## Remarks  
 All executable code must be inside a procedure. Each procedure, in turn, is declared within a class, a structure, or a module that is referred to as the containing class, structure, or module.  
  
 To return a value to the calling code, use a <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> procedure; otherwise, use a <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> procedure.  
  
## Defining a Function  
 You can define a <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> procedure only at the module level. Therefore, the declaration context for a function must be a class, a structure, a module, or an interface and can't be a source file, a namespace, a procedure, or a block. For more information, see [Declaration Contexts and Default Access Levels](../vs140/declaration-contexts-and-default-access-levels--visual-basic-.md).  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> procedures default to public access. You can adjust their access levels with the access modifiers.  
  
 A <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> procedure can declare the data type of the value that the procedure returns. You can specify any data type or the name of an enumeration, a structure, a class, or an interface. If you don't specify the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> parameter, the procedure returns <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>.  
  
 If this procedure uses the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> keyword, the containing class or structure must also have an <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> statement that immediately follows its <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> statement. The <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> statement must include each interface that's specified in <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>. However, the name by which an interface defines the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> (in <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>) doesn't need to match the name of this procedure (in <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>).  
  
> [!NOTE]
>  You can use lambda expressions to define function expressions inline. For more information, see [Function Expression](../vs140/function-expression--visual-basic-.md) and [Lambda Expressions](../vs140/lambda-expressions--visual-basic-.md).  
  
## Returning from a Function  
 When the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> procedure returns to the calling code, execution continues with the statement that follows the statement that called the procedure.  
  
 To return a value from a function, you can either assign the value to the function name or include it in a <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> statement.  
  
 The <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> statement simultaneously assigns the return value and exits the function, as the following example shows.  
  
 [!code[VbVbalrStatements#24](../vs140/codesnippet/VisualBasic/function-statement--visual-basic-_1.vb)]  
  
 The following example assigns the return value to the function name <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> and then uses the <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> statement to return.  
  
 [!code[VbVbalrStatements#23](../vs140/codesnippet/VisualBasic/function-statement--visual-basic-_2.vb)]  
  
 The <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> statements cause an immediate exit from a <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> procedure. Any number of <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> statements can appear anywhere in the procedure, and you can mix <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> statements.  
  
 If you use <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> without assigning a value to <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>, the procedure returns the default value for the data type that's specified in <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> isn't specified, the procedure returns <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>, which is the default value for <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>.  
  
## Calling a Function  
 You call a <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> procedure by using the procedure name, followed by the argument list in parentheses, in an expression. You can omit the parentheses only if you aren't supplying any arguments. However, your code is more readable if you always include the parentheses.  
  
 You call a <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> procedure the same way that you call any library function such as <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>.  
  
 You can also call a function by using the <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> keyword. In that case, the return value is ignored. Use of the <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> keyword isn't recommended in most cases. For more information, see [Call Statement (Visual Basic)](../vs140/call-statement--visual-basic-.md).  
  
 Visual Basic sometimes rearranges arithmetic expressions to increase internal efficiency. For that reason, you shouldn't use a <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> procedure in an arithmetic expression when the function changes the value of variables in the same expression.  
  
## Async Functions  
 The *Async* feature allows you to invoke asynchronous functions without using explicit callbacks or manually splitting your code across multiple functions or lambda expressions.  
  
 If you mark a function with the [Async](../vs140/async--visual-basic-.md) modifier, you can use the [Await](../vs140/await-operator--visual-basic-.md) operator in the function. When control reaches an <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> expression in the <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> function, control returns to the caller, and progress in the function is suspended until the awaited task completes. When the task is complete, execution can resume in the function.  
  
> [!NOTE]
>  An <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> procedure returns to the caller when either it encounters the first awaited object that’s not yet complete, or it gets to the end of the <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> procedure, whichever occurs first.  
  
 An <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> function can have a return type of <xref:System.Threading.Tasks.Task<CodeContentPlaceHolder>86\</CodeContentPlaceHolder>Async<CodeContentPlaceHolder>87\</CodeContentPlaceHolder>1*> is provided below.  
  
 An <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> function cannot declare any [ByRef](../vs140/byref--visual-basic-.md) parameters.  
  
 A [Sub Statement (Visual Basic)](../vs140/sub-statement--visual-basic-.md) can also be marked with the <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> modifier. This is primarily used for event handlers, where a value cannot be returned. An <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> procedure can't be awaited, and the caller of an <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> procedure can't catch exceptions that are thrown by the <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> procedure.  
  
 For more information about <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> functions, see [Asynchronous Programming with Async and Await (C# and Visual Basic)](../vs140/asynchronous-programming-with-async-and-await--csharp-and-visual-basic-.md), [Control Flow in Async Programs (C# and Visual Basic)](../vs140/control-flow-in-async-programs--csharp-and-visual-basic-.md), and [Async Return Types (C# and Visual Basic)](../vs140/async-return-types--csharp-and-visual-basic-.md).  
  
## Iterator Functions  
 An *iterator* function performs a custom iteration over a collection, such as a list or array. An iterator function uses the [Yield](../vs140/yield-statement--visual-basic-.md) statement to return each element one at a time. When a [Yield](../vs140/yield-statement--visual-basic-.md) statement is reached, the current location in code is remembered. Execution is restarted from that location the next time the iterator function is called.  
  
 You call an iterator from client code by using a [For Each…Next](../vs140/for-each...next-statement--visual-basic-.md) statement.  
  
 The return type of an iterator function can be \<xref:System.Collections.IEnumerable*>, <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>94\</CodeContentPlaceHolder>1*>.  
  
 For more information, see [Iterators (C# and Visual Basic)](../vs140/iterators--csharp-and-visual-basic-.md).  
  
## Example  
 The following example uses the <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> statement to declare the name, parameters, and code that form the body of a <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> procedure. The <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> modifier enables the function to accept a variable number of arguments.  
  
 [!code[VbVbalrStatements#25](../vs140/codesnippet/VisualBasic/function-statement--visual-basic-_3.vb)]  
  
## Example  
 The following example invokes the function declared in the preceding example.  
  
 [!code[VbVbalrStatements#26](../vs140/codesnippet/VisualBasic/function-statement--visual-basic-_4.vb)]  
  
## Example  
 In the following example, <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> is an <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> that has a return type of <xref:System.Threading.Tasks.Task<CodeContentPlaceHolder>100\</CodeContentPlaceHolder>DelayAsync<CodeContentPlaceHolder>101\</CodeContentPlaceHolder>Return<CodeContentPlaceHolder>102\</CodeContentPlaceHolder>DelayAsync<CodeContentPlaceHolder>103\</CodeContentPlaceHolder>Task(Of Integer)<CodeContentPlaceHolder>104\</CodeContentPlaceHolder>Task(Of Integer)<CodeContentPlaceHolder>105\</CodeContentPlaceHolder>Await<CodeContentPlaceHolder>106\</CodeContentPlaceHolder>DoSomethingAsync<CodeContentPlaceHolder>107\</CodeContentPlaceHolder>Dim result As Integer = Await delayTask<CodeContentPlaceHolder>108\</CodeContentPlaceHolder>startButton_Click<CodeContentPlaceHolder>109\</CodeContentPlaceHolder>Async Sub<CodeContentPlaceHolder>110\</CodeContentPlaceHolder>DoSomethingAsync<CodeContentPlaceHolder>111\</CodeContentPlaceHolder>Async<CodeContentPlaceHolder>112\</CodeContentPlaceHolder>DoSomethingAsync<CodeContentPlaceHolder>113\</CodeContentPlaceHolder>Await DoSomethingAsync()<CodeContentPlaceHolder>114\</CodeContentPlaceHolder>startButton_Click<CodeContentPlaceHolder>115\</CodeContentPlaceHolder> procedure must be defined with the <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> modifier because it has an <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> expression.  
  
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