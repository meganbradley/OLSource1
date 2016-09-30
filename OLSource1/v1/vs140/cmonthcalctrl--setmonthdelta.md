---
title: "CMonthCalCtrl::SetMonthDelta"
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
  - "CMonthCalCtrl::SetMonthDelta"
  - "SetMonthDelta"
  - "CMonthCalCtrl.SetMonthDelta"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMonthCalCtrl class, attributes"
  - "SetMonthDelta method"
ms.assetid: 9d1a9eb9-1988-40ed-b644-c0bd2ac8705c
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMonthCalCtrl::SetMonthDelta
Sets the scroll rate for a month calendar control.  
  
## Syntax  
  
```  
  
      int SetMonthDelta(  
   int iDelta   
);  
```  
  
#### Parameters  
 *iDelta*  
 The number of months to be set as the control's scroll rate. If this value is zero, the month delta is reset to the default, which is the number of months displayed in the control.  
  
## Return Value  
 The previous scroll rate. If the scroll rate has not been previously set, the return value is 0.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [MCM_SETMONTHDELTA](http://msdn.microsoft.com/library/windows/desktop/bb761010), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxdtctl.h  
  
## See Also  
 [CMonthCalCtrl Class](../vs140/cmonthcalctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMonthCalCtrl::GetMonthDelta](../vs140/cmonthcalctrl--getmonthdelta.md)