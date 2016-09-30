---
title: "Compiler Warning (level 4) C4938"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "C4938"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4938"
ms.assetid: 6acac81a-9d23-465e-b700-ed4b6e8edcd0
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 4) C4938
'var' : Floating point reduction variable may cause inconsistent results under /fp:strict or #pragma fenv_access  
  
 You should not use [/fp:strict](../vs140/-fp--specify-floating-point-behavior-.md) or [fenv_access](../vs140/fenv_access.md) with OpenMP floating-point reductions, because the sum is computed in a different order. Thus, results can differ from the results without /openmp.  
  
 The following sample generates C4938:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Without explicit parallelization, the sum is computed as follows:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 With explicit parallelization (and two threads), the sum is computed as follows:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>