---
title: "Call Stack Evaluation"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
helpviewer_keywords: 
  - debugging [Debugging SDK], call stack evaluation
  - call stacks, evaluation
ms.assetid: 373d6b49-0459-4cce-816e-05745a44fe49
caps.latest.revision: 12
translation.priority.mt: 
  - de-de
  - ja-jp
---
# Call Stack Evaluation
In order to view the stack frames of the call stack during break mode , you must implement the [EnumFrameInfo](../vs140/idebugthread2--enumframeinfo.md) method.  
  
## Methods for Evaluation  
 For a simple debug engine (DE), there might be only one stack frame. To examine the stack frame during break mode, you must implement the following methods of [IDebugStackFrame2](../vs140/idebugstackframe2.md).  
  
|Method|Description|  
|------------|-----------------|  
|[GetCodeContext](../vs140/idebugstackframe2--getcodecontext.md)|Gets the code context for a stack frame. The code context represents the current instruction pointer in a stack frame.|  
|[GetDocumentContext](../vs140/idebugstackframe2--getdocumentcontext.md)|Gets the document context for a stack frame. The document context represents the current location in the source code for a stack frame. Required for viewing the source code when you are stopped in a program.|  
  
 These methods require implementation of several context-related interfaces and methods. Thus, you must implement the [GetDocumentContext](../vs140/idebugcodecontext2--getdocumentcontext.md) method and the following methods of [IDebugDocumentContext2](../vs140/idebugdocumentcontext2.md).  
  
|Method|Description|  
|------------|-----------------|  
|[GetStatementRange](../vs140/idebugdocumentcontext2--getstatementrange.md)|Gets the file statement range of a document context.|  
  
 To enumerate code contexts, you must implement all the methods of [IEnumDebugCodeContexts2](../vs140/ienumdebugcodecontexts2.md).  
  
## See Also  
 [Execution Control and State Evaluation](../vs140/execution-control-and-state-evaluation.md)