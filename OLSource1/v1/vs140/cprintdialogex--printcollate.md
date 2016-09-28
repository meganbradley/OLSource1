---
title: "CPrintDialogEx::PrintCollate"
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
  - "CPrintDialogEx::PrintCollate"
  - "CPrintDialogEx.PrintCollate"
  - "PrintCollate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PrintCollate method"
ms.assetid: c43342bd-e847-4c63-9916-1f020ec57d2a
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPrintDialogEx::PrintCollate
Call this function after calling `DoModal` to determine whether the printer should collate all printed copies of the document.  
  
## Syntax  
  
```  
  
BOOL PrintCollate( ) const;  
  
```  
  
## Return Value  
 **TRUE** if the user selects the collate check box in the dialog box; otherwise **FALSE**.  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPrintDialogEx Class](../vs140/cprintdialogex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPrintDialogEx::GetCopies](../vs140/cprintdialogex--getcopies.md)