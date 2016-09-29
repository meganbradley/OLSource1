---
title: "CMFCBaseTabCtrl::SetAutoColors"
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
  - "CMFCBaseTabCtrl::SetAutoColors"
  - "CMFCBaseTabCtrl.SetAutoColors"
  - "SetAutoColors"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetAutoColors method"
ms.assetid: 0d69079f-c358-4e8f-a742-bca7074a1877
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCBaseTabCtrl::SetAutoColors
Sets the colors of the tab control that the framework uses in automatic color mode.  
  
## Syntax  
  
```  
void SetAutoColors(  
   const CArray<COLORREF,COLORREF>& arColors   
);  
```  
  
#### Parameters  
 [in] `arColors`  
 An array of RGB colors.  
  
## Remarks  
 If you provide a custom array of colors, the default array of colors is ignored. If the parameter `arColors` is empty, the framework reverts to the default array of colors.  
  
 To enable autocolor mode, use the [CMFCBaseTabCtrl::EnableAutoColor](../vs140/cmfcbasetabctrl--enableautocolor.md) method.  
  
## Requirements  
 **Header:** afxbasetabctrl.h  
  
## See Also  
 [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCBaseTabCtrl::EnableAutoColor](../vs140/cmfcbasetabctrl--enableautocolor.md)