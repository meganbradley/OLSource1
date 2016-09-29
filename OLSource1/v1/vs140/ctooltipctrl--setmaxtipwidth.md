---
title: "CToolTipCtrl::SetMaxTipWidth"
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
  - "SetMaxTipWidth"
  - "CToolTipCtrl.SetMaxTipWidth"
  - "CToolTipCtrl::SetMaxTipWidth"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetMaxTipWidth method"
  - "tool tips [C++], width"
ms.assetid: 947cdc07-9f4f-4626-8a2f-559bf4f5c982
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolTipCtrl::SetMaxTipWidth
Sets the maximum width for a tool tip window.  
  
## Syntax  
  
```  
  
      int SetMaxTipWidth(  
   int iWidth   
);  
```  
  
#### Parameters  
 *iWidth*  
 The maximum tool tip window width to be set.  
  
## Return Value  
 The previous maximum tip width.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [TTM_SETMAXTIPWIDTH](http://msdn.microsoft.com/library/windows/desktop/bb760408), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolTipCtrl Class](../vs140/ctooltipctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolTipCtrl::GetMaxTipWidth](../vs140/ctooltipctrl--getmaxtipwidth.md)