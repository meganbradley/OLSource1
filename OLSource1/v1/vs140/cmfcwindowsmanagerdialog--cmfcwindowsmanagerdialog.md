---
title: "CMFCWindowsManagerDialog::CMFCWindowsManagerDialog"
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
  - "CMFCWindowsManagerDialog"
  - "CMFCWindowsManagerDialog::CMFCWindowsManagerDialog"
  - "CMFCWindowsManagerDialog.CMFCWindowsManagerDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCWindowsManagerDialog class, constructor"
ms.assetid: d6a07dd4-e8f2-45b4-a454-317e86edf25f
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCWindowsManagerDialog::CMFCWindowsManagerDialog
Constructs a [CMFCWindowsManagerDialog](../vs140/cmfcwindowsmanagerdialog-class.md) object.  
  
## Syntax  
  
```  
CMFCWindowsManagerDialog(  
   CMDIFrameWndEx* pMDIFrame,  
   BOOL bHelpButton = FALSE  
);  
```  
  
#### Parameters  
 [in] `pMDIFrame`  
 A pointer to the parent or owner window.  
  
 [in] `bHelpButton`  
 A Boolean parameter that specifies whether the framework displays a **Help** button.  
  
## Remarks  
 For more information about visual managers, see [The Visualization Manager](../vs140/visualization-manager.md).  
  
## Requirements  
 **Header:** afxwindowsmanagerdialog.h  
  
## See Also  
 [CMFCWindowsManagerDialog Class](../vs140/cmfcwindowsmanagerdialog-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [The Visualization Manager](../vs140/visualization-manager.md)