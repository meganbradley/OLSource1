---
title: "IDebugDisassemblyStream2::GetDocument"
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
  - "IDebugDisassemblyStream2::GetDocument"
helpviewer_keywords: 
  - "IDebugDisassemblyStream2::GetDocument"
ms.assetid: 3d039a44-ebaa-4413-ac18-7cfd92c408bd
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugDisassemblyStream2::GetDocument
Gets the source document associated with this input stream.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The document URL.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Returns an [IDebugDocument2](../vs140/idebugdocument2.md) object representing the document.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 This method is implemented by debug engines that have text documents that are not stored in an actual file.  
  
## See Also  
 [IDebugDisassemblyStream2](../vs140/idebugdisassemblystream2.md)   
 [IDebugDocument2](../vs140/idebugdocument2.md)