---
title: "IDebugDocumentContext2::EnumCodeContexts"
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
  - "IDebugDocumentContext2::EnumCodeContexts"
helpviewer_keywords: 
  - "IDebugDocumentContext2::EnumCodeContexts"
ms.assetid: 627af69c-5cce-4e1d-8233-5f4d8dbc62e5
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugDocumentContext2::EnumCodeContexts
Retrieves a list of all code contexts associated with this document context.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Returns an [IEnumDebugCodeContexts2](../vs140/ienumdebugcodecontexts2.md) object that contains a list of code contexts.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 A single document context can generate multiple code contexts when the document is using templates or include files.  
  
## Example  
 The following example shows how to implement this method for a simple <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object that exposes the [IDebugDocumentContext2](../vs140/idebugdocumentcontext2.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugDocumentContext2](../vs140/idebugdocumentcontext2.md)   
 [IEnumDebugCodeContexts2](../vs140/ienumdebugcodecontexts2.md)