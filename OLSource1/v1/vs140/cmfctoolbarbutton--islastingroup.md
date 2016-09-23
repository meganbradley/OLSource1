---
title: "CMFCToolBarButton::IsLastInGroup"
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
  - CMFCToolBarButton.IsLastInGroup
  - CMFCToolBarButton::IsLastInGroup
  - IsLastInGroup
dev_langs: 
  - C++
helpviewer_keywords: 
  - IsLastInGroup method
ms.assetid: b5ec711d-ad2a-4bf7-be73-106e1216956a
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCToolBarButton::IsLastInGroup
Specifies whether the button is in the last position in its button group.  
  
## Syntax  
  
```  
virtual BOOL IsLastInGroup() const;  
```  
  
## Return Value  
 `TRUE` if the button is the last button in its button group; otherwise `FALSE`.  
  
## Remarks  
 This method defines a *button group* as a neighboring set of buttons that are positioned on the same row and are bounded by separators or the border of the toolbar This method returns `FALSE` if the toolbar button has no parent toolbar or the toolbar button refers to the **Customize** button. For more information about the **Customize** button, see [CMFCToolBar::GetCustomizeButton](../vs140/cmfctoolbar--getcustomizebutton.md).  
  
 Call the [CMFCToolBarButton::IsFirstInGroup](../vs140/cmfctoolbarbutton--isfirstingroup.md) method to determine whether the button is in the first position in its button group.  
  
## Requirements  
 **Header:** afxtoolbarbutton.h  
  
## See Also  
 [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCToolBar::GetCustomizeButton](../vs140/cmfctoolbar--getcustomizebutton.md)   
 [CMFCToolBarButton::IsFirstInGroup](../vs140/cmfctoolbarbutton--isfirstingroup.md)