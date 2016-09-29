---
title: "IEnumDebugPropertyInfo2::Clone"
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
  - "IEnumDebugPropertyInfo2::Clone"
helpviewer_keywords: 
  - "IEnumDebugPropertyInfo2::Clone"
ms.assetid: 0ede1667-1071-4aa4-b887-260ea103d724
caps.latest.revision: 13
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IEnumDebugPropertyInfo2::Clone
Returns a copy of the current enumeration as a separate object.  
  
## Syntax  
  
```cpp#  
HRESULT Clone(  
   IEnumDebugPropertyInfo2** ppEnum  
);  
```  
  
```c#  
int Clone(  
   out IEnumDebugPropertyInfo2 ppEnum  
);  
```  
  
#### Parameters  
 `ppEnum`  
 [out] Returns a copy of this enumeration as a separate object.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 The copy of the enumeration has the same state as the original at the time this method is called. However, the copy's and the original's states are separate and can be changed individually.  
  
## See Also  
 [IEnumDebugPropertyInfo2](../vs140/ienumdebugpropertyinfo2.md)