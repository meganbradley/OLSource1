---
title: "Compiler Error C2128"
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
  - c2128
dev_langs: 
  - C++
helpviewer_keywords: 
  - C2128
ms.assetid: 08cbf734-75b3-49f2-9026-9b319947612d
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C2128
'function' : alloc_text/same_seg applicable only to functions with C linkage  
  
 `pragma` `alloc_text` can only be used with functions declared to have C linkage.  
  
 The following sample generates C2128:  
  
```  
// C2128.cpp  
// compile with: /c  
  
// Delete the following line to resolve.  
void func();  
// #pragma alloc_text("my segment", func)   // C2128  
  
extern "C" {  
void func();  
}  
  
#pragma alloc_text("my segment", func)  
void func() {}  
```