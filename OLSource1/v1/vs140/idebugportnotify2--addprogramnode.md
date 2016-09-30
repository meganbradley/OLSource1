---
title: "IDebugPortNotify2::AddProgramNode"
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
  - "IDebugPortNotify2::AddProgramNode"
helpviewer_keywords: 
  - "IDebugPortNotify2::AddProgramNode"
ms.assetid: 34c0e949-1eb9-4108-9cb8-a3eb87fcf190
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugPortNotify2::AddProgramNode
Registers a program that can be debugged with the port it is running on.  
  
## Syntax  
  
```cpp#  
HRESULT AddProgramNode(   
   IDebugProgramNode2* pProgramNode  
);  
```  
  
```c#  
int AddProgramNode(   
   IDebugProgramNode2 pProgramNode  
);  
```  
  
#### Parameters  
 `pProgramNode`  
 [in] An [IDebugProgramNode2](../vs140/idebugprogramnode2.md) object that represents the program to be registered.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 A program node can be unregistered from the port by calling the [IDebugPortNotify2::RemoveProgramNode](../vs140/idebugportnotify2--removeprogramnode.md) method.  
  
## See Also  
 [IDebugPortNotify2](../vs140/idebugportnotify2.md)   
 [IDebugProgramNode2](../vs140/idebugprogramnode2.md)   
 [IDebugPortNotify2::RemoveProgramNode](../vs140/idebugportnotify2--removeprogramnode.md)