---
title: "CDocument::m_bPreviewHandlerMode"
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
  - "afxwin/CDocument::m_bPreviewHandlerMode"
  - "m_bPreviewHandlerMode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_bPreviewHandlerMode data member"
ms.assetid: 843e7996-077b-4e5d-949b-7fd26b278ea6
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDocument::m_bPreviewHandlerMode
Specifies that the `CDocument` object was created by prevhost for Rich Preview. Should be checked in `CView::OnDraw`.  
  
## Syntax  
  
```  
BOOL m_bPreviewHandlerMode;  
```  
  
## Remarks  
 `TRUE` indicates that the document was created by prevhost for Rich Preview.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDocument Class](../vs140/cdocument-class.md)