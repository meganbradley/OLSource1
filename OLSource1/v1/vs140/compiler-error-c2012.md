---
title: "Compiler Error C2012"
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
  - C2012
dev_langs: 
  - C++
helpviewer_keywords: 
  - C2012
ms.assetid: 9f0d8162-c0b3-4234-a41f-836fdb75c84e
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C2012
missing name following '<'  
  
 An `#include` directive lacks the required filename.  
  
 The following sample generates C2012:  
  
```  
// C2012.cpp  
#include <   // C2012 include the filename to resolve  
```  
  
 Possible resolution:  
  
```  
// C2012b.cpp  
// compile with: /c  
#include <stdio.h>  
```