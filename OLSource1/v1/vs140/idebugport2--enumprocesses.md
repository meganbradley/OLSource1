---
title: "IDebugPort2::EnumProcesses"
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
  - "IDebugPort2::EnumProcesses"
helpviewer_keywords: 
  - "IDebugPort2::EnumProcesses"
ms.assetid: aafb32c5-5790-4807-a448-878a80256438
caps.latest.revision: 14
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugPort2::EnumProcesses
Returns a list of all the processes running on a port.  
  
## Syntax  
  
```cpp#  
HRESULT EnumProcesses(   
   IEnumDebugProcesses2** ppEnum  
);  
```  
  
```c#  
int EnumProcesses(   
   out IEnumDebugProcesses2 ppEnum  
);  
```  
  
#### Parameters  
 `ppEnum`  
 [out] Returns an [IEnumDebugProcesses2](../vs140/ienumdebugprocesses2.md) object that contains a list of all the processes running on a port.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugPort2](../vs140/idebugport2.md)   
 [IEnumDebugProcesses2](../vs140/ienumdebugprocesses2.md)