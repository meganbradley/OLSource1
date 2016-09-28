---
title: "IDebugProgramPublisher2::UnpublishProgram"
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
  - "IDebugProgramPublisher2::UnpublishProgram"
helpviewer_keywords: 
  - "IDebugProgramPublisher2::UnpublishProgram"
ms.assetid: 627e7d38-b2ac-4873-9a40-37ff7f47cd1d
caps.latest.revision: 13
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProgramPublisher2::UnpublishProgram
Makes a program unavailable to be debugged.  
  
## Syntax  
  
```cpp  
HRESULT UnpublishProgram(  
   IUnknown* pDebuggeeInterface  
);  
```  
  
```c#  
int UnpublishProgram(  
   object pDebuggeeInterface  
);  
```  
  
#### Parameters  
 `pDebuggeeInterface`  
 [in] An `IUnknown` interface to the program. This is the same value supplied to the [IDebugProgramPublisher2::PublishProgram](../vs140/idebugprogrampublisher2--publishprogram.md) method and uniquely identifies the program being removed (that is, it is used as a cookie).  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 To make a program available to the debug engines and session debug manager, use the [IDebugProgramPublisher2::PublishProgram](../vs140/idebugprogrampublisher2--publishprogram.md) method.  
  
## See Also  
 [IDebugProgramPublisher2](../vs140/idebugprogrampublisher2.md)   
 [IDebugProgramPublisher2::PublishProgram](../vs140/idebugprogrampublisher2--publishprogram.md)