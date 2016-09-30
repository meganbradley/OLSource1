---
title: "CDocument::OnPreviewHandlerQueryFocus"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "OnPreviewHandlerQueryFocus"
  - "afxwin/CDocument::OnPreviewHandlerQueryFocus"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnPreviewHandlerQueryFocus"
ms.assetid: 38a47c06-a065-4b64-bd5f-677ff05cfd3f
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDocument::OnPreviewHandlerQueryFocus
Directs the preview handler to return the HWND retrieved from calling the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> function.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] When this method returns, contains a pointer to the HWND returned from calling the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function from the preview handler's foreground thread.  
  
## Return Value  
 Returns S_OK if successful; or an error value otherwise.  
  
## Remarks  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDocument Class](../vs140/cdocument-class.md)