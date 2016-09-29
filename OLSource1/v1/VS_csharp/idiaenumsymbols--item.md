---
title: "IDiaEnumSymbols::Item"
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
  - "IDiaEnumSymbols::Item method"
ms.assetid: 2bd1ec04-e677-4e32-8e32-33334f1eed77
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaEnumSymbols::Item
Retrieves a symbol by means of an index.  
  
## Syntax  
  
```cpp#  
HRESULT Item (   
   DWORD        index,  
   IDiaSymbol** symbol  
);  
```  
  
#### Parameters  
 index  
 [in] Index of the [IDiaSymbol](../VS_csharp/idiasymbol.md) object to be retrieved. The index is in the range 0 to `count`-1, where `count` is returned by the [IDiaEnumSymbols::get_Count](../VS_csharp/idiaenumsymbols--get_count.md) method.  
  
 symbol  
 [out] Returns an [IDiaSymbol](../VS_csharp/idiasymbol.md) object representing the desired symbol.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDiaEnumSymbols](../VS_csharp/idiaenumsymbols.md)   
 [IDiaSymbol](../VS_csharp/idiasymbol.md)