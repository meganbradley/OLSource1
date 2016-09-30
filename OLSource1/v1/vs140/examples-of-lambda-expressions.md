---
title: "Examples of Lambda Expressions"
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
  - "lambda expressions [C++], examples"
ms.assetid: 52506b15-0771-4190-a966-2f302049ca86
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Examples of Lambda Expressions
This article shows how to use lambda expressions in your programs. For an overview of lambda expressions, see [Lambda Expressions in C++](../vs140/lambda-expressions-in-c--.md). For more information about the structure of a lambda expression, see [Lambda Expression Syntax](../vs140/lambda-expression-syntax.md).  
  
##  \<a name="declaringLambdaExpressions">\</a> Declaring Lambda Expressions  
  
### Example 1  
 Because a lambda expression is typed, you can assign it to an <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> variable or to a [function](../vs140/function-class.md) object, as shown here:  
  
### Code  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Output  
 **5**  
**7**   
### Remarks  
 For more information, see [auto Keyword (Type Deduction)](../vs140/auto--c---.md), [function Class](../vs140/function-class.md), and [Function Call (C++)](../vs140/function-call--c---.md).  
  
 Although lambda expressions are most often declared in the body of a function, you can declare them anywhere that you can initialize a variable.  
  
### Example 2  
 The Visual C++ compiler binds a lambda expression to its captured variables when the expression is declared instead of when the expression is called. The following example shows a lambda expression that captures the local variable <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> by value and the local variable <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> by reference. Because the lambda expression captures <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> by value, the reassignment of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> later in the program does not affect the result of the expression. However, because the lambda expression captures <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> by reference, the reassignment of <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> does affect the result of the expression.  
  
### Code  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Output  
 **47** [[go to top](#top)]  
  
##  \<a name="callingLambdaExpressions">\</a> Calling Lambda Expressions  
 You can call a lambda expression immediately, as shown in the next code snippet. The second snippet shows how to pass a lambda as an argument to Standard Template Library (STL) algorithms such as <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
### Example 1  
 This example declares a lambda expression that returns the sum of two integers and calls the expression immediately with the arguments <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>:  
  
### Code  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Output  
 **9**   
### Example 2  
 This example passes a lambda expression as an argument to the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> function. The lambda expression returns <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> if its parameter is an even number.  
  
### Code  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Output  
 **The first even number in the list is 42.**   
### Remarks  
 For more information about the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> function, see [find_if](../vs140/find_if.md). For more information about the STL functions that perform common algorithms, see [\<algorithm>](../vs140/-algorithm-.md).  
  
 [[go to top](#top)]  
  
##  \<a name="nestingLambdaExpressions">\</a> Nesting Lambda Expressions  
  
### Example  
 You can nest a lambda expression inside another one, as shown in this example. The inner lambda expression multiplies its argument by 2 and returns the result. The outer lambda expression calls the inner lambda expression with its argument and adds 3 to the result.  
  
### Code  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Output  
 **13**   
### Remarks  
 In this example, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is the nested lambda expression.  
  
 [[go to top](#top)]  
  
##  \<a name="higherOrderLambdaExpressions">\</a> Higher-Order Lambda Functions  
  
### Example  
 Many programming languages support the concept of a *higher-order function.* A higher-order function is a lambda expression that takes another lambda expression as its argument or returns a lambda expression. You can use the [function](../vs140/function-class.md) class to enable a C++ lambda expression to behave like a higher-order function. The following example shows a lambda expression that returns a <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object and a lambda expression that takes a <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object as its argument.  
  
### Code  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Output  
 **30** [[go to top](#top)]  
  
##  \<a name="methodLambdaExpressions">\</a> Using a Lambda Expression in a Function  
  
### Example  
 You can use lambda expressions in the body of a function. The lambda expression can access any function or data member that the enclosing function can access. You can explicitly or implicitly capture the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> pointer to provide access to functions and data members of the enclosing class.  
  
 You can use the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> pointer explicitly in a function, as shown here:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 You can also capture the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> pointer implicitly:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The following example shows the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> class, which encapsulates a scale value.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Output  
 **3**  
**6**  
**9**  
**12**   
### Remarks  
 The <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> function uses a lambda expression to print the product of the scale value and each element in a <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> object. The lambda expression implicitly captures <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> so that it can access the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> member.  
  
 [[go to top](#top)]  
  
##  \<a name="templateLambdaExpressions">\</a> Using Lambda Expressions with Templates  
  
### Example  
 Because lambda expressions are typed, you can use them with C++ templates. The following example shows the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> functions. The <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> function applies the unary <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> to each element in the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> object. The <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> function prints each element in the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> object to the console.  
  
### Code  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Output  
 **34**  
**-43**  
**56**  
**After negate_all():**  
**-34**  
**43**  
**-56**   
### Remarks  
 For more information about C++ templates, see [Templates](../vs140/templates--c---.md).  
  
 [[go to top](#top)]  
  
##  \<a name="ehLambdaExpressions">\</a> Handling Exceptions  
  
### Example  
 The body of a lambda expression follows the rules for both structured exception handling (SEH) and C++ exception handling. You can handle a raised exception in the body of a lambda expression or defer exception handling to the enclosing scope. The following example uses the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> function and a lambda expression to fill a <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> object with the values of another one. It uses a <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>/<CodeContentPlaceHolder>46\</CodeContentPlaceHolder> block to handle invalid access to the first vector.  
  
### Code  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Output  
 **Caught 'invalid vector\<T> subscript'.**   
### Remarks  
 For more information about exception handling, see [Exception Handling in Visual C++](../vs140/exception-handling-in-visual-c--.md).  
  
 [[go to top](#top)]  
  
##  \<a name="managedLambdaExpressions">\</a> Using Lambda Expressions with Managed Types (C++/CLI)  
  
### Example  
 The capture clause of a lambda expression cannot contain a variable that has a managed type. However, you can pass an argument that has a managed type to the parameter list of a lambda expression. The following example contains a lambda expression that captures the local unmanaged variable <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> by value and takes a \<xref:System.String*?displayProperty=fullName> object as its parameter.  
  
### Code  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Output  
 **Hello!**   
### Remarks  
 You can also use lambda expressions with the STL/CLR library. For more information, see [STL/CLR Library Reference](../vs140/stl-clr-library-reference.md).  
  
> [!IMPORTANT]
>  Lambdas are not supported in these common language runtime (CLR) managed entities: <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>.  
  
 [[go to top](#top)]  
  
## See Also  
 [Lambda Expressions in C++](../vs140/lambda-expressions-in-c--.md)   
 [Lambda Expression Syntax](../vs140/lambda-expression-syntax.md)   
 [auto Keyword (Type Deduction)](../vs140/auto--c---.md)   
 [function Class](../vs140/function-class.md)   
 [find_if](../vs140/find_if.md)   
 [\<algorithm>](../vs140/-algorithm-.md)   
 [Function Call (C++)](../vs140/function-call--c---.md)   
 [Templates](../vs140/templates--c---.md)   
 [Exception Handling in Visual C++](../vs140/exception-handling-in-visual-c--.md)   
 [STL/CLR Library Reference](../vs140/stl-clr-library-reference.md)