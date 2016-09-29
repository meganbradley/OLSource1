---
title: "CMonthCalCtrl::IsYearView"
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
  - "CMonthCalCtrl.IsYearView"
  - "CMonthCalCtrl::IsYearView"
  - "IsYearView method"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsYearView method"
ms.assetid: 29b62b09-66b1-4e20-8b94-6e9545626524
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMonthCalCtrl::IsYearView
Indicates whether the current view of the current month calendar control is the year view.  
  
## Syntax  
  
```  
BOOL IsYearView() const;  
```  
  
## Return Value  
 `true` if the current view is the year view; otherwise, `false`.  
  
## Remarks  
 This method sends the [MCM_GETCURRENTVIEW](http://msdn.microsoft.com/library/windows/desktop/bb760955) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. If that message returns `MCMV_YEAR`, this method returns `true`.  
  
## Requirements  
 **Header:** afxdtctl.h  
  
 This control is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CMonthCalCtrl Class](../vs140/cmonthcalctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMonthCalCtrl::GetCurrentView](../vs140/cmonthcalctrl--getcurrentview.md)