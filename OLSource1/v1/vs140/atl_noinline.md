---
title: "ATL_NOINLINE"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "ATL_NOINLINE"
  - "ATL.ATL_NOINLINE"
  - "ATL::ATL_NOINLINE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ATL_NOINLINE macro"
ms.assetid: f9cd45e3-e9f9-490a-8495-63a73f670954
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ATL_NOINLINE
A symbol that indicates a function should not be inlined.  
  
## Syntax  
  
```  
  
      ATL_NOINLINE inline   
      myfunction  
{  
...  
}  
```  
  
#### Parameters  
 *myfunction*  
 The function that should not be inlined.  
  
## Remarks  
 Use this symbol if you want to ensure a function does not get inlined by the compiler, even though it must be declared as inline so that it can be placed in a header file. Expands to **__declspec(noinline)**.  
  
## Requirements  
 **Header:** atldef.h  
  
## See Also  
 [Compiler Options Macros](../vs140/compiler-options-macros.md)   
 [Macros](../vs140/atl-macros.md)