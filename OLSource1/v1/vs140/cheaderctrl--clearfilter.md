---
title: "CHeaderCtrl::ClearFilter"
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
  - "CHeaderCtrl::ClearFilter"
  - "CHeaderCtrl.ClearFilter"
  - "ClearFilter"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ClearFilter method"
ms.assetid: 605366ca-f24f-49e9-b981-6ca39f70da7b
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHeaderCtrl::ClearFilter
Clears the filter for a header control.  
  
## Syntax  
  
```  
BOOL ClearFilter(  
   int nColumn  
);  
```  
  
#### Parameters  
 `nColumn`  
 Column value indicating which filter to clear.  
  
## Return Value  
 `true` if this method is successful; otherwise, `false`.  
  
## Remarks  
 This method implements the behavior of the Win32 message [HDM_CLEARFILTER](http://msdn.microsoft.com/library/windows/desktop/bb775306), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CHeaderCtrl#3](../vs140/codesnippet/CPP/cheaderctrl--clearfilter_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CHeaderCtrl Class](../vs140/cheaderctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CHeaderCtrl::ClearAllFilters](../vs140/cheaderctrl--clearallfilters.md)   
 [CHeaderCtrl::EditFilter](../vs140/cheaderctrl--editfilter.md)   
 [CHeaderCtrl::SetFilterChangeTimeout](../vs140/cheaderctrl--setfilterchangetimeout.md)