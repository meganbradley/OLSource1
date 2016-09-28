---
title: "CDialog::OnCancel"
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
  - "CDialog.OnCancel"
  - "CDialog::OnCancel"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnCancel method"
  - "CDialog class, overridables"
ms.assetid: 01b6fadd-183c-481d-9a9b-4da64213b1c2
caps.latest.revision: 25
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDialog::OnCancel
The framework calls this method when the user clicks **Cancel** or presses the ESC key in a modal or modeless dialog box.  
  
## Syntax  
  
```  
virtual void OnCancel( );  
```  
  
## Remarks  
 Override this method to perform actions (such as restoring old data) when a user closes the dialog box by clicking **Cancel** or hitting the ESC key. The default closes a modal dialog box by calling [EndDialog](../vs140/cdialog--enddialog.md) and causing [DoModal](../vs140/cdialog--domodal.md) to return IDCANCEL.  
  
 If you implement the **Cancel** button in a modeless dialog box, you must override the `OnCancel` method and call [DestroyWindow](../vs140/cwnd--destroywindow.md) inside it. Do not call the base-class method, because it calls `EndDialog`, which will make the dialog box invisible but not destroy it.  
  
> [!NOTE]
>  You cannot override this method when you use a `CFileDialog` object in a program that is compiled under Windows XP. For more information about `CFileDialog`, see [CFileDialog Class](../vs140/cfiledialog-class.md).  
  
## Example  
 [!code[NVC_MFCControlLadenDialog#66](../vs140/codesnippet/CPP/cdialog--oncancel_1.cpp)]  
  
## Requirements  
 `Header:` afxwin.h  
  
## See Also  
 [CDialog Class](../vs140/cdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDialog::OnOK](../vs140/cdialog--onok.md)   
 [CDialog::EndDialog](../vs140/cdialog--enddialog.md)