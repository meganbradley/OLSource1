---
title: "Compiler Error C2032"
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
  - C2032
dev_langs: 
  - C++
helpviewer_keywords: 
  - C2032
ms.assetid: 625d7c83-70b6-42c2-a558-81fbc0026324
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C2032
'identifier' : function cannot be member of struct/union 'structorunion'  
  
 The structure or union has a member function, which is allowed in C++ but not in C. To resolve the error, either compile as a C++ program or remove the member function.  
  
 The following sample generates C2032:  
  
```  
// C2032.c  
struct z {  
   int i;  
   void func();   // C2032  
};  
```  
  
 Possible resolution:  
  
```  
// C2032b.c  
// compile with: /c  
struct z {  
   int i;  
};  
```