---
title: "Compiler Error C2052"
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
  - C2052
dev_langs: 
  - C++
helpviewer_keywords: 
  - C2052
ms.assetid: 922ca43b-b64b-4ef7-9611-c7313be3fd79
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C2052
'type' : illegal type for case expression  
  
 Case expressions must be integer constants.  
  
 The following sample generates C2052:  
  
```  
// C2052.cpp  
int main() {  
   int index = 0;  
   switch (index) {  
      case 1:  
         return 24;  
      case 1.0:   // C2052  
      // try the following line instead  
      // case 2:  
         return 23;  
   }  
}  
```