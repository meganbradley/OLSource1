---
title: "CMFCToolBar::SetButtonStyle"
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
  - "SetButtonStyle"
  - "CMFCToolBar.SetButtonStyle"
  - "CMFCToolBar::SetButtonStyle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetButtonStyle method"
ms.assetid: 53cac229-e066-4e21-8dbd-c55d84f5df68
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::SetButtonStyle
Sets the style of the toolbar button at the given index.  
  
## Syntax  
  
```  
virtual void SetButtonStyle(  
   int nIndex,  
   UINT nStyle   
);  
```  
  
#### Parameters  
 [in] `nIndex`  
 The zero-based index of the toolbar button whose style is to be set.  
  
 [in] `nStyle`  
 The style of the button. See [ToolBar Control Styles](../vs140/toolbar-control-styles.md) for the list of available toolbar button styles.  
  
## Remarks  
 This method removes the `TBBS_PRESSED` style if `nStyle` is `TBBS_DISABLED` because the user cannot click a disabled button.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [ToolBar Control Styles](../vs140/toolbar-control-styles.md)