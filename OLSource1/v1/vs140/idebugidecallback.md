---
title: "IDebugIDECallback"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "IDebugIDECallback interface"
ms.assetid: 8d31adc0-1c44-4658-8d4f-f4b73e35f4a6
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugIDECallback
> [!IMPORTANT]
>  In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).  
  
 Enables an expression evaluator (EE) to display a message in the debugger's output window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Notes for Implementers  
 This callback is implemented by the managed debug engine.  
  
## Notes for Callers  
 It can be consumed by an expression evaluator to send output to the debugger’s output window.  
  
## Methods  
 This interface implements the following method:  
  
|Method|Description|  
|------------|-----------------|  
|[IDebugIDECallback::DisplayMessage](../vs140/idebugidecallback--displaymessage.md)|Sends the specified message string to the debugger's output window.|  
  
## Requirements  
 Header: Ee.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll