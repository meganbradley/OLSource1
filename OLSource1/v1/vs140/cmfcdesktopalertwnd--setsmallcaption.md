---
title: "CMFCDesktopAlertWnd::SetSmallCaption"
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
  - "CMFCDesktopAlertWnd.SetSmallCaption"
  - "CMFCDesktopAlertWnd::SetSmallCaption"
  - "SetSmallCaption"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetSmallCaption method"
ms.assetid: f246f63e-b56a-4a0f-8364-6f7aa089a450
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCDesktopAlertWnd::SetSmallCaption
Switches between small and regular-size captions.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to specify that the alert window displays a small caption; otherwise, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to specify that the alert window displays a regular-size caption.  
  
## Remarks  
 Call this method to display the small or regular-size caption. By default, the small caption is 7 pixels high. You can obtain the size of the regular caption by calling the Windows API function <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxDesktopAlertWnd.h  
  
## See Also  
 [CMFCDesktopAlertWnd Class](../vs140/cmfcdesktopalertwnd-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)