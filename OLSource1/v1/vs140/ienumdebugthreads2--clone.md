---
title: "IEnumDebugThreads2::Clone"
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
  - IEnumDebugThreads2::Clone
helpviewer_keywords: 
  - IEnumDebugThreads2::Clone
ms.assetid: d774322c-e72d-4df3-b317-928da39dadc5
caps.latest.revision: 13
translation.priority.mt: 
  - de-de
  - ja-jp
---
# IEnumDebugThreads2::Clone
Returns a copy of the current enumeration as a separate object.  
  
## Syntax  
  
```cpp#  
HRESULT Clone(  
   IEnumDebugThreads2** ppEnum  
);  
```  
  
```c#  
int Clone(  
   out IEnumDebugThreads2 ppEnum  
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
 [IEnumDebugThreads2](../vs140/ienumdebugthreads2.md)