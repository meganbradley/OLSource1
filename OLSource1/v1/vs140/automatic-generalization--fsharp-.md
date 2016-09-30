---
title: "Automatic Generalization (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "type inference [F#]"
  - "automatic generalization [F#]"
  - "value restriction [F#]"
ms.assetid: 1a9ea094-2f91-445f-9a48-54e41b12f370
caps.latest.revision: 30
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Automatic Generalization (F#)
F# uses type inference to evaluate the types of functions and expressions. This topic describes how F# automatically generalizes the arguments and types of functions so that they work with multiple types when this is possible.  
  
## Automatic Generalization  
 The F# compiler, when it performs type inference on a function, determines whether a given parameter can be generic. The compiler examines each parameter and determines whether the function has a dependency on the specific type of that parameter. If it does not, the type is inferred to be generic.  
  
 The following code example illustrates a function that the compiler infers to be generic.  
  
 [!code[FsLangRef3#101](../vs140/codesnippet/FSharp/automatic-generalization--fsharp-_1.fs)]  
  
 The type is inferred to be <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 The type indicates that this is a function that takes two arguments of the same unknown type and returns a value of that same type. One of the reasons that the previous function can be generic is that the greater-than operator (<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>) is itself generic. The greater-than operator has the signature <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. Not all operators are generic, and if the code in a function uses a parameter type together with a non-generic function or operator, that parameter type cannot be generalized.  
  
 Because <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is generic, it can be used with types such as <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, and so on, as shown in the following examples.  
  
 [!code[FsLangRef3#102](../vs140/codesnippet/FSharp/automatic-generalization--fsharp-_2.fs)]  
  
 However, the two arguments must be of the same type. The signature is <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, not <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. Therefore, the following code produces an error because the types do not match.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> function also works with any type that supports the greater-than operator. Therefore, you could also use it on a string, as shown in the following code.  
  
 [!code[FsLangRef3#104](../vs140/codesnippet/FSharp/automatic-generalization--fsharp-_3.fs)]  
  
## Value Restriction  
 The compiler performs automatic generalization only on complete function definitions that have explicit arguments, and on simple immutable values.  
  
 This means that the compiler issues an error if you try to compile code that is not sufficiently constrained to be a specific type, but is also not generalizable. The error message for this problem refers to this restriction on automatic generalization for values as the *value restriction*.  
  
 Typically, the value restriction error occurs either when you want a construct to be generic but the compiler has insufficient information to generalize it, or when you unintentionally omit sufficient type information in a nongeneric construct. The solution to the value restriction error is to provide more explicit information to more fully constrain the type inference problem, in one of the following ways:  
  
-   Constrain a type to be nongeneric by adding an explicit type annotation to a value or parameter.  
  
-   If the problem is using a nongeneralizable construct to define a generic function, such as a function composition or incompletely applied curried function arguments, try to rewrite the function as an ordinary function definition.  
  
-   If the problem is an expression that is too complex to be generalized, make it into a function by adding an extra, unused parameter.  
  
-   Add explicit generic type parameters. This option is rarely used.  
  
-   The following code examples illustrate each of these scenarios.  
  
 Case 1: Too complex an expression. In this example, the list <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is intended to be <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, but it is not defined as a simple immutable value.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Case 2: Using a nongeneralizable construct to define a generic function. In this example, the construct is nongeneralizable because it involves partial application of function arguments.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Case 3: Adding an extra, unused parameter. Because this expression is not simple enough for generalization, the compiler issues the value restriction error.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Case 4: Adding type parameters.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 In the last case, the value becomes a type function, which may be used to create values of many different types, for example as follows:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## See Also  
 [Type Inference](../vs140/type-inference--fsharp-.md)   
 [Generics](../vs140/generics--fsharp-.md)   
 [Statically Resolved Type Parameters](../vs140/statically-resolved-type-parameters--fsharp-.md)   
 [Constraints](../vs140/constraints--fsharp-.md)