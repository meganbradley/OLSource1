---
title: "Functions as First-Class Values (F#)"
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
  - "functions [F#]"
  - "functions [F#], first-class values"
ms.assetid: a9669418-52e3-4fa4-b04f-99d0d4b3f1fa
caps.latest.revision: 40
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Functions as First-Class Values (F#)
A defining characteristic of functional programming languages is the elevation of functions to first-class status. You should be able to do with a function whatever you can do with values of the other built-in types, and be able to do so with a comparable degree of effort.  
  
 Typical measures of first-class status include the following:  
  
-   Can you bind an identifier to the value? That is, can you give it a name?  
  
-   Can you store the value in a data structure, such as a list?  
  
-   Can you pass the value as an argument in a function call?  
  
-   Can you return the value as the value of a function call?  
  
 The last two measures define what are known as *higher-order operations* or *higher-order functions*. Higher-order functions accept functions as arguments and return functions as the value of function calls. These operations support such mainstays of functional programming as mapping functions and composition of functions.  
  
## Give the Value a Name  
 If a function is a first-class value, you must be able to name it, just as you can name integers, strings, and other built-in types. This is referred to in functional programming literature as binding an identifier to a value. F# uses [let expressions](../vs140/let-bindings--fsharp-.md) to bind names to values: `let <identifier> = <value>`. The following code shows two examples.  
  
 [!code[FsConTour#20](../vs140/codesnippet/FSharp/functions-as-first-class-values--fsharp-_1.fs)]  
  
 You can name a function just as easily. The following example defines a function named `squareIt` by binding the identifier `squareIt` to the [lambda expression](../vs140/lambda-expressions--the-fun-keyword--fsharp-.md)`fun n -> n * n`. Function `squareIt` has one parameter, `n`, and it returns the square of that parameter.  
  
 [!code[FsConTour#21](../vs140/codesnippet/FSharp/functions-as-first-class-values--fsharp-_2.fs)]  
  
 F# provides the following more concise syntax to achieve the same result with less typing.  
  
 [!code[FsConTour#22](../vs140/codesnippet/FSharp/functions-as-first-class-values--fsharp-_3.fs)]  
  
 The examples that follow mostly use the first style, `let <function-name> = <lambda-expression>`, to emphasize the similarities between the declaration of functions and the declaration of other types of values. However, all the named functions can also be written with the concise syntax. Some of the examples are written in both ways.  
  
## Store the Value in a Data Structure  
 A first-class value can be stored in a data structure. The following code shows examples that store values in lists and in tuples.  
  
 [!code[FsConTour#23](../vs140/codesnippet/FSharp/functions-as-first-class-values--fsharp-_4.fs)]  
  
 To verify that a function name stored in a tuple does in fact evaluate to a function, the following example uses the `fst` and `snd` operators to extract the first and second elements from tuple `funAndArgTuple`. The first element in the tuple is `squareIt` and the second element is `num`. Identifier `num` is bound in a previous example to integer 10, a valid argument for the `squareIt` function. The second expression applies the first element in the tuple to the second element in the tuple: `squareIt num`.  
  
 [!code[FsConTour#24](../vs140/codesnippet/FSharp/functions-as-first-class-values--fsharp-_5.fs)]  
  
 Similarly, just as identifier `num` and integer 10 can be used interchangeably, so can identifier `squareIt` and lambda expression `fun n -> n * n`.  
  
 [!code[FsConTour#25](../vs140/codesnippet/FSharp/functions-as-first-class-values--fsharp-_6.fs)]  
  
## Pass the Value as an Argument  
 If a value has first-class status in a language, you can pass it as an argument to a function. For example, it is common to pass integers and strings as arguments. The following code shows integers and strings passed as arguments in F#.  
  
 [!code[FsConTour#26](../vs140/codesnippet/FSharp/functions-as-first-class-values--fsharp-_7.fs)]  
  
 If functions have first-class status, you must be able to pass them as arguments in the same way. Remember that this is the first characteristic of higher-order functions.  
  
 In the following example, function `applyIt` has two parameters, `op` and `arg`. If you send in a function that has one parameter for `op` and an appropriate argument for the function to `arg`, the function returns the result of applying `op` to `arg`. In the following example, both the function argument and the integer argument are sent in the same way, by using their names.  
  
 [!code[FsConTour#27](../vs140/codesnippet/FSharp/functions-as-first-class-values--fsharp-_8.fs)]  
  
 The ability to send a function as an argument to another function underlies common abstractions in functional programming languages, such as map or filter operations. A map operation, for example, is a higher-order function that captures the computation shared by functions that step through a list, do something to each element, and then return a list of the results. You might want to increment each element in a list of integers, or to square each element, or to change each element in a list of strings to uppercase. The error-prone part of the computation is the recursive process that steps through the list and builds a list of the results to return. That part is captured in the mapping function. All you have to write for a particular application is the function that you want to apply to each list element individually (adding, squaring, changing case). That function is sent as an argument to the mapping function, just as `squareIt` is sent to `applyIt` in the previous example.  
  
 F# provides map methods for most collection types, including [lists](../vs140/collections.list-module--fsharp-.md), [arrays](../vs140/collections.array-module--fsharp-.md), and [sets](../vs140/collections.set-module--fsharp-.md). The following examples use lists. The syntax is `List.map <the function> <the list>`.  
  
 [!code[FsConTour#28](../vs140/codesnippet/FSharp/functions-as-first-class-values--fsharp-_9.fs)]  
  
 For more information, see [Lists](../vs140/lists--fsharp-.md).  
  
## Return the Value from a Function Call  
 Finally, if a function has first-class status in a language, you must be able to return it as the value of a function call, just as you return other types, such as integers and strings.  
  
 The following function calls return integers and display them.  
  
 [!code[FsConTour#29](../vs140/codesnippet/FSharp/functions-as-first-class-values--fsharp-_10.fs)]  
  
 The following function call returns a string.  
  
 [!code[FsConTour#30](../vs140/codesnippet/FSharp/functions-as-first-class-values--fsharp-_11.fs)]  
  
 The following function call, declared inline, returns a Boolean value. The value displayed is `True`.  
  
 [!code[FsConTour#31](../vs140/codesnippet/FSharp/functions-as-first-class-values--fsharp-_12.fs)]  
  
 The ability to return a function as the value of a function call is the second characteristic of higher-order functions. In the following example, `checkFor` is defined to be a function that takes one argument, `item`, and returns a new function as its value. The returned function takes a list as its argument, `lst`, and searches for `item` in `lst`. If `item` is present, the function returns `true`. If `item` is not present, the function returns `false`. As in the previous section, the following code uses a provided list function, [List.exists](../vs140/list.exists--t--function--fsharp-.md), to search the list.  
  
 [!code[FsConTour#32](../vs140/codesnippet/FSharp/functions-as-first-class-values--fsharp-_13.fs)]  
  
 The following code uses `checkFor` to create a new function that takes one argument, a list, and searches for 7 in the list.  
  
 [!code[FsConTour#33](../vs140/codesnippet/FSharp/functions-as-first-class-values--fsharp-_14.fs)]  
  
 The following example uses the first-class status of functions in F# to declare a function, `compose`, that returns a composition of two function arguments.  
  
 [!code[FsConTour#34](../vs140/codesnippet/FSharp/functions-as-first-class-values--fsharp-_15.fs)]  
  
> [!NOTE]
>  For an even shorter version, see the following section, "Curried Functions."  
  
 The following code sends two functions as arguments to `compose`, both of which take a single argument of the same type. The return value is a new function that is a composition of the two function arguments.  
  
 [!code[FsConTour#35](../vs140/codesnippet/FSharp/functions-as-first-class-values--fsharp-_16.fs)]  
  
> [!NOTE]
>  F# provides two operators, `<<` and `>>`, that compose functions. For example, `let squareAndDouble2 = doubleIt << squareIt` is equivalent to `let squareAndDouble = compose doubleIt squareIt` in the previous example.  
  
 The following example of returning a function as the value of a function call creates a simple guessing game. To create a game, call `makeGame` with the value that you want someone to guess sent in for `target`. The return value from function `makeGame` is a function that takes one argument (the guess) and reports whether the guess is correct.  
  
 [!code[FsConTour#36](../vs140/codesnippet/FSharp/functions-as-first-class-values--fsharp-_17.fs)]  
  
 The following code calls `makeGame`, sending the value `7` for `target`. Identifier `playGame` is bound to the returned lambda expression. Therefore, `playGame` is a function that takes as its one argument a value for `guess`.  
  
 [!code[FsConTour#37](../vs140/codesnippet/FSharp/functions-as-first-class-values--fsharp-_18.fs)]  
  
## Curried Functions  
 Many of the examples in the previous section can be written more concisely by taking advantage of the implicit *currying* in F# function declarations. Currying is a process that transforms a function that has more than one parameter into a series of embedded functions, each of which has a single parameter. In F#, functions that have more than one parameter are inherently curried. For example, `compose` from the previous section can be written as shown in the following concise style, with three parameters.  
  
 [!code[FsConTour#38](../vs140/codesnippet/FSharp/functions-as-first-class-values--fsharp-_19.fs)]  
  
 However, the result is a function of one parameter that returns a function of one parameter that in turn returns another function of one parameter, as shown in `compose4curried`.  
  
 [!code[FsConTour#39](../vs140/codesnippet/FSharp/functions-as-first-class-values--fsharp-_20.fs)]  
  
 You can access this function in several ways. Each of the following examples returns and displays 18. You can replace `compose4` with `compose4curried` in any of the examples.  
  
 [!code[FsConTour#40](../vs140/codesnippet/FSharp/functions-as-first-class-values--fsharp-_21.fs)]  
  
 To verify that the function still works as it did before, try the original test cases again.  
  
 [!code[FsConTour#41](../vs140/codesnippet/FSharp/functions-as-first-class-values--fsharp-_22.fs)]  
  
> [!NOTE]
>  You can restrict currying by enclosing parameters in tuples. For more information, see "Parameter Patterns" in [Parameters and Arguments](../vs140/parameters-and-arguments--fsharp-.md).  
  
 The following example uses implicit currying to write a shorter version of `makeGame`. The details of how `makeGame` constructs and returns the `game` function are less explicit in this format, but you can verify by using the original test cases that the result is the same.  
  
 [!code[FsConTour#42](../vs140/codesnippet/FSharp/functions-as-first-class-values--fsharp-_23.fs)]  
  
 For more information about currying, see "Partial Application of Arguments" in [Functions](../vs140/functions--fsharp-.md).  
  
## Identifier and Function Definition Are Interchangeable  
 The variable name `num` in the previous examples evaluates to the integer 10, and it is no surprise that where `num` is valid, 10 is also valid. The same is true of function identifiers and their values: anywhere the name of the function can be used, the lambda expression to which it is bound can be used.  
  
 The following example defines a `Boolean` function called `isNegative`, and then uses the name of the function and the definition of the function interchangeably. The next three examples all return and display `False`.  
  
 [!code[FsConTour#43](../vs140/codesnippet/FSharp/functions-as-first-class-values--fsharp-_24.fs)]  
  
 To take it one step further, substitute the value that `applyIt` is bound to for `applyIt`.  
  
 [!code[FsConTour#44](../vs140/codesnippet/FSharp/functions-as-first-class-values--fsharp-_25.fs)]  
  
## Functions Are First-Class Values in F#  
 The examples in the previous sections demonstrate that functions in F# satisfy the criteria for being first-class values in F#:  
  
-   You can bind an identifier to a function definition.  
  
     [!code[FsConTour#21](../vs140/codesnippet/FSharp/functions-as-first-class-values--fsharp-_2.fs)]  
  
-   You can store a function in a data structure.  
  
     [!code[FsConTour#45](../vs140/codesnippet/FSharp/functions-as-first-class-values--fsharp-_26.fs)]  
  
-   You can pass a function as an argument.  
  
     [!code[FsConTour#46](../vs140/codesnippet/FSharp/functions-as-first-class-values--fsharp-_27.fs)]  
  
-   You can return a function as the value of a function call.  
  
     [!code[FsConTour#32](../vs140/codesnippet/FSharp/functions-as-first-class-values--fsharp-_13.fs)]  
  
 For more information about F#, see [F# Language Reference](../vs140/fsharp-language-reference.md).  
  
## Example  
  
### Description  
 The following code contains all the examples in this topic.  
  
### Code  
 [!code[FsConTour#47](../vs140/codesnippet/FSharp/functions-as-first-class-values--fsharp-_28.fs)]  
  
## See Also  
 [Lists](../vs140/lists--fsharp-.md)   
 [Tuples](../vs140/tuples--fsharp-.md)   
 [Functions](../vs140/functions--fsharp-.md)   
 [let Bindings](../vs140/let-bindings--fsharp-.md)   
 [lambda Expressions](../vs140/lambda-expressions--the-fun-keyword--fsharp-.md)