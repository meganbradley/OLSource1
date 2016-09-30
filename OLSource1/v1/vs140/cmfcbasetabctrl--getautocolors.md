---
title: "CMFCBaseTabCtrl::GetAutoColors"
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
  - "CMFCBaseTabCtrl.GetAutoColors"
  - "GetAutoColors"
  - "CMFCBaseTabCtrl::GetAutoColors"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetAutoColors method"
ms.assetid: 9507b2f1-c876-4fc1-ae1f-24e546ae9699
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCBaseTabCtrl::GetAutoColors
Retrieves the array of colors used for automatic coloring.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A reference to an array of [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) values that the [CMFCBaseTabCtrl](../vs140/cmfcbasetabctrl-class.md) object uses for automatic tab coloring.  
  
## Remarks  
 By default, the framework initializes the array of colors to library-defined colors. You can provide a custom array of colors by calling the method [CMFCBaseTabCtrl::SetAutoColors](../vs140/cmfcbasetabctrl--setautocolors.md).  
  
## Requirements  
 **Header:** afxbasetabctrl.h  
  
## See Also  
 [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCBaseTabCtrl::EnableAutoColor](../vs140/cmfcbasetabctrl--enableautocolor.md)   
 [CMFCBaseTabCtrl::SetAutoColors](../vs140/cmfcbasetabctrl--setautocolors.md)