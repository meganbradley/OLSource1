---
title: "IDiaSymbol::get_isOptimizedAway"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
ms.assetid: c18b1e38-b152-4a13-aba0-59faded5b2e6
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSymbol::get_isOptimizedAway
Specifies whether the variable is optimized away.  
  
## Syntax  
  
```cpp  
HRESULT get_isOptimizedAway(   
   BOOL* pRetVal);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] A pointer to a `BOOL` that specifies whether the variable is optimized away.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
## See Also  
 [IDiaSymbol](../vs140/idiasymbol.md)