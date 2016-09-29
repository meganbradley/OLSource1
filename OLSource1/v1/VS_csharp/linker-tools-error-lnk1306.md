---
title: "Linker Tools Error LNK1306"
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
  - "LNK1306"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LNK1306"
ms.assetid: fad1df6a-0bd9-412f-b0d1-7c9bc749c584
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Linker Tools Error LNK1306
DLL entry point function cannot be managed; compile to native  
  
 DllMain cannot be compiled to MSIL; it must be compiled to native.  
  
 To resolve,  
  
-   Compile the file that contains the entry point without **/clr**.  
  
-   Put the entry point in a `#pragma unmanaged` section.  
  
-   For more information, see  
  
-   [/clr (Common Language Runtime Compilation)](../VS_csharp/-clr--common-language-runtime-compilation-.md)  
  
-   [managed, unmanaged](../VS_csharp/managed--unmanaged.md)  
  
-   [Mixed Mode Initialization](../VS_csharp/initialization-of-mixed-assemblies.md)  
  
-   [Run-Time Library Behavior](../VS_csharp/run-time-library-behavior.md)  
  
## Example  
 The following sample generates LNK1306.  
  
```  
// LNK1306.cpp  
// compile with: /clr /link /dll /entry:NewDllMain  
// LNK1306 error expected  
#include <windows.h>  
int __stdcall NewDllMain( HINSTANCE h, ULONG ulReason, PVOID pvReserved ) {  
   return 1;  
}  
```