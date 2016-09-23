---
title: "Compiler Error C2194"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: error-reference
f1_keywords: 
  - C2194
dev_langs: 
  - C++
helpviewer_keywords: 
  - C2194
ms.assetid: df6e631c-0062-4844-9088-4cc7a0ff879f
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C2194
'identifier' : is a text segment  
  
 The `data_seg` pragma uses a segment name used with `code_seg`.  
  
 The following sample generates C2194:  
  
```  
// C2194.cpp  
// compile with: /c  
#pragma code_seg("MYCODE")  
#pragma data_seg("MYCODE")   // C2194  
#pragma data_seg("MYCODE2")   // OK  
```