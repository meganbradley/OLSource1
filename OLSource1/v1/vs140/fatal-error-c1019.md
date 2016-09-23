---
title: "Fatal Error C1019"
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
  - C1019
dev_langs: 
  - C++
helpviewer_keywords: 
  - C1019
ms.assetid: c4f8968b-bc62-4200-b3ca-69d06c163236
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Fatal Error C1019
unexpected #else  
  
 The `#else` directive appears outside an `#if`, `#ifdef`, or `#ifndef` construct. Use `#else` only within one of these constructs.  
  
 The following sample generates C1019:  
  
```  
// C1019.cpp  
#else   // C1019  
#endif  
  
int main() {}  
```  
  
 Possible resolution:  
  
```  
// C1019b.cpp  
#if 1  
#else  
#endif  
  
int main() {}  
```