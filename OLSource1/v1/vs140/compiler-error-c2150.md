---
title: "Compiler Error C2150"
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
  - C2150
dev_langs: 
  - C++
helpviewer_keywords: 
  - C2150
ms.assetid: 21e82a10-c1d4-4c0d-9dc6-c5d92ea42a31
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C2150
'identifier' : bit field must have type 'int', 'signed int', or 'unsigned int'  
  
 bit fields are required to be `int`, `signed``int`, or `unsigned``int`.  
  
 The following sample generates C2150:  
  
```  
// C2150.cpp  
// compile with: /c  
struct A {  
   float a : 8;    // C2150  
   int i : 8;   // OK  
};  
```