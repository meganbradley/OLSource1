---
title: "CANSTOP_REASON"
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
  - "CANSTOP_REASON"
helpviewer_keywords: 
  - "CANSTOP_REASON enumeration"
ms.assetid: 6da944eb-36cd-4a8c-8d71-544c775cfcc1
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# CANSTOP_REASON
Used to determine if a program can stop execution after reaching a particular point in the execution.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Members  
 CANSTOP_ENTRYPOINT  
 Specifies the entry point of the given program.  
  
 CANSTOP_STEPIN  
 Specifies stepping into a function.  
  
## Remarks  
 Passed as an argument to the [GetReason](../vs140/idebugcanstopevent2--getreason.md) method to confirm with the Session Debug Manager (SDM) if it is okay to stop after reaching the entry point of the program or after stepping into a function or method.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations (Visual Studio Debugging SDK)](../vs140/enumerations--visual-studio-debugging-.md)   
 [GetReason](../vs140/idebugcanstopevent2--getreason.md)