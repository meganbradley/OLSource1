---
title: "IDebugProgram2::GetProcess"
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
  - "IDebugProgram2::GetProcess"
helpviewer_keywords: 
  - "IDebugProgram2::GetProcess"
ms.assetid: 1d602485-ebaf-451c-9165-f2e226f20a90
caps.latest.revision: 17
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProgram2::GetProcess
Get the process that this program is running in.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] Returns the [IDebugProcess2](../vs140/idebugprocess2.md) interface that represents the process.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 Unless a debug engine (DE) implements the [IDebugEngineLaunch2](../vs140/idebugenginelaunch2.md) interface, the DE's implementation of this method should always return <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> because a DE cannot determine which process it is running in and therefore cannot satisfy an implementation of this method.  
  
 Implementing the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> interface means that the DE must know how to create a process; therefore, the DE's implementation of the [IDebugProgram2](../vs140/idebugprogram2.md) interface is able to know what process it is running in.  
  
## See Also  
 [IDebugProgram2](../vs140/idebugprogram2.md)   
 [IDebugProcess2](../vs140/idebugprocess2.md)   
 [IDebugEngineLaunch2](../vs140/idebugenginelaunch2.md)