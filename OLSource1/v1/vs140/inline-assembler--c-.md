---
title: "Inline Assembler (C)"
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
  - "C"
helpviewer_keywords: 
  - "__asm keyword [C]"
  - "inline assembler [C]"
ms.assetid: 821acc77-60b1-434c-ba54-2ba930a25ab4
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Inline Assembler (C)
**Microsoft Specific**  
  
 The inline assembler lets you embed assembly-language instructions directly in your C source programs without extra assembly and link steps. The inline assembler is built into the compiler — you don't need a separate assembler such as the Microsoft Macro Assembler (MASM).  
  
 Because the inline assembler doesn't require separate assembly and link steps, it is more convenient than a separate assembler. Inline assembly code can use any C variable or function name that is in scope, so it is easy to integrate it with your program's C code. And because the assembly code can be mixed with C statements, it can do tasks that are cumbersome or impossible in C alone.  
  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> keyword invokes the inline assembler and can appear wherever a C statement is legal. It cannot appear by itself. It must be followed by an assembly instruction, a group of instructions enclosed in braces, or, at the very least, an empty pair of braces. The term "<CodeContentPlaceHolder>4\</CodeContentPlaceHolder> block" here refers to any instruction or group of instructions, whether or not in braces.  
  
 The code below is a simple <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> block enclosed in braces. (The code is a custom function prolog sequence.)  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Alternatively, you can put <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> in front of each assembly instruction:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Since the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> keyword is a statement separator, you can also put assembly instructions on the same line:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **END Microsoft Specific**  
  
## See Also  
 [Function Attributes](../vs140/function-attributes.md)