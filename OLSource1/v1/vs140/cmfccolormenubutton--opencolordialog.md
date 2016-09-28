---
title: "CMFCColorMenuButton::OpenColorDialog"
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
  - "CMFCColorMenuButton.OpenColorDialog"
  - "CMFCColorMenuButton::OpenColorDialog"
  - "OpenColorDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OpenColorDialog method"
ms.assetid: a5cfdbb1-0e8d-4bb6-a724-712ab6da315c
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCColorMenuButton::OpenColorDialog
Opens a color selection dialog box.  
  
## Syntax  
  
```  
virtual BOOL OpenColorDialog(  
   const COLORREF colorDefault,  
   COLORREF& colorRes   
);  
```  
  
#### Parameters  
 [in] `colorDefault`  
 The default color that is selected in the color dialog box.  
  
 [out] `colorRes`  
 Returns the color that the user selects from the color dialog box.  
  
## Return Value  
 Nonzero if the user selects a new color; otherwise, zero.  
  
## Remarks  
 When the menu button is clicked, call this method to open a color dialog box. If the return value is nonzero, the color that the user selects is stored in the `colorRes` parameter. Use the [CMFCColorMenuButton::EnableOtherButton](../vs140/cmfccolormenubutton--enableotherbutton.md) method to switch between the standard color dialog box and the [CMFCColorDialog Class](../vs140/cmfccolordialog-class.md) dialog box.  
  
## Requirements  
 **Header:** afxcolormenubutton.h  
  
## See Also  
 [CMFCColorMenuButton Class](../vs140/cmfccolormenubutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449)