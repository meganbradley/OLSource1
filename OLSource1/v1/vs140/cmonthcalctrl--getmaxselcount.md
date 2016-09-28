---
title: "CMonthCalCtrl::GetMaxSelCount"
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
  - "CMonthCalCtrl.GetMaxSelCount"
  - "GetMaxSelCount"
  - "CMonthCalCtrl::GetMaxSelCount"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetMaxSelCount method"
  - "CMonthCalCtrl class, operations"
ms.assetid: e705dfcd-94c4-473a-96f5-63e97ad86fd5
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMonthCalCtrl::GetMaxSelCount
Retrieves the current maximum number of days that can be selected in a month calendar control.  
  
## Syntax  
  
```  
  
int GetMaxSelCount( ) const;  
  
```  
  
## Return Value  
 An integer value that represents the total number of days that can be selected for the control.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [MCM_GETMAXSELCOUNT](http://msdn.microsoft.com/library/windows/desktop/bb760960), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. Use this member function for controls with the **MCS_MULTISELECT** style set.  
  
## Example  
 See the example for [CMonthCalCtrl::SetMaxSelCount](../vs140/cmonthcalctrl--setmaxselcount.md).  
  
## Requirements  
 **Header:** afxdtctl.h  
  
## See Also  
 [CMonthCalCtrl Class](../vs140/cmonthcalctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMonthCalCtrl::SetMaxSelCount](../vs140/cmonthcalctrl--setmaxselcount.md)