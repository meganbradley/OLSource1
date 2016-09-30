---
title: "IDebugDisassemblyStream2::GetCodeLocationId"
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
  - "IDebugDisassemblyStream2::GetCodeLocationId"
helpviewer_keywords: 
  - "IDebugDisassemblyStream2::GetCodeLocationId"
ms.assetid: 567adfb8-2f54-499a-a027-e4ecb82277ef
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugDisassemblyStream2::GetCodeLocationId
Returns a code location identifier for a particular code context.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] An [IDebugCodeContext2](../vs140/idebugcodecontext2.md) object to be converted to an identifier.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Returns the code location identifier. See Remarks.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise, returns an error code. Returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if the code context is valid but outside the scope.  
  
## Remarks  
 The code location identifier is specific to the debug engine (DE) supporting the disassembly. This location identifier is used internally by the DE to track positions in the code and is typically an address or offset of some kind. The only requirement is that if the code context of one location is less than the code context of another location, then the corresponding code location identifier of the first code context must also be less than the code location identifier of the second code context.  
  
 To retrieve the code context of a code location identifier, call the [IDebugDisassemblyStream2::GetCodeContext](../vs140/idebugdisassemblystream2--getcodecontext.md) method.  
  
## See Also  
 [IDebugDocumentContext2](../vs140/idebugdocumentcontext2.md)   
 [IDebugCodeContext2](../vs140/idebugcodecontext2.md)   
 [IDebugDisassemblyStream2::GetCodeContext](../vs140/idebugdisassemblystream2--getcodecontext.md)