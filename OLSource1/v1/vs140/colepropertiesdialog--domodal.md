---
title: "COlePropertiesDialog::DoModal"
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
  - "COlePropertiesDialog.DoModal"
  - "COlePropertiesDialog::DoModal"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DoModal method"
  - "COlePropertiesDialog class, operations"
ms.assetid: b04a2673-70a7-44cd-b5e3-173fc02d423a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COlePropertiesDialog::DoModal
Call this member function to display the Windows common OLE Object Properties dialog box and allow the user to view and/or change the various properties of the document item.  
  
## Syntax  
  
```  
  
virtual INT_PTR DoModal( );  
  
```  
  
## Return Value  
 **IDOK** or **IDCANCEL** if successful; otherwise 0. **IDOK** and **IDCANCEL** are constants that indicate whether the user selected the OK or Cancel button.  
  
 If **IDCANCEL** is returned, you can call the Windows [CommDlgExtendedError](http://msdn.microsoft.com/library/windows/desktop/ms646916) function to determine whether an error occurred.  
  
## Requirements  
 **Header:** afxodlgs.h  
  
## See Also  
 [COlePropertiesDialog Class](../vs140/colepropertiesdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COlePropertiesDialog::OnApplyScale](../vs140/colepropertiesdialog--onapplyscale.md)   
 [COlePropertiesDialog::m_psh](../vs140/colepropertiesdialog--m_psh.md)