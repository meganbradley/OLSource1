---
title: "IDiaSymbol::get_subTypeId"
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
ms.assetid: 0f899920-4fc5-4de8-84a3-cd98c57bf124
caps.latest.revision: 7
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSymbol::get_subTypeId
Retrieves the sub type ID.  
  
## Syntax  
  
```cpp  
HRESULT get_subTypeId(   
   DWORD* pRetVal);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] A pointer to a `DWORD` that holds the sub type ID.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
## See Also  
 [IDiaSymbol](../vs140/idiasymbol.md)