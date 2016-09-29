---
title: "CToolBarCtrl::Customize"
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
  - "Customize"
  - "CToolBarCtrl::Customize"
  - "CToolBarCtrl.Customize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Customize method"
ms.assetid: 6327023c-3e9d-41fd-aa4f-46e65a63c680
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::Customize
Displays the Customize Toolbar dialog box.  
  
## Syntax  
  
```  
  
void Customize( );  
```  
  
## Remarks  
 This dialog box allows the user to customize the toolbar by adding and deleting buttons. To support customization, your toolbar's parent window must handle the customization notification messages as described in [Handling Customization Notifications](../vs140/handling-customization-notifications.md). Your toolbar must also have been created with the `CCS_ADJUSTABLE` style, as described in [CToolBarCtrl::Create](../vs140/ctoolbarctrl--create.md).  
  
 For more information, see Knowledge Base article Q241850 : PRB: Call to CToolBarCtrl::Customize Does Not Keep the Customize Dialog Visible.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Handling Customization Notifications](../vs140/handling-customization-notifications.md)