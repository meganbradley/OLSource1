---
title: "CPrintDialogEx::PrintRange"
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
  - CPrintDialogEx::PrintRange
  - CPrintDialogEx.PrintRange
  - PrintRange
dev_langs: 
  - C++
helpviewer_keywords: 
  - PrintRange method
ms.assetid: a940734b-bc69-45b6-ada2-f9f172ca7405
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CPrintDialogEx::PrintRange
Call this function after calling `DoModal` to determine whether to print only a range of pages in the document.  
  
## Syntax  
  
```  
  
BOOL PrintRange( ) const;  
  
```  
  
## Return Value  
 **TRUE** if only a range of pages in the document are to be printed; otherwise **FALSE**.  
  
## Remarks  
 The specified page ranges can be determined from [m_pdex](../vs140/cprintdialogex--m_pdex.md) (see **nPageRanges**, **nMaxPageRanges**, and **lpPageRanges** in the [PRINTDLGEX](http://msdn.microsoft.com/library/windows/desktop/ms646844) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]).  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPrintDialogEx Class](../vs140/cprintdialogex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPrintDialogEx::PrintAll](../vs140/cprintdialogex--printall.md)   
 [CPrintDialogEx::PrintCurrentPage](../vs140/cprintdialogex--printcurrentpage.md)   
 [CPrintDialogEx::PrintSelection](../vs140/cprintdialogex--printselection.md)