---
title: "Argument Passing and Naming Conventions"
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
  - "argument passing [C++], conventions"
  - "arguments [C++], widening"
  - "coding conventions, arguments"
  - "arguments [C++], passing"
  - "registers, return values"
  - "thiscall keyword [C++]"
  - "naming conventions [C++], arguments"
  - "arguments [C++], naming"
  - "passing arguments, conventions"
  - "conventions [C++], argument names"
ms.assetid: de468979-eab8-4158-90c5-c198932f93b9
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Argument Passing and Naming Conventions
**Microsoft Specific**  
  
 The Visual C++ compilers allow you to specify conventions for passing arguments and return values between functions and callers. Not all conventions are available on all supported platforms, and some conventions use platform-specific implementations. In most cases, keywords or compiler switches that specify an unsupported convention on a particular platform are ignored, and the platform default convention is used.  
  
 On x86 plaftorms, all arguments are widened to 32 bits when they are passed. Return values are also widened to 32 bits and returned in the EAX register, except for 8-byte structures, which are returned in the EDX:EAX register pair. Larger structures are returned in the EAX register as pointers to hidden return structures. Parameters are pushed onto the stack from right to left. Structures that are not PODs will not be returned in registers.  
  
 The compiler generates prolog and epilog code to save and restore the ESI, EDI, EBX, and EBP registers, if they are used in the function.  
  
> [!NOTE]
>  When a struct, union, or class is returned from a function by value, all definitions of the type need to be the same, else the program may fail at runtime.  
  
 For information on how to define your own function prolog and epilog code, see [Naked Function Calls](../vs140/naked-function-calls.md).  
  
 For information about the default calling conventions in code that targets x64 platforms, see [Overview of x64 Calling Conventions](../vs140/overview-of-x64-calling-conventions.md). For information about calling convention issues in code that targets ARM platforms, see [Common Visual C++ ARM Migration Issues](../vs140/common-visual-c---arm-migration-issues.md).  
  
 The following calling conventions are supported by the Visual C/C++ compiler.  
  
|Keyword|Stack cleanup|Parameter passing|  
|-------------|-------------------|-----------------------|  
|[__cdecl](../vs140/__cdecl.md)|Caller|Pushes parameters on the stack, in reverse order (right to left)|  
|[__clrcall](../vs140/__clrcall.md)|n/a|Load parameters onto CLR expression stack in order (left to right).|  
|[__stdcall](../vs140/__stdcall.md)|Callee|Pushes parameters on the stack, in reverse order (right to left)|  
|[__fastcall](../vs140/__fastcall.md)|Callee|Stored in registers, then pushed on stack|  
|[__thiscall](../vs140/__thiscall.md)|Callee|Pushed on stack; **this** pointer stored in ECX|  
|[__vectorcall](../vs140/__vectorcall.md)|Callee|Stored in registers, then pushed on stack in reverse order (right to left)|  
  
 For related information, see [Obsolete Calling Conventions](../vs140/obsolete-calling-conventions.md).  
  
 **END Microsoft Specific**  
  
## See Also  
 [Calling Conventions](../vs140/calling-conventions.md)