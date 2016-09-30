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
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An array of colors that the framework displays on the pop-up menu.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The default selected color.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The text label of the *automatic* (default) color button, or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 The standard label for the automatic button is **Automatic**.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The text label of the *other* button, which displays more color choices, or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 The standard label for the other button is **More Colors...**.  
  
 [in] <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The text label of the document colors button. The document colors palette lists all the colors that the document currently uses.  
  
 [in] <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 A list of colors that the document currently uses.  
  
 [in] <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The number of columns that the array of colors has.  
  
 [in] <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 The number of rows that the color bar has when it is docked horizontally.  
  
 [in] <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 The number of columns that the color bar has when it is docked vertically.  
  
 [in] <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 The default color that the framework applies when you click the automatic button.  
  
 [in] <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 The color bar control command ID.  
  
 [in] <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 A Boolean that indicates whether to show the standard system color dialog box or the [CMFCColorDialog](../vs140/cmfccolordialog-class.md) dialog box.  
  
 [in] <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 A pointer to a parent button.  
  
 [in] <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 The command ID.  
  
## Remarks  
 Each overloaded constructor sets the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> member to <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
## Example  
 The following example demonstrates how to construct a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object.  
  
 [!code[NVC_MFC_RibbonApp#34](../vs140/codesnippet/CPP/cmfccolorpopupmenu--cmfccolorpopupmenu_1.cpp)]  
  
## Requirements  
 **Header:** afxcolorpopupmenu.h  
  
## See Also  
 [CMFCColorPopupMenu Class](../vs140/cmfccolorpopupmenu-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)