---
title: "CMDIChildWndEx::GetTaskbarPreviewWnd"
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
  - "afxmdichildwndex/CMDIChildWndEx::GetTaskbarPreviewWnd"
  - "GetTaskbarPreviewWnd"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTaskbarPreviewWnd"
ms.assetid: a522b9d6-77a3-4921-a590-e7ebe32570b6
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIChildWndEx::GetTaskbarPreviewWnd
Called by the framework when it needs to obtain a child window (usually a view or splitter window) to be displayed on a Windows 7 taskbar tab thumbnail.  
  
## Syntax  
  
```  
virtual CWnd* GetTaskbarPreviewWnd();  
```  
  
## Return Value  
 Should return a valid pointer to a `CWnd` object, whose preview should be displayed on a Windows 7 taskbar tab related to this MDI child. The default implementation returns a child window of this MDI child with AFX_IDW_PANE_FIRST control ID (which is usually a `CView`-derived class).  
  
## Remarks  
  
## Requirements  
 **Header:** afxmdichildwndex.h  
  
## See Also  
 [CMDIChildWndEx Class](../vs140/cmdichildwndex-class.md)