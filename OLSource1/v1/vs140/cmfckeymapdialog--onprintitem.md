---
title: "CMFCKeyMapDialog::OnPrintItem"
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
  - "CMFCKeyMapDialog.OnPrintItem"
  - "CMFCKeyMapDialog::OnPrintItem"
  - "OnPrintItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnPrintItem method"
ms.assetid: 3a3d8dc5-753b-4b97-8181-b9d7fa2f73df
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCKeyMapDialog::OnPrintItem
Called by the framework to print a keyboard mapping item.  
  
## Syntax  
  
```  
virtual int OnPrintItem(  
   CDC& dc,  
   int nItem,  
   int y,  
   int cx,  
   BOOL bCalcHeight   
) const;  
```  
  
#### Parameters  
 [in] `dc`  
 The device context of the printer.  
  
 [in] `nItem`  
 The zero-based index of the item to print.  
  
 [in] `y`  
 The vertical offset between the top of the page and the position of the item.  
  
 [in] `cx`  
 The horizontal offset between the left of the page and the position of the item.  
  
 [in] `bCalcHeight`  
 `TRUE` to calculate the best height for the print item; `FALSE` to truncate the print item so that it fits the default space.  
  
## Return Value  
 The height of the printed item.  
  
## Remarks  
 The framework calls this method to print a key map dialog box item. By default, this method prints the item's command name, shortcut keys, and command description.  
  
## Requirements  
 **Header:** afxkeymapdialog.h  
  
## See Also  
 [CMFCKeyMapDialog Class](../vs140/cmfckeymapdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)