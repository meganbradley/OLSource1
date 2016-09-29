---
title: "CPrintDialog::GetFromPage"
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
  - "CPrintDialog::GetFromPage"
  - "GetFromPage"
  - "CPrintDialog.GetFromPage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetFromPage method"
  - "CPrintDialog class, operations"
ms.assetid: f4ceea66-bcd1-45e4-b878-2749d9343fc9
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPrintDialog::GetFromPage
Retrieves the starting page of the print range.  
  
## Syntax  
  
```  
  
int GetFromPage( ) const;  
```  
  
## Return Value  
 The starting page number in the range of pages to be printed.  
  
## Remarks  
 Call this function after calling `DoModal` to retrieve the starting page number in the range of pages to be printed.  
  
## Example  
 See the example for [CPrintDialog::m_pd](../vs140/cprintdialog--m_pd.md).  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPrintDialog Class](../vs140/cprintdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPrintDialog::GetToPage](../vs140/cprintdialog--gettopage.md)   
 [CPrintDialog::PrintRange](../vs140/cprintdialog--printrange.md)