---
title: "Lambda Expressions in C++"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "lambda expressions [C++]"
  - "lambda expressions [C++], overview"
  - "lambda expressions [C++], vs. function objects"
ms.assetid: 713c7638-92be-4ade-ab22-fa33417073bf
caps.latest.revision: 38
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Lambda Expressions in C++
In C++11, a lambda expression—often called a *lambda*—is a convenient way of defining an anonymous function object right at the location where it is invoked or passed as an argument to a function. Typically lambdas are used to encapsulate a few lines of code that are passed to algorithms or asynchronous methods. This article defines what lambdas are, compares them to other programming techniques, describes their advantages, and provides a basic example.  
  
## Parts of a Lambda Expression  
 The ISO C++ Standard shows a simple lambda that is passed as the third argument to the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> function:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This illustration shows the parts of a lambda:  
  
 ![Structural elements of a lambda expression](../vs140/media/lambdaexpsyntax.png "LambdaExpSyntax")  
  
1.  *capture clause* (Also known as the *lambda-introducer* in the C++ specification.)  
  
2.  *parameter list* Optional. (Also known as the *lambda declarator*)  
  
3.  *mutable specification* Optional.  
  
4.  *exception-specification* Optional.  
  
5.  *trailing-return-type* Optional.  
  
6.  *lambda body*)  
  
### Capture Clause  
 A lambda can introduce new variables in its body (in **C++14**), and it can also access—or *capture*--variables from the surrounding scope. A lambda begins with the capture clause (*lambda-introducer* in the Standard syntax), which specifies which variables are captured, and whether the capture is by value or by reference. Variables that have the ampersand (<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>) prefix are accessed by reference and variables that do not have it are accessed by value.  
  
 An empty capture clause, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, indicates that the body of the lambda expression accesses no variables in the enclosing scope.  
  
 You can use the default capture mode (<CodeContentPlaceHolder>16\</CodeContentPlaceHolder> in the Standard syntax) to indicate how to capture any outside variables that are referenced in the lambda: [&] means all variables that you refer to are captured by reference, and [=] means they are captured by value. You can use a default capture mode, and then specify the opposite mode explicitly for specific variables. For example, if a lambda body accesses the external variable <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> by reference and the external variable <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> by value, then the following capture clauses are equivalent:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Only variables that are mentioned in the lambda are captured when a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is used.  
  
 If a capture clause includes a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, then no <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> in a <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> of that capture clause can have the form <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. Likewise, if the capture clause includes a <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, then no <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> of that capture clause can have the form <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>. An identifier or <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> cannot appear more than once in a capture clause. The following code snippet illustrates some examples.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> followed by an ellipsis is a pack expansion, as shown in this [variadic template](../vs140/ellipses-and-variadic-templates.md) example:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 To use lambda expressions in the body of a class method, pass the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> pointer to the capture clause to provide access to the methods and data members of the enclosing class. For an example that shows how to use lambda expressions with class methods, see "Example: Using a Lambda Expression in a Method" in [Examples of Lambda Expressions](../vs140/examples-of-lambda-expressions.md).  
  
 When you use the capture clause, we recommend that you keep these points in mind, particularly when you use lambdas with multithreading:  
  
-   Reference captures can be used to modify variables outside, but value captures cannot. (<CodeContentPlaceHolder>30\</CodeContentPlaceHolder> allows copies to be modified, but not originals.)  
  
-   Reference captures reflect updates to variables outside, but value captures do not.  
  
-   Reference captures introduce a lifetime dependency, but value captures have no lifetime dependencies. This is especially important when the lambda runs asynchronously. If you capture a local by reference in an async lambda, that local will very possibly be gone by the time the lambda runs, resulting in an access violation at run time.  
  
 **Generalized capture (C++ 14)**  
  
 In C++14, you can introduce and initialize new variables in the capture clause, without the need to have those variables exist in the lambda function’s enclosing scope. The initialization can be expressed as any arbitrary expression; the type of the new variable is deduced from the type produced by the expression. One benefit of this feature is that in C++14 you can capture move-only variables (such as std::unique_ptr) from the surrounding scope and use them in a lambda.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameter List  
 In addition to capturing variables, a lambda can accept input parameters. A parameter list (*lambda declarator* in the Standard syntax) is optional and in most aspects resembles the parameter list for a function.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 In **C++ 14**, if the parameter type is generic, you can use the auto keyword as the type specifier. This tells the compiler to create the function call operator as a template. Each instance of auto in a parameter list is equivalent to a distinct type parameter.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A lambda expression can take another lambda expression as its argument. For more information, see "Higher-Order Lambda Expressions" in the topic [Examples of Lambda Expressions](../vs140/examples-of-lambda-expressions.md).  
  
 Because a parameter list is optional, you can omit the empty parentheses if you do not pass arguments to the lambda expression and its <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> does not contain *exception-specification*, *trailing-return-type*, or <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>.  
  
### Mutable Specification  
 Typically, a lambda's function call operator is const-by-value, but use of the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> keyword cancels this out. It does not produce mutable data members. The mutable specification enables the body of a lambda expression to modify variables that are captured by value. Some of the examples later in this article show how to use <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.  
  
### Exception Specification  
 You can use the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> exception specification to indicate that the lambda expression does not throw any exceptions. As with ordinary functions, the Visual C++ compiler generates warning [C4297](../vs140/compiler-warning--level-1--c4297.md) if a lambda expression declares the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> exception specification and the lambda body throws an exception, as shown here:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 For more information, see [Exception Specifications](../vs140/exception-specifications--throw---c---.md).  
  
### Return Type  
 The return type of a lambda expression is automatically deduced. You don't have to use the [auto](../vs140/auto--c---.md) keyword unless you specify a *trailing-return-type*. The *trailing-return-type* resembles the return-type part of an ordinary method or function. However, the return type must follow the parameter list, and you must include the trailing-return-type keyword <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> before the return type.  
  
 You can omit the return-type part of a lambda expression if the lambda body contains just one return statement or the expression does not return a value. If the lambda body contains one return statement, the compiler deduces the return type from the type of the return expression. Otherwise, the compiler deduces the return type to be <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>. Consider the following example code snippets that illustrate this principle.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 A lambda expression can produce another lambda expression as its return value. For more information, see "Higher-Order Lambda Expressions" in [Examples of Lambda Expressions](../vs140/examples-of-lambda-expressions.md).  
  
### Lambda Body  
 The lambda body (*compound-statement* in the Standard syntax) of a lambda expression can contain anything that the body of an ordinary method or function can contain. The body of both an ordinary function and a lambda expression can access these kinds of variables:  
  
-   Captured variables from the enclosing scope, as described previously.  
  
-   Parameters  
  
-   Locally-declared variables  
  
-   Class data members, when declared inside a class and <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> is captured  
  
-   Any variable that has static storage duration—for example, global variables  
  
 The following example contains a lambda expression that explicitly captures the variable <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> by value and implicitly captures the variable <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> by reference:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 **Output:**  
  
 **5**  
**0** Because the variable <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> is captured by value, its value remains <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> after the call to the lambda expression. The <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> specification allows <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> to be modified within the lambda.  
  
 Although a lambda expression can only capture variables that have automatic storage duration, you can use variables that have static storage duration in the body of a lambda expression. The following example uses the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> function and a lambda expression to assign a value to each element in a <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> object. The lambda expression modifies the static variable to generate the value of the next element.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 For more information, see [generate](../vs140/generate.md).  
  
 The following code example uses the function from the previous example, and adds an example of a lambda expression that uses the STL algorithm <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>. This lambda expression assigns an element of a <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> object to the sum of the previous two elements. The <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> keyword is used so that the body of the lambda expression can modify its copies of the external variables <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>, which the lambda expression captures by value. Because the lambda expression captures the original variables <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> by value, their values remain <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> after the lambda executes.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 **Output:**  
  
 **vector v after call to generate_n() with lambda: 1 1 2 3 5 8 13 21 34**  
**x: 1 y: 1**  
**vector v after 1st call to fillVector(): 1 2 3 4 5 6 7 8 9**  
**vector v after 2nd call to fillVector(): 10 11 12 13 14 15 16 17 18** For more information, see [generate_n](../vs140/generate_n.md).  
  
## Microsoft-Specific  
 Lambdas are not supported in the following common language runtime (CLR) managed entities: <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>.  
  
 If you are using a Microsoft-specific modifier such as [__declspec](../vs140/__declspec.md), you can insert it into a lambda expression immediately after the <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>—for example:  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 To determine whether a modifier is supported by lambdas, see the article about it in the [Microsoft-Specific Modifiers](../vs140/microsoft-specific-modifiers.md) section of the documentation.  
  
 Visual Studio supports C++11 Standard lambda expression syntax and functionality, with these exceptions:  
  
-   Like all other classes, lambdas don't get automatically generated move constructors and move assignment operators. For more information about support for rvalue reference behaviors, see the "Rvalue References" section in [Support For C++11 Features](../vs140/support-for-c--11-14-17-features--modern-c---.md).  
  
-   The optional *attribute-specifier-seq* is not supported in this version.  
  
 Visual Studio includes these features in addition to C++11 Standard lambda functionality:  
  
-   Stateless lambdas, which are omni-convertible to function pointers that use arbitrary calling conventions.  
  
-   Automatically deduced return types for lambda bodies that are more complicated than <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>, as long as all return statements have the same type. (This functionality is part of the proposed C++14 Standard.)  
  
## See Also  
 [C++ Language Reference](../vs140/c---language-reference.md)   
 [Function Objects](../vs140/function-objects-in-the-stl.md)   
 [Function Call (C++)](../vs140/function-call--c---.md)   
 [for_each](../vs140/for_each.md)