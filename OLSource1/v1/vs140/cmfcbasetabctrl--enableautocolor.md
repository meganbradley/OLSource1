---
title: "CMFCBaseTabCtrl::EnableAutoColor"
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
  - "EnableAutoColor"
  - "CMFCBaseTabCtrl::EnableAutoColor"
  - "CMFCBaseTabCtrl.EnableAutoColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableAutoColor method"
ms.assetid: de35377f-c045-4933-bd2e-64de11d71192
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCBaseTabCtrl::EnableAutoColor
Controls whether the framework uses the automatic background colors when drawing a tab.  
  
## Syntax  
  
```  
void EnableAutoColor(  
   BOOL bEnable = TRUE  
);  
```  
  
#### Parameters  
 [in] `bEnable`  
 A Boolean parameter that determines whether the framework uses automatic colors.  
  
## Remarks  
 A tab control has an array of several predefined colors. When the framework uses automatic colors, each tab in a series of tabs is assigned the next color from this array.  
  
 By default, the automatic colors are determined by the library-defined colors. You can provide a custom array of colors by calling [CMFCBaseTabCtrl::SetAutoColors](../vs140/cmfcbasetabctrl--setautocolors.md).  
  
## Requirements  
 **Header:** afxbasetabctrl.h  
  
## See Also  
 [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCBaseTabCtrl::SetAutoColors](../vs140/cmfcbasetabctrl--setautocolors.md)