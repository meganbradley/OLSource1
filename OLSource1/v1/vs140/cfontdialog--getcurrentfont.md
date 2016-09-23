---
title: "CFontDialog::GetCurrentFont"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CFontDialog.GetCurrentFont
  - CFontDialog::GetCurrentFont
  - GetCurrentFont
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetCurrentFont method
  - CFontDialog class, operations
ms.assetid: 6b86f074-bcdc-45af-a4b5-164be6987009
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CFontDialog::GetCurrentFont
Call this function to assign the characteristics of the currently selected font to the members of a [LOGFONT](http://msdn.microsoft.com/library/windows/desktop/dd145037) structure.  
  
## Syntax  
  
```  
  
      void GetCurrentFont(  
   LPLOGFONT lplf   
);  
```  
  
#### Parameters  
 *lplf*  
 A pointer to a `LOGFONT` structure.  
  
## Remarks  
 Other `CFontDialog` member functions are provided to access individual characteristics of the current font.  
  
 If this function is called during a call to [DoModal](../vs140/cfontdialog--domodal.md), it returns the current selection at the time (what the user sees or has changed in the dialog). If this function is called after a call to `DoModal` (only if `DoModal` returns **IDOK**), it returns what the user actually selected.  
  
## Example  
 [!code[NVC_MFCDocView#80](../vs140/codesnippet/CPP/cfontdialog--getcurrentfont_1.cpp)]
  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CFontDialog Class](../vs140/cfontdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFontDialog::GetFaceName](../vs140/cfontdialog--getfacename.md)   
 [CFontDialog::GetStyleName](../vs140/cfontdialog--getstylename.md)