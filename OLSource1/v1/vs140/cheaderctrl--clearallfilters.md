---
title: "CHeaderCtrl::ClearAllFilters"
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
  - "ClearAllFilters"
  - "CHeaderCtrl::ClearAllFilters"
  - "CHeaderCtrl.ClearAllFilters"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ClearAllFilters method"
ms.assetid: a96425fb-62e7-408d-bfbe-1b7bec75cc42
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHeaderCtrl::ClearAllFilters
Clears all filters for a header control.  
  
## Syntax  
  
```  
BOOL ClearAllFilters();  
```  
  
## Return Value  
 `true` if this method is successful; otherwise, `false`.  
  
## Remarks  
 This method implements the behavior of the Win32 message [HDM_CLEARFILTER](http://msdn.microsoft.com/library/windows/desktop/bb775306) with a column value of –1, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CHeaderCtrl#2](../vs140/codesnippet/CPP/cheaderctrl--clearallfilters_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CHeaderCtrl Class](../vs140/cheaderctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CHeaderCtrl::ClearFilter](../vs140/cheaderctrl--clearfilter.md)   
 [CHeaderCtrl::EditFilter](../vs140/cheaderctrl--editfilter.md)   
 [CHeaderCtrl::SetFilterChangeTimeout](../vs140/cheaderctrl--setfilterchangetimeout.md)