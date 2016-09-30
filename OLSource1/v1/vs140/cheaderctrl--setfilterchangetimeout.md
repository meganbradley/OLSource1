---
title: "CHeaderCtrl::SetFilterChangeTimeout"
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
  - "CHeaderCtrl::SetFilterChangeTimeout"
  - "SetFilterChangeTimeout"
  - "CHeaderCtrl.SetFilterChangeTimeout"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetFilterChangeTimeout method"
ms.assetid: 768dfe94-e377-4ca8-8916-f51f764b70a2
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHeaderCtrl::SetFilterChangeTimeout
Sets the timeout interval between the time a change takes place in the filter attributes and the posting of an [HDN_FILTERCHANGE](http://msdn.microsoft.com/library/windows/desktop/bb775277) notification.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *dwTimeOut*  
 Timeout value, in milliseconds.  
  
## Return Value  
 The index of the filter control being modified.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [HDM_SETFILTERCHANGETIMEOUT](http://msdn.microsoft.com/library/windows/desktop/bb775359), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CHeaderCtrl#15](../vs140/codesnippet/CPP/cheaderctrl--setfilterchangetimeout_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CHeaderCtrl Class](../vs140/cheaderctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CHeaderCtrl::ClearAllFilters](../vs140/cheaderctrl--clearallfilters.md)   
 [CHeaderCtrl::ClearFilter](../vs140/cheaderctrl--clearfilter.md)   
 [CHeaderCtrl::EditFilter](../vs140/cheaderctrl--editfilter.md)