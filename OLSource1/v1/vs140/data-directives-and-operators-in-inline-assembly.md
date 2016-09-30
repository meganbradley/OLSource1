---
title: "Data Directives and Operators in Inline Assembly"
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
  - "data directives [C++]"
  - "__asm keyword [C++], referencing limitations"
  - "MASM (Microsoft Macro Assembler), directives"
  - "directives [C++], MASM"
  - "MASM (Microsoft Macro Assembler), structures"
  - "operators [MASM]"
  - "inline assembly, operators"
  - "inline assembly, data directives"
  - "MASM (Microsoft Macro Assembler), operators"
  - "structures [C++], MASM"
ms.assetid: fb7410c7-156a-4131-bcfc-211aa70533e3
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Data Directives and Operators in Inline Assembly
## Microsoft Specific  
 Although an <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> block can reference C or C++ data types and objects, it cannot define data objects with MASM directives or operators. Specifically, you cannot use the definition directives **DB**, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, **DD**, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, or the operators <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or **THIS**. MASM structures and records are also unavailable. The inline assembler doesn't accept the directives <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, **WIDTH**, or **MASK**.  
  
 **END Microsoft Specific**  
  
## See Also  
 [Using Assembly Language in __asm Blocks](../vs140/using-assembly-language-in-__asm-blocks.md)