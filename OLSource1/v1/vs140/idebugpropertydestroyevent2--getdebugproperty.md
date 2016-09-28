---
title: "IDebugPropertyDestroyEvent2::GetDebugProperty"
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
  - "IDebugPropertyDestroyEvent2::GetDebugProperty"
helpviewer_keywords: 
  - "IDebugPropertyDestroyEvent2::GetDebugProperty"
ms.assetid: c96ae785-0ac8-4df4-8df3-15a8d7e13687
caps.latest.revision: 14
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugPropertyDestroyEvent2::GetDebugProperty
Gets the property to be destroyed.  
  
## Syntax  
  
```cpp#  
HRESULT GetDebugProperty (   
   IDebugProperty2** ppProperty  
);  
```  
  
```c#  
int GetDebugProperty (   
   out IDebugProperty2 ppProperty  
);  
```  
  
#### Parameters  
 `ppProperty`  
 [out] Returns an [IDebugProperty2](../vs140/idebugproperty2.md) object that represents the property to be destroyed.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugPropertyDestroyEvent2](../vs140/idebugpropertydestroyevent2.md)   
 [IDebugProperty2](../vs140/idebugproperty2.md)