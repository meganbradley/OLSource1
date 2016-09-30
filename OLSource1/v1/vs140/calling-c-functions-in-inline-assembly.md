---
title: "Calling C Functions in Inline Assembly"
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
  - "function calls, C functions"
  - "function calls, in inline assembly"
  - "functions [C], calling in inline assembly"
  - "Visual C, functions"
  - "inline assembly, calling functions"
  - "__asm keyword [C++], calling functions"
ms.assetid: f8a8d568-d175-4e23-9b24-36ef60a4cab3
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Calling C Functions in Inline Assembly
## Microsoft Specific  
 An <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> block can call C functions, including C library routines. The following example calls the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> library routine:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Because function arguments are passed on the stack, you simply push the needed arguments — string pointers, in the previous example — before calling the function. The arguments are pushed in reverse order, so they come off the stack in the desired order. To emulate the C statement  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 the example pushes pointers to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, in that order, and then calls <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 **END Microsoft Specific**  
  
## See Also  
 [Inline Assembler](../vs140/inline-assembler.md)