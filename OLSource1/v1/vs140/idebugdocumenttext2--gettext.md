---
title: "IDebugDocumentText2::GetText"
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
  - "IDebugDocumentText2::GetText"
helpviewer_keywords: 
  - "IDebugDocumentText2::GetText"
ms.assetid: f8c15a58-da77-473e-a721-7a094e306c63
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugDocumentText2::GetText
Retrieves the text from the specified position in the document.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] A [TEXT_POSITION](../vs140/text_position.md) structure that indicates the location of the text to be retrieved.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] The maximum number of characters of the text to be retrieved.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [in, out] A pointer to a buffer that is to be filled in with the desired text. This buffer must be able to contain at least <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> number of wide characters.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 [out] Returns the number of characters actually retrieved.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Example  
 This example shows how this method can be called from C#.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugDocumentText2](../vs140/idebugdocumenttext2.md)   
 [TEXT_POSITION](../vs140/text_position.md)