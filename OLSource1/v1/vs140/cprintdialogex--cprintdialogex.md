---
title: "CPrintDialogEx::CPrintDialogEx"
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
  - CPrintDialogEx.CPrintDialogEx
  - CPrintDialogEx::CPrintDialogEx
dev_langs: 
  - C++
helpviewer_keywords: 
  - CPrintDialogEx class, constructor
ms.assetid: 2e1e4401-4377-4c92-b5b6-5710acf21999
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CPrintDialogEx::CPrintDialogEx
Constructs a Windows 2000 Print property sheet.  
  
## Syntax  
  
```  
  
      CPrintDialogEx(  
   DWORD dwFlags = PD_ALLPAGES | PD_USEDEVMODECOPIES | PD_NOPAGENUMS  
      | PD_HIDEPRINTTOFILE | PD_NOSELECTION | PD_NOCURRENTPAGE,  
   CWnd* pParentWnd = NULL  
);  
```  
  
#### Parameters  
 `dwFlags`  
 One or more flags you can use to customize the settings of the dialog box, combined using the bitwise OR operator. For example, the **PD_ALLPAGES** flag sets the default print range to all pages of the document. See the [PRINTDLGEX](http://msdn.microsoft.com/library/windows/desktop/ms646844) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information on these flags.  
  
 `pParentWnd`  
 A pointer to the dialog box's parent or owner window.  
  
## Remarks  
 This member function only constructs the object. Use the `DoModal` member function to display the dialog box.  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPrintDialogEx Class](../vs140/cprintdialogex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPrintDialogEx::DoModal](../vs140/cprintdialogex--domodal.md)   
 [Print Property Sheet](http://msdn.microsoft.com/library/windows/desktop/ms646966)