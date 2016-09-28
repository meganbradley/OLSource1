---
title: "CWinFormsDialog::operator TManagedControl^"
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
  - "CWinFormsDialog::operator TManagedControl^"
  - "TManagedControl^"
  - "CWinFormsDialog.operator TManagedControl^"
  - "operator TManagedControl^"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator TManagedControl^"
  - "TManagedControl^ operator"
ms.assetid: 9ff688f2-92dc-4342-958f-4c8f6e2e1fff
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinFormsDialog::operator TManagedControl^
Casts a type as a reference to a Windows Forms user control.  
  
## Syntax  
  
```  
inline operator TManagedControl^( ) const throw( );  
```  
  
## Remarks  
 This operator casts a type as a reference to a <xref:System.Windows.Forms.UserControl*> control. It is used to pass a `CWinFormsDialog<``TManagedControl``>` dialog box to functions that accept a pointer to a Windows Forms user control object.  
  
## Requirements  
 **Header:** afxwinforms.h  
  
## See Also  
 <xref:System.Windows.Forms.UserControl*>   
 <xref:System.Windows.Forms.Form*>   
 [CWinFormsDialog Overview](../vs140/cwinformsdialog-class.md)