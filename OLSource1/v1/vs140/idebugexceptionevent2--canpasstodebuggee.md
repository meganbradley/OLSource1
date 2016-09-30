---
title: "IDebugExceptionEvent2::CanPassToDebuggee"
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
  - "IDebugExceptionEvent2::CanPassToDebuggee"
helpviewer_keywords: 
  - "IDebugExceptionEvent2::CanPassToDebuggee"
ms.assetid: ae4bbe0a-fbe1-49be-a310-ea64279a434b
caps.latest.revision: 16
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugExceptionEvent2::CanPassToDebuggee
Determines whether or not the debug engine (DE) supports the option of passing this exception to the program being debugged when execution resumes.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Return Value  
 Returns either <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> (the exception can be passed to the program) or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> (the exception cannot be passed on).  
  
## Remarks  
 The DE must have a default action for passing to the debuggee. The IDE may receive the [IDebugExceptionEvent2](../vs140/idebugexceptionevent2.md) event and call the [IDebugProcess3::Continue](../vs140/idebugprocess3--continue.md) method without calling the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> method. Therefore, the DE should have a default case for passing the exception on or not.  
  
## See Also  
 [IDebugExceptionEvent2](../vs140/idebugexceptionevent2.md)   
 [IDebugProcess3::Continue](../vs140/idebugprocess3--continue.md)