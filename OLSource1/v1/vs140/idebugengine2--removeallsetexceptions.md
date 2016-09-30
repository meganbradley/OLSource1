---
title: "IDebugEngine2::RemoveAllSetExceptions"
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
  - "IDebugEngine2::RemoveAllSetExceptions"
helpviewer_keywords: 
  - "IDebugEngine2::RemoveAllSetExceptions"
ms.assetid: 165fbe89-802d-4d99-85ca-c10fd6cccc09
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugEngine2::RemoveAllSetExceptions
Removes the list of exceptions the IDE has set for a particular run-time architecture or language.  
  
## Syntax  
  
```cpp#  
HRESULT RemoveAllSetExceptions(   
   REFGUID guidType  
);  
```  
  
```c#  
int RemoveAllSetExceptions(   
   ref Guid guidType  
);  
```  
  
#### Parameters  
 `guidType`  
 [in] Either the GUID for the language or the GUID for the debug engine that is specific to a run-time architecture.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 The exceptions removed by this method were set by earlier calls to the [SetException](../vs140/idebugengine2--setexception.md) method.  
  
 To remove a specific exception, call the [IDebugEngine2::RemoveSetException](../vs140/idebugengine2--removesetexception.md) method.  
  
## See Also  
 [IDebugEngine2](../vs140/idebugengine2.md)   
 [IDebugEngine2](../vs140/idebugengine2.md)   
 [IDebugEngine2::RemoveSetException](../vs140/idebugengine2--removesetexception.md)