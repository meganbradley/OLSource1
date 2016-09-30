---
title: "Controls (MFC)"
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
  - "Windows common controls [C++]"
  - "common controls [C++]"
  - "controls [MFC]"
ms.assetid: b2842884-6435-4b8f-933b-21671bf8af95
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Controls (MFC)
Controls are objects that users can interact with to enter or manipulate data. They commonly appear in dialog boxes or on toolbars. This topic family covers three main kinds of controls:  
  
-   Windows common controls, including owner-drawn controls  
  
-   ActiveX Controls  
  
-   Other control classes supplied by the Microsoft Foundation Class Library (MFC)  
  
## Windows Common Controls  
 The Windows operating system has always provided a number of Windows common controls. These control objects are programmable, and the Visual C++ dialog editor supports adding them to your dialog boxes. The Microsoft Foundation Class Library (MFC) supplies classes that encapsulate each of these controls, as shown in the table [Windows Common Controls and MFC Classes](#_core_windows_common_controls_and_mfc_classes). (Some items in the table have related topics that describe them further. For controls that lack topics, see the documentation for the MFC class.)  
  
 Class [CWnd](../vs140/cwnd-class.md) is the base class of all window classes, including all of the control classes. The Windows common controls are supported in the following environments:  
  
-   Windows 95, Windows 98, and Windows 2000  
  
-   Windows NT, version 3.51 and later  
  
-   Win32s, version 1.3 (Visual C++ versions 4.2 and later do not support Win32s)  
  
 The older common controls — check boxes, combo boxes, edit boxes, list boxes, option buttons, pushbuttons, scroll bar controls, and static controls — were available in earlier versions of Windows as well.  
  
## ActiveX Controls  
 ActiveX controls, formerly known as OLE controls, can be used in dialog boxes in your applications for Windows, or in HTML pages on the World Wide Web. For more information, see [MFC ActiveX Controls](../vs140/mfc-activex-controls.md).  
  
## Other MFC Control Classes  
 In addition to classes that encapsulate all of the Windows common controls and that support programming your own ActiveX controls (or using ActiveX controls supplied by others), MFC supplies the following control classes of its own:  
  
-   [CBitmapButton](../vs140/cbitmapbutton-class.md)  
  
-   [CCheckListBox](../vs140/cchecklistbox-class.md)  
  
-   [CDragListBox](../vs140/cdraglistbox-class.md)  
  
##  \<a name="_core_finding_information_about_windows_common_controls"></a> Finding Information About Windows Common Controls  
 The table below briefly describes each of the Windows common controls, including the control's MFC wrapper class.  
  
### Windows Common Controls and MFC Classes  
  
|Control|MFC class|Description|New in Windows 95?|  
|-------------|---------------|-----------------|------------------------|  
|[animation](../vs140/using-canimatectrl.md)|[CAnimateCtrl](../vs140/canimatectrl-class.md)|Displays successive frames of an AVI video clip|Yes|  
|button|[CButton](../vs140/cbutton-class.md)|Pushbuttons that cause an action; also used for check boxes, radio buttons, and group boxes|No|  
|combo box|[CComboBox](../vs140/ccombobox-class.md)|Combination of an edit box and a list box|No|  
|[date and time picker](../vs140/using-cdatetimectrl.md)|[CDateTimeCtrl](../vs140/cdatetimectrl-class.md)|Allows the user to choose a specific date or time value|Yes|  
|edit box|[CEdit](../vs140/cedit-class.md)|Boxes for entering text|No|  
|[extended combo box](../vs140/using-ccomboboxex.md)|[CComboBoxEx](../vs140/ccomboboxex-class.md)|A combo box control with the ability to display images|Yes|  
|[header](../vs140/using-cheaderctrl.md)|[CHeaderCtrl](../vs140/cheaderctrl-class.md)|Button that appears above a column of text; controls width of text displayed|Yes|  
|[hotkey](../vs140/using-chotkeyctrl.md)|[CHotKeyCtrl](../vs140/chotkeyctrl-class.md)|Window that enables user to create a "hot key" to perform an action quickly|Yes|  
|[image list](../vs140/using-cimagelist.md)|[CImageList](../vs140/cimagelist-class.md)|Collection of images used to manage large sets of icons or bitmaps (image list isn't really a control; it supports lists used by other controls)|Yes|  
|[list](../vs140/using-clistctrl.md)|[CListCtrl](../vs140/clistctrl-class.md)|Window that displays a list of text with icons|Yes|  
|list box|[CListBox](../vs140/clistbox-class.md)|Box that contains a list of strings|No|  
|[month calendar](../vs140/using-cmonthcalctrl.md)|[CMonthCalCtrl](../vs140/cmonthcalctrl-class.md)|Control that displays date information|Yes|  
|[progress](../vs140/using-cprogressctrl.md)|[CProgressCtrl](../vs140/cprogressctrl-class.md)|Window that indicates progress of a long operation|Yes|  
|[rebar](../vs140/using-crebarctrl.md)|[CRebarCtrl](../vs140/crebarctrl-class.md)|Tool bar that can contain additional child windows in the form of controls|Yes|  
|[rich edit](../vs140/using-cricheditctrl.md)|[CRichEditCtrl](../vs140/cricheditctrl-class.md)|Window in which user can edit with character and paragraph formatting (see [Classes Related to Rich Edit Controls](../vs140/classes-related-to-rich-edit-controls.md))|Yes|  
|scroll bar|[CScrollBar](../vs140/cscrollbar-class.md)|Scroll bar used as a control inside a dialog box (not on a window)|No|  
|[slider](../vs140/using-csliderctrl.md)|[CSliderCtrl](../vs140/csliderctrl-class.md)|Window containing a slider control with optional tick marks|Yes|  
|[spin button](../vs140/using-cspinbuttonctrl.md)|[CSpinButtonCtrl](../vs140/cspinbuttonctrl-class.md)|Pair of arrow buttons user can click to increment or decrement a value|Yes|  
|static-text|[CStatic](../vs140/cstatic-class.md)|Text for labeling other controls|No|  
|[status bar](../vs140/using-cstatusbarctrl.md)|[CStatusBarCtrl](../vs140/cstatusbarctrl-class.md)|Window for displaying status information, similar to MFC class `CStatusBar`|Yes|  
|[tab](../vs140/using-ctabctrl.md)|[CTabCtrl](../vs140/ctabctrl-class.md)|Analogous to the dividers in a notebook; used in "tab dialog boxes" or property sheets|Yes|  
|[toolbar](../vs140/using-ctoolbarctrl.md)|[CToolBarCtrl](../vs140/ctoolbarctrl-class.md)|Window with command-generating buttons, similar to MFC class `CToolBar`|Yes|  
|[tool tip](../vs140/using-ctooltipctrl.md)|[CToolTipCtrl](../vs140/ctooltipctrl-class.md)|Small pop-up window that describes purpose of a toolbar button or other tool|Yes|  
|[tree](../vs140/using-ctreectrl.md)|[CTreeCtrl](../vs140/ctreectrl-class.md)|Window that displays a hierarchical list of items|Yes|  
  
### What do you want to know more about?  
  
-   An individual control: see the table [Windows Common Controls and MFC Classes](#_core_windows_common_controls_and_mfc_classes) in this topic for links to all controls  
  
-   [Making and using controls](../vs140/making-and-using-controls.md)  
  
-   [Using the dialog editor to add controls](../vs140/using-the-dialog-editor-to-add-controls.md)  
  
-   [Adding controls to a dialog box by hand](../vs140/adding-controls-by-hand.md)  
  
-   [Deriving control classes from the MFC control classes](../vs140/deriving-controls-from-a-standard-control.md)  
  
-   [Using common controls as child windows](../vs140/using-a-common-control-as-a-child-window.md)  
  
-   [Notifications from common controls](../vs140/receiving-notification-from-common-controls.md)  
  
-   [Add common controls to a dialog box](../vs140/using-common-controls-in-a-dialog-box.md).  
  
-   [Derive a control from a standard Windows control](../vs140/deriving-controls-from-a-standard-control.md)  
  
-   [Access dialog-box controls with type safety](../vs140/type-safe-access-to-controls-in-a-dialog-box.md)  
  
-   [Receive notification messages from common controls](../vs140/receiving-notification-from-common-controls.md)  
  
-   [Samples](../vs140/common-control-sample-list.md)  
  
 For information about Windows common controls in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)], see [Common Controls](http://msdn.microsoft.com/library/windows/desktop/bb775493).  
  
## See Also  
 [User Interface Elements](../vs140/user-interface-elements--mfc-.md)   
 [Dialog Editor](../vs140/dialog-editor.md)