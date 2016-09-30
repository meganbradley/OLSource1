---
title: "IDebugDocumentContext2::GetName"
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
  - "IDebugDocumentContext2::GetName"
helpviewer_keywords: 
  - "IDebugDocumentContext2::GetName"
ms.assetid: 546c5b2e-f166-4edb-9e61-57d797ca98a1
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugDocumentContext2::GetName
Gets the displayable name of the document that contains this document context.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] A value from the [GETNAME_TYPE](../vs140/getname_type.md) enumeration that specifies the type of name to return.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [out] Returns the name of the file.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 This method typically forwards the call to the [IDebugDocument2::GetName](../vs140/idebugdocument2--getname.md) method, unless the document context is written to store the document name itself (as the Example show).  
  
## Example  
 The following example shows how to implement this method for a simple <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object that exposes the [IDebugDocumentContext2](../vs140/idebugdocumentcontext2.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugDocumentContext2](../vs140/idebugdocumentcontext2.md)   
 [GETNAME_TYPE](../vs140/getname_type.md)