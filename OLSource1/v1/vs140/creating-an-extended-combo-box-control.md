---
title: "Creating an Extended Combo Box Control"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
helpviewer_keywords: 
  - extended combo boxes
  - CComboBoxEx class, creating extended combo box controls
  - extended combo boxes, creating
ms.assetid: a964267e-97b6-4e77-9f89-55bb5c68913f
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Creating an Extended Combo Box Control
How the extended combo box control is created depends on whether you are using the control in a dialog box or creating it in a nondialog window.  
  
### To use CComboBoxEx directly in a dialog box  
  
1.  In the dialog editor, add an Extended Combo Box control to your dialog template resource. Specify its control ID.  
  
2.  Specify any styles required, using the Properties dialog box of the extended combo box control.  
  
3.  Use the [Add Member Variable Wizard](../vs140/adding-a-member-variable---visual-c---.md) to add a member variable of type [CComboBoxEx](../vs140/ccomboboxex-class.md) with the Control property. You can use this member to call `CComboBoxEx` member functions.  
  
4.  Use the Properties window to map handler functions in the dialog class for any extended combo box control notification messages you need to handle (see [Mapping Messages to Functions](../vs140/mapping-messages-to-functions.md)).  
  
5.  In [OnInitDialog](../vs140/cdialog--oninitdialog.md), set any additional styles for the `CComboBoxEx` object.  
  
### To use CComboBoxEx in a nondialog window  
  
1.  Define the control in the view or window class.  
  
2.  Call the control's [Create](../vs140/ctabctrl--create.md) member function, possibly in [OnInitialUpdate](../vs140/cview--oninitialupdate.md), possibly as early as the parent window's [OnCreate](../vs140/cwnd--oncreate.md) handler function. Set the styles for the control.  
  
## See Also  
 [Using CComboBoxEx](../vs140/using-ccomboboxex.md)   
 [Controls (MFC)](../vs140/controls--mfc-.md)