---
title: "IDebugDisassemblyStream2::Seek"
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
  - "IDebugDisassemblyStream2::Seek"
helpviewer_keywords: 
  - "IDebugDisassemblyStream2::Seek"
ms.assetid: afec3008-b1e0-4803-ad24-195dbfb6497e
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugDisassemblyStream2::Seek
Moves the read pointer in the disassembly stream a given number of instructions relative to a specified position.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] A value from the [SEEK_START](../vs140/seek_start.md) enumeration that specifies the relative position to begin the seek process.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] The [IDebugCodeContext2](../vs140/idebugcodecontext2.md) object representing the code context that the seek operation is relative to. This parameter is used only if <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> = <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>; otherwise, this parameter is ignored and can be a null value.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [in] The code location identifier that the seek operation is relative to. This parameter is used if <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> = <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>; otherwise, this parameter is ignored and can be set to 0. See the Remarks section for the [IDebugDisassemblyStream2::GetCodeLocationId](../vs140/idebugdisassemblystream2--getcodelocationid.md) method for a description of a code location identifier.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 [in] The number of instructions to move relative to the position specified in <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. This value can be negative to move backwards.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. Returns <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> if the seek position was to a point beyond the list of available instructions. Otherwise, returns an error code.  
  
## Remarks  
 If the seek was to a position before the beginning of the list, the read position is set to the first instruction in the list. If the see was to a position after the end of the list, the read position is set to the last instruction in the list.  
  
## See Also  
 [IDebugDisassemblyStream2](../vs140/idebugdisassemblystream2.md)   
 [SEEK_START](../vs140/seek_start.md)   
 [IDebugCodeContext2](../vs140/idebugcodecontext2.md)   
 [IDebugDisassemblyStream2::GetCodeLocationId](../vs140/idebugdisassemblystream2--getcodelocationid.md)