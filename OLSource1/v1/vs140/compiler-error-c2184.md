---
title: "Compiler Error C2184"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - C2184
dev_langs: 
  - C++
helpviewer_keywords: 
  - C2184
ms.assetid: 80fc8bff-7d76-4bde-94d2-01d84bb6824a
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C2184
'type' : illegal type for __except expression, must be an integral  
  
 A type was used in an [__except](../vs140/try-except-statement--c-.md) statement, but the type is not allowed.  
  
 The following sample generates C2184:  
  
```  
// C2184.cpp  
void f() {  
   int * p;  
   __try{}  
   __except(p){};   // C2184  
}  
```  
  
 Possible resolution:  
  
```  
// C2184b.cpp  
// compile with: /c  
void f() {  
   int i = 0;  
   __try{}  
   __except(i){};  
}  
```