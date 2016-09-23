---
title: "Compiler Warning (level 3) C4018"
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
  - C4018
dev_langs: 
  - C++
helpviewer_keywords: 
  - C4018
ms.assetid: 6e8cbb04-d914-4319-b431-cbc2fbe40eb1
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Warning (level 3) C4018
'expression' : signed/unsigned mismatch  
  
 Comparing a signed and unsigned number required the compiler to convert the signed value to unsigned.  
  
 This warning may be fixed if you cast one of the two types when testing signed and unsigned types.  
  
 The following sample generates C4018:  
  
```  
// C4018.cpp  
// compile with: /W3  
int main() {  
   unsigned int uc = 0;  
   int c = 0;  
   unsigned int c2 = 0;  
  
   if (uc < c) uc = 0;   // C4018  
  
   // OK  
   if (uc == c2) uc = 0;  
}  
```