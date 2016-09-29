---
title: "IEnumDebugObjects::GetCount"
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
  - "IEnumDebugObjects::GetCount"
helpviewer_keywords: 
  - "IEnumDebugObjects::GetCount method"
ms.assetid: 9cbc5db4-03ae-479f-a664-13cad66ad210
caps.latest.revision: 9
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IEnumDebugObjects::GetCount
This method returns the number of elements in the enumeration.  
  
## Syntax  
  
```cpp#  
HRESULT GetCount(  
   [out] ULONG* pcelt  
);  
```  
  
```c#  
int GetCount(  
   out uint pcelt  
);  
```  
  
#### Parameters  
 `pcelt`  
 [out] Returns the number of elements in the enumeration.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 This method is not part of the customary COM enumeration interface which specifies that only Next, Clone, Skip, and Reset need to be implemented.  
  
## See Also  
 [IEnumDebugObjects](../vs140/ienumdebugobjects.md)