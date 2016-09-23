---
title: "CSliderCtrl::GetToolTips"
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
  - CSliderCtrl::GetToolTips
  - CSliderCtrl.GetToolTips
  - GetToolTips
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetToolTips method
ms.assetid: 39c64872-7636-47ac-bff6-5543e5078cd2
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CSliderCtrl::GetToolTips
Retrieves the handle to the tooltip control assigned to the slider control, if any.  
  
## Syntax  
  
```  
  
CToolTipCtrl* GetToolTips( ) const;  
  
```  
  
## Return Value  
 A pointer to a [CToolTipCtrl](../vs140/ctooltipctrl-class.md) object, or **NULL** if tooltips are not in use. If the slider control does not use the **TBS_TOOLTIPS** style, the return value is **NULL**.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [TBM_GETTOOLTIPS](http://msdn.microsoft.com/library/windows/desktop/bb760209), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. Note that this member function returns a `CToolTipCtrl` object instead of a handle to a control.  
  
 For a description of the slider control styles, see [Trackbar Control Styles](http://msdn.microsoft.com/library/windows/desktop/bb760147) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CSliderCtrl Class](../vs140/csliderctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSliderCtrl::SetToolTips](../vs140/csliderctrl--settooltips.md)