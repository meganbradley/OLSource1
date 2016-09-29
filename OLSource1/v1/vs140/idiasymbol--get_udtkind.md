---
title: "IDiaSymbol::get_udtKind"
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
  - "IDiaSymbol::get_udtKind method"
ms.assetid: 4002f887-aea6-4475-b302-67c57079fe0a
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSymbol::get_udtKind
Retrieves the variety of a user-defined type (UDT).  
  
## Syntax  
  
```cpp#  
HRESULT get_udtKind (   
   DWORD* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns a value from the [UdtKind](../vs140/udtkind.md) enumeration that specifies the kind of a UDT: structure, class, or union.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or error code.  
  
> [!NOTE]
>  A return value of `S_FALSE` means the property is not available for the symbol.  
  
## See Also  
 [IDiaSymbol](../vs140/idiasymbol.md)   
 [UdtKind Enumeration](../vs140/udtkind.md)