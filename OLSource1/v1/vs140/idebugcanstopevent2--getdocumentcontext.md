---
title: "IDebugCanStopEvent2::GetDocumentContext"
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
  - "IDebugCanStopEvent2::GetDocumentContext"
helpviewer_keywords: 
  - "IDebugCanStopEvent2::GetDocumentContext"
ms.assetid: 936a6c4e-30c5-4c7e-9ad5-910cc605a4b5
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugCanStopEvent2::GetDocumentContext
Gets the document context that describes the location of this event.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] Returns the [IDebugDocumentContext2](../vs140/idebugdocumentcontext2.md) interface that represents a position in a source file document corresponding to the current code location.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 Generally, the document context can be thought of as a position in a source file.  
  
 To get the code context, which is oriented towards code instructions, call the [IDebugCanStopEvent2::GetCodeContext](../vs140/idebugcanstopevent2--getcodecontext.md) method.  
  
## See Also  
 [IDebugCanStopEvent2](../vs140/idebugcanstopevent2.md)   
 [IDebugDocumentContext2](../vs140/idebugdocumentcontext2.md)   
 [IDebugCanStopEvent2::GetCodeContext](../vs140/idebugcanstopevent2--getcodecontext.md)