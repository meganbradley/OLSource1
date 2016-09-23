---
title: "CDateTimeCtrl::GetMonthCalStyle"
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
  - GetMonthCalStyle method
  - CDateTimeCtrl.GetMonthCalStyle
  - CDateTimeCtrl::GetMonthCalStyle
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetMonthCalStyle method
ms.assetid: 8ee24ab1-e844-44b1-a8fc-8572845018f6
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDateTimeCtrl::GetMonthCalStyle
Gets the style of the drop-down month calendar control that is associated with the current date and time picker control.  
  
## Syntax  
  
```  
DWORD GetMonthCalStyle() const;  
```  
  
## Return Value  
 The style of the drop-down month calendar control, which is a bitwise combination (OR) of date and time picker control styles. For more information, see [Month Calendar Control Styles](http://msdn.microsoft.com/library/windows/desktop/bb760919).  
  
## Remarks  
 This method sends the [DTM_GETMCSTYLE](http://msdn.microsoft.com/library/windows/desktop/bb761763) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxdtctl.h  
  
 This method is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
## See Also  
 [CDateTimeCtrl Class](../vs140/cdatetimectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDateTimeCtrl::SetMonthCalStyle](../vs140/cdatetimectrl--setmonthcalstyle.md)   
 [DTM_GETMCSTYLE](http://msdn.microsoft.com/library/windows/desktop/bb761763)   
 [Date and Time Picker Control Styles](http://msdn.microsoft.com/library/windows/desktop/bb761728)