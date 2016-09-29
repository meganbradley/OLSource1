---
title: "IDebugProperty2::GetParent"
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
  - "IDebugProperty2::GetParent"
helpviewer_keywords: 
  - "IDebugProperty2::GetParent"
ms.assetid: 58780469-fe25-4d84-9187-67940ca0767f
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProperty2::GetParent
Gets the parent property of a property.  
  
## Syntax  
  
```cpp#  
HRESULT GetParent (   
   IDebugProperty2** ppParent  
);  
```  
  
```c#  
int GetParent (   
   out IDebugProperty2 ppParent  
);  
```  
  
#### Parameters  
 `ppParent`  
 [out] Returns an [IDebugProperty2](../vs140/idebugproperty2.md) object that represents the parent of the property.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise returns error code. Returns `S_GETPARENT_NO_PARENT` if there is no parent.  
  
## See Also  
 [IDebugProperty2](../vs140/idebugproperty2.md)