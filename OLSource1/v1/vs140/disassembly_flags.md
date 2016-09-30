---
title: "DISASSEMBLY_FLAGS"
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
  - "DISASSEMBLY_FLAGS"
helpviewer_keywords: 
  - "DISASSEMBLY_FLAGS enumeration"
ms.assetid: c1ec5a4d-5d42-4660-932c-7348550140cb
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# DISASSEMBLY_FLAGS
Specifies the flags for disassembly.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Members  
 DF_DOCUMENTCHANGE  
 Indicates that this instruction is in a different document than the previous one.  
  
 DF_DISABLED  
 Indicates that this instruction will not be executed.  
  
 DF_INSTRUCTION_ACTIVE  
 Indicates that this instruction is one of the next instructions to be executed (there may be more than one).  
  
 DF_DATA  
 Indicates that this instruction is really data (not code).  
  
 DF_HASSOURCE  
 Indicates that this instruction has source. Some instructions, such as profiling or garbage collection code, have no corresponding source.  
  
 DF_DOCUMENT_CHECKSUM  
 Indicates that <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> field contains checksum data after the document URL. See the Remarks section for the [DisassemblyData](../vs140/disassemblydata.md) structure for how the checksum data is stored.  
  
## Remarks  
 Used as the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> member of the [DisassemblyData](../vs140/disassemblydata.md) structure.  
  
 These flags may be combined with a bitwise <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations (Visual Studio Debugging SDK)](../vs140/enumerations--visual-studio-debugging-.md)   
 [DisassemblyData](../vs140/disassemblydata.md)