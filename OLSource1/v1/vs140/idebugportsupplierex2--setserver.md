---
title: "IDebugPortSupplierEx2::SetServer"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "IDebugPortSupplierEx2::SetServer"
ms.assetid: 0e8ef194-3a4f-4abf-8382-4607ab3005d1
caps.latest.revision: 9
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugPortSupplierEx2::SetServer
Sets the core server for the port supplier.  
  
## Syntax  
  
```cpp#  
HRESULT SetServer(  
   IDebugCoreServer2* pServer  
);  
```  
  
```c#  
int SetServer(  
   IDebugCoreServer2 pServer  
);  
```  
  
#### Parameters  
 `pServer`  
 Core server to set for the port supplier.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugPortSupplierEx2](../vs140/idebugportsupplierex2.md)