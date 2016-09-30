---
title: "PENDING_BP_STATE_FLAGS"
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
  - "PENDING_BP_STATE_FLAGS"
helpviewer_keywords: 
  - "PENDING_BP_STATE_FLAGS enumeration"
ms.assetid: 85522449-3fd8-4da5-b0fe-a43160e0c33b
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# PENDING_BP_STATE_FLAGS
Specifies the pending breakpoint state flags.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Members  
 PBPSF_NONE  
 Placeholder.  
  
 PBPSF_VIRTUALIZED  
 Specifies a virtualized pending breakpoint, one that is to be bound every time new code is loaded.  
  
## Remarks  
 Used for the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> member of the [PENDING_BP_STATE_INFO](../vs140/pending_bp_state_info.md) structure.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations (Visual Studio Debugging SDK)](../vs140/enumerations--visual-studio-debugging-.md)   
 [PENDING_BP_STATE_INFO](../vs140/pending_bp_state_info.md)