---
title: "Creating the Tab Control"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "TCS_EX_REGISTERDROP"
  - "TCS_EX_FLATSEPARATORS"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "TCS_EX_REGISTERDROP extended style"
  - "tab controls, creating"
  - "CTabCtrl class, creating"
  - "TCS_EX_FLATSEPARATORS extended style"
ms.assetid: 3a9c2d64-f5f4-41ea-84ab-fceb73c3dbdc
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Creating the Tab Control
How the tab control is created depends on whether you are using the control in a dialog box or creating it in a nondialog window.  
  
### To use CTabCtrl directly in a dialog box  
  
1.  In the dialog editor, add a Tab Control to your dialog template resource. Specify its control ID.  
  
2.  Use the [Add Member Variable Wizard](../vs140/adding-a-member-variable---visual-c---.md) to add a member variable of type [CTabCtrl](../vs140/ctabctrl-class.md) with the Control property. You can use this member to call <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> member functions.  
  
3.  Map handler functions in the dialog class for any tab control notification messages you need to handle. For more information, see [Mapping Messages to Functions](../vs140/mapping-messages-to-functions.md).  
  
4.  In [OnInitDialog](../vs140/cdialog--oninitdialog.md), set the styles for the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
### To use CTabCtrl in a nondialog window  
  
1.  Define the control in the view or window class.  
  
2.  Call the control's [Create](../vs140/ctabctrl--create.md) member function, possibly in [OnInitialUpdate](../vs140/cview--oninitialupdate.md), possibly as early as the parent window's [OnCreate](../vs140/cwnd--oncreate.md) handler function (if you're subclassing the control). Set the styles for the control.  
  
 After the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object has been created, you can set or clear the following extended styles:  
  
-   **TCS_EX_FLATSEPARATORS** The tab control will draw separators between the tab items. This extended style only affects tab controls that have the **TCS_BUTTONS** and **TCS_FLATBUTTONS** styles. By default, creating the tab control with the **TCS_FLATBUTTONS** style sets this extended style.  
  
-   **TCS_EX_REGISTERDROP** The tab control generates **TCN_GETOBJECT** notification messages to request a drop target object when an object is dragged over the tab items in the control.  
  
    > [!NOTE]
    >  To receive the **TCN_GETOBJECT** notification, you must initialize the OLE libraries with a call to [AfxOleInit](../vs140/afxoleinit.md).  
  
 These styles can be retrieved and set, after the control has been created, with respective calls to the [GetExtendedStyle](../vs140/ctabctrl--getextendedstyle.md) and [SetExtendedStyle](../vs140/ctabctrl--setextendedstyle.md) member functions.  
  
 For instance, set the **TCS_EX_FLATSEPARATORS** style with the following lines of code:  
  
 [!code[NVC_MFCControlLadenDialog#33](../vs140/codesnippet/CPP/creating-the-tab-control_1.cpp)]  
  
 Clear the **TCS_EX_FLATSEPARATORS** style from a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object with the following lines of code:  
  
 [!code[NVC_MFCControlLadenDialog#34](../vs140/codesnippet/CPP/creating-the-tab-control_2.cpp)]  
  
 This will remove the separators that appear between the buttons of your <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object.  
  
## See Also  
 [Using CTabCtrl](../vs140/using-ctabctrl.md)   
 [Controls (MFC)](../vs140/controls--mfc-.md)