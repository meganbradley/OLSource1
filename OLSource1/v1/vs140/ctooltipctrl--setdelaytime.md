---
title: "CToolTipCtrl::SetDelayTime"
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
  - "SetDelayTime"
  - "CToolTipCtrl.SetDelayTime"
  - "CToolTipCtrl::SetDelayTime"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetDelayTime method"
ms.assetid: 269deb38-c0f9-4416-86c7-115ebd4852e4
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolTipCtrl::SetDelayTime
Sets the delay time for a tool tip control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *nDelay*  
 Specifies the new delay time, in milliseconds.  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Flag that specifies which duration value will be retrieved. See [CToolTipCtrl::GetDelayTime](../vs140/ctooltipctrl--getdelaytime.md) for a description of the valid values.  
  
 *iTime*  
 The specified delay time, in milliseconds.  
  
## Remarks  
 The delay time is the length of time the cursor must remain on a tool before the tool tip window appears. The default delay time is 500 milliseconds.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolTipCtrl Class](../vs140/ctooltipctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolTipCtrl::Activate](../vs140/ctooltipctrl--activate.md)   
 [CToolTipCtrl::HitTest](../vs140/ctooltipctrl--hittest.md)   
 [CToolTipCtrl::GetDelayTime](../vs140/ctooltipctrl--getdelaytime.md)   
 [TTM_SETDELAYTIME](http://msdn.microsoft.com/library/windows/desktop/bb760404)