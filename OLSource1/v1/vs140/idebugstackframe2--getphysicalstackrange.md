---
title: "IDebugStackFrame2::GetPhysicalStackRange"
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
  - "IDebugStackFrame2::GetPhysicalStackRange"
helpviewer_keywords: 
  - "IDebugStackFrame2::GetPhysicalStackRange"
ms.assetid: 2f6992e2-ac1c-433f-83b7-a7f83a4ce63d
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugStackFrame2::GetPhysicalStackRange
Gets a machine-dependent representation of the range of physical addresses associated with a stack frame.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] Returns the lowest physical address associated with this stack frame.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Returns the highest physical address associated with this stack frame.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 The information returned by this method is used by the session debug manager (SDM) to sort stack frames.  
  
 It is assumed that the call stack grows down, that is, that new stack frames are added at increasingly lower memory addresses. A run-time architecture must provide physical stack ranges that match this assumption.  
  
## See Also  
 [IDebugStackFrame2](../vs140/idebugstackframe2.md)