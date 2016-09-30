---
title: "C-Style Casts with -clr (C++-CLI)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
H1: "C-Style Casts with /clr (C++/CLI)"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C-style casts and /clr"
ms.assetid: d2a4401a-156a-4da9-8d12-923743e26913
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# C-Style Casts with -clr (C++-CLI)
The following topic applies only to the Common Language Runtime.  
  
 When used with CLR types, the compiler attempts to map C-style cast to one of the casts listed below, in the following order:  
  
1.  const_cast  
  
2.  safe_cast  
  
3.  safe_cast plus const_cast  
  
4.  static_cast  
  
5.  static_cast plus const_cast  
  
 If none of the casts listed above is valid, and if the type of the expression and the target type are CLR reference types, C-style cast maps to a runtime-check (castclass MSIL instruction). Otherwise, a C-style cast is considered invalid and the compiler issues an error.  
  
## Remarks  
 A C-style cast is not recommended. When compiling with [/clr (Common Language Runtime Compilation)](../vs140/-clr--common-language-runtime-compilation-.md), use [safe_cast](../vs140/safe_cast--c---component-extensions-.md).  
  
 The following sample shows a C-style cast that maps to a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The following sample shows a C-style cast that maps to a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The following sample shows a C-style cast that maps to a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> plus <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The following sample shows a C-style cast that maps to a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The following sample shows a C-style cast that maps to a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> plus <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The following sample shows a C-style cast that maps to a run-time check.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The following sample shows an invalid C-style cast, which causes the compiler to issue an error.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
## Requirements  
 Compiler option: **/clr**  
  
## See Also  
 [/clr Keywords and Constructs](../vs140/component-extensions-for-runtime-platforms.md)