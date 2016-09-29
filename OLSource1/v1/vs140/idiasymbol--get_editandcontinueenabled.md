---
title: "IDiaSymbol::get_editAndContinueEnabled"
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
  - "IDiaSymbol::get_editAndContinueEnabled method"
ms.assetid: cd703c64-9ff8-4654-8493-8cde9309cb22
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSymbol::get_editAndContinueEnabled
Retrieves a flag indicating whether the module was compiled with the [/Z7, /Zd, /Zi, /ZI (Debug Information Format)](../vs140/-z7---zi---zi--debug-information-format-.md) compiler switch.  
  
## Syntax  
  
```cpp#  
HRESULT get_editAndContinueEnabled (   
   BOOL* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns `TRUE` if edit-and-continue was enabled at compilation; otherwise, returns `FALSE`.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
> [!NOTE]
>  A return value of `S_FALSE` means that the property is not available for the symbol.  
  
## Requirements  
  
|Requirement|Description|  
|-----------------|-----------------|  
|Header:|dia2.h|  
|Version:|DIA SDK v7.0|  
  
## See Also  
 [IDiaSymbol](../vs140/idiasymbol.md)   
 [/Z7, /Zd, /Zi, /ZI (Debug Information Format)](../vs140/-z7---zi---zi--debug-information-format-.md)