---
title: "IDiaSymbol::get_registerId"
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
  - "IDiaSymbol::get_registerId method"
ms.assetid: f881e793-eb9e-48dc-a847-dd61d77174fc
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSymbol::get_registerId
Retrieves the register designator of the location when the [LocationType Enumeration](../VS_csharp/locationtype.md) is set to `LocIsEnregistered`.  
  
## Syntax  
  
```cpp#  
HRESULT get_registerId (   
   DWORD* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns the register designator of the location.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
> [!NOTE]
>  A return value of `S_FALSE` means that the property is not available for the symbol.  
  
## Remarks  
 If the symbol is relative to a register, that is, if the symbol's [LocationType Enumeration](../VS_csharp/locationtype.md) is set to `LocIsRegRel`, use the `get_registerId` method followed by a call to the [IDiaSymbol::get_offset](../VS_csharp/idiasymbol--get_offset.md) method to get the offset from the register where the symbol is located.  
  
## See Also  
 [IDiaSymbol](../VS_csharp/idiasymbol.md)   
 [LocationType Enumeration](../VS_csharp/locationtype.md)