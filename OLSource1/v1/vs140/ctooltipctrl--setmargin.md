---
title: "CToolTipCtrl::SetMargin"
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
  - "CToolTipCtrl::SetMargin"
  - "SetMargin"
  - "CToolTipCtrl.SetMargin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "tool tips [C++], setting margin"
  - "SetMargin method"
ms.assetid: 7217236d-5712-4bc1-8f69-5f700debe4e1
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolTipCtrl::SetMargin
Sets the top, left, bottom, and right margins for a tool tip window.  
  
## Syntax  
  
```  
  
      void SetMargin(  
   LPRECT lprc   
);  
```  
  
#### Parameters  
 `lprc`  
 Address of a `RECT` structure that contains the margin information to be set. The members of the `RECT` structure do not define a bounding rectangle. See [CToolTipCtrl::GetMargin](../vs140/ctooltipctrl--getmargin.md) for a description of the margin information.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [TTM_SETMARGIN](http://msdn.microsoft.com/library/windows/desktop/bb760406), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolTipCtrl Class](../vs140/ctooltipctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolTipCtrl::GetMargin](../vs140/ctooltipctrl--getmargin.md)