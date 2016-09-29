---
title: "CAtlPreviewCtrlImpl::Create"
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
  - "atlpreviewctrlimpl/CAtlPreviewCtrlImpl::Create"
  - "Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create"
ms.assetid: f3d13a6d-c846-462c-8e94-59781f20ada5
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlPreviewCtrlImpl::Create
Called by a Rich Preview handler to create the Windows window.  
  
## Syntax  
  
```  
virtual BOOL Create(  
   HWND hWndParent,  
   const RECT* prc  
);  
```  
  
#### Parameters  
 `hWndParent`  
 A handle to the host window supplied by the Shell for Rich Preview.  
  
 `prc`  
 Specifies the initial size and position of the window.  
  
## Return Value  
 `TRUE` if successful; otherwise `FALSE`.  
  
## Remarks  
  
## Requirements  
 **Header:** atlpreviewctrlimpl.h  
  
## See Also  
 [CAtlPreviewCtrlImpl Class](../vs140/catlpreviewctrlimpl-class.md)