---
title: "Fatal Error C1060"
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
  - "C1060"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C1060"
ms.assetid: feaf305c-c84c-4160-b974-50e283412849
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Fatal Error C1060
compiler is out of heap space  
  
 The operating system or run-time library cannot fill a request for memory.  
  
### To fix this error try the following possible solutions  
  
1.  If the compiler also issues errors [C1076](../vs140/fatal-error-c1076.md) and [C3859](../vs140/compiler-error-c3859.md), use the [/Zm](../vs140/-zm--specify-precompiled-header-memory-allocation-limit-.md) compiler option to lower the memory allocation limit. More heap space is available to your application if you lower the remaining memory allocation.  
  
     If the [/Zm](../vs140/-zm--specify-precompiled-header-memory-allocation-limit-.md) option is already set, try removing it. Heap space might be exhausted because the memory allocation limit specified in the option is too high. The compiler uses a default limit if you remove the [/Zm](../vs140/-zm--specify-precompiled-header-memory-allocation-limit-.md) option.  
  
2.  If you are compiling on a 64-bit platform, use the 64-bit compiler toolset. For information, see [How to: Enable a 64-Bit Visual C++ Toolset on the Command Line](../vs140/how-to--enable-a-64-bit-visual-c---toolset-on-the-command-line.md).  
  
3.  On 32-bit Windows, try using the [/3GB](http://go.microsoft.com/fwlink/?LinkId=177831) boot.ini switch.  
  
4.  Increase the size of the Windows swap-file.  
  
5.  Close other running programs.  
  
6.  Eliminate unnecessary include files.  
  
7.  Eliminate unnecessary global variables, for example, by allocating memory dynamically instead of declaring a large array.  
  
8.  Eliminate unused declarations.  
  
9. Split the current file into smaller files.