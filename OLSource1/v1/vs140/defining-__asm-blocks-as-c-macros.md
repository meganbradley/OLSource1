---
title: "Defining __asm Blocks as C Macros"
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
  - "macros, __asm blocks"
  - "Visual C, macros"
  - "__asm keyword [C++], as C macros"
ms.assetid: 677ba11c-21c8-4609-bba7-cd47312243b0
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Defining __asm Blocks as C Macros
**Microsoft Specific**  
  
 C macros offer a convenient way to insert assembly code into your source code, but they demand extra care because a macro expands into a single logical line. To create trouble-free macros, follow these rules:  
  
-   Enclose the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> block in braces.  
  
-   Put the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> keyword in front of each assembly instruction.  
  
-   Use old-style C comments ( <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>) instead of assembly-style comments ( <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>) or single-line C comments ( <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>).  
  
 To illustrate, the following example defines a simple macro:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 At first glance, the last three <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> keywords seem superfluous. They are needed, however, because the macro expands into a single line:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The third and fourth <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> keywords are needed as statement separators. The only statement separators recognized in <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> blocks are the newline character and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> keyword. Because a block defined as a macro is one logical line, you must separate each instruction with <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 The braces are essential as well. If you omit them, the compiler can be confused by C or C++ statements on the same line to the right of the macro invocation. Without the closing brace, the compiler cannot tell where assembly code stops, and it sees C or C++ statements after the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> block as assembly instructions.  
  
 Assembly-style comments that start with a semicolon (**;**) continue to the end of the line. This causes problems in macros because the compiler ignores everything after the comment, all the way to the end of the logical line. The same is true of single-line C or C++ comments ( <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>). To prevent errors, use old-style C comments ( <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>) in <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> blocks defined as macros.  
  
 An <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> block written as a C macro can take arguments. Unlike an ordinary C macro, however, an <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> macro cannot return a value. So you cannot use such macros in C or C++ expressions.  
  
 Be careful not to invoke macros of this type indiscriminately. For instance, invoking an assembly-language macro in a function declared with the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> convention may cause unexpected results. (See [Using and Preserving Registers in Inline Assembly](../vs140/using-and-preserving-registers-in-inline-assembly.md).)  
  
 **END Microsoft Specific**  
  
## See Also  
 [Inline Assembler](../vs140/inline-assembler.md)