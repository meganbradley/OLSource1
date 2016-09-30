---
title: "CPrintDialogEx::DoModal"
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
  - "CPrintDialogEx.DoModal"
  - "CPrintDialogEx::DoModal"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DoModal method"
ms.assetid: c1bd61ae-b881-4603-9fb2-0f9e4a7da775
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPrintDialogEx::DoModal
Call this function to display the Windows 2000 common Print property sheet and allow the user to select various printing options such as the number of copies, page range, and whether copies should be collated.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The INT_PTR return value is actually an HRESULT. See the Return Values section in [PrintDlgEx](http://msdn.microsoft.com/library/windows/desktop/ms646942) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Remarks  
 If you want to initialize the various print dialog options by setting members of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> structure, you should do this before calling <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, but after the dialog object is constructed.  
  
 After calling <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, you can call other member functions to retrieve the settings or information input by the user into the dialog box.  
  
 If the **PD_RETURNDC** flag is used when calling <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, a printer DC will be returned in the **hDC** member of [m_pdex](../vs140/cprintdialogex--m_pdex.md). This DC must be freed with a call to [DeleteDC](http://msdn.microsoft.com/library/windows/desktop/dd183533) by the caller of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPrintDialogEx Class](../vs140/cprintdialogex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPrintDialogEx::CPrintDialogEx](../vs140/cprintdialogex--cprintdialogex.md)   
 [CDialog::DoModal](../vs140/cdialog--domodal.md)