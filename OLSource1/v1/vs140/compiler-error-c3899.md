---
title: "Compiler Error C3899"
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
  - "C3899"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3899"
ms.assetid: 14e07e4a-f7a7-4309-baaa-649d69e12e23
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3899
'var' : l-value use of initonly data member is not allowed directly within a parallel region in class 'class'  
  
 An [initonly](../vs140/initonly--c---cli-.md) data member cannot be initialized inside that part of a constructor that is in a [parallel](../vs140/parallel.md) region.  This is because the compiler does an internal relocation of that code, such that, it is effectively no longer part of the constructor.  
  
 To resolve, initialize the initonly data member in the constructor, but outside the parallel region.  
  
## Example  
 The following sample generates C3899.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>