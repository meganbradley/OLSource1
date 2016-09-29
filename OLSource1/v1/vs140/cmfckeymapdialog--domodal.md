---
title: "CMFCKeyMapDialog::DoModal"
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
  - "CMFCKeyMapDialog::DoModal"
  - "DoModal"
  - "CMFCKeyMapDialog.DoModal"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DoModal method"
ms.assetid: 591f239f-6340-4c0b-8ada-7c2d4a3d4026
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCKeyMapDialog::DoModal
Displays a keyboard mapping dialog box.  
  
## Syntax  
  
```  
virtual INT_PTR DoModal();  
```  
  
## Return Value  
 A signed integer, such as `IDOK` or `IDCANCEL`, that is passed to the [CDialog::EndDialog](../vs140/cdialog--enddialog.md) method. The method, in turn, closes the dialog box. For more information, see [CDialog::DoModal](../vs140/cdialog--domodal.md).  
  
## Remarks  
 The keyboard mapping dialog box enables you to select and assign accelerator keys to various categories of commands. In addition, you can copy the selected accelerator keys and their description to the clipboard.  
  
## Requirements  
 **Header:** afxkeymapdialog.h  
  
## See Also  
 [CMFCKeyMapDialog Class](../vs140/cmfckeymapdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)