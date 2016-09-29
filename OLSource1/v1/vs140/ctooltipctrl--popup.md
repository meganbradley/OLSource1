---
title: "CToolTipCtrl::Popup"
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
  - "Popup method"
  - "CToolTipCtrl.Popup"
  - "CToolTipCtrl::Popup"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Popup method"
ms.assetid: 6cab3554-6acd-4476-81a3-2001e48ee6ec
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolTipCtrl::Popup
Causes the current tooltip control to display at the coordinates of the last mouse message.  
  
## Syntax  
  
```  
void Popup();  
```  
  
## Remarks  
 This method sends the [TTM_POPUP](http://msdn.microsoft.com/library/windows/desktop/bb760402) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
 This method is supported in Windows XP and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## Example  
 The following code example displays a tooltip window.  
  
 [!code[NVC_MFC_CToolBarCtrl_s1#7](../vs140/codesnippet/CPP/ctooltipctrl--popup_1.cpp)]  
  
## See Also  
 [CToolTipCtrl Class](../vs140/ctooltipctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [TTM_POPUP](http://msdn.microsoft.com/library/windows/desktop/bb760402)