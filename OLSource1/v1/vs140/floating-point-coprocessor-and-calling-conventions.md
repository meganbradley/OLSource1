---
title: "Floating Point Coprocessor and Calling Conventions"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: language-reference
dev_langs: 
  - C++
helpviewer_keywords: 
  - floating-point numbers, coprocessor
  - floating-point coprocessor
  - floating-point numbers
ms.assetid: 3cc6615a-b308-4cf7-9570-83e192a832b3
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Floating Point Coprocessor and Calling Conventions
If you are writing assembly routines for the floating point coprocessor, you must preserve the floating point control word and clean the coprocessor stack unless you are returning a **float** or **double** value (which your function should return in ST(0)).  
  
## See Also  
 [Calling Conventions](../vs140/calling-conventions.md)