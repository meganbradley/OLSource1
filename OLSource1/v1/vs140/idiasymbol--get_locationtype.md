---
title: "IDiaSymbol::get_locationType"
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
helpviewer_keywords: 
  - "IDiaSymbol::get_locationType method"
ms.assetid: fbb09c43-ebb7-4b4f-be53-ccff86eb183a
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSymbol::get_locationType
Retrieves the location type of a data symbol.  
  
## Syntax  
  
```cpp#  
HRESULT get_locationType (   
   DWORD* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns a value from the [LocationType](../vs140/locationtype.md) enumeration that specifies the location type of a data symbol, such as `static` or `local`.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
> [!NOTE]
>  A return value of `S_FALSE` means the property is not available for the symbol.  
  
## See Also  
 [IDiaSymbol](../vs140/idiasymbol.md)   
 [LocationType Enumeration](../vs140/locationtype.md)