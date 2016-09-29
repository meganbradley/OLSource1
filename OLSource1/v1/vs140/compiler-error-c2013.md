---
title: "Compiler Error C2013"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "C2013"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2013"
ms.assetid: 6b5c955c-53da-48ee-8533-64ef5b905173
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2013
missing '>'  
  
 An `#include` directive lacks a closing angle bracket. Add the closing bracket to resolve the error.  
  
 The following sample generates C2013:  
  
```  
// C2013.cpp  
#include <stdio.h    // C2013  
```  
  
 Possible resolution:  
  
```  
// C2013b.cpp  
// compile with: /c  
#include <stdio.h>  
```