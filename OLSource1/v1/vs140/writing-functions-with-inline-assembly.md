---
title: "Writing Functions with Inline Assembly"
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
  - "functions [C++], inline assembly"
  - "inline assembly [C++], writing functions"
  - "assembler [C++], writing functions"
  - "__asm keyword [C++], in functions"
ms.assetid: b5df8a04-fdc7-4622-8c9e-e4b618927497
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Writing Functions with Inline Assembly
## Microsoft Specific  
 If you write a function with inline assembly code, it's easy to pass arguments to the function and return a value from it. The following examples compare a function first written for a separate assembler and then rewritten for the inline assembler. The function, called <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, receives two parameters, multiplying the first parameter by 2 to the power of the second parameter. Written for a separate assembler, the function might look like this:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Since it's written for a separate assembler, the function requires a separate source file and assembly and link steps. C and C++ function arguments are usually passed on the stack, so this version of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function accesses its arguments by their positions on the stack. (Note that the **MODEL** directive, available in MASM and some other assemblers, also allows you to access stack arguments and local stack variables by name.)  
  
## Example  
 This program writes the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> function with inline assembly code:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The inline version of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function refers to its arguments by name and appears in the same source file as the rest of the program. This version also requires fewer assembly instructions.  
  
 Because the inline version of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> doesn't execute a C <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> statement, it causes a harmless warning if you compile at warning level 2 or higher. The function does return a value, but the compiler cannot tell that in the absence of a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> statement. You can use [#pragma warning](../vs140/warning.md) to disable the generation of this warning.  
  
 **END Microsoft Specific**  
  
## See Also  
 [Using C or C++ in __asm Blocks](../vs140/using-c-or-c---in-__asm-blocks.md)