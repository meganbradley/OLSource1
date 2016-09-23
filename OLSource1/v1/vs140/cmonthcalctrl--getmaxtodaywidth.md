---
title: "CMonthCalCtrl::GetMaxTodayWidth"
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
  - CMonthCalCtrl::GetMaxTodayWidth
  - CMonthCalCtrl.GetMaxTodayWidth
  - GetMaxTodayWidth method
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetMaxTodayWidth method
ms.assetid: b29f654d-a5d8-489f-ba42-f746eb1331a5
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMonthCalCtrl::GetMaxTodayWidth
Retrieves the maximum width of the "Today" string for the current month calendar control.  
  
## Syntax  
  
```  
DWORD GetMaxTodayWidth() const;  
```  
  
## Return Value  
 The width of the "Today" string, in pixels.  
  
## Example  
 The following code example defines the variable, `m_monthCalCtrl`, that is used to programmatically access the month calendar control. This variable is used in the next example.  
  
 [!code[NVC_MFC_CMonthCalCtrl_s1#9](../vs140/codesnippet/CPP/cmonthcalctrl--getmaxtodaywidth_1.h)]
  
  
## Example  
 The following code example demonstrates the `GetMaxTodayWidth` method.  
  
 [!code[NVC_MFC_CMonthCalCtrl_s1#1](../vs140/codesnippet/CPP/cmonthcalctrl--getmaxtodaywidth_2.cpp)]
  
  
## Remarks  
 The user can return to the current date by clicking the "Today" string, which is displayed at the bottom of the month calendar control. The "Today" string includes label text and date text.  
  
 This method sends the [MCM_GETMAXTODAYWIDTH](http://msdn.microsoft.com/library/windows/desktop/bb760962) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxdtctl.h  
  
## See Also  
 [CMonthCalCtrl Class](../vs140/cmonthcalctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [MCM_GETMAXTODAYWIDTH](http://msdn.microsoft.com/library/windows/desktop/bb760962)