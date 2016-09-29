---
title: "Control Classes"
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
  - "vc.classes.control"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "static display controls"
  - "control classes"
  - "buttons, MFC control classes"
  - "controls [C++], MFC control classes"
  - "controls [MFC]"
  - "list boxes, MFC control classes"
  - "control classes, MFC"
  - "text, controls for input"
  - "user input, MFC control classes"
ms.assetid: f9876606-9f5b-44cb-9135-213298d1df8f
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Control Classes
Control classes encapsulate a wide variety of standard Windows controls ranging from static text controls to tree controls. In addition, MFC provides some new controls, including buttons with bitmaps and control bars.  
  
 The controls whose class names end in "**Ctrl**" were new in Windows 95 and Windows NT version 3.51.  
  
## Static Display Controls  
 [CStatic](../VS_csharp/cstatic-class.md)  
 A static-display window. Static controls are used to label, box, or separate other controls in a dialog box or window. They may also display graphical images rather than text or a box.  
  
## Text Controls  
 [CEdit](../VS_csharp/cedit-class.md)  
 An editable-text control window. Edit controls are used to accept textual input from the user.  
  
 [CIPAddressCtrl](../VS_csharp/cipaddressctrl-class.md)  
 Supports an edit box for manipulating an Internet Protocol (IP) address.  
  
 [CRichEditCtrl](../VS_csharp/cricheditctrl-class.md)  
 A control in which the user can enter and edit text. Unlike the control encapsulated in `CEdit`, a rich edit control supports character and paragraph formatting and OLE objects.  
  
## Controls That Represent Numbers  
 [CSliderCtrl](../VS_csharp/csliderctrl-class.md)  
 A control containing a slider, which the user moves to select a value or set of values.  
  
 [CSpinButtonCtrl](../VS_csharp/cspinbuttonctrl-class.md)  
 A pair of arrow buttons the user can click to increment or decrement a value.  
  
 [CProgressCtrl](../VS_csharp/cprogressctrl-class.md)  
 Displays a rectangle that is gradually filled from left to right to indicate the progress of an operation.  
  
 [CScrollBar](../VS_csharp/cscrollbar-class.md)  
 A scroll-bar control window. The class provides the functionality of a scroll bar, for use as a control in a dialog box or window, through which the user can specify a position within a range.  
  
## Buttons  
 [CButton](../VS_csharp/cbutton-class.md)  
 A button control window. The class provides a programmatic interface for a push button, check box, or radio button in a dialog box or window.  
  
 [CBitmapButton](../VS_csharp/cbitmapbutton-class.md)  
 A button with a bitmap rather than a text caption.  
  
## Lists  
 [CListBox](../VS_csharp/clistbox-class.md)  
 A list-box control window. A list box displays a list of items that the user can view and select.  
  
 [CDragListBox](../VS_csharp/cdraglistbox-class.md)  
 Provides the functionality of a Windows list box; allows the user to move list box items, such as filenames and string literals, within the list box. List boxes with this capability are useful for an item list in an order other than alphabetical, such as include pathnames or files in a project.  
  
 [CComboBox](../VS_csharp/ccombobox-class.md)  
 A combo-box control window. A combo box consists of an edit control plus a list box.  
  
 [CComboBoxEx](../VS_csharp/ccomboboxex-class.md)  
 Extends the combo box control by providing support for image lists.  
  
 [CCheckListBox](../VS_csharp/cchecklistbox-class.md)  
 Displays a list of items with check boxes, which the user can check or clear, next to each item.  
  
 [CListCtrl](../VS_csharp/clistctrl-class.md)  
 Displays a collection of items, each consisting of an icon and a label, in a manner similar to the right pane of File Explorer.  
  
 [CTreeCtrl](../VS_csharp/ctreectrl-class.md)  
 Displays a hierarchical list of icons and labels arranged in a manner similar to the left pane of File Explorer.  
  
## Toolbars and Status Bars  
 [CToolBarCtrl](../VS_csharp/ctoolbarctrl-class.md)  
 Provides the functionality of the Windows toolbar common control. Most MFC programs use [CToolBar](../VS_csharp/ctoolbar-class.md) instead of this class.  
  
 [CStatusBarCtrl](../VS_csharp/cstatusbarctrl-class.md)  
 A horizontal window, usually divided into panes, in which an application can display status information. Most MFC programs use [CStatusBar](../VS_csharp/cstatusbar-class.md) instead of this class.  
  
## Miscellaneous Controls  
 [CAnimateCtrl](../VS_csharp/canimatectrl-class.md)  
 Displays a simple video clip.  
  
 [CToolTipCtrl](../VS_csharp/ctooltipctrl-class.md)  
 A small pop-up window that displays a single line of text describing the purpose of a tool in an application.  
  
 [CDateTimeCtrl](../VS_csharp/cdatetimectrl-class.md)  
 Supports either an extended edit control, or a simple calendar interface control, that allows a user to choose a specific date or time value.  
  
 [CHeaderCtrl](../VS_csharp/cheaderctrl-class.md)  
 Displays titles or labels for columns.  
  
 [CMonthCalCtrl](../VS_csharp/cmonthcalctrl-class.md)  
 Supports a simple calendar interface control that allows a user to select a date.  
  
 [CTabCtrl](../VS_csharp/ctabctrl-class.md)  
 A control with tabs on which the user can click, analogous to the dividers in a notebook.  
  
 [CHotKeyCtrl](../VS_csharp/chotkeyctrl-class.md)  
 Enables the user to create a hot key combination, which the user can press to perform an action quickly.  
  
 [CLinkCtrl](../VS_csharp/clinkctrl-class.md)  
 Renders marked-up text and launches appropriate applications when the user clicks the embedded link.  
  
 [CHtmlEditCtrl](../VS_csharp/chtmleditctrl-class.md)  
 Provides the functionality of the WebBrowser ActiveX control in an MFC window.  
  
## Related Classes  
 [CImageList](../VS_csharp/cimagelist-class.md)  
 Provides the functionality of the Windows image list. Image lists are used with list controls and tree controls. They can also be used to store and archive a set of same-sized bitmaps.  
  
 [CCtrlView](../VS_csharp/cctrlview-class.md)  
 The base class for all views associated with Windows controls. The views based on controls are described below.  
  
 [CEditView](../VS_csharp/ceditview-class.md)  
 A view that contains a Windows standard edit control.  
  
 [CRichEditView](../VS_csharp/cricheditview-class.md)  
 A view that contains a Windows rich edit control.  
  
 [CListView](../VS_csharp/clistview-class.md)  
 A view that contains a Windows list control.  
  
 [CTreeView](../VS_csharp/ctreeview-class.md)  
 A view that contains a Windows tree control.  
  
## See Also  
 [Class Overview](../VS_csharp/class-library-overview.md)