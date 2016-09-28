---
title: "IDebugDefaultPort2::QueryIsLocal"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IDebugDefaultPort2::QueryIsLocal"
helpviewer_keywords: 
  - "IDebugDefaultPort2::QueryIsLocal"
ms.assetid: 1a42e774-c6ed-419a-a0e3-cab5778652ca
caps.latest.revision: 14
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugDefaultPort2::QueryIsLocal
This method determines whether this port is on the local machine.  
  
## Syntax  
  
```cpp#  
HRESULT QueryIsLocal(  
   void  
);  
```  
  
```c#  
int QueryIsLocal();  
```  
  
## Return Value  
 Returns `S_OK` if this port is local (on the same machine as the caller) or `S_FALSE` if the port is on another machine.  
  
## See Also  
 [IDebugDefaultPort2](../vs140/idebugdefaultport2.md)