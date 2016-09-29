---
title: "CPrintDialogEx::PrintSelection"
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
  - "CPrintDialogEx::PrintSelection"
  - "PrintSelection"
  - "CPrintDialogEx.PrintSelection"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PrintSelection method"
ms.assetid: 9327f163-9f99-4edd-b0a9-adf6fb3d24a1
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPrintDialogEx::PrintSelection
Call this function after calling `DoModal` to determine whether to print only the currently selected items.  
  
## Syntax  
  
```  
  
BOOL PrintSelection( ) const;  
  
```  
  
## Return Value  
 **TRUE** if only the selected items are to be printed; otherwise **FALSE**.  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPrintDialogEx Class](../vs140/cprintdialogex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPrintDialogEx::PrintAll](../vs140/cprintdialogex--printall.md)   
 [CPrintDialogEx::PrintRange](../vs140/cprintdialogex--printrange.md)