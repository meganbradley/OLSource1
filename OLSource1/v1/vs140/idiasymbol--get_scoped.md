---
title: "IDiaSymbol::get_scoped"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
helpviewer_keywords: 
  - IDiaSymbol::get_scoped method
ms.assetid: 588163f7-958e-4072-bf66-db5c5f07d3cb
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IDiaSymbol::get_scoped
Retrieves a flag that specifies whether the user-defined data type appears in a non-global lexical scope.  
  
## Syntax  
  
```cpp#  
HRESULT get_scoped (   
   BOOL* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns `TRUE` if the user-defined data type appears in a non-global lexical scope; otherwise, returns `FALSE`.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
> [!NOTE]
>  A return value of `S_FALSE` means that the property is not available for the symbol.  
  
## See Also  
 [IDiaSymbol](../vs140/idiasymbol.md)