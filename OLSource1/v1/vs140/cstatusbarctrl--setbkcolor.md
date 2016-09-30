---
title: "CStatusBarCtrl::SetBkColor"
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
  - "CStatusBarCtrl.SetBkColor"
  - "CStatusBarCtrl::SetBkColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetBkColor method"
  - "status bar controls, setting background color"
  - "CStatusBarCtrl class, attributes"
ms.assetid: 9fddbd97-f531-4f43-8d8d-f5ac30b8e3ad
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStatusBarCtrl::SetBkColor
Sets the background color in a status bar.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **COLORREF** value that specifies the new background color. Specify the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> value to cause the status bar to use its default background color.  
  
## Return Value  
 A [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) value that represents the previous default background color.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [SB_SETBKCOLOR](http://msdn.microsoft.com/library/windows/desktop/bb760754), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CStatusBarCtrl#8](../vs140/codesnippet/CPP/cstatusbarctrl--setbkcolor_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CStatusBar Class](../vs140/cstatusbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)