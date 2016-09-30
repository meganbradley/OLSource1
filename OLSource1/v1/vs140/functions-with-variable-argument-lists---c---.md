---
title: "Functions with Variable Argument Lists  (C++)"
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
  - "arguments [C++], variable number of"
  - "variable argument lists"
  - "declarators, functions"
  - "argument lists [C++], variable number of"
  - "declaring functions, variables"
  - "function calls, variable number of arguments"
ms.assetid: 27c2f83a-21dd-44c6-913c-2834cb944703
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Functions with Variable Argument Lists  (C++)
Function declarations in which the last member of  is the ellipsis (...) can take a variable number of arguments. In these cases, C++ provides type checking only for the explicitly declared arguments. You can use variable argument lists when you need to make a function so general that even the number and types of arguments can vary. The  family of functions is an example of functions that use variable argument lists.<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>*argument-declaration-list*  
  
## Functions with variable arguments  
 To access arguments after those declared, use the macros contained in the standard include file STDARG.H as described below.  
  
 **Microsoft Specific**  
  
 Microsoft C++ allows the ellipsis to be specified as an argument if the ellipsis is the last argument and the ellipsis is preceded by a comma. Therefore, the declaration <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is legal, but <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is not.  
  
 **END Microsoft Specific**  
  
 Declaration of a function that takes a variable number of arguments requires at least one placeholder argument, even if it is not used. If this placeholder argument is not supplied, there is no way to access the remaining arguments.  
  
 When arguments of type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> are passed as variable arguments, they are converted to type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. Similarly, when arguments of type **float** are passed as variable arguments, they are converted to type **double**. Arguments of other types are subject to the usual integral and floating-point promotions. See [Integral Promotions](../vs140/integral-promotions.md) for more information.  
  
 Functions that require variable lists are declared by using the ellipsis (...) in the argument list. Use the types and macros that are described in the STDARG.H include file to access arguments that are passed by a variable list. For more information about these macros, see [va_arg, va_copy, va_end, va_start](../vs140/va_arg--va_copy--va_end--va_start.md). in the documentation for the C Run-Time Library.  
  
 The following example shows how the macros work together with the  type (declared in STDARG.H): <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The previous example illustrates these important concepts:  
  
1.  You must establish a list marker as a variable of type <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> before any variable arguments are accessed. In the previous example, the marker is called <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
2.  The individual arguments are accessed by using the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> macro. You must tell the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> macro the type of argument to retrieve so that it can transfer the correct number of bytes from the stack. If you specify an incorrect type of a size different from that supplied by the calling program to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, the results are unpredictable.  
  
3.  You should explicitly cast the result obtained by using the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> macro to the type that you want.  
  
 You must call the  macro to terminate variable-argument processing.<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>