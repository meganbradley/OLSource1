---
title: "CMonthCalCtrl::GetCurrentView"
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
  - "CMonthCalCtrl::GetCurrentView"
  - "GetCurrentView method"
  - "CMonthCalCtrl.GetCurrentView"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetCurrentView method"
ms.assetid: a7a24bbf-a24d-48e7-9a13-31859472e4ff
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMonthCalCtrl::GetCurrentView
Retrieves the view that is currently displayed by the current month calendar control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The current view, which is indicated by one of the following values:  
  
|Value|Meaning|  
|-----------|-------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Monthly view|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Annual view|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Decade view|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Century view|  
  
## Remarks  
 This method sends the [MCM_GETCURRENTVIEW](http://msdn.microsoft.com/library/windows/desktop/bb760955) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxdtctl.h  
  
 This control is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## Example  
 The following code example defines the variable, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, that is used to programmatically access the month calendar control. This variable is used in the next example.  
  
 [!code[NVC_MFC_CMonthCalCtrl_s1#9](../vs140/codesnippet/CPP/cmonthcalctrl--getcurrentview_1.h)]  
  
## Example  
 The following code example reports which view the month calendar control currently displays.  
  
 [!code[NVC_MFC_CMonthCalCtrl_s1#7](../vs140/codesnippet/CPP/cmonthcalctrl--getcurrentview_2.cpp)]  
  
## See Also  
 [CMonthCalCtrl Class](../vs140/cmonthcalctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [MCM_GETCURRENTVIEW](http://msdn.microsoft.com/library/windows/desktop/bb760955)   
 [CMonthCalCtrl::SetCurrentView](../vs140/cmonthcalctrl--setcurrentview.md)