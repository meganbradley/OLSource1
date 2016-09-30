---
title: "IDebugDocumentContext2::GetStatementRange"
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
  - "IDebugDocumentContext2::GetStatementRange"
helpviewer_keywords: 
  - "IDebugDocumentContext2::GetStatementRange"
ms.assetid: bc94851a-0ec4-47ea-99c7-0a585e54e726
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugDocumentContext2::GetStatementRange
Gets the file statement range of the document context.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in, out] A [TEXT_POSITION](../vs140/text_position.md) structure that is filled in with the starting position. Set this argument to a null value if this information is not needed.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in, out] A [TEXT_POSITION](../vs140/text_position.md) structure that is filled in with the ending position. Set this argument to a null value if this information is not needed.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 A statement range is the range of the lines that contributed the code to which this document context refers.  
  
 To obtain the range of source code (including comments) within this document context, call the [GetSourceRange](../vs140/idebugdocumentcontext2--getsourcerange.md) method.  
  
## Example  
 The following example shows how to implement this method for a simple <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object that exposes the [IDebugDocumentContext2](../vs140/idebugdocumentcontext2.md) interface. This example fills in the ending position only if the beginning position is not a null value.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugDocumentContext2](../vs140/idebugdocumentcontext2.md)   
 [GetSourceRange](../vs140/idebugdocumentcontext2--getsourcerange.md)   
 [TEXT_POSITION](../vs140/text_position.md)