---
title: "BP_LOCATION_CODE_FILE_LINE"
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
  - "BP_LOCATION_CODE_FILE_LINE"
helpviewer_keywords: 
  - "BP_LOCATION_CODE_FILE_LINE structure"
ms.assetid: 3ff32032-d412-44d3-91bf-870cc354a09e
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# BP_LOCATION_CODE_FILE_LINE
Contains the data for the location of a breakpoint at a specific line in a code source file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The context of the breakpoint, typically a method or function name as seen on a call stack.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The [IDebugDocumentPosition2](../vs140/idebugdocumentposition2.md) object that represents the document position of the breakpoint.  
  
## Remarks  
 This structure is a member of the [BP_LOCATION](../vs140/bp_location.md) structure as part of a union.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../vs140/structures-and-unions.md)   
 [BP_LOCATION](../vs140/bp_location.md)   
 [IDebugDocumentPosition2](../vs140/idebugdocumentposition2.md)