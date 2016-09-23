---
title: "IDebugPortSupplierLocale2::SetLocale"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
helpviewer_keywords: 
  - IDebugPortSupplierLocale2::SetLocale
ms.assetid: 21e88510-caac-405e-ba45-cb00e19a28bc
caps.latest.revision: 9
translation.priority.mt: 
  - de-de
  - ja-jp
---
# IDebugPortSupplierLocale2::SetLocale
Sets the locale for the port supplier.  
  
## Syntax  
  
```cpp#  
HRESULT SetLocale(  
   WORD wLangID  
);  
```  
  
```c#  
int SetLocale(  
   ushort wLangID  
);  
```  
  
#### Parameters  
 `wLangID`  
 Identifier for the locale to set.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugPortSupplierLocale2](../vs140/idebugportsupplierlocale2.md)