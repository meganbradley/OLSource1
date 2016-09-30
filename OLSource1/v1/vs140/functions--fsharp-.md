---
title: "Functions (F#)"
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
  - "functions [F#], curried"
  - "arguments, functions [F#]"
  - "function values [F#]"
  - "scope, functions [F#]"
  - "lambda expressions [F#]"
  - "curried functions [F#]"
  - "pipelining functions [F#]"
  - "functions [F#], return values"
  - "functions, return values [F#]"
  - "functions [F#]"
  - "function composition [F#]"
  - "arguments [F#], functions"
  - "return values [F#]"
  - "arguments [F#], partial application"
  - "arguments, partial application [F#]"
  - "composition of functions [F#]"
  - "functions, curried [F#]"
  - "function pipelining [F#]"
ms.assetid: a54734f3-15e1-4266-b66f-aae2562b0cb1
caps.latest.revision: 39
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Functions (F#)
Functions are the fundamental unit of program execution in any programming language. As in other languages, an F# function has a name, can have parameters and take arguments, and has a body. F# also supports functional programming constructs such as treating functions as values, using unnamed functions in expressions, composition of functions to form new functions, curried functions, and the implicit definition of functions by way of the partial application of function arguments.  
  
 You define functions by using the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> keyword, or, if the function is recursive, the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> keyword combination.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is an identifier that represents the function. The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> consists of successive parameters that are separated by spaces. You can specify an explicit type for each parameter, as described in the Parameters section. If you do not specify a specific argument type, the compiler attempts to infer the type from the function body. The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> consists of an expression. The expression that makes up the function body is typically a compound expression consisting of a number of expressions that culminate in a final expression that is the return value. The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is a colon followed by a type and is optional. If you do not specify the type of the return value explicitly, the compiler determines the return type from the final expression.  
  
 A simple function definition resembles the following:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 In the previous example, the function name is <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, the argument is <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, which has type <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, the function body is <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, and the return value is of type <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
 The inline specifier is a hint to the compiler that the function is small and that the code for the function can be integrated into the body of the caller.  
  
## Scope  
 At any level of scope other than module scope, it is not an error to reuse a value or function name. If you reuse a name, the name declared later shadows the name declared earlier. However, at the top level scope in a module, names must be unique. For example, the following code produces an error when it appears at module scope, but not when it appears inside a function:  
  
 [!code[FsLangRef1#101](../vs140/codesnippet/FSharp/functions--fsharp-_1.fs)]  
  
 But the following code is acceptable at any level of scope:  
  
 [!code[FsLangRef1#102](../vs140/codesnippet/FSharp/functions--fsharp-_2.fs)]  
  
#### Parameters  
 Names of parameters are listed after the function name. You can specify a type for a parameter, as shown in the following example:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 If you specify a type, it follows the name of the parameter and is separated from the name by a colon. If you omit the type for the parameter, the parameter type is inferred by the compiler. For example, in the following function definition, the argument <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is inferred to be of type <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> because 1 is of type <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 However, the compiler will attempt to make the function as generic as possible. For example, note the following code:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The function creates a tuple from one argument of any type. Because the type is not specified, the function can be used with any argument type. For more information, see [Automatic Generalization and Generics](../vs140/automatic-generalization--fsharp-.md).  
  
## Function Bodies  
 A function body can contain definitions of local variables and functions. Such variables and functions are in scope in the body of the current function but not outside it. When you have the lightweight syntax option enabled, you must use indentation to indicate that a definition is in a function body, as shown in the following example:  
  
 [!code[FsLangRef1#103](../vs140/codesnippet/FSharp/functions--fsharp-_3.fs)]  
  
 For more information, see [Code Formatting Guidelines (F#)](../vs140/code-formatting-guidelines--fsharp-.md) and [Verbose Syntax (F#)](../vs140/verbose-syntax--fsharp-.md).  
  
## Return Values  
 The compiler uses the final expression in a function body to determine the return value and type. The compiler might infer the type of the final expression from previous expressions. In the function <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, shown in the previous section, the type of <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is determined from the type of the literal <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> to be <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>. The compiler uses the type of <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> to determine the type of the expression <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> to be <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>. Therefore, the overall return type of the function is <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
 To specify the return value explicitly, write the code as follows:  
  
 [!code[FsLangRef1#105](../vs140/codesnippet/FSharp/functions--fsharp-_4.fs)]  
  
 As the code is written above, the compiler applies <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> to the entire function; if you mean to apply it to the parameter types as well, use the following code:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## Calling a Function  
 You call functions by specifying the function name followed by a space and then any arguments separated by spaces. For example, to call the function <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> and assign the result to the value <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, you write the following code:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
## Partial Application of Arguments  
 If you supply fewer than the specified number of arguments, you create a new function that expects the remaining arguments. This method of handling arguments is referred to as *currying* and is a characteristic of functional programming languages like F#. For example, suppose you are working with two sizes of pipe: one has a radius of <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> and the other has a radius of <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>. You could create functions that determine the volume of pipe as follows:  
  
 [!code[FsLangRef1#106](../vs140/codesnippet/FSharp/functions--fsharp-_5.fs)]  
  
 You would then supply the additional argument as needed for various lengths of pipe of the two different sizes:  
  
 [!code[FsLangRef1#107](../vs140/codesnippet/FSharp/functions--fsharp-_6.fs)]  
  
## Recursive Functions  
 *Recursive functions* are functions that call themselves. They require that you specify the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> keyword following the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> keyword. Invoke the recursive function from within the body of the function just as you would invoke any function call. The following recursive function computes the *n*th Fibonacci number. The Fibonacci number sequence has been known since antiquity and is a sequence in which each successive number is the sum of the previous two numbers in the sequence.  
  
 [!code[FsLangRef1#108](../vs140/codesnippet/FSharp/functions--fsharp-_7.fs)]  
  
 Some recursive functions might overflow the program stack or perform inefficiently if you do not write them with care and with awareness of special techniques, such as the use of accumulators and continuations.  
  
## Function Values  
 In F#, all functions are considered values; in fact, they are known as *function values*. Because functions are values, they can be used as arguments to other functions or in other contexts where values are used. Following is an example of a function that takes a function value as an argument:  
  
 [!code[FsLangRef1#109](../vs140/codesnippet/FSharp/functions--fsharp-_8.fs)]  
  
 You specify the type of a function value by using the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> token. On the left side of this token is the type of the argument, and on the right side is the return value. In the previous example, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> is a function that takes a function <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> as an argument, where <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> is a function that takes an integer and returns another integer. The following code shows how to use <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>:  
  
 [!code[FsLangRef1#110](../vs140/codesnippet/FSharp/functions--fsharp-_9.fs)]  
  
 The value of <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> will be 101 after the previous code runs.  
  
 Multiple arguments are separated by successive <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> tokens, as shown in the following example:  
  
 [!code[FsLangRef1#111](../vs140/codesnippet/FSharp/functions--fsharp-_10.fs)]  
  
 The result is 200.  
  
## Lambda Expressions  
 A *lambda expression* is an unnamed function. In the previous examples, instead of defining named functions <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>, you could use lambda expressions as follows:  
  
 [!code[FsLangRef1#112](../vs140/codesnippet/FSharp/functions--fsharp-_11.fs)]  
  
 You define lambda expressions by using the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> keyword. A lambda expression resembles a function definition, except that instead of the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> token, the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> token is used to separate the argument list from the function body. As in a regular function definition, the argument types can be inferred or specified explicitly, and the return type of the lambda expression is inferred from the type of the last expression in the body. For more information, see [Lambda Expressions: the fun Keyword](../vs140/lambda-expressions--the-fun-keyword--fsharp-.md).  
  
## Function Composition and Pipelining  
 Functions in F# can be composed from other functions. The composition of two functions <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> is another function that represents the application of <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> followed the application of <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>:  
  
 [!code[FsLangRef1#113](../vs140/codesnippet/FSharp/functions--fsharp-_12.fs)]  
  
 The result is 202.  
  
 Pipelining enables function calls to be chained together as successive operations. Pipelining works as follows:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The result is again 202.  
  
 The composition operators take two functions and return a function; by contrast, the pipeline operators take a function and an argument and return a value. The following code example shows the difference between the pipeline and composition operators by showing the differences in the function signatures and usage.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
## Overloading Functions  
 You can overload methods of a type but not functions. For more information, see [Methods (F#)](../vs140/methods--fsharp-.md).  
  
## See Also  
 [Values (F#)](../vs140/values--fsharp-.md)   
 [F# Language Reference](../vs140/fsharp-language-reference.md)