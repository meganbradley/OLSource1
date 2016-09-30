---
title: "CMFCDesktopAlertWnd::GetCaptionHeight"
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
  - "CMFCDesktopAlertWnd.GetCaptionHeight"
  - "CMFCDesktopAlertWnd::GetCaptionHeight"
  - "GetCaptionHeight"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetCaptionHeight method"
ms.assetid: 18a8e2aa-6fd9-4b00-9f10-1c26e4e76973
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCDesktopAlertWnd::GetCaptionHeight
Returns the height of the caption.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The height, in pixels, of the caption.  
  
## Remarks  
 This method can be overridden in a derived class. The default implementation either: returns the small caption height value (7 pixels) if the popup window should display the small caption, or the value obtained from the Windows API function <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxDesktopAlertWnd.h  
  
## See Also  
 [CMFCDesktopAlertWnd Class](../vs140/cmfcdesktopalertwnd-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)