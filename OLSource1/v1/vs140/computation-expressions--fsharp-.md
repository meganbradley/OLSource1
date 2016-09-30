---
title: "Computation Expressions (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "use!_FS"
  - "return!_FS"
  - "yield!_FS"
  - "let!_FS"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "do! keyword [F#]"
  - "yield! keyword [F#]"
  - "workflows [F#]"
  - "monads [F#]"
  - "let! keyword [F#]"
  - "computation expressions [F#]"
  - "return keyword [F#]"
ms.assetid: 1a629b0f-f961-4064-8b64-69cf8877eae4
caps.latest.revision: 46
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Computation Expressions (F#)
Computation expressions in F# provide a convenient syntax for writing computations that can be sequenced and combined using control flow constructs and bindings. They can be used to provide a convenient syntax for *monads*, a functional programming feature that can be used to manage data, control, and side effects in functional programs.  
  
## Built-in Workflows  
 Sequence expressions are an example of a computation expression, as are asynchronous workflows and query expressions. For more information, see [Sequences](../vs140/sequences--fsharp-.md), [Asynchronous Workflows](../vs140/asynchronous-workflows--fsharp-.md), and [Query Expressions](../vs140/query-expressions--fsharp-.md).  
  
 Certain features are common to both sequence expressions and asynchronous workflows and illustrate the basic syntax for a computation expression:  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> { <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> }  
  
 The previous syntax specifies that the given expression is a computation expression of a type specified by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. The computation expression can be a built-in workflow, such as <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, or it can be something you define. The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is the identifier for an instance of a special type known as the *builder type*. The builder type is a class type that defines special methods that govern the way the fragments of the computation expression are combined, that is, code that controls how the expression executes. Another way to describe a builder class is to say that it enables you to customize the operation of many F# constructs, such as loops and bindings.  
  
 In computation expressions, two forms are available for some common language constructs. You can invoke the variant constructs by using a ! (bang) suffix on certain keywords, such as <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, and so on. These special forms cause certain functions defined in the builder class to replace the ordinary built-in behavior of these operations. These forms resemble the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> form of the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> keyword that is used in sequence expressions. For more information, see [Sequences](../vs140/sequences--fsharp-.md).  
  
## Creating a New Type of Computation Expression  
 You can define the characteristics of your own computation expressions by creating a builder class and defining certain special methods on the class. The builder class can optionally define the methods as listed in the following table.  
  
 The following table describes methods that can be used in a workflow builder class.  
  
||||  
|-|-|-|  
|**Method**|**Typical signature(s)**|**Description**|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Called for <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> in computation expressions.|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|Wraps a computation expression as a function.|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|Called for <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> in computation expressions.|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|Called for <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> in computation expressions.|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder> or\<br />\<br /> <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|Executes a computation expression.|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder> or\<br />\<br /> <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|Called for sequencing in computation expressions.|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder> or\<br />\<br /> <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|Called for <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> expressions in computation expressions.|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|Called for <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> expressions in computation expressions.|  
|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|Called for <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> expressions in computation expressions.|  
|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|Called for <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> bindings in computation expressions.|  
|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|Called for <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> expressions in computation expressions.|  
|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|Called for <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> expressions in computation expressions.|  
|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|Called for <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> expressions in computation expressions.|  
|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>|Called for empty <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> branches of <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> expressions in computation expressions.|  
  
 Many of the methods in a builder class use and return an <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> construct, which is typically a separately defined type that characterizes the kind of computations being combined, for example, <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> for asynchronous workflows and <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> for sequence workflows. The signatures of these methods enable them to be combined and nested with each other, so that the workflow object returned from one construct can be passed to the next. The compiler, when it parses a computation expression, converts the expression into a series of nested function calls by using the methods in the preceding table and the code in the computation expression.  
  
 The nested expression is of the following form:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In the above code, the calls to <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> are omitted if they are not defined in the computation expression builder class. The body of the computation expression, here denoted as <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>, is translated into calls involving the methods of the builder class by the translations described in the following table. The computation expression <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> is defined recursively according to these translations where <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> is an F# expression and <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> is a computation expression.  
  
|Expression|Translation|  
|----------------|-----------------|  
|<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>74\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>75\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>76\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>78\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>79\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>80\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>81\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>82\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>83\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>84\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>85\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>86\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>87\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>88\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>89\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>90\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>91\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>92\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>93\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>94\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>95\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>96\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>97\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>98\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>99\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>100\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>101\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>102\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>103\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>104\</CodeContentPlaceHolder>|  
  
 In the previous table, <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> describes an expression that is not otherwise listed in the table. A builder class does not need to implement all of the methods and support all of the translations listed in the previous table. Those constructs that are not implemented are not available in computation expressions of that type. For example, if you do not want to support the <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> keyword in your computation expressions, you can omit the definition of <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> in your builder class.  
  
 The following code example shows a computation expression that encapsulates a computation as a series of steps that can be evaluated one step at a time. A discriminated union type, <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>, encodes the error state of the expression as evaluated so far. This code demonstrates several typical patterns that you can use in your computation expressions, such as boilerplate implementations of some of the builder methods.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A computation expression has an underlying type, which the expression returns. The underlying type may represent a computed result or a delayed computation that can be performed, or it may provide a way to iterate through some type of collection. In the previous example, the underlying type was <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>.For a sequence expression, the underlying type is <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>110\</CodeContentPlaceHolder>1*>. For an asychronous workflow, the underlying type is [Async](../vs140/control.async-class--fsharp-.md). The <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> object represents the work to be performed to compute the result. For example, you call [Async.RunSynchronously](../vs140/async.runsynchronously--t--method--fsharp-.md) to execute a computation and return the result.  
  
## Custom Operations  
 You can define a custom operation on a computation expression and use a custom operation as an operator in a computation expression. For example, you can include a query operator in a query expression. When you define a custom operation, you must define the Yield and For methods in the computation expression. To define a custom operation, put it in a builder class for the computation expression, and then apply the [CustomOperationAttribute](../vs140/core.customoperationattribute-class--fsharp-.md). This attribute takes a string as an argument, which is the name to be used in a custom operation. This name comes into scope at the start of the opening curly brace of the computation expression. Therefore, you shouldn’t use identifiers that have the same name as a custom operation in this block. For example, avoid the use of identifiers such as <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> in query expressions.  
  
## See Also  
 [F# Language Reference](../vs140/fsharp-language-reference.md)   
 [Asynchronous Workflows (F#)](../vs140/asynchronous-workflows--fsharp-.md)   
 [Sequences (F#)](../vs140/sequences--fsharp-.md)   
 [Query Expressions (F#)](../vs140/query-expressions--fsharp-.md)