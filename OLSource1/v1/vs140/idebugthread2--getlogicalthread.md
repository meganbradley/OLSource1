---
title: "IDebugThread2::GetLogicalThread"
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
  - "IDebugThread2::GetLogicalThread"
helpviewer_keywords: 
  - "IDebugThread2::GetLogicalThread"
ms.assetid: bce6230e-41d4-49b7-a050-2dde5efb6805
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugThread2::GetLogicalThread
Debug engines do not implement this method.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] An [IDebugStackFrame2](../vs140/idebugstackframe2.md) object that represents the stack frame.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Returns an <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> interface that represents the associated logical thread. A debug engine implementation should set this to a null value.  
  
## Return Value  
 Debug engine implementations always return <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## See Also  
 [IDebugThread2](../vs140/idebugthread2.md)