---
title: "IDebugDisassemblyStream2::Read"
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
  - "IDebugDisassemblyStream2::Read"
helpviewer_keywords: 
  - "IDebugDisassemblyStream2::Read"
ms.assetid: 7db5f6bb-73ee-45bc-b187-c1b6aa2dfdd5
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugDisassemblyStream2::Read
Reads instructions starting from the current position in the disassembly stream.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The number of instructions to disassemble. This value is also the maximum length of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> array.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] A combination of flags from the [DISASSEMBLY_STREAM_FIELDS](../vs140/disassembly_stream_fields.md) enumeration that indicate which fields of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> are to be filled out.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [out] Returns the number of instructions actually disassembled.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 [out] An array of [DisassemblyData](../vs140/disassemblydata.md) structures that is filled in with the disassembled code, one structure per disassembled instruction. The length of this array is dictated by the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> parameter.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 The maximum number of instructions that are available in the current scope can be obtained by calling the [IDebugDisassemblyStream2::GetSize](../vs140/idebugdisassemblystream2--getsize.md) method.  
  
 The current position where the next instruction is read from can be changed by calling the [IDebugDisassemblyStream2::Seek](../vs140/idebugdisassemblystream2--seek.md) method.  
  
 The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> flag can be added to the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> flag in the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> parameter to indicate that symbol names should be used when disassembling instructions.  
  
## See Also  
 [IDebugDisassemblyStream2](../vs140/idebugdisassemblystream2.md)   
 [DISASSEMBLY_STREAM_FIELDS](../vs140/disassembly_stream_fields.md)   
 [DisassemblyData](../vs140/disassemblydata.md)   
 [IDebugDisassemblyStream2::GetSize](../vs140/idebugdisassemblystream2--getsize.md)   
 [IDebugDisassemblyStream2::Seek](../vs140/idebugdisassemblystream2--seek.md)