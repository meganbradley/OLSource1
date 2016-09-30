---
title: "CPageSetupDialog::DoModal"
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
  - "CPageSetupDialog.DoModal"
  - "CPageSetupDialog::DoModal"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DoModal method"
  - "CPageSetupDialog class, operations"
ms.assetid: 09a99693-2870-413d-b316-3e7254244453
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPageSetupDialog::DoModal
Call this function to display the Windows common OLE Page Setup dialog box and allow the user to select various print setup options such as the printing margins, size and orientation of the paper, and destination printer.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 **IDOK** or **IDCANCEL**. If **IDCANCEL** is returned, call the Windows [CommDlgExtendedError](http://msdn.microsoft.com/library/windows/desktop/ms646916) function to determine whether an error occurred.  
  
 **IDOK** and **IDCANCEL** are constants that indicate whether the user selected the OK or Cancel button.  
  
## Remarks  
 In addition, the user can access the printer setup options such as network location and properties specific to the selected printer.  
  
 If you want to initialize the various Page Setup dialog options by setting members of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> structure, you should do so before calling <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, and after the dialog object is constructed. After calling <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, call other member functions to retrieve the settings or information input by the user into the dialog box.  
  
 If you want to propagate the current settings entered by the user, make a call to [CWinApp::SelectPrinter](../vs140/cwinapp--selectprinter.md). This function takes the information from the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object and initializes and selects a new printer DC with the proper attributes.  
  
 [!code[NVC_MFCDocView#95](../vs140/codesnippet/CPP/cpagesetupdialog--domodal_1.cpp)]  
  
## Example  
 See the example for [CPageSetupDialog::CPageSetupDialog](../vs140/cpagesetupdialog--cpagesetupdialog.md).  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPageSetupDialog Class](../vs140/cpagesetupdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPageSetupDialog::m_psd](../vs140/cpagesetupdialog--m_psd.md)