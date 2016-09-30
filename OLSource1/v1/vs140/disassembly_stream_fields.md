---
title: "DISASSEMBLY_STREAM_FIELDS"
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
  - "DISASSEMBLY_STREAM_FIELDS"
helpviewer_keywords: 
  - "DISASSEMBLY_STREAM_FIELDS enumeration"
ms.assetid: cfc9b4de-c756-4844-bea7-d9f186a51d1b
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# DISASSEMBLY_STREAM_FIELDS
Specifies what information to retrieve about a disassembly field.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Members  
 DSF_ADDRESS  
 Initialize/use the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> field.  
  
 DSF_ADDRESSOFFSET  
 Initialize/use the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> field.  
  
 DSF_CODEBYTES  
 Initialize/use the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> field.  
  
 DSF_OPCODE  
 Initialize/use the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> field.  
  
 DSF_OPERANDS  
 Initialize/use the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> field.  
  
 DSF_SYMBOL  
 Initialize/use the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> field.  
  
 DSF_CODELOCATIONID  
 Initialize/use the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> field.  
  
 DSF_POSITION  
 Initialize/use the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> fields.  
  
 DSF_DOCUMENTURL  
 Initialize/use the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> field.  
  
 DSF_BYTEOFFSET  
 Initialize/use the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> field.  
  
 DSF_FLAGS  
 Initialize/use the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> ([DISASSEMBLY_FLAGS](../vs140/disassembly_flags.md)) field.  
  
 DSF_OPERANDS_SYMBOLS  
 Include symbol names in the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> field.  
  
 DSF_ALL  
 Specifies all fields for the disassembly stream.  
  
## Remarks  
 Passed as a parameter to the [Read](../vs140/idebugdisassemblystream2--read.md) method to indicate which fields of the [DisassemblyData](../vs140/disassemblydata.md) structure are to be initialized.  
  
 Used for the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> member of the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> structure to indicate which fields are used and valid when the structure is returned.  
  
 These values may be combined with a bitwise <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations (Visual Studio Debugging SDK)](../vs140/enumerations--visual-studio-debugging-.md)   
 [DisassemblyData](../vs140/disassemblydata.md)   
 [Read](../vs140/idebugdisassemblystream2--read.md)   
 [DISASSEMBLY_FLAGS](../vs140/disassembly_flags.md)