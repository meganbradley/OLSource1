---
title: "IDebugProgram2::GetProgramId"
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
  - "IDebugProgram2::GetProgramId"
helpviewer_keywords: 
  - "IDebugProgram2::GetProgramId"
ms.assetid: 2c31c0aa-2b71-46c7-849c-356e237d26f8
caps.latest.revision: 15
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProgram2::GetProgramId
Gets a GUID for this program.  
  
## Syntax  
  
```cpp#  
HRESULT GetProgramId(   
   GUID* pguidProgramId  
);  
```  
  
```c#  
int GetProgramId(   
   out Guid pguidProgramId  
);  
```  
  
#### Parameters  
 `pguidProgramId`  
 [out] Returns the `GUID` for this program.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 A debug engine (DE) must return the program identifier originally passed to the [IDebugProgramNodeAttach2::OnAttach](../vs140/idebugprogramnodeattach2--onattach.md) or [Attach](../vs140/idebugengine2--attach.md) methods. This allows identification of the program across debugger components.  
  
## See Also  
 [IDebugProgram2](../vs140/idebugprogram2.md)   
 [IDebugProgramNodeAttach2::OnAttach](../vs140/idebugprogramnodeattach2--onattach.md)   
 [Attach](../vs140/idebugengine2--attach.md)