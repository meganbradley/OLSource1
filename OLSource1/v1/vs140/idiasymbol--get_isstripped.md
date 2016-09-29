---
title: "IDiaSymbol::get_isStripped"
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
  - "IDiaSymbol::get_isStripped method"
ms.assetid: cc2c4a0b-ab9f-4b79-a8ff-a3badb0405d6
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSymbol::get_isStripped
Retrieves flag indicating whether private symbols were stripped from the symbol file.  
  
## Syntax  
  
```cpp#  
HRESULT get_isStripped(  
   BOOL *pFlag  
);  
```  
  
#### Parameters  
 `pFlag`  
 [out] Returns `TRUE` if private symbols were removed from the symbol file; otherwise, returns `FALSE`.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
> [!NOTE]
>  A return value of `S_FALSE` means the property is not available for the symbol.  
  
## Remarks  
 This property is available from the `SymTagExe` symbol type (see [Exe](../vs140/exe.md)).  
  
## Requirements  
  
|Requirement|Description|  
|-----------------|-----------------|  
|Header:|dia2.h|  
|Version:|DIA SDK v8.0|  
  
## See Also  
 [IDiaSymbol](../vs140/idiasymbol.md)   
 [Exe](../vs140/exe.md)