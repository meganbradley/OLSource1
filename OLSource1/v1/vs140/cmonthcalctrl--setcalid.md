---
title: "CMonthCalCtrl::SetCalID"
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
  - "CMonthCalCtrl::SetCalID"
  - "SetCalID method"
  - "CMonthCalCtrl.SetCalID"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetCalID method"
ms.assetid: 9d629550-eb11-4f54-a7e6-bf650b96a763
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMonthCalCtrl::SetCalID
Sets the calendar identifier for the current month calendar control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|One of the [calendar identifier](http://msdn.microsoft.com/library/windows/desktop/dd317732) constants.|  
  
## Return Value  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if this method is successful; otherwise, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Remarks  
 A calendar identifier specifies a region-specific calendar, such as the Gregorian (localized), Japanese, or Hijri calendars. Use the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> method to display a calendar that is specified by the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter if the locale that contains the calendar is installed on your computer.  
  
 This method sends the [MCM_SETCALID](http://msdn.microsoft.com/library/windows/desktop/bb760995) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxdtctl.h  
  
 This control is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## Example  
 The following code example defines the variable, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, that is used to programmatically access the month calendar control. This variable is used in the next example.  
  
 [!code[NVC_MFC_CMonthCalCtrl_s1#9](../vs140/codesnippet/CPP/cmonthcalctrl--setcalid_1.h)]  
  
## Example  
 The following code example sets the month calendar control to display the Japanese Emperor Era calendar. The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> method succeeds only if that calendar is installed on your computer.  
  
 [!code[NVC_MFC_CMonthCalCtrl_s1#4](../vs140/codesnippet/CPP/cmonthcalctrl--setcalid_2.cpp)]  
  
## See Also  
 [CMonthCalCtrl Class](../vs140/cmonthcalctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [MCM_SETCALID](http://msdn.microsoft.com/library/windows/desktop/bb760995)   
 [Calendar Identifiers](http://msdn.microsoft.com/library/windows/desktop/dd317732)   
 [CMonthCalCtrl::GetCalID](../vs140/cmonthcalctrl--getcalid.md)