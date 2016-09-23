---
title: "IDiaSymbol::get_subType"
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
ms.assetid: 0b3cbf77-8f11-434a-ad60-ea9829fec6fa
caps.latest.revision: 7
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IDiaSymbol::get_subType
Retrieves the sub type.  
  
## Syntax  
  
```cpp  
HRESULT get_subType(   
   IDiaSymbol** pRetVal);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] A pointer to the sub type.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
## See Also  
 [IDiaSymbol](../vs140/idiasymbol.md)