---
title: "CPrintDialog::CPrintDialog"
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
  - CPrintDialog::CPrintDialog
  - CPrintDialog.CPrintDialog
dev_langs: 
  - C++
helpviewer_keywords: 
  - CPrintDialog class, construction/destruction
  - CPrintDialog class, constructor
ms.assetid: a97d4237-105f-4d19-a9be-843fda84238b
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CPrintDialog::CPrintDialog
Constructs either a Windows Print or Print Setup dialog object.  
  
## Syntax  
  
```  
  
      CPrintDialog(  
   BOOL bPrintSetupOnly,  
   DWORD dwFlags = PD_ALLPAGES | PD_USEDEVMODECOPIES | PD_NOPAGENUMS | PD_HIDEPRINTTOFILE | PD_NOSELECTION,  
   CWnd* pParentWnd = NULL   
);  
```  
  
#### Parameters  
 `bPrintSetupOnly`  
 Specifies whether the standard Windows Print dialog box or Print Setup dialog box is displayed. Set this parameter to **TRUE** to display the standard Windows Print Setup dialog box. Set it to **FALSE** to display the Windows Print dialog box. If `bPrintSetupOnly` is **FALSE**, a Print Setup option button is still displayed in the Print dialog box.  
  
 `dwFlags`  
 One or more flags you can use to customize the settings of the dialog box, combined using the bitwise OR operator. For example, the **PD_ALLPAGES** flag sets the default print range to all pages of the document. See the [PRINTDLG](http://msdn.microsoft.com/library/windows/desktop/ms646843) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information on these flags.  
  
 `pParentWnd`  
 A pointer to the dialog box's parent or owner window.  
  
## Remarks  
 This member function only constructs the object. Use the `DoModal` member function to display the dialog box.  
  
 Note that when you call the constructor with `bPrintSetupOnly` set to **FALSE**, the **PD_RETURNDC** flag is automatically used. After calling `DoModal`, `GetDefaults`, or `GetPrinterDC`, a printer DC will be returned in `m_pd.hDC`. This DC must be freed with a call to [DeleteDC](http://msdn.microsoft.com/library/windows/desktop/dd183533) by the caller of `CPrintDialog`.  
  
## Example  
 [!code[NVC_MFCDocView#174](../vs140/codesnippet/CPP/cprintdialog--cprintdialog_1.cpp)]
  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPrintDialog Class](../vs140/cprintdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPrintDialog::DoModal](../vs140/cprintdialog--domodal.md)   
 [PrintDlg](http://msdn.microsoft.com/library/windows/desktop/ms646940)