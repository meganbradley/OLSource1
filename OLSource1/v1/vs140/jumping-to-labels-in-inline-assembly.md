---
title: "Jumping to Labels in Inline Assembly"
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
  - "inline assembly, jumping to labels"
  - "labels, in inline assembly"
  - "__asm keyword [C++], labels"
  - "case sensitivity, labels in inline assembly"
  - "labels, in __asm blocks"
  - "jumping to labels in inline assembly"
ms.assetid: 36c18b97-8981-4631-9dfd-af6c14a04297
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Jumping to Labels in Inline Assembly
## Microsoft Specific  
 Like an ordinary C or C++ label, a label in an <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> block has scope throughout the function in which it is defined (not only in the block). Both assembly instructions and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> statements can jump to labels inside or outside the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> block.  
  
 Labels defined in <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> blocks are not case sensitive; both <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> statements and assembly instructions can refer to those labels without regard to case. C and C++ labels are case sensitive only when used by <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> statements. Assembly instructions can jump to a C or C++ label without regard to case.  
  
 The following code shows all the permutations:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Don't use C library function names as labels in <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> blocks. For instance, you might be tempted to use <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> as a label, as follows:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Because **exit** is the name of a C library function, this code might cause a jump to the **exit** function instead of to the desired location.  
  
 As in MASM programs, the dollar symbol (<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>) serves as the current location counter. It is a label for the instruction currently being assembled. In <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> blocks, its main use is to make long conditional jumps:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **END Microsoft Specific**  
  
## See Also  
 [Inline Assembler](../vs140/inline-assembler.md)