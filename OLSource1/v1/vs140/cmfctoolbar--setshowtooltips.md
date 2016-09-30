---
title: "CMFCToolBar::SetShowTooltips"
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
  - "CMFCToolBar.SetShowTooltips"
  - "SetShowTooltips"
  - "CMFCToolBar::SetShowTooltips"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetShowTooltips method"
ms.assetid: 971e764f-fbc8-47d8-9f9c-f3a8dc72a391
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::SetShowTooltips
Specifies whether the framework displays tool tips.  
  
## Syntax  
  
```  
static void SetShowTooltips(  
   BOOL bValue   
);  
```  
  
#### Parameters  
 [in] `bValue`  
 If this parameter is `TRUE`, the framework shows tool tips. Otherwise, the framework hides tool tips.  
  
## Remarks  
 By default, the framework shows tool tips.  
  
 Call the [CMFCToolBar::GetShowTooltips](../vs140/cmfctoolbar--getshowtooltips.md) method to determine whether the framework shows tool tips.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBar::GetShowTooltips](../vs140/cmfctoolbar--getshowtooltips.md)