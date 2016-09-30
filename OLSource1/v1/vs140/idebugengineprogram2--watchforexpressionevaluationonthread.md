---
title: "IDebugEngineProgram2::WatchForExpressionEvaluationOnThread"
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
  - "IDebugEngineProgram2::WatchForExpressionEvaluationOnThread"
helpviewer_keywords: 
  - "IDebugEngineProgram2::WatchForExpressionEvaluationOnThread"
ms.assetid: 01d05e77-8cac-4d1b-b19f-25756767ed27
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugEngineProgram2::WatchForExpressionEvaluationOnThread
Allows (or disallows) expression evaluation to occur on the given thread, even if the program has stopped.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] An [IDebugProgram2](../vs140/idebugprogram2.md) object representing the program that is evaluating an expression.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] Specifies the identifier of the thread.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] A combination of flags from the [EVALFLAGS](../vs140/evalflags.md) enumeration that specify how the evaluation is to be performed.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [in] An [IDebugEventCallback2](../vs140/idebugeventcallback2.md) object to be used to send debug events that occur during expression evaluation.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [in] If non-zero (<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>), allows expression evaluation on the thread identified by <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>; otherwise, zero (<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>) disallows expression evaluation on that thread.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 When the session debug manager (SDM) asks a program, identified by the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> parameter, to evaluate an expression, it notifies all other attached programs by calling this method.  
  
 Expression evaluation in one program may cause code to run in another, due to function evaluation or evaluation of any <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> properties. Because of this, this method allows expression evaluation to run and complete even though the thread may be stopped in this program.  
  
## See Also  
 [IDebugEngineProgram2](../vs140/idebugengineprogram2.md)   
 [EVALFLAGS](../vs140/evalflags.md)   
 [IDebugEventCallback2](../vs140/idebugeventcallback2.md)   
 [IDebugProgram2](../vs140/idebugprogram2.md)