---
title: "CMFCColorPopupMenu::CMFCColorPopupMenu"
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
  - "CMFCColorPopupMenu.CMFCColorPopupMenu"
  - "CMFCColorPopupMenu"
  - "CMFCColorPopupMenu::CMFCColorPopupMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCColorPopupMenu, constructor"
ms.assetid: 36c30b91-537a-49dc-967e-04d25540e347
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCColorPopupMenu::CMFCColorPopupMenu
Constructs a `CMFCColorPopupMenu` object.  
  
## Syntax  
  
```  
CMFCColorPopupMenu(  
   const CArray<COLORREF, COLORREF>& colors,  
   COLORREF color,  
   LPCTSTR lpszAutoColor,  
   LPCTSTR lpszOtherColor,  
   LPCTSTR lpszDocColors,  
   CList<COLORREF, COLORREF>& lstDocColors,  
   int nColumns,  
   int nHorzDockRows,  
   int nVertDockColumns,  
   COLORREF colorAutomatic,  
   UINT uiCommandID,  
   BOOL bStdColorDlg = FALSE  
);  
CMFCColorPopupMenu(  
   CMFCColorButton* pParentBtn,  
   const CArray<COLORREF, COLORREF>& colors,  
   COLORREF color,  
   LPCTSTR lpszAutoColor,  
   LPCTSTR lpszOtherColor,  
   LPCTSTR lpszDocColors,  
   CList<COLORREF, COLORREF>& lstDocColors,  
   int nColumns,  
   COLORREF colorAutomatic  
);  
CMFCColorPopupMenu(  
   CMFCRibbonColorButton* pParentBtn,  
   const CArray<COLORREF, COLORREF>& colors,  
   COLORREF color,  
   LPCTSTR lpszAutoColor,  
   LPCTSTR lpszOtherColor,  
   LPCTSTR lpszDocColors,  
   CList<COLORREF, COLORREF>& lstDocColors,  
   int nColumns,  
   COLORREF colorAutomatic,  
   UINT nID  
);  
```  
  
#### Parameters  
 [in] `colors`  
 An array of colors that the framework displays on the pop-up menu.  
  
 [in] `color`  
 The default selected color.  
  
 [in] `lpszAutoColor`  
 The text label of the *automatic* (default) color button, or `NULL`.  
  
 The standard label for the automatic button is **Automatic**.  
  
 [in] `lpszOtherColor`  
 The text label of the *other* button, which displays more color choices, or `NULL`.  
  
 The standard label for the other button is **More Colors...**.  
  
 [in] `lpszDocColors`  
 The text label of the document colors button. The document colors palette lists all the colors that the document currently uses.  
  
 [in] `lstDocColors`  
 A list of colors that the document currently uses.  
  
 [in] `nColumns`  
 The number of columns that the array of colors has.  
  
 [in] `nHorzDockRows`  
 The number of rows that the color bar has when it is docked horizontally.  
  
 [in] `nVertDockColumns`  
 The number of columns that the color bar has when it is docked vertically.  
  
 [in] `colorAutomatic`  
 The default color that the framework applies when you click the automatic button.  
  
 [in] `uiCommandID`  
 The color bar control command ID.  
  
 [in] `bStdColorDlg`  
 A Boolean that indicates whether to show the standard system color dialog box or the [CMFCColorDialog](../vs140/cmfccolordialog-class.md) dialog box.  
  
 [in] `pParentBtn`  
 A pointer to a parent button.  
  
 [in] `nID`  
 The command ID.  
  
## Remarks  
 Each overloaded constructor sets the `m_bEnabledInCustomizeMode` member to `FALSE`.  
  
## Example  
 The following example demonstrates how to construct a `CMFCColorPopupMenu` object.  
  
 [!code[NVC_MFC_RibbonApp#34](../vs140/codesnippet/CPP/cmfccolorpopupmenu--cmfccolorpopupmenu_1.cpp)]  
  
## Requirements  
 **Header:** afxcolorpopupmenu.h  
  
## See Also  
 [CMFCColorPopupMenu Class](../vs140/cmfccolorpopupmenu-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)