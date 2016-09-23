---
title: "IDebugProcess2::Detach"
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
  - IDebugProcess2::Detach
helpviewer_keywords: 
  - IDebugProcess2::Detach
ms.assetid: ee2b9084-2db1-4e49-a1d9-387284b7c3f8
caps.latest.revision: 14
translation.priority.mt: 
  - de-de
  - ja-jp
---
# IDebugProcess2::Detach
Detaches the debugger from this process by detaching all of the programs in the process.  
  
## Syntax  
  
```cpp#  
HRESULT Detach(   
   void   
);  
```  
  
```c#  
int Detach();  
```  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 All programs and the process continue running, but are no longer part of the debug session. After the detach operation is complete, no more debug events for this process (and its programs) will be sent.  
  
## See Also  
 [IDebugProcess2](../vs140/idebugprocess2.md)