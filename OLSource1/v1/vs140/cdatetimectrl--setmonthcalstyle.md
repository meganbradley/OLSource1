---
title: "CDateTimeCtrl::SetMonthCalStyle"
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
  - "SetMonthCalStyle method"
  - "CDateTimeCtrl::SetMonthCalStyle"
  - "CDateTimeCtrl.SetMonthCalStyle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetMonthCalStyle method"
ms.assetid: 011c4dbc-5743-462a-91b8-ac29aab6270d
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDateTimeCtrl::SetMonthCalStyle
Sets the style of the drop-down month calendar control that is associated with the current date and time picker control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|A new month calendar control style, which is a bitwise combination (OR) of month calendar control styles. For more information, see [Month Calendar Control Styles](http://msdn.microsoft.com/library/windows/desktop/bb760919).|  
  
## Return Value  
 The previous style of the drop-down month calendar control.  
  
## Remarks  
 This method sends the [DTM_SETMCSTYLE](http://msdn.microsoft.com/library/windows/desktop/bb761778) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 The following code example defines the variable, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, that is used to programmatically access the date and time picker control. This variable is used in the next example.  
  
 [!code[NVC_MFC_CDateTimeCtrl_s1#1](../vs140/codesnippet/CPP/cdatetimectrl--setmonthcalstyle_1.h)]  
  
## Example  
 The following code example sets the date and time picker control to display week numbers, abbreviated names of days of the week, and no today indicator.  
  
 [!code[NVC_MFC_CDateTimeCtrl_s1#3](../vs140/codesnippet/CPP/cdatetimectrl--setmonthcalstyle_2.cpp)]  
  
## Requirements  
 **Header:** afxdtctl.h  
  
 This method is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
## See Also  
 [CDateTimeCtrl Class](../vs140/cdatetimectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDateTimeCtrl::GetMonthCalStyle](../vs140/cdatetimectrl--getmonthcalstyle.md)   
 [DTM_SETMCSTYLE](http://msdn.microsoft.com/library/windows/desktop/bb761778)   
 [Date and Time Picker Control Styles](http://msdn.microsoft.com/library/windows/desktop/bb761728)