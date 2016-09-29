---
title: "CSliderCtrl::SetBuddy"
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
  - "CSliderCtrl.SetBuddy"
  - "CSliderCtrl::SetBuddy"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetBuddy method"
ms.assetid: 16639cec-9f57-4850-a46b-30b1df6e2e6c
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSliderCtrl::SetBuddy
Assigns a window as the buddy window for a slider control.  
  
## Syntax  
  
```  
  
      CWnd* SetBuddy(  
   CWnd* pWndBuddy,  
   BOOL fLocation = TRUE   
);  
```  
  
#### Parameters  
 `pWndBuddy`  
 A pointer to a `CWnd` object that will be set as the slider control's buddy.  
  
 `fLocation`  
 Value specifying the location at which to display the buddy window. This value can be one of the following:  
  
-   **TRUE** The buddy will appear to the left of the trackbar if the trackbar control uses the `TBS_HORZ` style. If the trackbar uses the `TBS_VERT` style, the buddy appears above the trackbar control.  
  
-   **FALSE** The buddy will appear to the right of the trackbar if the trackbar control uses the `TBS_HORZ` style. If the trackbar uses the `TBS_VERT` style, the buddy appears below the trackbar control.  
  
## Return Value  
 A pointer to a [CWnd](../vs140/cwnd-class.md) object that was previously assigned to the slider control at that location.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [TBM_SETBUDDY](http://msdn.microsoft.com/library/windows/desktop/bb760213), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. Note that this member function uses pointers to `CWnd` objects, rather than window handles for both its return value and parameter.  
  
 For a description of the slider control styles, see [Trackbar Control Styles](http://msdn.microsoft.com/library/windows/desktop/bb760147) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CSliderCtrl Class](../vs140/csliderctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSliderCtrl::GetBuddy](../vs140/csliderctrl--getbuddy.md)