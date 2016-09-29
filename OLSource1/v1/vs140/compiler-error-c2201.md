---
title: "Compiler Error C2201"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "C2201"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2201"
ms.assetid: ed927659-6e9c-447d-9963-19969ae1e957
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2201
'identifier' : must have external linkage in order to be exported/imported  
  
 The exported identifier is `static`.  
  
 The following sample generates C2286:  
  
```  
// C2201.cpp  
// compile with: /c  
__declspec(dllexport) static void func() {}   // C2201 func() is static  
__declspec(dllexport) void func2() {}   // OK  
```  
  
## See Also  
 [Types of Linkage](../vs140/types-of-linkage.md)