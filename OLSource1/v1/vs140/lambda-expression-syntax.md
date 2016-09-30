---
title: "Lambda Expression Syntax"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "VCF1 Lambda_CPP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "lambda expressions [C++], syntax"
ms.assetid: 5d6154a4-f34d-4a15-970d-7e7de45f54e9
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Lambda Expression Syntax
This article demonstrates the syntax and structural elements of lambda expressions. For a description of lambda expressions, see [Lambda Expressions in C++](../vs140/lambda-expressions-in-c--.md).  
  
## Function Objects vs. Lambdas  
 When you write code, you probably use function pointers and function objects to solve problems and perform calculations, especially when you use [STL algorithms](../vs140/algorithms--modern-c---.md). Function pointers and function objects each have advantages and disadvantages—for example, function pointers have minimal syntactic overhead but do not retain state within a scope, and function objects can maintain state but require the syntactic overhead of a class definition.  
  
 A lambda combines the benefits of function pointers and function objects and avoids their disadvantages. Like a function objects, a lambda is flexible and can maintain state, but unlike a function object, its compact syntax doesn't require an explicit class definition. By using lambdas, you can write code that's less cumbersome and less prone to errors than the code for an equivalent function object.  
  
 The following examples compare the use of a lambda to the use of a function object. The first example uses a lambda to print to the console whether each element in a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object is even or odd. The second example uses a function object to accomplish the same task.  
  
## Example 1: Using a Lambda  
 This example passes a lambda to the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function. The lambda prints a result that states whether each element in a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object is even or odd.  
  
### Code  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Output  
 **1 is odd**  
**2 is even**  
**3 is odd**  
**4 is even**  
**5 is odd**  
**6 is even**  
**7 is odd**  
**8 is even**  
**9 is odd**  
**There are 4 even numbers in the vector.**   
### Comments  
 In the example, the third argument to the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function is a lambda. The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> part specifies the capture clause of the expression, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> specifies the parameter list, and remaining part specifies the body of the expression.  
  
## Example 2: Using a Function Object  
 Sometimes a lambda would be too unwieldy to extend much further than the previous example. The next example uses a function object instead of a lambda, together with the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> function, to produce the same results as Example 1. Both examples store the count of even numbers in a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object. To maintain the state of the operation, the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> class stores the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> variable by reference as a member variable. To perform the operation, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> implements the function-call operator, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. The Visual C++ compiler generates code that is comparable in size and performance to the lambda code in Example 1. For a basic problem like the one in this article, the simpler lambda design is probably better than the function-object design. However, if you think that the functionality might require significant expansion in the future, then use a function object design so that code maintenance will be easier.  
  
 For more information about the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, see [Function Call (C++)](../vs140/function-call--c---.md). For more information about the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> function, see [for_each](../vs140/for_each.md).  
  
### Code  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
 **1 is odd**  
**2 is even**  
**3 is odd**  
**4 is even**  
**5 is odd**  
**6 is even**  
**7 is odd**  
**8 is even**  
**9 is odd**  
**There are 4 even numbers in the vector.**   
## See Also  
 [Lambda Expressions in C++](../vs140/lambda-expressions-in-c--.md)   
 [Examples of Lambda Expressions](../vs140/examples-of-lambda-expressions.md)   
 [generate](../vs140/generate.md)   
 [generate_n](../vs140/generate_n.md)   
 [for_each](../vs140/for_each.md)   
 [Exception Specifications](../vs140/exception-specifications--throw---c---.md)   
 [Compiler Warning (level 1) C4297](../vs140/compiler-warning--level-1--c4297.md)   
 [Microsoft-Specific Modifiers](../vs140/microsoft-specific-modifiers.md)