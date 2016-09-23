---
title: "CPrintDialog::PrintRange"
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
  - PrintRange
  - CPrintDialog::PrintRange
  - CPrintDialog.PrintRange
dev_langs: 
  - C++
helpviewer_keywords: 
  - CPrintDialog class, operations
  - PrintRange method
ms.assetid: ffd0494f-1a43-4de1-a7ea-dce1483039bf
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CPrintDialog::PrintRange
Determines whether to print only a specified range of pages.  
  
## Syntax  
  
```  
  
BOOL PrintRange( ) const;  
```  
  
## Return Value  
 Nonzero if only a range of pages in the document are to be printed; otherwise 0.  
  
## Remarks  
 Call this function after calling `DoModal` to determine whether to print only a range of pages in the document.  
  
## Example  
 See the example for [CPrintDialog::m_pd](../vs140/cprintdialog--m_pd.md).  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPrintDialog Class](../vs140/cprintdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPrintDialog::PrintAll](../vs140/cprintdialog--printall.md)   
 [CPrintDialog::PrintSelection](../vs140/cprintdialog--printselection.md)   
 [CPrintDialog::GetFromPage](../vs140/cprintdialog--getfrompage.md)   
 [CPrintDialog::GetToPage](../vs140/cprintdialog--gettopage.md)