---
title: "CMFCColorBar::OpenColorDialog"
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
  - "CMFCColorBar.OpenColorDialog"
  - "OpenColorDialog"
  - "CMFCColorBar::OpenColorDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OpenColorDialog method"
ms.assetid: bc69d08a-1e5d-4631-9f95-d856b869445b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCColorBar::OpenColorDialog
Opens a color dialog box.  
  
## Syntax  
  
```  
virtual BOOL OpenColorDialog(  
   const COLORREF colorDefault,  
   COLORREF& colorRes   
);  
```  
  
#### Parameters  
 [in] `colorDefault`  
 The color that is selected by default when the color dialog box opens.  
  
 [out] `colorRes`  
 The color that a user selected.  
  
## Return Value  
 `TRUE` if the user selected a color; `FALSE` if the user canceled the color dialog box.  
  
## Remarks  
  
## Requirements  
 **Header:** afxcolorbar.h  
  
## See Also  
 [CMFCColorBar Class](../vs140/cmfccolorbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449)   
 [CMFCColorBar::EnableOtherButton](../vs140/cmfccolorbar--enableotherbutton.md)