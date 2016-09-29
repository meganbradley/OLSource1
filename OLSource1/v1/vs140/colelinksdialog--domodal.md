---
title: "COleLinksDialog::DoModal"
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
  - "COleLinksDialog.DoModal"
  - "COleLinksDialog::DoModal"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleLinksDialog class, operations and attributes"
  - "DoModal method"
ms.assetid: 00a76c98-39df-45ad-ba04-2a8ba15205a8
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleLinksDialog::DoModal
Displays the OLE Edit Links dialog box.  
  
## Syntax  
  
```  
  
virtual INT_PTR DoModal();  
```  
  
## Return Value  
 Completion status for the dialog box. One of the following values:  
  
-   **IDOK** if the dialog box was successfully displayed.  
  
-   **IDCANCEL** if the user canceled the dialog box.  
  
-   **IDABORT** if an error occurred. If **IDABORT** is returned, call the `COleDialog::GetLastError` member function to get more information about the type of error that occurred. For a listing of possible errors, see the [OleUIEditLinks](http://msdn.microsoft.com/library/windows/desktop/ms679703) function in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Remarks  
 If you want to initialize the various dialog box controls by setting members of the [m_el](../vs140/colelinksdialog--m_el.md) structure, you should do it before calling `DoModal`, but after the dialog object is constructed.  
  
## Requirements  
 **Header:** afxodlgs.h  
  
## See Also  
 [COleLinksDialog Class](../vs140/colelinksdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDialog::GetLastError](../vs140/coledialog--getlasterror.md)   
 [CDialog::DoModal](../vs140/cdialog--domodal.md)   
 [COleLinksDialog::m_el](../vs140/colelinksdialog--m_el.md)