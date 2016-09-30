---
title: "CWinFormsDialog::OnInitDialog"
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
  - "CWinFormsDialog.OnInitDialog"
  - "CWinFormsDialog::OnInitDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnInitDialog method"
ms.assetid: 70ccd31c-cef5-4312-b975-3fc3ea15e042
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinFormsDialog::OnInitDialog
Initializes the MFC dialog box by creating and hosting a Windows Forms user control on it.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A boolean value that specifies whether the application has set the input focus to one of the controls in the dialog box. If <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> returns nonzero, Windows sets the input focus to the first control in the dialog box. This method can return 0 only if the application has explicitly set the input focus to one of the controls in the dialog box.  
  
## Remarks  
 When the MFC dialog box is created (using the [Create](../vs140/cdialog--create.md), [CreateIndirect](../vs140/cdialog--createindirect.md), or [DoModal](../vs140/cdialog--domodal.md) method inherited from [CDialog](../vs140/cdialog-class.md)), a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> message is sent and this method is called. It creates an instance of a \<xref:System.Windows.Forms.UserControl*> control on the dialog box and adjusts the size of the dialog box to accommodate for the size of the user control. Then it hosts the new control in the MFC dialog box.  
  
 Override this member function if you need to perform special processing when the dialog box is initialized. For more information on using this method, see [CDialog::OnInitDialog](../vs140/cdialog--oninitdialog.md).  
  
## Requirements  
 **Header:** afxwinforms.h  
  
## See Also  
 \<xref:System.Windows.Forms.UserControl*?displayProperty=fullName>   
 [CWinFormsDialog Overview](../vs140/cwinformsdialog-class.md)   
 [CDialog::OnInitDialog](../vs140/cdialog--oninitdialog.md)