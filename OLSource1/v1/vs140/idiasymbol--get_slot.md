---
title: "IDiaSymbol::get_slot"
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
  - "IDiaSymbol::get_slot method"
ms.assetid: 97e405b8-483f-4da0-91e7-ca4d88251ecd
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSymbol::get_slot
Retrieves the slot number of the location. Use when the [LocationType Enumeration](../vs140/locationtype.md) is `LocIsSlot`.  
  
## Syntax  
  
```cpp#  
HRESULT get_slot (   
   DWORD* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns the slot number of the location.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
> [!NOTE]
>  A return value of `S_FALSE` means that the property is not available for the symbol.  
  
## See Also  
 [IDiaSymbol](../vs140/idiasymbol.md)   
 [LocationType Enumeration](../vs140/locationtype.md)