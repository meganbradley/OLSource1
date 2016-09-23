---
title: "CDialog::OnOK"
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
  - CDialog.OnOK
  - CDialog::OnOK
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnOK method
  - CDialog class, overridables
ms.assetid: 78ca29b6-d9cf-44e6-ac6f-37a046e876e3
caps.latest.revision: 25
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDialog::OnOK
Called when the user clicks the **OK** button (the button with an ID of IDOK).  
  
## Syntax  
  
```  
virtual void OnOK( );  
```  
  
## Remarks  
 Override this method to perform actions when the **OK** button is activated. If the dialog box includes automatic data validation and exchange, the default implementation of this method validates the dialog box data and updates the appropriate variables in your application.  
  
 If you implement the **OK** button in a modeless dialog box, you must override the `OnOK` method and call [DestroyWindow](../vs140/cwnd--destroywindow.md) inside it. Do not call the base-class method, because it calls [EndDialog](../vs140/cdialog--enddialog.md) which makes the dialog box invisible but does not destroy it.  
  
> [!NOTE]
>  You cannot override this method when you use a `CFileDialog` object in a program that is compiled under Windows XP. For more information about `CFileDialog`, see [CFileDialog Class](../vs140/cfiledialog-class.md).  
  
## Example  
 [!code[NVC_MFCControlLadenDialog#68](../vs140/codesnippet/CPP/cdialog--onok_1.cpp)]
  
  
## Requirements  
 `Header:` afxwin.h  
  
## See Also  
 [CDialog Class](../vs140/cdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDialog::OnCancel](../vs140/cdialog--oncancel.md)   
 [CDialog::EndDialog](../vs140/cdialog--enddialog.md)