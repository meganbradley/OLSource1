---
title: "IDebugDocumentContext2::GetLanguageInfo"
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
  - "IDebugDocumentContext2::GetLanguageInfo"
helpviewer_keywords: 
  - "IDebugDocumentContext2::GetLanguageInfo"
ms.assetid: 6a212ee5-414c-4eb5-ab11-19db1786943d
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugDocumentContext2::GetLanguageInfo
Gets the language associated with this document context.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Returns the name of the language that implements the code at this document context.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [out] Returns the GUID of the language that implements the code at this document context. For example, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. This GUID is not limited to the languages supplied by [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)].  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Example  
 The following example shows how to implement this method for a simple <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object that exposes the [IDebugDocumentContext2](../vs140/idebugdocumentcontext2.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugDocumentContext2](../vs140/idebugdocumentcontext2.md)