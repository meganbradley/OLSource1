---
title: "Compiler Error C2706"
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
  - C2706
dev_langs: 
  - C++
helpviewer_keywords: 
  - C2706
ms.assetid: e18da924-c42d-4b09-8e29-f4e0382d7dc6
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C2706
illegal __except without matching \__try (missing '}' in \__try block?)  
  
 The compiler did not find a closing brace for a `__try` block.  
  
 The following sample generates C2706:  
  
```  
// C2706.cpp  
int main() {  
   __try {  
      void f();  
   // C2706  } missing here  
   __except(GetExceptionCode() == 0x0) {  
   }  
}  
```