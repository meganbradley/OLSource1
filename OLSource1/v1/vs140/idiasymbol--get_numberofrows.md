---
title: "IDiaSymbol::get_numberOfRows"
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
ms.assetid: cf3eb110-d07f-4995-b68b-08290aa67d6f
caps.latest.revision: 7
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IDiaSymbol::get_numberOfRows
Retrieves the number of rows in the matrix.  
  
## Syntax  
  
```cpp  
HRESULT get_numberOfRows(   
   DWORD* pRetVal);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] A pointer to a `DWORD` that holds the number of rows in the matrix.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
## See Also  
 [IDiaSymbol](../vs140/idiasymbol.md)