---
title: "IEEVisualizerDataProvider::GetNewObjectForVisualizer"
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
  - "IEEVisualizerDataProvider::GetNewObjectForVisualizer"
helpviewer_keywords: 
  - "IEEVisualizerDataProvider::GetNewObjectForVisualizer method"
ms.assetid: a898d549-4898-4fde-aad1-e8bb89129652
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IEEVisualizerDataProvider::GetNewObjectForVisualizer
This method gets a new object for the visualizer. This method will always create a new object from the existing object.  
  
## Syntax  
  
```cpp  
HRESULT GetNewObjectForVisualizer(  
   IDebugObject** ppObject  
);  
```  
  
```c#  
int GetNewObjectForVisualizer(  
   out IDebugObject ppObject  
);  
```  
  
#### Parameters  
 `ppObject`  
 [out] The new object.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 `This method` re-evaluates the object it currently represents and returns the result as a new object. The existing object will be updated as a result of the evaluation.  
  
## See Also  
 [IEEVisualizerDataProvider](../vs140/ieevisualizerdataprovider.md)   
 [IDebugObject](../vs140/idebugobject.md)