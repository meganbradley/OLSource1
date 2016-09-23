---
title: "IDebugPortEx2::GetPortProcessId"
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
  - IDebugPortEx2::GetPortProcessId
helpviewer_keywords: 
  - IDebugPortEx2::GetPortProcessId
ms.assetid: be85be66-47e6-415f-b0ca-24599aa5f13c
caps.latest.revision: 14
translation.priority.mt: 
  - de-de
  - ja-jp
---
# IDebugPortEx2::GetPortProcessId
Gets the process ID of the port itself.  
  
## Syntax  
  
```cpp#  
HRESULT GetPortProcessId (   
   DWORD* pdwProcessId  
);  
```  
  
```c#  
int GetPortProcessId (   
   out uint pdwProcessId  
);  
```  
  
#### Parameters  
 `pdwProcessId`  
 [out] Returns the physical process ID of the port itself.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 In the Win32 runtime for example, this method typically calls the Win32 function `GetCurrentProcessId` to get the physical process ID.  
  
## See Also  
 [IDebugPortEx2](../vs140/idebugportex2.md)