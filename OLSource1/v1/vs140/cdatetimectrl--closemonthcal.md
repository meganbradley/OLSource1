---
title: "CDateTimeCtrl::CloseMonthCal"
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
  - "CloseMonthCal method"
  - "CDateTimeCtrl::CloseMonthCal"
  - "CDateTimeCtrl.CloseMonthCal"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CloseMonthCal method"
ms.assetid: 36bce7ff-0f97-4ed4-a520-6cb81c35e6eb
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDateTimeCtrl::CloseMonthCal
Closes the current date and time picker control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 This method sends the [DTM_CLOSEMONTHCAL](http://msdn.microsoft.com/library/windows/desktop/bb761753) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 The following code example defines the variable, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, that is used to programmatically access the date and time picker control. This variable is used in the next example.  
  
 [!code[NVC_MFC_CDateTimeCtrl_s1#1](../vs140/codesnippet/CPP/cdatetimectrl--closemonthcal_1.h)]  
  
## Example  
 The following code example closes the drop-down calendar for the current date and time picker control.  
  
 [!code[NVC_MFC_CDateTimeCtrl_s1#5](../vs140/codesnippet/CPP/cdatetimectrl--closemonthcal_2.cpp)]  
  
## Requirements  
 **Header:** afxdtctl.h  
  
 This method is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
## See Also  
 [CDateTimeCtrl Class](../vs140/cdatetimectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [DTM_CLOSEMONTHCAL](http://msdn.microsoft.com/library/windows/desktop/bb761753)