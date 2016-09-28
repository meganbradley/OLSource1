---
title: "CFileDialog::DoModal"
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
  - "CFileDialog.DoModal"
  - "CFileDialog::DoModal"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CFileDialog class, operations"
  - "DoModal method"
ms.assetid: 391bf5a3-c19f-4c71-93d9-cdc9468c2681
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFileDialog::DoModal
Call this function to display the Windows common file dialog box and allow the user to browse files and directories and enter a filename.  
  
## Syntax  
  
```  
  
virtual INT_PTR DoModal( );  
```  
  
## Return Value  
 **IDOK** or **IDCANCEL**. If **IDCANCEL** is returned, call the Windows [CommDlgExtendedError](http://msdn.microsoft.com/library/windows/desktop/ms646916) function to determine whether an error occurred.  
  
 **IDOK** and **IDCANCEL** are constants that indicate whether the user selected the OK or Cancel button.  
  
## Remarks  
 If you want to initialize the various file dialog-box options by setting members of the **m_ofn** structure, you should do this before calling `DoModal`, but after the dialog object is constructed.  
  
 For example, if you want to allow the user to select multiple files, set the `OFN_ALLOWMULTISELECT` flag before calling `DoModal`, as shown in the code example in [CFileDialog Class](../vs140/cfiledialog-class.md).  
  
 When the user clicks the dialog box's OK or Cancel buttons, or selects the Close option from the dialog box's control menu, control is returned to your application. You can then call other member functions to retrieve the settings or information the user inputs into the dialog box.  
  
 `DoModal` is a virtual function overridden from class `CDialog`.  
  
## Example  
 [!code[NVC_MFCFiles#25](../vs140/codesnippet/CPP/cfiledialog--domodal_1.cpp)]  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CFileDialog Class](../vs140/cfiledialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDialog::DoModal](../vs140/cdialog--domodal.md)   
 [CFileDialog::CFileDialog](../vs140/cfiledialog--cfiledialog.md)