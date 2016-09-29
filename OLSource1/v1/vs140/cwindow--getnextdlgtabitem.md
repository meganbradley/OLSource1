---
title: "CWindow::GetNextDlgTabItem"
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
  - "CWindow::GetNextDlgTabItem"
  - "GetNextDlgTabItem"
  - "CWindow.GetNextDlgTabItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetNextDlgTabItem method"
ms.assetid: 43e4774f-d8bc-4251-b36a-b28eb49023e7
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWindow::GetNextDlgTabItem
Retrieves the previous or next control having the **WS_TABSTOP** style.  
  
## Syntax  
  
```  
  
      HWND GetNextDlgTabItem(  
   HWND hWndCtl,  
   BOOL bPrevious = FALSE   
) const throw();  
```  
  
## Remarks  
 See [GetNextDlgTabItem](http://msdn.microsoft.com/library/windows/desktop/ms645495) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)   
 [CWindow::GetNextDlgGroupItem](../vs140/cwindow--getnextdlggroupitem.md)