---
title: "CToolTipCtrl::SetTitle"
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
  - "CToolTipCtrl.SetTitle"
  - "CToolTipCtrl::SetTitle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetTitle method"
ms.assetid: 7e2cee33-20bd-42fe-9173-12289f72fd89
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolTipCtrl::SetTitle
Adds a standard icon and title string to a tool tip.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *uIcon*  
 See *icon* in [TTM_SETTITLE](http://msdn.microsoft.com/library/windows/desktop/bb760414) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 *lpstrTitle*  
 Pointer to the title string.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [TTM_SETTITLE](http://msdn.microsoft.com/library/windows/desktop/bb760414), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolTipCtrl Class](../vs140/ctooltipctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)