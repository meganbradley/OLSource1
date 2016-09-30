---
title: "__thiscall"
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
  - "__thiscall"
  - "__thiscall_cpp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__thiscall keyword [C++]"
ms.assetid: a6a22dd2-0101-4885-b33b-22f6057965df
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __thiscall
## Microsoft Specific  
 The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> calling convention is used on member functions and is the default calling convention used by C++ member functions that do not use variable arguments. Under <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, the callee cleans the stack, which is impossible for <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> functions. Arguments are pushed on the stack from right to left, with the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> pointer being passed via register ECX, and not on the stack, on the x86 architecture.  
  
 One reason to use <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is in classes whose member functions use <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> by default. In that case, you can use <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to make individual member functions callable from native code.  
  
 When compiling with [/clr:pure](../vs140/-clr--common-language-runtime-compilation-.md), all functions and function pointers are <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> unless specified otherwise.  
  
 In releases before Visual C++ 2005, the thiscall calling convention could not be explicitly specified in a program, because <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> was not a keyword.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> member functions use the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> calling convention. All function arguments are pushed on the stack, with the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> pointer placed on the stack last  
  
 Because this calling convention applies only to C++, there is no C name decoration scheme.  
  
 On ARM and [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)] machines, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is accepted and ignored by the compiler.  
  
 For non-static class functions, if the function is defined out-of-line, the calling convention modifier does not have to be specified on the out-of-line definition. That is, for class non-static member methods, the calling convention specified during declaration is assumed at the point of definition.  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## END Microsoft Specific  
  
## See Also  
 [Argument Passing and Naming Conventions](../vs140/argument-passing-and-naming-conventions.md)