---
title: "Compiler Warning (level 1) C4747"
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
  - "C4747"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4747"
ms.assetid: af37befd-ba1f-4bdc-96e1-a953f7a2ad9c
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4747
Calling managed 'entrypoint': Managed code may not be run under loader lock, including the DLL entrypoint and calls reached from the DLL entrypoint  
  
 The compiler found a (probable) DLL entry point compiled to MSIL.  Because of potential problems with loading a DLL whose entry point has been compiled to MSIL, you are strongly discouraged from compiling a DLL entry point function to MSIL.  
  
 For more information, see [Mixed Mode Initialization](../vs140/initialization-of-mixed-assemblies.md) and [Linker Tools Error LNK1306](../vs140/linker-tools-error-lnk1306.md).  
  
### To correct this error  
  
1.  Do not compile the module with **/clr**.  
  
2.  Mark the entry point function with <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Example  
 The following sample generates C4747.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>