---
title: "Creating the Date and Time Picker Control"
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
  - "DateTimePicker control [MFC], creating"
  - "CDateTimeCtrl class, creating"
ms.assetid: 764ec2fb-98cd-478b-a5f2-d63f0bb12279
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Creating the Date and Time Picker Control
How the date and time picker control is created depends on whether you are using the control in a dialog box or creating it in a nondialog window.  
  
### To use CDateTimeCtrl directly in a dialog box  
  
1.  In the dialog editor, add a Date and Time Picker Control to your dialog template resource. Specify its control ID.  
  
2.  Specify any styles required, using the Properties dialog box of the date and time picker control.  
  
3.  Use the [Add Member Variable Wizard](../vs140/adding-a-member-variable---visual-c---.md) to add a member variable of type [CDateTimeCtrl](../vs140/cdatetimectrl-class.md) with the Control property. You can use this member to call <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> member functions.  
  
4.  Use the Properties window to map handler functions in the dialog class for any date time picker control [notification](../vs140/processing-notification-messages-in-date-and-time-picker-controls.md) messages you need to handle (see [Mapping Messages to Functions](../vs140/mapping-messages-to-functions.md)).  
  
5.  In [OnInitDialog](../vs140/cdialog--oninitdialog.md), set any additional styles for the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
### To use CDateTimeCtrl in a nondialog window  
  
1.  Declare the control in the view or window class.  
  
2.  Call the control's [Create](../vs140/ctabctrl--create.md) member function, possibly in [OnInitialUpdate](../vs140/cview--oninitialupdate.md), possibly as early as the parent window's [OnCreate](../vs140/cwnd--oncreate.md) handler function (if you're subclassing the control). Set the styles for the control.  
  
## See Also  
 [Using CDateTimeCtrl](../vs140/using-cdatetimectrl.md)   
 [Controls (MFC)](../vs140/controls--mfc-.md)