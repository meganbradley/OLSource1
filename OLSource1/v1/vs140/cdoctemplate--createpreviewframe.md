---
title: "CDocTemplate::CreatePreviewFrame"
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
  - "CreatePreviewFrame"
  - "afxwin/CDocTemplate::CreatePreviewFrame"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreatePreviewFrame"
ms.assetid: d16a87e3-bb38-4654-aa6f-a42d7d6d06b8
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDocTemplate::CreatePreviewFrame
Creates a child frame used for Rich Preview.  
  
## Syntax  
  
```  
CFrameWnd* CreatePreviewFrame(  
   CWnd* pParentWnd,  
   CDocument* pDoc  
);  
```  
  
#### Parameters  
 `pParentWnd`  
 A pointer to a parent window (usually provided by the Shell).  
  
 `pDoc`  
 A pointer to a document object, whose content will be previewed.  
  
## Return Value  
 A valid pointer to a `CFrameWnd` object, or `NULL` if the creation fails.  
  
## Remarks  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDocTemplate Class](../vs140/cdoctemplate-class.md)