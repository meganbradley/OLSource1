---
title: "Compiler Error C3862"
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
  - "C3862"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3862"
ms.assetid: ba547366-4189-4077-8c00-ab45e08a9533
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3862
'function': cannot compile an unmanaged function with /clr:pure or /clr:safe  
  
 A compilation with **/clr:pure** or **/clr:safe** will produce an MSIL only image, an image with no native (unmanaged) code.  Therefore, you cannot use the `unmanaged` pragma in a **/clr:pure** or **/clr:safe** compilation.  
  
 For more information, see [/clr (Common Language Runtime Compilation)](../vs140/-clr--common-language-runtime-compilation-.md) and [managed, unmanaged](../vs140/managed--unmanaged.md).  
  
## Example  
 The following sample generates C3862:  
  
```  
// C3862.cpp  
// compile with: /clr:pure /c  
#pragma unmanaged  
void f() {}   // C3862  
```