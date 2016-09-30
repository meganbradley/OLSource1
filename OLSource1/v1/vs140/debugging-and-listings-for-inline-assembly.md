---
title: "Debugging and Listings for Inline Assembly"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "source level debugger"
  - "__asm keyword [C++], debugging"
  - "inline assembly, listings"
  - "bugs, __asm blocks"
  - "debugging [C++], inline assembly code"
  - "inline assembly, debugging"
ms.assetid: 69266930-6f9a-433d-b704-f4f44e7b2583
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Debugging and Listings for Inline Assembly
## Microsoft Specific  
 Programs containing inline assembly code can be debugged with a source-level debugger if you compile with the [/Zi](../vs140/-z7---zi---zi--debug-information-format-.md) option.  
  
 Within the debugger, you can set breakpoints on both C or C++ and assembly-language lines. If you enable mixed assembly and source mode, you can display both the source and disassembled form of the assembly code.  
  
 Note that putting multiple assembly instructions or source language statements on one line can hamper debugging. In source mode, you can use the debugger to set breakpoints on a single line but not on individual statements on the same line. The same principle applies to an <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> block defined as a C macro, which expands to a single logical line.  
  
 If you create a mixed source and assembly listing with the [/FAs](../vs140/-fa---fa--listing-file-.md) compiler option, the listing contains both the source and assembly forms of each assembly-language line. Macros are not expanded in listings, but they are expanded during compilation.  
  
 **END Microsoft Specific**  
  
## See Also  
 [Using Assembly Language in __asm Blocks](../vs140/using-assembly-language-in-__asm-blocks.md)