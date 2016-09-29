---
title: "IDebugBinder3::GetEEService"
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
  - "IDebugBinder3::GetEEService"
helpviewer_keywords: 
  - "IDebugBinder3::GetEEService method"
ms.assetid: eb07aa40-8cd9-4a52-a4c7-4affd2307a01
caps.latest.revision: 16
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugBinder3::GetEEService
This method returns a requested service.  
  
## Syntax  
  
```cpp  
HRESULT GetEEService(  
   [in] GUID        vendor,  
   [in] GUID        language,  
   [in] GUID        iid,  
   [out] IUnknown** ppService  
);  
```  
  
```c#  
Int GetEEService(  
   Guid       vendor,  
   Guid       language,  
   Guid       iid,  
   out object ppService  
);  
```  
  
#### Parameters  
 `vendor`  
 [in] `GUID` of a vendor (a null value is acceptable).  
  
 `language`  
 [in] `GUID` of a language (a null value is acceptable).  
  
 `iid`  
 [in] `IID` of the service to obtain.  
  
 `ppService`  
 [out] An interface to the requested service.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 Pass the `IID` for the [IEEVisualizerServiceProvider](../vs140/ieevisualizerserviceprovider.md) interface (`IID_IEEVisualizerServiceProvider`) to see if the Type Visualizer service is available. If so, the expression evaluator can obtain the [IEEVisualizerService](../vs140/ieevisualizerservice.md) interface to support type visualizers. See [Visualizing and Viewing Data](../vs140/visualizing-and-viewing-data.md) for details.  
  
## See Also  
 [IDebugBinder3](../vs140/idebugbinder3.md)   
 [IEEVisualizerServiceProvider](../vs140/ieevisualizerserviceprovider.md)   
 [IEEVisualizerService](../vs140/ieevisualizerservice.md)   
 [Visualizing and Viewing Data](../vs140/visualizing-and-viewing-data.md)