---
title: "Using Operators in __asm Blocks"
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
  - "brackets [ ]"
  - "brackets [ ], __asm blocks"
  - "__asm keyword [C++], operators"
  - "square brackets [ ], __asm blocks"
  - "operators [C++], using in __asm blocks"
  - "square brackets [ ]"
ms.assetid: a26ccfd4-40ae-4a61-952f-c417982aa8dd
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using Operators in __asm Blocks
## Microsoft Specific  
 An <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> block cannot use C or C++ specific operators, such as the **<<** operator. However, operators shared by C and MASM, such as the \* operator, are interpreted as assembly-language operators. For instance, outside an <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> block, square brackets (**[ ]**) are interpreted as enclosing array subscripts, which C automatically scales to the size of an element in the array. Inside an <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> block, they are seen as the MASM index operator, which yields an unscaled byte offset from any data object or label (not just an array). The following code illustrates the difference:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The first reference to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is not scaled, but the second is. Note that you can use the **TYPE** operator to achieve scaling based on a constant. For example, the following statements are equivalent:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **END Microsoft Specific**  
  
## See Also  
 [Using C or C++ in __asm Blocks](../vs140/using-c-or-c---in-__asm-blocks.md)