---
title: "IDiaSymbol::get_noReturn"
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
  - "IDiaSymbol::get_noReturn method"
ms.assetid: 704c1cc0-5b84-4334-a02a-70f43aff39d5
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSymbol::get_noReturn
Retrieves a flag that specifies whether the function has been marked as never returning with the [noreturn](../vs140/noreturn.md) attribute.  
  
## Syntax  
  
```cpp  
HRESULT get_noReturn(  
   BOOL *pFlag  
);  
```  
  
#### Parameters  
 pFlag  
 [out] Returns `TRUE` if the function has been declared as never returning with the `noreturn` attribute; otherwise, returns `FALSE`.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
> [!NOTE]
>  A return value of `S_FALSE` means the property is not available for the symbol.  
  
## Requirements  
  
|Requirement|Description|  
|-----------------|-----------------|  
|Header:|dia2.h|  
|Version:|DIA SDK v8.0|  
  
## See Also  
 [IDiaSymbol Interface](../vs140/idiasymbol.md)   
 [noreturn](../vs140/noreturn.md)