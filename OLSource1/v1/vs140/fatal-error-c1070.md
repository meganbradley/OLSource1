---
title: "Fatal Error C1070"
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
  - C1070
dev_langs: 
  - C++
helpviewer_keywords: 
  - C1070
ms.assetid: 1058269a-5db6-4c23-a97f-b5269eb9188b
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Fatal Error C1070
mismatched #if/#endif pair in file 'filename'  
  
 An `#if`, `#ifdef`, or `#ifndef` directive has no corresponding `#endif`.  
  
 The following sample generates C1070:  
  
```  
// C1070.cpp  
#define TEST  
  
#ifdef TEST  
  
#ifdef TEST  
#endif  
// C1070  
```  
  
 Possible resolution:  
  
```  
// C1070b.cpp  
// compile with: /c  
#define TEST  
  
#ifdef TEST  
#endif  
  
#ifdef TEST  
#endif  
```