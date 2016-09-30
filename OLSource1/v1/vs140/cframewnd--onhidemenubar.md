---
title: "CFrameWnd::OnHideMenuBar"
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
  - "CFrameWnd.OnHideMenuBar"
  - "OnHideMenuBar"
  - "CFrameWnd::OnHideMenuBar"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnHideMenuBar method"
ms.assetid: c87cf2dd-0e80-4d0c-849e-ca763c545019
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWnd::OnHideMenuBar
This function is called when the system is about to hide the menu bar in the current MFC application.  
  
## Syntax  
  
```  
virtual void OnHideMenuBar();  
```  
  
## Remarks  
 This event handler enables your application to perform custom actions when the system is about to hide the menu. You cannot prevent the menu from being hidden, but you can, for example, call other methods to retrieve the menu style or state.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CFrameWnd Class](../vs140/cframewnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFrameWnd::OnShowMenuBar](../vs140/cframewnd--onshowmenubar.md)