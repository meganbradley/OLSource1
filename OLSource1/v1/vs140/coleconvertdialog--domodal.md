---
title: "COleConvertDialog::DoModal"
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
  - "COleConvertDialog::DoModal"
  - "COleConvertDialog.DoModal"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleConvertDialog class, operations and attributes"
  - "DoModal method"
ms.assetid: e383e972-945a-460c-b881-e7a7b2942bc8
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleConvertDialog::DoModal
Call this function to display the OLE Convert dialog box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Completion status for the dialog box. One of the following values:  
  
-   **IDOK** if the dialog box was successfully displayed.  
  
-   **IDCANCEL** if the user canceled the dialog box.  
  
-   **IDABORT** if an error occurred. If **IDABORT** is returned, call the [COleDialog::GetLastError](../vs140/coledialog--getlasterror.md) member function to get more information about the type of error that occurred. For a listing of possible errors, see the [OleUIConvert](http://msdn.microsoft.com/library/windows/desktop/ms680694) function in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Remarks  
 If you want to initialize the various dialog box controls by setting members of the [m_cv](../vs140/coleconvertdialog--m_cv.md) structure, you should do this before calling <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, but after the dialog object is constructed.  
  
 If <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> returns **IDOK**, you can call other member functions to retrieve the settings or information that was input by the user into the dialog box.  
  
## Requirements  
 **Header:** afxodlgs.h  
  
## See Also  
 [COleConvertDialog Class](../vs140/coleconvertdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDialog::GetLastError](../vs140/coledialog--getlasterror.md)   
 [CDialog::DoModal](../vs140/cdialog--domodal.md)   
 [COleConvertDialog::m_cv](../vs140/coleconvertdialog--m_cv.md)   
 [COleConvertDialog::DoConvert](../vs140/coleconvertdialog--doconvert.md)   
 [COleConvertDialog::GetSelectionType](../vs140/coleconvertdialog--getselectiontype.md)   
 [COleConvertDialog::GetClassID](../vs140/coleconvertdialog--getclassid.md)   
 [COleConvertDialog::GetDrawAspect](../vs140/coleconvertdialog--getdrawaspect.md)   
 [COleConvertDialog::GetIconicMetafile](../vs140/coleconvertdialog--geticonicmetafile.md)