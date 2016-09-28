---
title: "CMFCToolBarButton::OnDblClk"
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
  - "OnDblClk"
  - "CMFCToolBarButton.OnDblClk"
  - "CMFCToolBarButton::OnDblClk"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDblClk method"
ms.assetid: 2c7dcf5a-55e3-4159-ae67-17c678252fb4
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarButton::OnDblClk
Called by the framework when the parent toolbar handles a [WM_LBUTTONDBLCLK](http://msdn.microsoft.com/library/windows/desktop/ms645606) message.  
  
## Syntax  
  
```  
virtual void OnDblClk(  
   CWnd* pWnd  
);  
```  
  
#### Parameters  
 [in] `pWnd`  
 -   The parent window of the button.  
  
## Remarks  
 This method is called by the `CMFCToolBar::OnLButtonDblClk` method when the parent toolbar handles a [WM_LBUTTONDBLCLK](http://msdn.microsoft.com/library/windows/desktop/ms645606) message.  
  
 The default implementation of this method does nothing.  
  
## Requirements  
 **Header:** afxtoolbarbutton.h  
  
## See Also  
 [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [WM_LBUTTONDBLCLK](http://msdn.microsoft.com/library/windows/desktop/ms645606)