---
title: "IDebugPortEx2::TerminateProcess"
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
  - "IDebugPortEx2::TerminateProcess"
helpviewer_keywords: 
  - "IDebugPortEx2::TerminateProcess"
ms.assetid: bf8fa94c-6d9d-4e4f-ac08-3b44ba5ace68
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugPortEx2::TerminateProcess
Terminates a process.  
  
## Syntax  
  
```cpp#  
HRESULT TerminateProcess(   
   IDebugProcess2* pPortProcess  
);  
```  
  
```c#  
int TerminateProcess(   
   IDebugProcess2 pPortProcess  
);  
```  
  
#### Parameters  
 `pPortProcess`  
 [in] An [IDebugProcess2](../vs140/idebugprocess2.md) object representing the process to be terminated.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugPortEx2](../vs140/idebugportex2.md)   
 [IDebugProcess2](../vs140/idebugprocess2.md)