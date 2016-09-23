---
title: "Compiler Error C2448"
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
  - C2448
dev_langs: 
  - C++
helpviewer_keywords: 
  - C2448
ms.assetid: e255df3c-f861-4b4d-a193-8768cef061a5
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C2448
'identifier' : function-style initializer appears to be a function definition  
  
 The function definition is incorrect.  
  
 This error can be caused by an old-style C-language formal list.  
  
 The following sample generates C2448:  
  
```  
// C2448.cpp  
void func(c)  
   int c;  
{}   // C2448  
```