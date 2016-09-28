---
title: "CDialog::NextDlgCtrl"
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
  - "CDialog.NextDlgCtrl"
  - "NextDlgCtrl"
  - "CDialog::NextDlgCtrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "NextDlgCtrl method"
  - "CDialog class, operations"
ms.assetid: 58a0959c-f112-4d01-9ca0-66a947637b26
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDialog::NextDlgCtrl
Moves the focus to the next control in the dialog box.  
  
## Syntax  
  
```  
  
void NextDlgCtrl( ) const;  
```  
  
## Remarks  
 If the focus is at the last control in the dialog box, it moves to the first control.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDialog Class](../vs140/cdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDialog::PrevDlgCtrl](../vs140/cdialog--prevdlgctrl.md)   
 [CDialog::GotoDlgCtrl](../vs140/cdialog--gotodlgctrl.md)