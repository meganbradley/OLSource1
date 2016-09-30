---
title: "CPrintDialog::DoModal"
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
  - "CPrintDialog::DoModal"
  - "CPrintDialog.DoModal"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DoModal method"
  - "CPrintDialog class, operations"
ms.assetid: a41cc6f0-be27-42e7-8281-3394e453f603
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPrintDialog::DoModal
Displays the Windows common print dialog box and allows the user to select various printing options such as the number of copies, page range, and whether copies should be collated.  
  
## Syntax  
  
```  
  
virtual INT_PTR DoModal( );  
```  
  
## Return Value  
 **IDOK** or **IDCANCEL**. If **IDCANCEL** is returned, call the Windows [CommDlgExtendedError](http://msdn.microsoft.com/library/windows/desktop/ms646916) function to determine whether an error occurred.  
  
 **IDOK** and **IDCANCEL** are constants that indicate whether the user selected the OK or Cancel button.  
  
## Remarks  
 If you want to initialize the various print dialog options by setting members of the `m_pd` structure, you should do this before calling `DoModal`, but after the dialog object is constructed.  
  
 After calling `DoModal`, you can call other member functions to retrieve the settings or information input by the user into the dialog box.  
  
 Note that when you call the constructor with `bPrintSetupOnly` set to **FALSE**, the **PD_RETURNDC** flag is automatically used. After calling `DoModal`, `GetDefaults`, or `GetPrinterDC`, a printer DC will be returned in `m_pd.hDC`. This DC must be freed with a call to [DeleteDC](http://msdn.microsoft.com/library/windows/desktop/dd183533) by the caller of `CPrintDialog`.  
  
## Example  
 See the example for [CPrintDialog::CreatePrinterDC](../vs140/cprintdialog--createprinterdc.md).  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPrintDialog Class](../vs140/cprintdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPrintDialog::CPrintDialog](../vs140/cprintdialog--cprintdialog.md)   
 [CDialog::DoModal](../vs140/cdialog--domodal.md)