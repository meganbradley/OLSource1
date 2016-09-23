---
title: "CMFCTabCtrl::ModifyTabStyle"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CMFCTabCtrl::ModifyTabStyle
  - ModifyTabStyle
  - CMFCTabCtrl.ModifyTabStyle
dev_langs: 
  - C++
helpviewer_keywords: 
  - ModifyTabStyle method
ms.assetid: 4cde3030-a100-48eb-93fb-48d45ce41afa
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCTabCtrl::ModifyTabStyle
Specifies the appearance of tabs in the current tab control.  
  
## Syntax  
  
```  
BOOL ModifyTabStyle(  
   Style style  
);  
```  
  
#### Parameters  
 [in] `style`  
 One of the enumeration values that specifies the appearance of the tab control. For more information, see the table in Remarks.  
  
## Return Value  
 Always `TRUE`.  
  
## Remarks  
 The value of the `style` parameter can be one of the following `CMFCTabCtrl::Style`enumerations.  
  
|Name|Description|  
|----------|-----------------|  
|STYLE_3D|Displays three-dimensional, rectangular tabs that have round corners.|  
|STYLE_3D_ONENOTE|Displays three-dimensional tabs that have one vertical side and one slanted side and that have rounded corners.|  
|STYLE_3D_ROUNDED|Displays three-dimensional tabs that have slanted sides and rounded corners.|  
|STYLE_3D_ROUNDED_SCROLL|Displays three-dimensional tabs that have slanted sides and rounded corners. If there are more tabs than can be displayed at the same time, the framework displays a drop-down arrow and a menu of tabs to make active.|  
|STYLE_3D_SCROLLED|Displays three-dimensional, rectangular tabs. If there are more tabs than can be displayed at the same time, the framework displays a drop-down arrow and a menu of tabs to make active.|  
|STYLE_3D_VS2005|Displays three-dimensional, rounded tabs that have one slanted side and one vertical side.|  
|STYLE_FLAT|Displays two-dimensional tabs that have slanted left and right sides.|  
|STYLE_FLAT_SHARED_HORZ_SCROLL|Displays two-dimensional tabs. If there are more tabs than can be displayed at the same time, the framework displays scroll arrows at the ends of the tab area.|  
  
## Requirements  
 **Header:** afxtabctrl.h  
  
## See Also  
 [CMFCTabCtrl Class](../vs140/cmfctabctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)