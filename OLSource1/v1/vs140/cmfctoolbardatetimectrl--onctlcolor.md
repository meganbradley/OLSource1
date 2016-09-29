---
title: "CMFCToolBarDateTimeCtrl::OnCtlColor"
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
  - "CMFCToolBarDateTimeCtrl.OnCtlColor"
  - "CMFCToolBarDateTimeCtrl::OnCtlColor"
  - "OnCtlColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnCtlColor method"
ms.assetid: 463c18da-fd79-41f0-b0df-53499f3d93f6
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarDateTimeCtrl::OnCtlColor
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
 Unused.  
  
## Return Value  
 A handle to the global brush that the framework uses to paint the background of the button.  
  
## Remarks  
 This method overrides the base class implementation, [CMFCToolBarButton::OnCtlColor](../vs140/cmfctoolbarbutton--onctlcolor.md), by setting the text and background colors of the provided device context to the global text and background colors, respectively.  
  
 For more information about global options that are available to your application, see [AFX_GLOBAL_DATA Structure](../vs140/afx_global_data-structure.md).  
  
## Requirements  
 **Header:** afxtoolbardatetimectrl.h  
  
## See Also  
 [CMFCToolBarDateTimeCtrl Class](../vs140/cmfctoolbardatetimectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBarButton::OnCtlColor](../vs140/cmfctoolbarbutton--onctlcolor.md)   
 [AFX_GLOBAL_DATA Structure](../vs140/afx_global_data-structure.md)