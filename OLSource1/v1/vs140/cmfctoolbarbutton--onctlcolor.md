---
title: "CMFCToolBarButton::OnCtlColor"
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
  - "CMFCToolBarButton::OnCtlColor"
  - "CMFCToolBarButton.OnCtlColor"
  - "OnCtlColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnCtlColor method"
ms.assetid: 83c71fa5-6550-437c-a787-81aa253865a0
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarButton::OnCtlColor
Called by the framework when the parent toolbar handles a `WM_CTLCOLOR` message.  
  
## Syntax  
  
```  
virtual HBRUSH OnCtlColor(  
   CDC* pDC,  
   UINT nCtlColor  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 The device context that displays the button.  
  
 [in] `nCtlColor`  
 The specific color notification.  
  
## Return Value  
 A handle to the brush object that the framework uses to paint the background of the button.  
  
## Remarks  
 The framework calls this method when the parent toolbar processes the `WM_CTLCOLOR` message for a toolbar button that contains a Windows control. The framework does not call this method if the toolbar button is windowless.  
  
 The framework calls this method when the toolbar framework is in customization mode and the toolbar button is unlocked. For more information about customization mode, see [CMFCToolBar::SetCustomizeMode](../vs140/cmfctoolbar--setcustomizemode.md). For more information about locking toolbar buttons, see [CMFCToolBarButton::IsLocked](../vs140/cmfctoolbarbutton--islocked.md).  
  
 The default implementation does nothing and returns `NULL`.  
  
## Requirements  
 **Header:** afxtoolbarbutton.h  
  
## See Also  
 [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBar::SetCustomizeMode](../vs140/cmfctoolbar--setcustomizemode.md)   
 [CMFCToolBarButton::IsLocked](../vs140/cmfctoolbarbutton--islocked.md)