---
title: "Creating the Header Control"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CHeaderCtrl class, creating"
  - "header controls, creating"
ms.assetid: 7864d9d2-4a2c-4622-b58b-7b110a1e28d2
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Creating the Header Control
The header control is not directly available in the dialog editor (although you can add a list control, which includes a header control).  
  
### To put a header control in a dialog box  
  
1.  Manually embed a member variable of type [CHeaderCtrl](../vs140/cheaderctrl-class.md) in your dialog class.  
  
2.  In [OnInitDialog](../vs140/cdialog--oninitdialog.md), create and set the styles for the `CHeaderCtrl`, position it, and display it.  
  
3.  Add items to the header control.  
  
4.  Use the Properties window to map handler functions in the dialog class for any header-control notification messages you need to handle (see [Mapping Messages to Functions](../vs140/mapping-messages-to-functions.md)).  
  
### To put a header control in a view (not a CListView)  
  
1.  Embed a [CHeaderCtrl](../vs140/cheaderctrl-class.md) object in your view class.  
  
2.  Style, position, and display the header control window in the view's [OnInitialUpdate](../vs140/cview--oninitialupdate.md) member function.  
  
3.  Add items to the header control.  
  
4.  Use the Properties window to map handler functions in the view class for any header-control notification messages you need to handle (see [Mapping Messages to Functions](../vs140/mapping-messages-to-functions.md)).  
  
 In either case, the embedded control object is created when the view or dialog object is created. Then you must call [CHeaderCtrl::Create](../vs140/cheaderctrl--create.md) to create the control window. To position the control, call [CHeaderCtrl::Layout](../vs140/cheaderctrl--layout.md) to determine the control's initial size and position and [SetWindowPos](../vs140/cwnd--setwindowpos.md) to set the position you want. Then add items as described in [Adding Items to the Header Control](../vs140/adding-items-to-the-header-control.md).  
  
 For more information, see [Creating a Header Control](http://msdn.microsoft.com/library/windows/desktop/bb775238) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## See Also  
 [Using CHeaderCtrl](../vs140/using-cheaderctrl.md)   
 [Controls (MFC)](../vs140/controls--mfc-.md)