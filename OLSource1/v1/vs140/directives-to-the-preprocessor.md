---
title: "Directives to the Preprocessor"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
  - "C"
ms.assetid: adc6251e-cf6b-4508-bdbb-55f446c838d3
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Directives to the Preprocessor
A "directive" instructs the C preprocessor to perform a specific action on the text of the program before compilation. [Preprocessor directives](../vs140/preprocessor-directives.md) are fully described in the *Preprocessor Reference*. This example uses the preprocessor directive `#define`:  
  
```  
#define MAX 100  
```  
  
 This statement tells the compiler to replace each occurrence of `MAX` by `100` before compilation. The C compiler preprocessor directives are:  
  
|#define|#endif|#ifdef|#line|  
|--------------|-------------|-------------|------------|  
|`#elif`|`#error`|**#ifndef**|**#pragma**|  
|`#else`|`#if`|`#include`|`#undef`|  
  
## See Also  
 [Source Files and Source Programs](../vs140/source-files-and-source-programs.md)