---
title: "Compiler Error C2165"
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
  - C2165
dev_langs: 
  - C++
helpviewer_keywords: 
  - C2165
ms.assetid: b108313b-b8cb-4dce-b2ec-f2b31c9cdc87
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C2165
'keyword' : cannot modify pointers to data  
  
 The `__stdcall`, `__cdecl`, or `__fastcall` keyword attempts to modify a pointer to data.  
  
 The following sample generates C2165:  
  
```  
// C2165.cpp  
// compile with: /c  
char __cdecl *p;   // C2165  
char *p;   // OK  
```