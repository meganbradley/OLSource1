---
title: "CMFCToolBarButton::IsHidden"
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
  - "IsHidden"
  - "CMFCToolBarButton::IsHidden"
  - "CMFCToolBarButton.IsHidden"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsHidden method"
ms.assetid: 138eef89-5be3-4fb4-9aca-d37b1ad59508
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarButton::IsHidden
Determines whether the button is hidden.  
  
## Syntax  
  
```  
BOOL IsHidden() const;  
```  
  
## Return Value  
 Nonzero if the button is hidden (invisible); otherwise 0.  
  
## Remarks  
 The framework calls this method when the parent toolbar is stretched to determine whether the toolbar button is visible.  
  
 If you set the button to be invisible by using the [CMFCToolBarButton::SetVisible](../vs140/cmfctoolbarbutton--setvisible.md) method, use [CMFCToolBarButton::IsVisible](../vs140/cmfctoolbarbutton--isvisible.md) to determine whether the toolbar button is visible.  
  
 By default, all toolbar buttons are visible. Use the [CMFCToolBarButton::Show](../vs140/cmfctoolbarbutton--show.md) method to hide or show toolbar buttons.  
  
## Requirements  
 **Header:** afxtoolbarbutton.h  
  
## See Also  
 [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBarButton::SetVisible](../vs140/cmfctoolbarbutton--setvisible.md)   
 [CMFCToolBarButton::IsVisible](../vs140/cmfctoolbarbutton--isvisible.md)   
 [CMFCToolBarButton::Show](../vs140/cmfctoolbarbutton--show.md)