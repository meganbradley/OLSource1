---
title: "CMFCPreviewCtrlImpl::Create"
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
  - "afxwin/CMFCPreviewCtrlImpl::Create"
  - "Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create"
ms.assetid: cca6b860-a69e-4204-bdae-92962f2aa735
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPreviewCtrlImpl::Create
Overloaded. Called by a Rich Preview handler to create the Windows window.  
  
## Syntax  
  
```  
virtual BOOL Create(  
   HWND hWndParent,  
   const RECT* prc  
);  
virtual BOOL Create(  
   HWND hWndParent,  
   const RECT* prc,  
   CCreateContext* pContext  
);  
```  
  
#### Parameters  
 `hWndParent`  
 A handle to the host window supplied by the Shell for Rich Preview.  
  
 `prc`  
 Specifies the initial size and position of the window.  
  
 `pContext`  
 A pointer to a creation context.  
  
## Return Value  
 `TRUE` if creation succeeded; otherwise `FALSE`.  
  
## Remarks  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CMFCPreviewCtrlImpl Class](../vs140/cmfcpreviewctrlimpl-class.md)