---
title: "Compiler Warning (level 4) C4515"
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
  - C4515
dev_langs: 
  - C++
helpviewer_keywords: 
  - C4515
ms.assetid: 167b5177-3f89-418b-b6c8-7de634f6b28f
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Warning (level 4) C4515
'namespace' : namespace uses itself  
  
 A namespace is used recursively.  
  
 The following sample generates C4515:  
  
```  
// C4515.cpp  
// compile with: /W4  
namespace A  
{  
   using namespace A; // C4515  
}  
  
int main()  
{  
}  
```