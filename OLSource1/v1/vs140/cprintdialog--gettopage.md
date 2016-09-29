---
title: "CPrintDialog::GetToPage"
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
  - "CPrintDialog::GetToPage"
  - "GetToPage"
  - "CPrintDialog.GetToPage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetToPage method"
  - "CPrintDialog class, operations"
ms.assetid: b2f12348-73c6-4abd-a32e-f15c533ad997
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPrintDialog::GetToPage
Retrieves the ending page of the print range.  
  
## Syntax  
  
```  
  
int GetToPage( ) const;  
```  
  
## Return Value  
 The ending page number in the range of pages to be printed.  
  
## Remarks  
 Call this function after calling `DoModal` to retrieve the ending page number in the range of pages to be printed.  
  
## Example  
 See the example for [CPrintDialog::m_pd](../vs140/cprintdialog--m_pd.md).  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPrintDialog Class](../vs140/cprintdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPrintDialog::GetFromPage](../vs140/cprintdialog--getfrompage.md)   
 [CPrintDialog::PrintRange](../vs140/cprintdialog--printrange.md)