---
title: "IDebugProgram2::Terminate"
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
  - "IDebugProgram2::Terminate"
helpviewer_keywords: 
  - "IDebugProgram2::Terminate"
ms.assetid: 4d3127d3-b1e9-4b28-ac22-2f2eea255f86
caps.latest.revision: 12
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProgram2::Terminate
Terminates the program.  
  
## Syntax  
  
```cpp#  
HRESULT Terminate(   
   void   
);  
```  
  
```c#  
int Terminate();  
```  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 If possible, the program will be terminated and unloaded from the process; otherwise, the debug engine (DE) will perform any necessary cleanup.  
  
 This method or the [Terminate](../vs140/idebugprocess2--terminate.md) method is called by the IDE, typically in response to the user halting all debugging. The implementation of this method should, ideally, terminate the program within the process. If this is not possible, the DE should prevent the program from running any more in this process (and do any necessary cleanup). If the `IDebugProcess2::Terminate` method was called by the IDE, the entire process will be terminated sometime after the `IDebugProgram2::Terminate` method is called.  
  
## See Also  
 [IDebugProgram2](../vs140/idebugprogram2.md)   
 [Terminate](../vs140/idebugprocess2--terminate.md)