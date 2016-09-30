---
title: "CPrintDialog::PrintCollate"
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
  - "PrintCollate"
  - "CPrintDialog.PrintCollate"
  - "CPrintDialog::PrintCollate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PrintCollate method"
  - "CPrintDialog class, operations"
ms.assetid: b6c40861-5f1e-42a3-868b-1d2c33de5f9e
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPrintDialog::PrintCollate
Determines whether collated copies are requested.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if the user selects the collate check box in the dialog box; otherwise 0.  
  
## Remarks  
 Call this function after calling <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to determine whether the printer should collate all printed copies of the document.  
  
## Example  
 [!code[NVC_MFCDocView#110](../vs140/codesnippet/CPP/cprintdialog--printcollate_1.cpp)]  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPrintDialog Class](../vs140/cprintdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPrintDialog::GetCopies](../vs140/cprintdialog--getcopies.md)