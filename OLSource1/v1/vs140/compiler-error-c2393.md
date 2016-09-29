---
title: "Compiler Error C2393"
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
  - "C2393"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2393"
ms.assetid: 4bd95728-e813-4ce8-844a-c6ebe235ca82
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2393
'symbol' : per-appdomain symbol cannot be allocated in segment 'segment'  
  
 The use of [appdomain](../vs140/appdomain.md) variables implies that you are compiling with **/clr:pure** or **/clr:safe**, and a safe or pure image cannot contain data segments.  
  
 See [/clr (Common Language Runtime Compilation)](../vs140/-clr--common-language-runtime-compilation-.md) for more information.  
  
## Example  
 The following sample generates C2393.  
  
```  
// C2393.cpp  
// compile with: /clr:pure /c  
#pragma data_seg("myseg")  
int n = 0;   // C2393  
```