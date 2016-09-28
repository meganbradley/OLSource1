---
title: "IDiaSymbol::get_thunkOrdinal"
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
  - "IDiaSymbol::get_thunkOrdinal method"
ms.assetid: 4b28d78a-1974-4d8a-8bb7-781bf630f2f4
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSymbol::get_thunkOrdinal
Retrieves the thunk type of a function.  
  
## Syntax  
  
```cpp#  
HRESULT get_thunkOrdinal (   
   DWORD* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns a value from the [THUNK_ORDINAL](../vs140/thunk_ordinal.md) enumeration that specifies the thunk type of a function.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
> [!NOTE]
>  A return value of `S_FALSE` means the property is not available for the symbol.  
  
## Remarks  
 This property is valid only if the symbol as a [SymTagEnum](../vs140/symtagenum.md) value of `SymTagThunk`.  
  
 A "thunk" is a piece of code that converts between a 32-bit memory address space (also known as flat address space) and a 16-bit address space (known as a segmented address space).  
  
## See Also  
 [IDiaSymbol](../vs140/idiasymbol.md)   
 [THUNK_ORDINAL Enumeration](../vs140/thunk_ordinal.md)   
 [SymTagEnum](../vs140/symtagenum.md)