---
title: "CPrintDialog::GetCopies"
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
  - CPrintDialog::GetCopies
  - GetCopies
  - CPrintDialog.GetCopies
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetCopies method
  - CPrintDialog class, operations
ms.assetid: ff3c6e6c-333c-48e6-83f9-61961e0dd289
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CPrintDialog::GetCopies
Retrieves the number of copies requested.  
  
## Syntax  
  
```  
  
int GetCopies( ) const;  
```  
  
## Return Value  
 The number of copies requested.  
  
## Remarks  
 Call this function after calling `DoModal` to retrieve the number of copies requested.  
  
## Example  
 See the example for [CPrintDialog::PrintCollate](../vs140/cprintdialog--printcollate.md).  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPrintDialog Class](../vs140/cprintdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPrintDialog::PrintCollate](../vs140/cprintdialog--printcollate.md)