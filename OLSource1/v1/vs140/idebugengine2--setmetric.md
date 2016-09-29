---
title: "IDebugEngine2::SetMetric"
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
  - "IDebugEngine2:::SetMetric"
helpviewer_keywords: 
  - "IDebugEngine2:::SetMetric"
ms.assetid: dcda4972-c32e-4693-a0e1-25d5c58b9782
caps.latest.revision: 19
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugEngine2::SetMetric
This method sets a registry value known as a metric.  
  
## Syntax  
  
```cpp#  
HRESULT SetMetric(  
   LPCOLESTR pszMetric,  
   VARIANT   varValue  
);  
```  
  
```c#  
int SetMetric(  
   string pszMetric,  
   object varValue  
);  
```  
  
#### Parameters  
 `pszMetric`  
 [in] The metric name.  
  
 `varValue`  
 [in] Specifies the metric value.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 A metric is a registry value used to change a debug engine's behavior or to advertise supported functionality. This method can forward the call to the appropriate form of the [Debugging SDK Helpers](../vs140/sdk-helpers-for-debugging.md) function, `SetMetric`.  
  
## See Also  
 [IDebugEngine2](../vs140/idebugengine2.md)   
 [Debugging SDK Helpers](../vs140/sdk-helpers-for-debugging.md)