---
title: "CDialog::GotoDlgCtrl"
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
  - "CDialog.GotoDlgCtrl"
  - "CDialog::GotoDlgCtrl"
  - "GotoDlgCtrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDialog class, operations"
  - "GotoDlgCtrl method"
ms.assetid: 171bc5b7-5ecb-4bec-a0b5-5b56c5ebbddd
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDialog::GotoDlgCtrl
Moves the focus to the specified control in the dialog box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Identifies the window (control) that is to receive the focus.  
  
## Remarks  
 To get a pointer to the control (child window) to pass as <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, call the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> member function, which returns a pointer to a [CWnd](../vs140/cwnd-class.md) object.  
  
## Example  
 See the example for [CWnd::GetDlgItem](../vs140/cwnd--getdlgitem.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDialog Class](../vs140/cdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::GetDlgItem](../vs140/cwnd--getdlgitem.md)   
 [CDialog::PrevDlgCtrl](../vs140/cdialog--prevdlgctrl.md)   
 [CDialog::NextDlgCtrl](../vs140/cdialog--nextdlgctrl.md)