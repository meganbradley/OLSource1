---
title: "noalias"
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
  - "noalias"
  - "noalias_cpp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "noalias __declspec keyword"
  - "__declspec keyword [C++], noalias"
ms.assetid: efafa8b0-7f39-4edc-a81e-d287ae882c9b
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# noalias
**Microsoft Specific**  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> means that a function call does not modify or reference visible global state and only modifies the memory pointed to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> by pointer parameters (first-level indirections).  
  
 If a function is annotated as <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, the optimizer can assume that, in addition to the parameters themselves, only first-level indirections of pointer parameters are referenced or modified inside the function. The visible global state is the set of all data that is not defined or referenced outside of the compilation scope, and their address is not taken. The compilation scope is all source files ([/LTCG (Link-time Code Generation)](../vs140/-ltcg--link-time-code-generation-.md) builds) or a single source file (non-**/LTCG** build).  
  
## Example  
 The following sample demonstrates using <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. Normally, memory returned from <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> because the CRT headers are decorated appropriately.  
  
 However, in this example, the pointers <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> are global so the compiler has no assurance that the memory is not subject to aliasing. Decorating the functions that return pointers with <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> tells the compiler that the memory pointed to by the return value is not aliased.  
  
 Decorating the function in the example that accesses memory with <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> tells the compiler that this function does not interfere with the global state except through the pointers in its parameter list.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [__declspec](../vs140/__declspec.md)   
 [Keywords](../vs140/keywords--c---.md)