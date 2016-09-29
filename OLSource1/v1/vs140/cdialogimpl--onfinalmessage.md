---
title: "CDialogImpl::OnFinalMessage"
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
  - "CDialogImpl::OnFinalMessage"
  - "CDialogImpl.OnFinalMessage"
  - "OnFinalMessage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnFinalMessage method"
ms.assetid: 1b16f4dc-80e5-4b11-a0ff-f224ffe2d774
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDialogImpl::OnFinalMessage
Called after receiving the last message (typically `WM_NCDESTROY`).  
  
## Syntax  
  
```  
  
      virtual void OnFinalMessage(  
   HWND hWnd   
);  
```  
  
#### Parameters  
 `hWnd`  
 [in] A handle to the window being destroyed.  
  
## Remarks  
 Note that if you want to automatically delete your object upon the window destruction, you can call `delete this;` here.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CDialogImpl Class](../vs140/cdialogimpl-class.md)   
 [CDialogImpl::GetDialogProc](../vs140/cdialogimpl--getdialogproc.md)