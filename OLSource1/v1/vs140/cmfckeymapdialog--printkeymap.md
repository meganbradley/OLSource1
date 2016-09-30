---
title: "CMFCKeyMapDialog::PrintKeyMap"
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
  - "CMFCKeyMapDialog.PrintKeyMap"
  - "CMFCKeyMapDialog::PrintKeyMap"
  - "PrintKeyMap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PrintKeyMap method"
ms.assetid: 308e00a7-f86a-446d-adea-4c039625220a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCKeyMapDialog::PrintKeyMap
Called by the framework when a user clicks the **Print** button.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> method prints the key map. It initiates a new print job and then repeatedly calls the [CMFCKeyMapDialog::OnPrintHeader](../vs140/cmfckeymapdialog--onprintheader.md) and [CMFCKeyMapDialog::OnPrintItem](../vs140/cmfckeymapdialog--onprintitem.md) methods until all the key mappings are printed.  
  
## Requirements  
 **Header:** afxkeymapdialog.h  
  
## See Also  
 [CMFCKeyMapDialog Class](../vs140/cmfckeymapdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC Class](../vs140/cdc-class.md)