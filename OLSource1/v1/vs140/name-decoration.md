---
title: "Name Decoration"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "name decoration [C++]"
  - "names [C++], decorated"
  - "decorated names, calling conventions"
ms.assetid: 8327a27b-bb4f-49f2-8218-b851b9d2a463
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Name Decoration
Name decoration usually refers to C++ naming conventions, but can apply to a number of C cases as well. By default, C++ uses the function name, parameters, and return type to create a linker name for the function. Consider the following function:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The following table shows the linker name for various calling conventions.  
  
|Calling convention|extern "C" or .c file|.cpp, .cxx or /TP|  
|------------------------|---------------------------|------------------------|  
|C naming convention (<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>)|_test|?test@@ZAXXZ|  
|Fastcall naming convention (<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>)|@test@0|?test@@YIXXZ|  
|Standard Call naming convention (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>)|_test@0|?test@@YGXXZ|  
|Vectorcall naming convention (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>)|test@@0|?test@@YQXXZ|  
  
 Use extern "C" to call a C function from C++. Extern "C" forces use of the C naming convention for non-class C++ functions. Be aware of compiler switches **/Tc** or **/Tp**, which tell the compiler to ignore the filename extension and compile the file as C or C++, respectively. These options may cause names you do not expect.  
  
 Having function prototypes that have mismatched parameters can also cause this error. Name decoration incorporates the parameters of a function into the final decorated function name. Calling a function with the parameter types that do not match those in the function declaration may also cause LNK2001.  
  
 There is currently no standard for C++ naming between compiler vendors or even between different versions of a compiler. Therefore linking object files compiled with other compilers may not produce the same naming scheme and thus causes unresolved externals.  
  
## See Also  
 [Linker Tools Error LNK2001](../vs140/linker-tools-error-lnk2001.md)