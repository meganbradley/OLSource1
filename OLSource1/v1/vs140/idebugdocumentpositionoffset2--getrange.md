---
title: "IDebugDocumentPositionOffset2::GetRange"
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
  - "IDebugDocumentPositionOffset2::GetRange"
ms.assetid: 27da7130-0932-4f97-abde-05e6fb018606
caps.latest.revision: 10
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugDocumentPositionOffset2::GetRange
Retrieves the range for the current document position.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in, out] Offset for the start position of the range. Set this parameter to a null value if this information is not needed.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in, out] Offset for the end position of the range. Set this parameter to a null value if this information is not needed.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 The range specified in a document position for a location breakpoint is used by the debug engine (DE) to search ahead for a statement that actually contributes code. For example, consider the following code:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Line 5 contributes no code to the program being debugged. If the debugger that sets the breakpoint on line 5 wants the DE to search forward a certain amount for the first line that contributes code, the debugger would specify a range that includes additional candidate lines where a breakpoint might be correctly placed. The DE would then search forward through those lines until it found a line that could accept a breakpoint.  
  
## See Also  
 [IDebugDocumentPositionOffset2](../vs140/idebugdocumentpositionoffset2.md)   
 [IDebugDocumentPosition2::GetRange](../vs140/idebugdocumentposition2--getrange.md)