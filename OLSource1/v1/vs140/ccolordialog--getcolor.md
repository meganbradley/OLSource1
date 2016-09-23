---
title: "CColorDialog::GetColor"
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
  - CColorDialog::GetColor
  - GetColor
  - CColorDialog.GetColor
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetColor method
  - CColorDialog class, operations
ms.assetid: 57dcfbe3-7c5d-4837-86af-31aa19aef3b0
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CColorDialog::GetColor
Call this function after calling `DoModal` to retrieve the information about the color the user selected.  
  
## Syntax  
  
```  
  
COLORREF GetColor( ) const;  
```  
  
## Return Value  
 A [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) value that contains the RGB information for the color selected in the color dialog box.  
  
## Example  
 [!code[NVC_MFCDocView#50](../vs140/codesnippet/CPP/ccolordialog--getcolor_1.cpp)]
  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CColorDialog Class](../vs140/ccolordialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CColorDialog::SetCurrentColor](../vs140/ccolordialog--setcurrentcolor.md)