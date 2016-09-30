---
title: "constexpr (C++)"
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
  - "constexpr"
  - "constexpr_cpp"
dev_langs: 
  - "C++"
ms.assetid: c6458ccb-51c6-4a16-aa61-f69e6f4e04f7
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# constexpr (C++)
The keyword <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> was introduced in C++11 and improved in C++14. It means *constant expression*. Like <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, it can be applied to variables so that a compiler error will be raised if any code attempts to modify the value. Unlike <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> can also be applied to functions and class constructors. <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> indicates that the value, or return value, is constant and, if possible, will be computed at compile time.  A <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> integral value can be used wherever a const integer is required, such as in template arguments and array declarations. And when a value can be computed at compile time instead of run time, it can help your program can run faster and use less memory.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 One or more parameters which must be a literal type (as listed below) and must itself be a constant expression.  
  
## Return Value  
 A constexpr variable or function must return one of the literal types, as listed below.  
  
## Literal types  
 To limit the complexity of computing compile time constants, and their potential impacts of compilation time, the C++14 standard requires that the types involved in constant expressions be restricted to literal types. A literal type is one whose layout can be determined at compile time. The following are the literal types:  
  
1.  void  
  
2.  scalar types  
  
3.  references  
  
4.  Arrays of void, scalar types or references  
  
5.  A class that has a trivial destructor, and one or more constexpr constructors that are not move or copy constructors. Additionally, all its non-static data members and base classes must be literal types and not volatile.  
  
## constexpr variables  
 The primary difference between const and constexpr variables is that the initialization of a const variable can be deferred until run time whereas a constexpr variable must be initialized at compile time.  All constexpr variables are const.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## constexpr functions  
 A <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> function is one whose return value can be computed at compile when consuming code requires it.  A <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> function must accept and return only literal types. When its arguments are <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> values, and consuming code requires the return value at compile time, for example to initialize a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> variable or provide a non-type template argument, it produces a compile-time constant. When called with non-<CodeContentPlaceHolder>15\</CodeContentPlaceHolder> arguments, or when its value is not required at compile-time, it produces a value at run time like a regular function.  (This dual behavior saves you from having to write <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and non-<CodeContentPlaceHolder>17\</CodeContentPlaceHolder> versions of the same function.)  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
> [!TIP]
>  Note: In the Visual Studio debugger, you can tell whether a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> function is being evaluated at compile time by putting a breakpoint inside it. If the breakpoint is hit, the function was called at run-time.  If not, then the function was called at compile time.  
  
## General constexpr rules  
 For a function, variable, constructor or static data member to be defined as <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, it must meet certain requirements:  
  
-   A <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> function can be recursive. It cannot be [virtual](../vs140/virtual--c---.md), and its return type and parameter types must all be literal types. The body can be defined as <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. Otherwise it must follow these rules: it contains no <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> statements, try blocks, unitialized variables, or variable definitions that are not literal types, or that are static or thread-local. Additionally, a constructor cannot be defined as constexpr if the enclosing class has any virtual base classes.  
  
-   A variable can be declared with <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, if it has a literal type and is initialized. If the initialization is performed by a constructor, the constructor must be declared as <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
-   A reference may be declared as constexpr if the object that it references has been initialized by a constant expression and any implicit conversions that are invoked during initialization are also constant expressions.  
  
-   All declarations of a <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> variable or function must have the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> specifier.  
  
-   An explicit specialization of a non-constexpr template can be declared as <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>:  
  
-   An explicit specialization of a <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> template does not have to also be <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>:  
  
-   A <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> function or constructor is implicitly <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>.  
  
## Example  
 The following example shows <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> variables, functions and a user-defined type. Note that in the last statement in main(), the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> member function GetValue() is a run-time call because the value is not required to be known at compile time.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Requirements  
 Visual Studio 2015  
  
## See Also  
 [Declarations and definitions](../vs140/declarations-and-definitions--c---.md)   
 [const](../vs140/constexpr--c---.md)