---
title: "IDebugActivateDocumentEvent2::GetDocumentContext"
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
  - "IDebugActivateDocumentEvent2::GetDocumentContext"
helpviewer_keywords: 
  - "GetDocumentContext method"
  - "IDebugActivateDocumentEvent2::GetDocumentContext method"
ms.assetid: e7472069-7337-4ef4-8f8a-8c027a2e22f4
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugActivateDocumentEvent2::GetDocumentContext
Gets the document context that describes the position in the document that is to be made active by the debug package.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] Returns an [IDebugDocumentContext2](../vs140/idebugdocumentcontext2.md) object that represents a position in a source file document.  
  
## Remarks  
 This position might be used to show the caret, for example.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## See Also  
 [IDebugActivateDocumentEvent2](../vs140/idebugactivatedocumentevent2.md)   
 [IDebugDocumentContext2](../vs140/idebugdocumentcontext2.md)