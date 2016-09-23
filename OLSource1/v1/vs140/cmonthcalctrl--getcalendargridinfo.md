---
title: "CMonthCalCtrl::GetCalendarGridInfo"
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
  - CMonthCalCtrl.GetCalendarGridInfo
  - GetCalendarGridInfo method
  - CMonthCalCtrl::GetCalendarGridInfo
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetCalendarGridInfo method
ms.assetid: da8978f5-e939-45cd-8620-e6042690a071
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMonthCalCtrl::GetCalendarGridInfo
Retrieves information about the current month calendar control.  
  
## Syntax  
  
```  
BOOL GetCalendarGridInfo(  
     PMCGRIDINFO pmcGridInfo  
) const;  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[out] `pmcGridInfo`|Pointer to a [MCGRIDINFO](http://msdn.microsoft.com/library/windows/desktop/bb760925) structure that receives information about the current month calendar control. The caller is responsible for allocating and initializing this structure.|  
  
## Return Value  
 `true` if this method is successful; otherwise, `false`.  
  
## Remarks  
 This method sends the [MCM_GETCALENDARGRIDINFO](http://msdn.microsoft.com/library/windows/desktop/bb760949) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxdtctl.h  
  
 This control is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## Example  
 The following code example defines the variable, `m_monthCalCtrl`, that is used to programmatically access the month calendar control. This variable is used in the next example.  
  
 [!code[NVC_MFC_CMonthCalCtrl_s1#9](../vs140/codesnippet/CPP/cmonthcalctrl--getcalendargridinfo_1.h)]
  
  
## Example  
 The following code example uses the `GetCalendarGridInfo` method to retrieve the calendar date that the current month calendar control displays.  
  
 [!code[NVC_MFC_CMonthCalCtrl_s1#3](../vs140/codesnippet/CPP/cmonthcalctrl--getcalendargridinfo_2.cpp)]
  
  
## See Also  
 [CMonthCalCtrl Class](../vs140/cmonthcalctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [MCM_GETCALENDARGRIDINFO](http://msdn.microsoft.com/library/windows/desktop/bb760949)   
 [MCGRIDINFO](http://msdn.microsoft.com/library/windows/desktop/bb760925)