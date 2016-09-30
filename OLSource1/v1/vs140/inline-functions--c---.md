---
title: "Inline Functions (C++)"
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
  - "__forceinline_cpp"
  - "__inline_cpp"
  - "inline_cpp"
  - "__forceinline"
  - "__inline"
  - "inline"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "inline functions, class members"
ms.assetid: 355f120c-2847-4608-ac04-8dda18ffe10c
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Inline Functions (C++)
A function defined in the body of a class declaration is an inline function.  
  
## Example  
 In the following class declaration, the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> constructor is an inline function. The member functions <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> are not specified as **inline** but can be implemented as inline functions.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
> [!NOTE]
>  In the class declaration, the functions were declared without the **inline** keyword. The **inline** keyword can be specified in the class declaration; the result is the same.  
  
 A given inline member function must be declared the same way in every compilation unit. This constraint causes inline functions to behave as if they were instantiated functions. Additionally, there must be exactly one definition of an inline function.  
  
 A class member function defaults to external linkage unless a definition for that function contains the **inline** specifier. The preceding example shows that these functions need not be explicitly declared with the **inline** specifier; using **inline** in the function definition causes it to be an inline function. However, it is illegal to redeclare a function as **inline** after a call to that function.  
  
## Inline, __inline, and \__forceinline  
 The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> specifiers instruct the compiler to insert a copy of the function body into each place the function is called.  
  
 The insertion (called inline expansion or inlining) occurs only if the compiler's cost/benefit analysis show it to be profitable. Inline expansion alleviates the function-call overhead at the potential cost of larger code size.  
  
 The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> keyword overrides the cost/benefit analysis and relies on the judgment of the programmer instead. Exercise caution when using <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. Indiscriminate use of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> can result in larger code with only marginal performance gains or, in some cases, even performance losses (due to increased paging of a larger executable, for example).  
  
 Using inline functions can make your program faster because they eliminate the overhead associated with function calls. Functions expanded inline are subject to code optimizations not available to normal functions.  
  
 The compiler treats the inline expansion options and keywords as suggestions. There is no guarantee that functions will be inlined. You cannot force the compiler to inline a particular function, even with the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> keyword. When compiling with **/clr**, the compiler will not inline a function if there are security attributes applied to the function.  
  
 The **inline** keyword is available only in C++. The <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> keywords are available in both C and C++. For compatibility with previous versions, **_inline** is a synonym for <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
 The **inline** keyword tells the compiler that inline expansion is preferred. However, the compiler can create a separate instance of the function (instantiate) and create standard calling linkages instead of inserting the code inline. Two cases where this can happen are:  
  
-   Recursive functions.  
  
-   Functions that are referred to through a pointer elsewhere in the translation unit.  
  
 These reasons may interfere with inlining, *as may others*, at the discretion of the compiler; you should not depend on the **inline** specifier to cause a function to be inlined.  
  
 As with normal functions, there is no defined order of evaluation of the arguments to an inline function. In fact, it could be different from the order in which the arguments are evaluated when passed using normal function call protocol.  
  
 The [/Ob](../vs140/-ob--inline-function-expansion-.md) compiler optimization option helps to determine whether inline function expansion actually occurs.  
  
 [/LTCG](../vs140/-ltcg--link-time-code-generation-.md) performs cross-module inlining regardless of whether it was requested in source code.  
  
### Example 1  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A class's member functions can be declared inline either by using the **inline** keyword or by placing the function definition within the class definition.  
  
### Example 2  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Microsoft Specific  
 The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> keyword is equivalent to **inline**.  
  
 Even with <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, the compiler cannot inline code in all circumstances. The compiler cannot inline a function if:  
  
-   The function or its caller is compiled with /Ob0 (the default option for debug builds).  
  
-   The function and the caller use different types of exception handling (C++ exception handling in one, structured exception handling in the other).  
  
-   The function has a variable argument list.  
  
-   The function uses inline assembly, unless compiled with /Og, /Ox, /O1, or /O2.  
  
-   The function is recursive and not accompanied by **#pragma inline_recursion(on)**. With the pragma, recursive functions are inlined to a default depth of 16 calls. To reduce the inlining depth, use [inline_depth](../vs140/inline_depth.md) pragma.  
  
-   The function is virtual and is called virtually. Direct calls to virtual functions can be inlined.  
  
-   The program takes the address of the function and the call is made via the pointer to the function. Direct calls to functions that have had their address taken can be inlined.  
  
-   The function is also marked with the [naked](../vs140/naked--c---.md) [__declspec](../vs140/__declspec.md) modifier.  
  
 If the compiler cannot inline a function declared with <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, it generates a level 1 warning.  
  
 Recursive functions can be substituted inline to a depth specified by the [inline_depth](../vs140/inline_depth.md) pragma, up to a maximum of 16 calls. After that depth, recursive function calls are treated as calls to an instance of the function.  The depth to which recursive functions are examined by the inline heuristic cannot exceed 16. The [inline_recursion](../vs140/inline_recursion.md) pragma controls the inline expansion of a function currently under expansion. See the [Inline-Function Expansion](../vs140/-ob--inline-function-expansion-.md) (/Ob) compiler option for related information.  
  
### END Microsoft Specific  
 For more information on using the **inline** specifier, see:  
  
-   [Inline Class Member Functions](../vs140/inline-functions--c---.md)  
  
-   [Inline Functions versus Macros](../vs140/inline-functions-versus-macros.md)  
  
-   [When to Use Inline Functions](../vs140/when-to-use-inline-functions.md)  
  
-   [Defining Inline C++ Functions with dllexport and dllimport](../vs140/defining-inline-c---functions-with-dllexport-and-dllimport.md)  
  
## When to use inline functions  
 Inline functions are best used for small functions such as accessing private data members. The main purpose of these one- or two-line "accessor" functions is to return state information about objects; short functions are sensitive to the overhead of function calls. Longer functions spend proportionately less time in the calling/returning sequence and benefit less from inlining.  
  
 The <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> class, introduced in [Function-Call Results](../vs140/function-call-results.md) can be optimized as follows:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Assuming coordinate manipulation is a relatively common operation in a client of such a class, specifying the two accessor functions (<CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> in the preceding example) as **inline** typically saves the overhead on:  
  
-   Function calls (including parameter passing and placing the object's address on the stack)  
  
-   Preservation of caller's stack frame  
  
-   New stack-frame setup  
  
-   Return-value communication  
  
-   Old stack-frame restore  
  
-   Return  
  
## Inline functions vs. macros  
 Although inline functions are similar to macros (because the function code is expanded at the point of the call at compile time), inline functions are parsed by the compiler, whereas macros are expanded by the preprocessor. As a result, there are several important differences:  
  
-   Inline functions follow all the protocols of type safety enforced on normal functions.  
  
-   Inline functions are specified using the same syntax as any other function except that they include the **inline** keyword in the function declaration.  
  
-   Expressions passed as arguments to inline functions are evaluated once. In some cases, expressions passed as arguments to macros can be evaluated more than once.  
  
 The following example shows a macro that converts lowercase letters to uppercase:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The intent of the expression <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is that a character should be read from the console device (<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>) and, if necessary, converted to uppercase.  
  
 Because of the implementation of the macro, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is executed once to determine whether the character is greater than or equal to "a," and once to determine whether it is less than or equal to "z." If it is in that range, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is executed again to convert the character to uppercase. This means the program waits for two or three characters when, ideally, it should wait for only one.  
  
 Inline functions remedy the problem previously described:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 **Sample Input: <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>**   
**Sample Output: <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>**   
## See Also  
 [noinline](../vs140/noinline.md)   
 [auto_inline](../vs140/auto_inline.md)