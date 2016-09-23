---
title: "IDebugCoreServer3::DisableAutoAttach"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - IDebugCoreServer3::DisableAutoAttach
helpviewer_keywords: 
  - IDebugCoreServer3::DisableAutoAttach
ms.assetid: 9d860a20-c154-4df4-ba15-636e0fcd42bf
caps.latest.revision: 10
translation.priority.mt: 
  - de-de
  - ja-jp
---
# IDebugCoreServer3::DisableAutoAttach
Disables automatic attaching for all debug engines associated with this server.  
  
## Syntax  
  
```cpp#  
HRESULT DisableAutoAttach(  
   void  
);  
```  
  
```c#  
int DisableAutoAttach();  
```  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns error code.  
  
## See Also  
 [IDebugCoreServer3](../vs140/idebugcoreserver3.md)