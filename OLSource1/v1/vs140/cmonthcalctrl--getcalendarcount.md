---
title: "CMonthCalCtrl::GetCalendarCount"
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
  - "GetCalendarCount method"
  - "CMonthCalCtrl.GetCalendarCount"
  - "CMonthCalCtrl::GetCalendarCount"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetCalendarCount method"
ms.assetid: da1ce040-8b31-4718-b180-3569c107c10a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMonthCalCtrl::GetCalendarCount
Retrieves the number of calendars displayed in the current month calendar control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The number of calendars currently displayed in the month calendar control. The maximum allowed number of calendars is 12.  
  
## Remarks  
 This method sends the [MCM_GETCALENDARCOUNT](http://msdn.microsoft.com/library/windows/desktop/bb760947) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxdtctl.h  
  
 This control is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CMonthCalCtrl Class](../vs140/cmonthcalctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [MCM_GETCALENDARCOUNT](http://msdn.microsoft.com/library/windows/desktop/bb760947)