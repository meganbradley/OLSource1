---
title: "Compiler Warning (level 4) C4245"
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
  - "C4245"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4245"
ms.assetid: 85083d53-9cc2-4d12-b58c-6dad28f15cbe
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 4) C4245
'conversion' : conversion from 'type1' to 'type2', signed/unsigned mismatch  
  
 You tried to convert a signed **const** that has a negative value to an `unsigned`.  
  
 The following sample generates C4245:  
  
```  
// C4245.cpp  
// compile with: /W4 /c  
const int i = -1;  
unsigned int j = i; // C4245  
  
const int k = 1;  
unsigned int l = k; // okay  
  
int m = -1;  
unsigned int n = m; // okay  
  
void Test(size_t i) {}  
  
int main() {  
   Test( -19 );   // C4245  
}  
```