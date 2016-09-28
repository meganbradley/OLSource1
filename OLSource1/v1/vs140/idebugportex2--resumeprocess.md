---
title: "IDebugPortEx2::ResumeProcess"
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
  - "IDebugPortEx2::ResumeProcess"
helpviewer_keywords: 
  - "IDebugPortEx2::ResumeProcess"
ms.assetid: e80a6960-9456-4764-9320-e7b1bd57fe5d
caps.latest.revision: 14
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugPortEx2::ResumeProcess
Resumes execution of a process.  
  
## Syntax  
  
```cpp#  
HRESULT ResumeProcess(   
   IDebugProcess2* pPortProcess  
);  
```  
  
```cpp#  
int ResumeProcess(   
   IDebugProcess2 pPortProcess  
);  
```  
  
#### Parameters  
 `pPortProcess`  
 [in] An [IDebugProcess2](../vs140/idebugprocess2.md) object representing the process to be resumed.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugPortEx2](../vs140/idebugportex2.md)   
 [IDebugProcess2](../vs140/idebugprocess2.md)