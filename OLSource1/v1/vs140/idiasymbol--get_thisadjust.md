---
title: "IDiaSymbol::get_thisAdjust"
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
  - IDiaSymbol::get_thisAdjust method
ms.assetid: 56b9a147-e8c0-4d4b-a42a-398214dd5f86
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IDiaSymbol::get_thisAdjust
Retrieves the logical `this` adjustor for the method.  
  
## Syntax  
  
```cpp#  
HRESULT get_thisAdjust (   
   LONG* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns the logical `this` adjustor for the method.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
> [!NOTE]
>  A return value of `S_FALSE` means the property is not available for the symbol.  
  
## Remarks  
 In some multiple inheritance cases the method itself must calculate a true `this` value by adding an offset to `this`.  
  
## See Also  
 [IDiaSymbol](../vs140/idiasymbol.md)