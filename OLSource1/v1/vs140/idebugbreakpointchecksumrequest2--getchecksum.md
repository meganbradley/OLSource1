---
title: "IDebugBreakpointChecksumRequest2::GetChecksum"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "IDebugBreakpointChecksumRequest2::GetChecksum"
ms.assetid: ec434882-e5c0-4d76-a58b-22c260d8626e
caps.latest.revision: 16
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugBreakpointChecksumRequest2::GetChecksum
Retrieves the document checksum for a breakpoint request given the unique identifier of the checksum algorithm to use.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] Unique identifier of the checksum algorithm.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [out] Document checksum for the breakpoint request.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Example  
 The following example shows a function that checks whether the checksum of a document, which is about to be bound, matches one from the UI.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugBreakpointChecksumRequest2](../vs140/idebugbreakpointchecksumrequest2.md)