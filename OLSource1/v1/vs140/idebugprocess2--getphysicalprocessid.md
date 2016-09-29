---
title: "IDebugProcess2::GetPhysicalProcessId"
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
  - "IDebugProcess2::GetPhysicalProcessId"
helpviewer_keywords: 
  - "IDebugProcess2::GetPhysicalProcessId"
ms.assetid: 77da6e10-75af-4308-97dd-c44416ca52d7
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProcess2::GetPhysicalProcessId
Gets the system process identifier.  
  
## Syntax  
  
```cpp#  
HRESULT GetPhysicalProcessId(  
   AD_PROCESS_ID* pdwProcessId  
);  
```  
  
```c#  
int GetPhysicalProcessId(  
   AD_PROCESS_ID[] pdwProcessId  
);  
```  
  
#### Parameters  
 `pdwProcessId`  
 [out] An [AD_PROCESS_ID](../vs140/ad_process_id.md) structure that is filled in with the system process identifier information.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugProcess2](../vs140/idebugprocess2.md)   
 [AD_PROCESS_ID](../vs140/ad_process_id.md)