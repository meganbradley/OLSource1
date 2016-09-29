---
title: "CAxDialogImpl::DestroyWindow"
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
  - "CAxDialogImpl.DestroyWindow"
  - "CAxDialogImpl::DestroyWindow"
  - "ATL::CAxDialogImpl::DestroyWindow"
  - "ATL.CAxDialogImpl.DestroyWindow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DestroyWindow method"
ms.assetid: db769308-a5f3-4c71-981b-9d3fce14abdc
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAxDialogImpl::DestroyWindow
Call this method to destroy a modeless dialog box.  
  
## Syntax  
  
```  
  
BOOL DestroyWindow( );  
  
```  
  
## Return Value  
 TRUE if the window is successfully destroyed; otherwise FALSE.  
  
## Remarks  
 Do not call `DestroyWindow` to destroy a modal dialog box. Call [EndDialog](../vs140/caxdialogimpl--enddialog.md) instead.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CAxDialogImpl Class](../vs140/caxdialogimpl-class.md)   
 [DestroyWindow](http://msdn.microsoft.com/library/windows/desktop/ms632682)