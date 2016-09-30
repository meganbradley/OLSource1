---
title: "CToolTipCtrl::GetMargin"
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
  - "CToolTipCtrl.GetMargin"
  - "CToolTipCtrl::GetMargin"
  - "GetMargin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetMargin method"
ms.assetid: 303d8abc-950f-4349-b4ff-5dd98496ed42
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolTipCtrl::GetMargin
Retrieves the top, left, bottom, and right margins set for a tool tip window.  
  
## Syntax  
  
```  
  
      void GetMargin(  
   LPRECT lprc   
) const;  
```  
  
#### Parameters  
 `lprc`  
 Address of a `RECT` structure that will receive the margin information. The members of the [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure do not define a bounding rectangle. For the purpose of this message, the structure members are interpreted as follows:  
  
|Member|Representation|  
|------------|--------------------|  
|**top**|Distance between top border and top of tool tip text, in pixels.|  
|**left**|Distance between left border and left end of tip text, in pixels.|  
|**bottom**|Distance between bottom border and bottom of tip text, in pixels.|  
|**right**|Distance between right border and right end of tip text, in pixels.|  
  
## Remarks  
 This member function implements the behavior of the Win32 message [TTM_GETMARGIN](http://msdn.microsoft.com/library/windows/desktop/bb760391), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolTipCtrl Class](../vs140/ctooltipctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolTipCtrl::SetMargin](../vs140/ctooltipctrl--setmargin.md)