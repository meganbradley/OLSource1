---
title: "IDiaSymbol::get_notReached"
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
  - "IDiaSymbol::get_notReached method"
ms.assetid: e44ba922-6cda-40c2-9b62-44e5a8628e63
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSymbol::get_notReached
Retrieves a flag that specifies whether the function or label is never reached.  
  
## Syntax  
  
```cpp  
HRESULT get_notReached(  
   BOOL *pFlag  
);  
```  
  
#### Parameters  
 pFlag  
 [out] Returns `TRUE` if the function or label is never reached; otherwise, returns `FALSE`.  
  
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