---
title: "IDebugExceptionEvent2::PassToDebuggee"
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
  - "IDebugExceptionEvent2::PassToDebuggee"
helpviewer_keywords: 
  - "IDebugExceptionEvent2::PassToDebuggee"
ms.assetid: a20d0f0b-2ca0-4437-bd22-9213c81d2738
caps.latest.revision: 16
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugExceptionEvent2::PassToDebuggee
Specifies whether the exception should be passed on to the program being debugged when execution resumes, or if the exception should be discarded.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] Nonzero (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>) if the exception should be passed on to the program being debugged when execution resumes, or zero (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>) if the exception should be discarded.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 Calling this method does not actually cause any code to be executed in the program being debugged. The call is merely to set the state for the next code execution. For example, calls to the [IDebugExceptionEvent2::CanPassToDebuggee](../vs140/idebugexceptionevent2--canpasstodebuggee.md) method may return <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> with the [EXCEPTION_INFO](../vs140/exception_info.md).<CodeContentPlaceHolder>7\</CodeContentPlaceHolder> field set to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 The IDE may receive the [IDebugExceptionEvent2](../vs140/idebugexceptionevent2.md) event and call the [Continue](../vs140/idebugprogram2--continue.md) method. The debug engine (DE) should have a default behavior to handle the case if the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> method is not called.  
  
## See Also  
 [IDebugExceptionEvent2](../vs140/idebugexceptionevent2.md)   
 [IDebugExceptionEvent2::CanPassToDebuggee](../vs140/idebugexceptionevent2--canpasstodebuggee.md)   
 [Continue](../vs140/idebugprogram2--continue.md)