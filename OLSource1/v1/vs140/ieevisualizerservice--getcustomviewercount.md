---
title: "IEEVisualizerService::GetCustomViewerCount"
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
  - "IEEVisualizerService::GetCustomViewerCount"
helpviewer_keywords: 
  - "IEEVisualizerService::GetCustomViewerCount method"
ms.assetid: f7b095c2-e538-4352-8cad-d4c6d4f6bdbc
caps.latest.revision: 13
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IEEVisualizerService::GetCustomViewerCount
This method gets the number of type visualizers available from this service.  
  
## Syntax  
  
```cpp  
HRESULT GetCustomViewerCount(  
   ULONG* pcelt  
);  
```  
  
```c#  
int GetCustomViewerCount(  
   out uint pcelt  
);  
```  
  
#### Parameters  
 `pcelt`  
 [out] Returns the number of type visualizers available.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 [IDebugProperty3::GetCustomViewerCount](../vs140/idebugproperty3--getcustomviewercount.md) passes the request to this method in its support for type visualizers.  
  
## See Also  
 [IEEVisualizerService](../vs140/ieevisualizerservice.md)   
 [IDebugProperty3::GetCustomViewerCount](../vs140/idebugproperty3--getcustomviewercount.md)