---
title: "Compiler Error C2435"
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
  - "C2435"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2435"
ms.assetid: be6aa8f8-579b-42ea-bdd8-2d01393646ad
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2435
'var' : dynamic initialization requires managed CRT, cannot compile with /clr:safe  
  
 Initialization of global per–application domain variable requires the CRT compiled with `/clr:pure`, which does not produce a verifiable image.  
  
 For more information, see [appdomain](../VS_csharp/appdomain.md) and [process](../VS_csharp/process.md).  
  
 The following sample generates C2435:  
  
```  
// C2435.cpp  
// compile with: /clr:safe /c  
int globalvar = 0;   // C2435  
  
__declspec(process)  
int globalvar2 = 0;  
```