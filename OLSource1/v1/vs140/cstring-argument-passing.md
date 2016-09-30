---
title: "CString Argument Passing"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "strings [C++], as function input/output"
  - "argument passing [C++]"
  - "arguments [C++], passing"
  - "functions [C++], strings as input/output"
  - "argument passing [C++], C strings"
  - "passing arguments, C strings"
  - "CString objects, passing arguments"
  - "string arguments"
ms.assetid: a67bebff-edf1-4cf4-bbff-d1cc6a901099
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CString Argument Passing
This article explains how to pass [CString](../vs140/cstringt-class.md) objects to functions and how to return <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> objects from functions.  
  
##  \<a name="_core_cstring_argument.2d.passing_conventions">\</a> CString Argument-Passing Conventions  
 When you define a class interface, you must determine the argument-passing convention for your member functions. There are some standard rules for passing and returning <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> objects. If you follow the rules described in [Strings as Function Inputs](#_core_strings_as_function_inputs) and [Strings as Function Outputs](#_core_strings_as_function_outputs), you will have efficient, correct code.  
  
##  \<a name="_core_strings_as_function_inputs">\</a> Strings as Function Inputs  
 The most efficient and secure way to use a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object in called functions is to pass a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object to the function. Despite the name, a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object does not store a string internally as a C-style string that has a null terminator. Instead, a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object keeps careful track of the number of characters it has. Having <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> provide a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> pointer to a null-terminated string is a small amount of work that can become significant if your code has to do it constantly. The result is temporary because any change to the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> contents invalidates old copies of the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> pointer.  
  
 It does make sense in some cases to provide a C-style string. For example, there can be a situation where a called function is written in C and does not support objects. In this case, coerce the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> parameter to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, and the function will get a C-style null-terminated string. You can also go the other direction and create a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object by using the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> constructor that accepts a C-style string parameter.  
  
 If the string contents are to be changed by a function, declare the parameter as a nonconstant <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> reference (**CString&**).  
  
##  \<a name="_core_strings_as_function_outputs">\</a> Strings as Function Outputs  
 Typically you can return <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> objects from functions because <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> objects follow value semantics like primitive types. To return a read-only string, use a constant <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> reference (**const CString&**). The following example illustrates the use of <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> parameters and return types:  
  
 [!code[NVC_ATLMFC_Utilities#197](../vs140/codesnippet/CPP/cstring-argument-passing_1.cpp)]  
  
 [!code[NVC_ATLMFC_Utilities#198](../vs140/codesnippet/CPP/cstring-argument-passing_2.cpp)]  
  
## See Also  
 [Strings (ATL/MFC)](../vs140/strings--atl-mfc-.md)