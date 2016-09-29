---
title: "IDiaSymbol::get_isMultipleInheritance"
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
ms.assetid: 0aa356a1-5c5c-4ee4-8b48-bae0a2610013
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSymbol::get_isMultipleInheritance
Specifies whether the `this` pointer points to a data member with multiple inheritance.  
  
## Syntax  
  
```cpp  
HRESULT get_isMultipleInheritance(   
   BOOL* pRetVal);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] A pointer to a `BOOL` that specifies whether the `this` pointer points to a data member with multiple inheritance.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
## See Also  
 [IDiaSymbol](../vs140/idiasymbol.md)