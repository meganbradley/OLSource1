---
title: "Compiler Warning (level 1) C4561"
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
  - "C4561"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4561"
ms.assetid: 3a10c12c-601b-4b6c-9861-331fd022e021
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4561
'__fastcall' incompatible with the '/clr' option: converting to '\__stdcall'  
  
 The [__fastcall](../vs140/__fastcall.md) function-calling convention cannot be used with the [/clr](../vs140/-clr--common-language-runtime-compilation-.md) compiler option. The compiler ignores the calls to `__fastcall`. To fix this warning, either remove the calls to **__fastcall** or compile without **/clr**.  
  
 The following sample generates C4561:  
  
```  
// C4561.cpp  
// compile with: /clr /W1 /c  
// processor: x86  
void __fastcall Func(void *p);   // C4561, remove __fastcall to resolve  
```