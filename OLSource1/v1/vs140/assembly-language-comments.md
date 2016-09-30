---
title: "Assembly-Language Comments"
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
  - "assembly language [C++], comments"
  - "comments [C++], assembly language"
  - "macros [C++], assembly language"
  - "__asm keyword [C++], instructions"
ms.assetid: 0dc10850-77f5-426e-9dab-185ea28e06e4
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Assembly-Language Comments
## Microsoft Specific  
 Instructions in an <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> block can use assembly-language comments:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Because C macros expand into a single logical line, avoid using assembly-language comments in macros. (See [Defining __asm Blocks as C Macros](../vs140/defining-__asm-blocks-as-c-macros.md).) An <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> block can also contain C-style comments; for more information, see [Using C or C++ in __asm Blocks](../vs140/using-c-or-c---in-__asm-blocks.md).  
  
 **END Microsoft Specific**  
  
## See Also  
 [Using Assembly Language in __asm Blocks](../vs140/using-assembly-language-in-__asm-blocks.md)