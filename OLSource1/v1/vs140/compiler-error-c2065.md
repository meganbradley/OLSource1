---
title: "Compiler Error C2065"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "C2065"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2065"
ms.assetid: 78093376-acb7-45f5-9323-5ed7e0aab1dc
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2065
'identifier' : undeclared identifier  
  
 A variable's type must be specified in a declaration before it can be used. The parameters that a function uses must be specified in a declaration, or prototype, before the function can be used.  
  
 Possible causes:  
  
1.  Identifier name is misspelled.  
  
2.  Identifier uses the wrong uppercase and lowercase letters.  
  
3.  Missing closing quote after a string constant.  
  
4.  You are compiling with a debug version of the C runtime, declaring a Standard C++ Library iterator variable in a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> loop, and then trying to use that iterator variable outside the scope of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> loop. Compiling C++ Standard Library code with a debug version of the C runtime implies [/Zc:forScope](../vs140/-zc-forscope--force-conformance-in-for-loop-scope-.md).  See [Debug Iterator Support](../vs140/debug-iterator-support.md) for more information.  
  
5.  You may be calling a function in an SDK header file that is currently not supported in your build environment.  
  
6.  Omitting necessary include files, especially if you define <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. These symbols exclude some header files from windows.h and afxv_w32.h to speed compiles. (Look in windows.h and afxv_w32.h for an up-to-date description of what's excluded.)  
  
7.  Improper namespace scope. For example, to resolve C++ Standard Library functions and operators that are not fully qualified, you must specify the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> namespace with the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> directive. The following example fails to compile because the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> directive is commented out and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is defined in the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> namespace:  
  
## Example  
 The following sample generates C2065 and shows how to fix it.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 When calling a generic function, if the intended type argument cannot be deduced from the parameters used, the compiler will report an error. For more information, see [Generic Functions](../vs140/generic-functions--c---cli-.md).  
  
 The following sample generates C2065 and shows how to fix it.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 This error can also be generated as a result of compiler conformance work that was done for Visual C++ 2005: parameter checking for Visual C++ attributes.  
  
 The following sample generates C2065 and shows how to fix it.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>