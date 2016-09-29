---
title: "CMonthCalCtrl::SetCalendarBorder"
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
  - "SetCalendarBorder method"
  - "CMonthCalCtrl::SetCalendarBorder"
  - "CMonthCalCtrl.SetCalendarBorder"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetCalendarBorder method"
ms.assetid: 7d8395ff-a7e4-487f-ae1a-3d626dc2ecf8
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMonthCalCtrl::SetCalendarBorder
Sets the width of the border of the current month calendar control.  
  
## Syntax  
  
```  
void SetCalendarBorder(  
     int cxyBorder  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `cxyBorder`|The width of the border, in pixels.|  
  
## Remarks  
 If this method succeeds, the border width is set to the `cxyBorder` parameter. Otherwise, the border width is reset to the default value that is specified by the current [theme](_inet_themes_visualstyles_overview), or zero if themes are not used.  
  
 This method sends the [MCM_SETCALENDARBORDER](http://msdn.microsoft.com/library/windows/desktop/bb760993) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxdtctl.h  
  
 This control is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## Example  
 The following code example defines the variable, `m_monthCalCtrl`, that is used to programmatically access the month calendar control. This variable is used in the next example.  
  
 [!code[NVC_MFC_CMonthCalCtrl_s1#9](../vs140/codesnippet/CPP/cmonthcalctrl--setcalendarborder_1.h)]  
  
## Example  
 The following code example sets the border width of the month calendar control to eight pixels. Use the [CMonthCalCtrl::GetCalendarBorder](../vs140/cmonthcalctrl--getcalendarborder.md) method to determine whether this method succeeded.  
  
 [!code[NVC_MFC_CMonthCalCtrl_s1#6](../vs140/codesnippet/CPP/cmonthcalctrl--setcalendarborder_2.cpp)]  
  
## See Also  
 [CMonthCalCtrl Class](../vs140/cmonthcalctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMonthCalCtrl::SetCalendarBorderDefault](../vs140/cmonthcalctrl--setcalendarborderdefault.md)   
 [MCM_SETCALENDARBORDER](http://msdn.microsoft.com/library/windows/desktop/bb760993)   
 [Themes and Visual Styles](_inet_themes_visualstyles_overview)