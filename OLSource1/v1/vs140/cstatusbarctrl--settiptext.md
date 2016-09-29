---
title: "CStatusBarCtrl::SetTipText"
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
  - "CStatusBarCtrl::SetTipText"
  - "CStatusBarCtrl.SetTipText"
  - "SetTipText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetTipText method"
  - "tool tips [C++], adding text"
  - "CStatusBarCtrl class, attributes"
ms.assetid: 7505a1f3-0c37-4cb1-b30b-af83f75bdf91
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStatusBarCtrl::SetTipText
Sets the tooltip text for a pane in a status bar.  
  
## Syntax  
  
```  
  
      void SetTipText(  
   int nPane,  
   LPCTSTR pszTipText   
);  
```  
  
#### Parameters  
 `nPane`  
 The zero-based index of status bar pane to receive the tooltip text.  
  
 *pszTipText*  
 A pointer to a string containing the tooltip text.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [SB_SETTIPTEXT](http://msdn.microsoft.com/library/windows/desktop/bb760759), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CStatusBarCtrl#12](../vs140/codesnippet/CPP/cstatusbarctrl--settiptext_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CStatusBar Class](../vs140/cstatusbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CStatusBarCtrl::GetTipText](../vs140/cstatusbarctrl--gettiptext.md)