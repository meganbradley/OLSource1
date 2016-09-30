---
title: "noinline"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "noinline"
  - "noinline_cpp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "noinline __declspec keyword"
  - "__declspec keyword [C++], noinline"
ms.assetid: f259d55b-dec7-4bde-8cf9-14521e4fdc42
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# noinline
## Microsoft Specific  
 **__declspec(noinline)** tells the compiler to never inline a particular member function (function in a class).  
  
 It may be worthwhile to not inline a function if it is small and not critical to the performance of your code. That is, if the function is small and not likely to be called often, such as a function that handles an error condition.  
  
 Keep in mind that if a function is marked <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, the calling function will be smaller and thus, itself a candidate for compiler inlining.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## END Microsoft Specific  
  
## See Also  
 [__declspec](../vs140/__declspec.md)   
 [Keywords](../vs140/keywords--c---.md)   
 [inline, __inline, \__forceinline](../vs140/inline--__inline--__forceinline.md)