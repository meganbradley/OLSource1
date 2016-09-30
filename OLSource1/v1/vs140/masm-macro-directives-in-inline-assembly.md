---
title: "MASM Macro Directives in Inline Assembly"
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
  - "directives, macros"
  - "inline assembly, macro directives"
  - "macros, directives"
  - "MASM (Microsoft Macro Assembler), inline assembly macro directives"
ms.assetid: 83643a09-1699-40a8-8ef2-13502bc4ac2c
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MASM Macro Directives in Inline Assembly
## Microsoft Specific  
 The inline assembler is not a macro assembler. You cannot use MASM macro directives (**MACRO**, <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>, **IRC**, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>) or macro operators (**<>**, **!**, **&**, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>). An <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> block can use C preprocessor directives, however. See [Using C or C++ in __asm Blocks](../vs140/using-c-or-c---in-__asm-blocks.md) for more information.  
  
 **END Microsoft Specific**  
  
## See Also  
 [Using Assembly Language in __asm Blocks](../vs140/using-assembly-language-in-__asm-blocks.md)