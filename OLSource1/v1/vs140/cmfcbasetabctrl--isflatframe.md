---
title: "CMFCBaseTabCtrl::IsFlatFrame"
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
  - "CMFCBaseTabCtrl::IsFlatFrame"
  - "CMFCBaseTabCtrl.IsFlatFrame"
  - "IsFlatFrame"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsFlatFrame method"
ms.assetid: f46d681a-bfe0-4757-b394-f0558b1b86c1
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCBaseTabCtrl::IsFlatFrame
Indicates whether the frame of the tab control is rendered in a flat style or in a 3D style.  
  
## Syntax  
  
```  
virtual BOOL IsFlatFrame() const;  
```  
  
## Return Value  
 `TRUE` if the frame of the tab control is rendered in a flat style; `FALSE` if the frame is rendered in a 3D style.  
  
## Remarks  
 Use [CMFCTabCtrl::SetFlatFrame](../vs140/cmfctabctrl--setflatframe.md) to change the style for the frame of the tab control.  
  
 Tab controls that use the Outlook style cannot be rendered with flat frames. This includes the [CMFCOutlookBarTabCtrl Class](../vs140/cmfcoutlookbartabctrl-class.md) and any classes derived from that class.  
  
## Requirements  
 **Header:** afxbasetabctrl.h  
  
## See Also  
 [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCTabCtrl::SetFlatFrame](../vs140/cmfctabctrl--setflatframe.md)