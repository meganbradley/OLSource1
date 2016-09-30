---
title: "CWinFormsDialog::GetControlHandle"
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
  - "GetControlHandle"
  - "CWinFormsDialog::GetControlHandle"
  - "CWinFormsDialog.GetControlHandle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetControlHandle method"
ms.assetid: 76700e94-e2e6-4257-8737-07c4cae047c5
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinFormsDialog::GetControlHandle
Retrieves a window handle to the Windows Forms user control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Description  
 This method is provided as a convenient way to obtain a window handle (<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>) for a \<xref:System.Windows.Forms.UserControl*> control, rather than performing a series of casts on a managed object, such as:  
  
 [!CODE [NVC_MFC_Managed#3](NVC_MFC_Managed#3)]  
  
## Return Value  
 Returns a window handle to the Windows Forms user control.  
  
## Requirements  
 **Header:** afxwinforms.h  
  
## See Also  
 \<xref:System.Windows.Forms.UserControl*?displayProperty=fullName>   
 [CWinFormsDialog Overview](../vs140/cwinformsdialog-class.md)   
 [CWinFormsDialog::GetControl](../vs140/cwinformsdialog--getcontrol.md)