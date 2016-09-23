---
title: "CSliderCtrl::SetTipSide"
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
  - SetTipSide
  - CSliderCtrl.SetTipSide
  - CSliderCtrl::SetTipSide
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetTipSide method
ms.assetid: 3f2af1bc-c6fb-417c-a971-1457e372dca1
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CSliderCtrl::SetTipSide
Positions a tooltip control used by a trackbar control.  
  
## Syntax  
  
```  
  
      int SetTipSide(  
   int nLocation   
);  
```  
  
#### Parameters  
 `nLocation`  
 Value representing the location at which to display the tooltip control. For a list of possible values, see the Win32 message [TBM_SETTIPSIDE](http://msdn.microsoft.com/library/windows/desktop/bb760240), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 A value that represents the tooltip control's previous location. The return value equals one of the possible values for `nLocation`.  
  
## Remarks  
 This member function implements the behavior of the Win32 message **TBM_SETTIPSIDE**, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. Slider controls that use the **TBS_TOOLTIPS** style display tooltips. For a description of the slider control styles, see [Trackbar Control Styles](http://msdn.microsoft.com/library/windows/desktop/bb760147) in the [!INCLUDE[winsdkshort](../vs140/includes/winsdkshort_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CSliderCtrl Class](../vs140/csliderctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)