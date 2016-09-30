---
title: "Compiler Warning (Level 1) C4730"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "C4730"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4730"
ms.assetid: 11303e3f-162b-4b19-970a-479686123a68
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (Level 1) C4730
'main' : mixing _m64 and floating point expressions may result in incorrect code  
  
 A function uses [__m64](../vs140/__m64.md) and **float**/**double** types. Because the MMX and floating-point registers share the same physical register space (cannot be used simultaneously), using <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and **float**/**double** types in the same function can result in data corruption, possibly causing an exception.  
  
 To safely use <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> types and floating-point types in the same function, each instruction that uses one of the types should be separated by the **_m_empty()** (for MMX) or **_m_femms()** (for 3DNow!) intrinsic.  
  
 The following sample generates C4730:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>