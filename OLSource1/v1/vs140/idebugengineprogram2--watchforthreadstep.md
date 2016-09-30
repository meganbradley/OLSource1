---
title: "IDebugEngineProgram2::WatchForThreadStep"
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
  - "IDebugEngineProgram2::WatchForThreadStep"
helpviewer_keywords: 
  - "IDebugEngineProgram2::WatchForThreadStep"
ms.assetid: b70922a3-1313-409a-b3b7-50c7cd13e394
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugEngineProgram2::WatchForThreadStep
Watches for execution (or stops watching for execution) to occur on the given thread.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] An [IDebugProgram2](../vs140/idebugprogram2.md) object representing the program being stepped.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] Specifies the identifier of the thread to watch.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] Non-zero (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>) means start watching for execution on the thread identified by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>; otherwise, zero (<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>) means stop watching for execution on <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 [in] Specifies a frame index that controls the step type. When this is value is zero (0), the step type is "step into" and the program should stop whenever the thread identified by <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> executes. When <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is non-zero, the step type is "step over" and the program should stop only if the thread identified by <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is running in a frame whose index is equal to or higher on the stack than <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 When the session debug manager (SDM) steps a program, identified by the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> parameter, it notifies all other attached programs by calling this method.  
  
 This method is applicable only to same-thread stepping.  
  
## See Also  
 [IDebugEngineProgram2](../vs140/idebugengineprogram2.md)   
 [IDebugProgram2](../vs140/idebugprogram2.md)