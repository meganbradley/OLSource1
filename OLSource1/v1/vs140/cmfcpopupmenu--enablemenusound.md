---
title: "CMFCPopupMenu::EnableMenuSound"
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
  - "EnableMenuSound"
  - "CMFCPopupMenu.EnableMenuSound"
  - "CMFCPopupMenu::EnableMenuSound"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableMenuSound method"
ms.assetid: f77fe306-9ea2-4003-845c-526a21d88581
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPopupMenu::EnableMenuSound
Enables menu sound.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to enable sound, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> otherwise.  
  
## Remarks  
 If you enable sound, the framework calls the [PlaySound](http://msdn.microsoft.com/library/windows/desktop/bb774426) method when a user opens a pop-up menu or selects a menu command. By default, this feature is enabled.  
  
## Requirements  
 **Header:** afxpopupmenu.h  
  
## See Also  
 [CMFCPopupMenu Class](../vs140/cmfcpopupmenu-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)