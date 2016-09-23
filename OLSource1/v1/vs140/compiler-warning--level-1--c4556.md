---
title: "Compiler Warning (level 1) C4556"
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
  - xml
  - C4556
dev_langs: 
  - C++
helpviewer_keywords: 
  - C4556
ms.assetid: e4c0e296-b747-4db1-9608-30b8b74feac2
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Warning (level 1) C4556
value of intrinsic immediate argument 'value' is out of range 'lowerbound - upperbound'  
  
 An intrinsic matches a hardware instruction. The hardware instruction has a fixed number of bits to encode the constant. If ***value*** is out of range, it will not encode properly. The compiler truncates the extra bits.  
  
 The following sample generates C4556:  
  
```  
// C4556.cpp  
// compile with: /W1  
// processor: x86 IPF  
#include <xmmintrin.h>  
void test()  
{  
   __m64 m;  
   _m_pextrw(m, 5);   // C4556  
}  
int main()  
{  
}  
```