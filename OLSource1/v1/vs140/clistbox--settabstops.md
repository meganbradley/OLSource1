---
title: "CListBox::SetTabStops"
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
  - "CListBox::SetTabStops"
  - "CListBox.SetTabStops"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetTabStops method"
  - "CListBox class, general operations"
ms.assetid: 68d0e66c-ca54-460f-a8d3-521a2d7fb6a5
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListBox::SetTabStops
Sets the tab-stop positions in a list box.  
  
## Syntax  
  
```  
  
      void SetTabStops( );  
BOOL SetTabStops(  
   const int& cxEachStop   
);  
BOOL SetTabStops(  
   int nTabStops,  
   LPINT rgTabStops   
);  
```  
  
#### Parameters  
 `cxEachStop`  
 Tab stops are set at every `cxEachStop` dialog units. See *rgTabStops* for a description of a dialog unit.  
  
 `nTabStops`  
 Specifies the number of tab stops to have in the list box.  
  
 `rgTabStops`  
 Points to the first member of an array of integers containing the tab-stop positions in dialog units. A dialog unit is a horizontal or vertical distance. One horizontal dialog unit is equal to one-fourth of the current dialog base width unit, and one vertical dialog unit is equal to one-eighth of the current dialog base height unit. The dialog base units are computed based on the height and width of the current system font. The **GetDialogBaseUnits** Windows function returns the current dialog base units in pixels. The tab stops must be sorted in increasing order; back tabs are not allowed.  
  
## Return Value  
 Nonzero if all the tabs were set; otherwise 0.  
  
## Remarks  
 To set tab stops to the default size of 2 dialog units, call the parameterless version of this member function. To set tab stops to a size other than 2, call the version with the `cxEachStop` argument.  
  
 To set tab stops to an array of sizes, use the version with the `rgTabStops` and `nTabStops` arguments. A tab stop will be set for each value in `rgTabStops`, up to the number specified by `nTabStops`.  
  
 To respond to a call to the `SetTabStops` member function, the list box must have been created with the [LBS_USETABSTOPS](../vs140/list-box-styles.md) style.  
  
## Example  
 [!code[NVC_MFC_CListBox#39](../vs140/codesnippet/CPP/clistbox--settabstops_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CListBox Class](../vs140/clistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [LB_SETTABSTOPS](http://msdn.microsoft.com/library/windows/desktop/bb761354)   
 [GetDialogBaseUnits](http://msdn.microsoft.com/library/windows/desktop/ms645475)