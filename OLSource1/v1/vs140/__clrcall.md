---
title: "__clrcall"
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
  - "__clrcall"
  - "__clrcall_cpp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__clrcall keyword [C++]"
ms.assetid: 92096695-683a-40ed-bf65-0c8443572152
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __clrcall
**Microsoft Specific**  
  
 Specifies that a function can only be called from managed code.  Use <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> for all virtual functions that will only be called from managed code. However this calling convention cannot be used for functions that will be called from native code.  
  
 Use <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to improve performance when calling from a managed function to a virtual managed function or from managed function to managed function through pointer.  
  
 Entry points are separate, compiler-generated functions. If a function has both native and managed entry points, one of them will be the actual function with the function implementation. The other function will be a separate function (a thunk) that calls into the actual function and lets the common language runtime perform PInvoke. When marking a function as <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, you indicate the function implementation must be MSIL and that the native entry point function will not be generated.  
  
 When taking the address of a native function if <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is not specified, the compiler uses the native entry point. <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> indicates that the function is managed and there is no need to go through the transition from managed to native. In that case the compiler uses the managed entry point.  
  
 When **/clr** (not **/clr:pure** or **/clr:safe**) is used and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is not used, taking the address of a function always returns the address of the native entry point function. When <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is used, the native entry point function is not created, so you get the address of the managed function, not an entry point thunk function. For more information, see [Double Thunks](../vs140/double-thunking--c---.md).  
  
 [/clr (Common Language Runtime Compilation)](../vs140/-clr--common-language-runtime-compilation-.md) implies that all functions and function pointers are <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and the compiler will not permit a function inside the compiland to be marked anything other than <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. When **/clr:pure** is used, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> can only be specified on function pointers and external declarations.  
  
 You can directly call <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> functions from existing C++ code that was compiled by using **/clr** as long as that function has an MSIL implementation. <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> functions cannot be called directly from functions that have inline asm and call CPU-specific intrinisics, for example, even if those functions are compiled with **/clr**.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> function pointers are only meant to be used in the application domain in which they were created.  Instead of passing <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> function pointers across application domains, use \<xref:System.CrossAppDomainDelegate*>. For more information, see [Application Domains and Visual C++](../vs140/application-domains-and-visual-c--.md).  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 Note that when a function is declared with <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, code will be generated when needed; for example, when function is called.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **in Func1**  
**&Func1 != pf, comparison fails**  
**in Func1**  
**in Func1**   
## Example  
 The following sample shows that you can define a function pointer, such that, you declare that the function pointer will only be invoked from managed code. This allows the compiler to directly call the managed function and avoid the native entry point (double thunk issue).  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [Argument Passing and Naming Conventions](../vs140/argument-passing-and-naming-conventions.md)   
 [Keywords](../vs140/keywords--c---.md)