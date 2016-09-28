---
title: "CMFCPropertyGridCtrl::GetTextColor"
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
  - "CMFCPropertyGridCtrl::GetTextColor"
  - "GetTextColor"
  - "CMFCPropertyGridCtrl.GetTextColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTextColor method"
  - "CMFCPropertyGridCtrl::GetTextColor"
ms.assetid: 1873e882-ec1f-43d7-ada6-8b6ef2f543d4
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertyGridCtrl::GetTextColor
Retrieves the color that is used to draw the text of property items in the current property grid control.  
  
## Syntax  
  
```  
COLORREF GetTextColor() const;  
```  
  
## Return Value  
 An RGB color value.  
  
## Remarks  
 This method retrieves the color that the framework uses to draw the foreground of the current property grid control. The [CMFCPropertyGridCtrl::GetBkColor](../vs140/cmfcpropertygridctrl--getbkcolor.md) method retrieves the background color.  
  
## Requirements  
 **Header:** afxpropertygridctrl.h  
  
## See Also  
 [CMFCPropertyGridCtrl Class](../vs140/cmfcpropertygridctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449)   
 [CMFCPropertyGridCtrl::GetBkColor](../vs140/cmfcpropertygridctrl--getbkcolor.md)