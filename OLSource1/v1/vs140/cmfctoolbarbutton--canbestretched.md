---
title: "CMFCToolBarButton::CanBeStretched"
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
  - "CanBeStretched"
  - "CMFCToolBarButton.CanBeStretched"
  - "CMFCToolBarButton::CanBeStretched"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CanBeStretched method"
ms.assetid: ff931e47-cf05-4bfd-af60-d14508e5c05b
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarButton::CanBeStretched
Specifies whether a user can stretch the button during customization.  
  
## Syntax  
  
```  
virtual BOOL CanBeStretched() const;  
```  
  
## Return Value  
 This method returns `FALSE`.  
  
## Remarks  
 This method is used by the framework to determine whether the button can be stretched in customization mode.  
  
 The default implementation of this method returns `FALSE`. Override this method to return `TRUE` for a variable-width control such as a combo box or slider.  
  
 For more information about customization mode, see [CMFCToolBar::SetCustomizeMode](../vs140/cmfctoolbar--setcustomizemode.md).  
  
## Requirements  
 **Header:** afxtoolbarbutton.h  
  
## See Also  
 [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBar::SetCustomizeMode](../vs140/cmfctoolbar--setcustomizemode.md)