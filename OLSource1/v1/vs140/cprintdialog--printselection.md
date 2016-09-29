---
title: "CPrintDialog::PrintSelection"
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
  - "CPrintDialog::PrintSelection"
  - "CPrintDialog.PrintSelection"
  - "PrintSelection"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PrintSelection method"
  - "CPrintDialog class, operations"
ms.assetid: de4e87df-8103-40f3-a42f-6104f336fb12
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPrintDialog::PrintSelection
Determines whether to print only the currently selected items.  
  
## Syntax  
  
```  
  
BOOL PrintSelection( ) const;  
```  
  
## Return Value  
 Nonzero if only the selected items are to be printed; otherwise 0.  
  
## Remarks  
 Call this function after calling `DoModal` to determine whether to print only the currently selected items.  
  
## Example  
 See the example for [CPrintDialog::m_pd](../vs140/cprintdialog--m_pd.md).  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPrintDialog Class](../vs140/cprintdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPrintDialog::PrintRange](../vs140/cprintdialog--printrange.md)   
 [CPrintDialog::PrintAll](../vs140/cprintdialog--printall.md)