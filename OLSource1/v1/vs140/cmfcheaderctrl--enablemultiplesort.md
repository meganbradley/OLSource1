---
title: "CMFCHeaderCtrl::EnableMultipleSort"
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
  - "CMFCHeaderCtrl::EnableMultipleSort"
  - "CMFCHeaderCtrl.EnableMultipleSort"
  - "EnableMultipleSort"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableMultipleSort method"
ms.assetid: 82738ee4-e30b-4eb4-a39f-386db09d919c
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCHeaderCtrl::EnableMultipleSort
Enables or disables *multiple column sort* mode for the current header control.  
  
## Syntax  
  
```  
void EnableMultipleSort(  
   BOOL bEnable=TRUE   
);  
```  
  
#### Parameters  
 [in] `bEnable`  
 `TRUE` to enable multiple column sort mode; `FALSE` to disable multiple column sort mode and to remove any columns from the list of sorted columns. The default value is `TRUE`.  
  
## Remarks  
 Use this method to enable or disable multiple column sort mode. Two or more columns can participate in a sort if the header control is in multiple column sort mode.  
  
## Requirements  
 **Header:** afxheaderctrl.h  
  
## See Also  
 [CMFCHeaderCtrl Class](../vs140/cmfcheaderctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)