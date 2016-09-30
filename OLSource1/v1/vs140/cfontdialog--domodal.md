---
title: "CFontDialog::DoModal"
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
  - "CFontDialog::DoModal"
  - "CFontDialog.DoModal"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DoModal method"
  - "CFontDialog class, operations"
ms.assetid: b9d5c37a-6f65-4409-95f3-277a9eb0b796
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFontDialog::DoModal
Call this function to display the Windows common font dialog box and allow the user to choose a font.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 **IDOK** or **IDCANCEL**. If **IDCANCEL** is returned, call the Windows [CommDlgExtendedError](http://msdn.microsoft.com/library/windows/desktop/ms646916) function to determine whether an error occurred.  
  
 **IDOK** and **IDCANCEL** are constants that indicate whether the user selected the OK or Cancel button.  
  
## Remarks  
 If you want to initialize the various font dialog controls by setting members of the [m_cf](../vs140/cfontdialog--m_cf.md) structure, you should do this before calling <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, but after the dialog object is constructed.  
  
 If <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> returns **IDOK**, you can call other member functions to retrieve the settings or information input by the user into the dialog box.  
  
## Example  
 See the examples for [CFontDialog::CFontDialog](../vs140/cfontdialog--cfontdialog.md) and [CFontDialog::GetColor](../vs140/cfontdialog--getcolor.md).  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CFontDialog Class](../vs140/cfontdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDialog::DoModal](../vs140/cdialog--domodal.md)   
 [CFontDialog::CFontDialog](../vs140/cfontdialog--cfontdialog.md)