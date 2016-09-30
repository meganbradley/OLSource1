---
title: "IDebugProgram2::Step"
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
  - "IDebugProgram2::Step"
helpviewer_keywords: 
  - "IDebugProgram2::Step"
ms.assetid: e4c2ffce-9810-4088-8162-eac9ef04f2a9
caps.latest.revision: 20
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProgram2::Step
Performs a step.  
  
> [!NOTE]
>  This method is deprecated. Use the [IDebugProcess3::Step](../vs140/idebugprocess3--step.md) method instead.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] An [IDebugThread2](../vs140/idebugthread2.md) object that represents the thread being stepped.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] A value from the [STEPKIND](../vs140/stepkind.md) enumeration that specifies the kind of step.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] A value from the [STEPUNIT](../vs140/stepunit.md) enumeration that specifies the unit of step (for example, by statement or instruction).  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 In case there is any thread synchronization or communication between threads, other threads in the program should run when a particular thread is stepping.  
  
> [!WARNING]
>  Do not send a stopping event or an immediate (synchronous) event to [IDebugEventCallback2::Event](../vs140/idebugeventcallback2--event.md) while handling this call; otherwise the debugger may hang.  
  
## See Also  
 [IDebugProgram2](../vs140/idebugprogram2.md)   
 [IDebugEngineProgram2](../vs140/idebugengineprogram2.md)   
 [IDebugEventCallback2::Event](../vs140/idebugeventcallback2--event.md)