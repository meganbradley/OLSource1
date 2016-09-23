---
title: "Compiler Warning (level 4) C4232"
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
  - C4232
dev_langs: 
  - C++
helpviewer_keywords: 
  - C4232
ms.assetid: f92028a5-4ddd-43c1-97f5-4f724e5e14af
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Warning (level 4) C4232
nonstandard extension used : 'identifier' : address of dllimport 'dllimport' is not static, identity not guaranteed  
  
 Under Microsoft extensions (/Ze), you can give a nonstatic value as the address of a function declared with the **dllimport** modifier. Under ANSI compatibility ([/Za](../vs140/-za---ze--disable-language-extensions-.md)), this causes an error.  
  
 The following sample generates C4232:  
  
```  
// C4232.c  
// compile with: /W4 /Ze /c  
int __declspec(dllimport) f();  
int (*pfunc)() = &f;   // C4232  
```