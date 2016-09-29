---
title: "Compiler Warning (level 1) C4470"
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
  - "C4470"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4470"
ms.assetid: f52a3eaa-a235-4747-a47d-9ec4ad4cb0ea
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4470
floating-point control pragmas ignored under /clr  
  
 The float-control pragmas:  
  
-   [fenv_access](../VS_csharp/fenv_access.md)  
  
-   [float_control](../VS_csharp/float_control.md)  
  
-   [fp_contract](../VS_csharp/fp_contract.md)  
  
 have no effect under [/clr](../VS_csharp/-clr--common-language-runtime-compilation-.md).  
  
 The following sample generates C4470:  
  
```  
// C4470.cpp  
// compile with: /clr /W1 /LD  
#pragma float_control(except, on)   // C4470  
```