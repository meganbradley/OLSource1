---
title: "IDiaSymbol::get_samplerSlot"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
ms.assetid: 41c751ba-81be-4bd3-838f-8373fc146157
caps.latest.revision: 7
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IDiaSymbol::get_samplerSlot
Retrieves the sampler slot.  
  
## Syntax  
  
```cpp  
HRESULT get_samplerSlot(   
   DWORD* pRetVal);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] A pointer to a `DWORD` that holds the sampler slot.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
## See Also  
 [IDiaSymbol](../vs140/idiasymbol.md)