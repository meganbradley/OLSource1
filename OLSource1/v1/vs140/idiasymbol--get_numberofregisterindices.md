---
title: "IDiaSymbol::get_numberOfRegisterIndices"
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
ms.assetid: 1ec8b8ea-e423-4327-8dc0-a390e6e3ffb0
caps.latest.revision: 7
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IDiaSymbol::get_numberOfRegisterIndices
Retrieves the number of register indices.  
  
## Syntax  
  
```cpp  
HRESULT get_numberOfRegisterIndices(   
   DWORD* pRetVal);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] A pointer to a `DWORD` that holds the number of register indices.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
## See Also  
 [IDiaSymbol](../vs140/idiasymbol.md)