---
title: "CMFCColorBar::Create"
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
  - "CMFCColorBar.Create"
  - "Create"
  - "CMFCColorBar::Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method"
ms.assetid: dc42b9e6-183f-460a-81e8-507579f451d9
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCColorBar::Create
Creates a color bar control window and attaches it to the `CMFCColorBar` object.  
  
## Syntax  
  
```  
virtual BOOL Create(  
   CWnd* pParentWnd,  
   DWORD dwStyle,  
   UINT nID,  
   CPalette* pPalette=NULL,  
   int nColumns=0,  
   int nRowsDockHorz=0,  
   int nColDockVert=0   
);  
```  
  
#### Parameters  
 [in] `pParentWnd`  
 Pointer to the parent window.  
  
 [in] `dwStyle`  
 A bitwise combination (OR) of [window styles](../vs140/window-styles.md).  
  
 [in] `nID`  
 The command ID.  
  
 [in] `pPalette`  
 Pointer to a palette of colors. The default is `NULL`.  
  
 [in] `nColumns`  
 The number of columns in the color bar control. The default is 0.  
  
 [in] `nRowsDockHorz`  
 The number of rows in the color bar control when it is docked horizontally. The default is 0.  
  
 [in] `nColDockVert`  
 The number of columns in the color bar control when it is docked vertically. The default is 0.  
  
## Return Value  
 `TRUE` if this method is successful; otherwise, `FALSE`.  
  
## Remarks  
 To construct a `CMFCColorBar` object, call the class constructor then this method. The `Create` method creates the Windows control and initializes a list of colors.  
  
## Requirements  
 **Header:** afxcolorbar.h  
  
## See Also  
 [CMFCColorBar Class](../vs140/cmfccolorbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)