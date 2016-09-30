---
title: "Inline Assembler Overview"
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
  - "inline assembler"
  - "__asm keyword [C++], invoking inline assembler"
  - "invoking inline assembler"
  - "inline assembly, inline assembler"
ms.assetid: d990331a-0e33-4760-8d7a-b720b0288335
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Inline Assembler Overview
**Microsoft Specific**  
  
 The inline assembler lets you embed assembly-language instructions in your C and C++ source programs without extra assembly and link steps. The inline assembler is built into the compiler — you don't need a separate assembler such as the Microsoft Macro Assembler (MASM).  
  
 Because the inline assembler doesn't require separate assembly and link steps, it is more convenient than a separate assembler. Inline assembly code can use any C or C++ variable or function name that is in scope, so it is easy to integrate it with your program's C and C++ code. And because the assembly code can be mixed with C and C++ statements, it can do tasks that are cumbersome or impossible in C or C++ alone.  
  
 The [__asm](../vs140/__asm.md) keyword invokes the inline assembler and can appear wherever a C or C++ statement is legal. It cannot appear by itself. It must be followed by an assembly instruction, a group of instructions enclosed in braces, or, at the very least, an empty pair of braces. The term "<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> block" here refers to any instruction or group of instructions, whether or not in braces.  
  
 The following code is a simple <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> block enclosed in braces. (The code is a custom function prolog sequence.)  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Alternatively, you can put <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> in front of each assembly instruction:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Since the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> keyword is a statement separator, you can also put assembly instructions on the same line:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **END Microsoft Specific**  
  
## See Also  
 [Inline Assembler](../vs140/inline-assembler.md)