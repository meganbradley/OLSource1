---
title: "CMonthCalCtrl::SetMaxSelCount"
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
  - "SetMaxSelCount"
  - "CMonthCalCtrl::SetMaxSelCount"
  - "CMonthCalCtrl.SetMaxSelCount"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMonthCalCtrl class, operations"
  - "SetMaxSelCount method"
ms.assetid: e4095510-c98b-4928-be2b-b31be59f9583
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMonthCalCtrl::SetMaxSelCount
Sets the maximum number of days that can be selected in a month calendar control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The value that will be set to represent the maximum number of selectable days.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [MCM_SETMAXSELCOUNT](http://msdn.microsoft.com/library/windows/desktop/bb761008), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CMonthCalCtrl#8](../vs140/codesnippet/CPP/cmonthcalctrl--setmaxselcount_1.cpp)]  
  
## Requirements  
 **Header:** afxdtctl.h  
  
## See Also  
 [CMonthCalCtrl Class](../vs140/cmonthcalctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMonthCalCtrl::GetMaxSelCount](../vs140/cmonthcalctrl--getmaxselcount.md)