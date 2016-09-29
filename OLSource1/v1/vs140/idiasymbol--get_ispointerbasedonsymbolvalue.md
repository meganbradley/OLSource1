---
title: "IDiaSymbol::get_isPointerBasedOnSymbolValue"
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
ms.assetid: 577c8011-9269-4373-8577-b4822a983724
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSymbol::get_isPointerBasedOnSymbolValue
Specifies whether the `this` pointer is based on a symbol value.  
  
## Syntax  
  
```cpp  
HRESULT get_isPointerBasedOnSymbolValue(   
   BOOL* pRetVal);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] A pointer to a `BOOL` that specifies whether the `this` pointer is based on a symbol value.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
## See Also  
 [IDiaSymbol](../vs140/idiasymbol.md)