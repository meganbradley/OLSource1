---
title: "CPrintDialogEx::PrintAll"
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
  - "CPrintDialogEx::PrintAll"
  - "PrintAll"
  - "CPrintDialogEx.PrintAll"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PrintAll method"
ms.assetid: cd91dc57-bc95-49fd-863b-ebdc8a7cbe27
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPrintDialogEx::PrintAll
Call this function after calling `DoModal` to determine whether to print all pages in the document.  
  
## Syntax  
  
```  
  
BOOL PrintAll( ) const;  
  
```  
  
## Return Value  
 **TRUE** if all pages in the document are to be printed; otherwise **FALSE**.  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPrintDialogEx Class](../vs140/cprintdialogex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPrintDialogEx::PrintCurrentPage](../vs140/cprintdialogex--printcurrentpage.md)   
 [CPrintDialogEx::PrintRange](../vs140/cprintdialogex--printrange.md)   
 [CPrintDialogEx::PrintSelection](../vs140/cprintdialogex--printselection.md)