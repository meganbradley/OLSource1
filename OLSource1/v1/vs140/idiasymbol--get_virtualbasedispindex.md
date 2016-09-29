---
title: "IDiaSymbol::get_virtualBaseDispIndex"
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
  - "IDiaSymbol::get_virtualBaseDispIndex method"
ms.assetid: 5561a3cb-2c82-41cf-9217-3ee2b1e1d1d1
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSymbol::get_virtualBaseDispIndex
Retrieves the index of the symbol in the virtual base displacement table.  
  
## Syntax  
  
```cpp#  
HRESULT get_virtualBaseDispIndex (  
   DWORD* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns the index into the virtual base displacement table.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or error code.  
  
> [!NOTE]
>  A return value of `S_FALSE` means the property is not available for the symbol.  
  
## See Also  
 [IDiaSymbol](../vs140/idiasymbol.md)