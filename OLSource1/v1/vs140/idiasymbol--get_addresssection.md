---
title: "IDiaSymbol::get_addressSection"
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
  - "IDiaSymbol::get_addressSection method"
ms.assetid: fe80d479-3bb5-4f55-9b62-1bd58d0a60ce
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSymbol::get_addressSection
Retrieves the section part of an address location. Use when the [LocationType Enumeration](../vs140/locationtype.md) is set to `LocIsStatic`.  
  
## Syntax  
  
```cpp#  
HRESULT get_addressSection (   
   DWORD* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns the section part of an address location.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
> [!NOTE]
>  A return value of `S_FALSE` means that the property is not available for the symbol.  
  
## Remarks  
 For static members located in an external DLL, the section returned by this method may be 0 as this method relies on obtaining the virtual address of the member. Virtual addresses are valid only if the [IDiaSession::put_loadAddress](../vs140/idiasession--put_loadaddress.md) method in the [IDiaSession](../vs140/idiasession.md) interface has been called with a nonzero parameter specifying the load address of the DLL.  
  
 To get the offset part of an address, call the [IDiaSymbol::get_addressOffset](../vs140/idiasymbol--get_addressoffset.md) method.  
  
## Requirements  
  
|Requirement|Description|  
|-----------------|-----------------|  
|Header:|dia2.h|  
|Version:|DIA SDK v7.0|  
  
## See Also  
 [IDiaSymbol](../vs140/idiasymbol.md)   
 [LocationType Enumeration](../vs140/locationtype.md)