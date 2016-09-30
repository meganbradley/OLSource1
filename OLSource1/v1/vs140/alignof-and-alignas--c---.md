---
title: "alignof and alignas (C++)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
ms.assetid: 1d18aa8a-9621-4fb5-86e5-4cc86d5187f4
caps.latest.revision: 6
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# alignof and alignas (C++)
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> type specifier is a portable, C++ standard way to specify custom alignment of variables and user defined types. The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> operator is likewise a standard, portable way to obtain the alignment of a specified type or variable.  
  
## Example  
 You can use <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> on a class, struck or union, or on individual members. When multiple <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> specifiers are encountered, the compiler will choose the strictest one, (the one with the largest value).  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Alignment (C++ Declarations)](../vs140/alignment--c---declarations-.md)