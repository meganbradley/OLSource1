---
title: "IDebugDisassemblyStream2::GetCurrentLocation"
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
  - "IDebugDisassemblyStream2::GetCurrentLocation"
helpviewer_keywords: 
  - "IDebugDisassemblyStream2::GetCurrentLocation"
ms.assetid: 512302f1-12b1-4107-8a6e-c5bc878ce1c3
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugDisassemblyStream2::GetCurrentLocation
Returns a code location identifier that represents the current code location.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] Returns the code location identifier. See the Remarks section for the [IDebugDisassemblyStream2::GetCodeLocationId](../vs140/idebugdisassemblystream2--getcodelocationid.md) method for a description of a code location identifier.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 The code location identifier can be converted to a code context by calling the [GetCodeContext](../vs140/idebugdisassemblystream2--getcodecontext.md) method.  
  
## See Also  
 [IDebugDocumentContext2](../vs140/idebugdocumentcontext2.md)   
 [IDebugDisassemblyStream2::GetCodeLocationId](../vs140/idebugdisassemblystream2--getcodelocationid.md)   
 [GetCodeContext](../vs140/idebugdisassemblystream2--getcodecontext.md)