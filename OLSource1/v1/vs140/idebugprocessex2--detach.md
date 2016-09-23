---
title: "IDebugProcessEx2::Detach"
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
  - IDebugProcessEx2::Detach
helpviewer_keywords: 
  - IDebugProcessEx2::Detach method
ms.assetid: 66d54c2c-9302-47c8-9975-f30ed988ab29
caps.latest.revision: 19
translation.priority.mt: 
  - de-de
  - ja-jp
---
# IDebugProcessEx2::Detach
This method informs the process that a session is no longer debugging the process.  
  
## Syntax  
  
```cpp#  
HRESULT Detach(   
   IDebugSession2* pSession  
);  
```  
  
```c#  
int Detach(  
   IDebugSession2 pSession  
);  
```  
  
#### Parameters  
 `pSession`  
 [in] A value that uniquely identifies the session to detach this process from.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 The interface passed in `pSession` is to be treated only as a cookie, a value that uniquely identifies the session debug manager that originally attached to this process; none of the methods on the supplied interface are functional.  
  
## See Also  
 [IDebugProcessEx2](../vs140/idebugprocessex2.md)