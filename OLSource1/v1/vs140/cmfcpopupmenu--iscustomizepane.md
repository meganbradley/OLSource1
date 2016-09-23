---
title: "CMFCPopupMenu::IsCustomizePane"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CMFCPopupMenu::IsCustomizePane
  - IsCustomizePane
  - CMFCPopupMenu.IsCustomizePane
dev_langs: 
  - C++
helpviewer_keywords: 
  - IsCustomizePane method
ms.assetid: 19699577-8759-4a1d-a36f-610dd3ae51ba
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCPopupMenu::IsCustomizePane
Indicates whether the pop-up menu is functioning as a **QuickCustomizePane**.  
  
## Syntax  
  
```  
BOOL IsCustomizePane();  
```  
  
## Return Value  
 `TRUE` if the pop-up is a **QuckCustomizePane**; otherwise `FALSE`.  
  
## Remarks  
 Use the **QuickCustomizePane** to enable the user to directly customize the pop-up menu. The **QuickCustomizePane** is a [CMFCPopupMenu](../vs140/cmfcpopupmenu-class.md) that appears when the user clicks on a toolbar button to edit it directly.  
  
 Your application should call this method during [CMDIFrameWndEx::OnShowCustomizePane](../vs140/cmdiframewndex--onshowcustomizepane.md).  
  
## Requirements  
 **Header:** afxpopupmenu.h  
  
## See Also  
 [CMFCPopupMenu Class](../vs140/cmfcpopupmenu-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMDIFrameWndEx::OnShowCustomizePane](../vs140/cmdiframewndex--onshowcustomizepane.md)