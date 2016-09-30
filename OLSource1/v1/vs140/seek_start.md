---
title: "SEEK_START"
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
  - "SEEK_START"
helpviewer_keywords: 
  - "SEEK_START enumeration"
ms.assetid: 55bd8901-626e-428b-a263-23b14417f4c6
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# SEEK_START
Specifies the position from which to start seeking in a disassembly stream.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Members  
 SEEK_START_BEGIN  
 Starts seeking at the beginning of the current document.  
  
 SEEK_START_END  
 Starts seeking at the end of the current document.  
  
 SEEK_START_CURRENT  
 Starts seeking at the current position of the current document.  
  
 SEEK_START_CODECONTEXT  
 Starts seeking at the given code context of the current document.  
  
 SEEK_START_CODELOCID  
 Starts seeking at the given code location identifier. Code location identifiers are obtained by calling [GetCurrentLocation](../vs140/idebugdisassemblystream2--getcurrentlocation.md).  
  
## Remarks  
 Passed as an argument to the [Seek](../vs140/idebugdisassemblystream2--seek.md) method.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations (Visual Studio Debugging SDK)](../vs140/enumerations--visual-studio-debugging-.md)   
 [Seek](../vs140/idebugdisassemblystream2--seek.md)   
 [GetCurrentLocation](../vs140/idebugdisassemblystream2--getcurrentlocation.md)