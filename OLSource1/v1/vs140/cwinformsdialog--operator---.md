---
title: "CWinFormsDialog::operator -&gt;"
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
  - "CWinFormsDialog::operator->"
  - "CWinFormsDialog.operator->"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator ->"
  - "-> operator"
ms.assetid: dc7c7a65-4332-432c-b482-6c96a0b5a28c
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinFormsDialog::operator -&gt;
Replaces [GetControl](../vs140/cwinformsdialog--getcontrol.md) in expressions.  
  
## Syntax  
  
```  
inline TManagedControl^ operator->( ) const throw( );  
```  
  
## Remarks  
 This operator provides a convenient syntax that replaces `GetControl` in expressions.  
  
 For information on using Windows Forms, see [Using a Windows Form User Control in MFC](../vs140/using-a-windows-form-user-control-in-mfc.md).  
  
## Requirements  
 **Header:** afxwinforms.h  
  
## See Also  
 [CWinFormsDialog Overview](../vs140/cwinformsdialog-class.md)   
 [GetControl](../vs140/cwinformsdialog--getcontrol.md)