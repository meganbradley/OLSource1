---
title: "CDocument::IsSearchAndOrganizeHandler"
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
  - "afxwin/CDocument::IsSearchAndOrganizeHandler"
  - "IsSearchAndOrganizeHandler"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsSearchAndOrganizeHandler"
ms.assetid: 57756e0e-abc8-47d9-948c-603915a44255
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDocument::IsSearchAndOrganizeHandler
Tells whether this instance of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> was created for the Search & Organize handler.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if this instance of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> was created for the Search & Organize handler.  
  
## Remarks  
 Currently this function returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> only for Rich Preview handlers implemented in an out of process server. You can set the appropriate flags (m_bPreviewHandlerMode, m_bSearchMode, m_bGetThumbnailMode) at your application level to make this function return <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDocument Class](../vs140/cdocument-class.md)