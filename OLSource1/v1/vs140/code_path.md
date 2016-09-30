---
title: "CODE_PATH"
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
  - "CODE_PATH"
helpviewer_keywords: 
  - "CODE_PATH structure"
ms.assetid: 2d4b2890-4c9d-47e1-83c0-df9c6436427f
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# CODE_PATH
Describes a method or function call.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Members  
 bstrName  
 The name of the code path.  
  
 pCode  
 The [IDebugCodeContext2](../vs140/idebugcodecontext2.md) object that identifies where in the code to step into a function.  
  
## Remarks  
 This structure is used to implement stepping into a function. [EnumCodePaths](../vs140/idebugprogram2--enumcodepaths.md) returns all the calls from the current location in the program being debugged. This structure represents one such call.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../vs140/structures-and-unions.md)   
 [IDebugCodeContext2](../vs140/idebugcodecontext2.md)   
 [EnumCodePaths](../vs140/idebugprogram2--enumcodepaths.md)