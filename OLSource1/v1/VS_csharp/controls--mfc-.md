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
  
 Class [CWnd](../VS_csharp/cwnd-class.md) is the base class of all window classes, including all of the control classes. The Windows common controls are supported in the following environments:  
  
-   Windows 95, Windows 98, and Windows 2000  
  
-   Windows NT, version 3.51 and later  
  
-   Win32s, version 1.3 (Visual C++ versions 4.2 and later do not support Win32s)  
  
 The older common controls — check boxes, combo boxes, edit boxes, list boxes, option buttons, pushbuttons, scroll bar controls, and static controls — were available in earlier versions of Windows as well.  
  
## ActiveX Controls  
 ActiveX controls, formerly known as OLE controls, can be used in dialog boxes in your applications for Windows, or in HTML pages on the World Wide Web. For more information, see [MFC ActiveX Controls](../VS_csharp/mfc-activex-controls.md).  
  
## Other MFC Control Classes  
 In addition to classes that encapsulate all of the Windows common controls and that support programming your own ActiveX controls (or using ActiveX controls supplied by others), MFC supplies the following control classes of its own:  
  
-   [CBitmapButton](../VS_csharp/cbitmapbutton-class.md)  
  
-   [CCheckListBox](../VS_csharp/cchecklistbox-class.md)  
  
-   [CDragListBox](../VS_csharp/cdraglistbox-class.md)  
  
##  <a name="_core_finding_information_about_windows_common_controls"></a> Finding Information About Windows Common Controls  
 The table below briefly describes each of the Windows common controls, including the control's MFC wrapper class.  
  
### Windows Common Controls and MFC Classes  
  
|Control|MFC class|Description|New in Windows 95?|  
|-------------|---------------|-----------------|------------------------|  
|[animation](../VS_csharp/using-canimatectrl.md)|[CAnimateCtrl](../VS_csharp/canimatectrl-class.md)|Displays successive frames of an AVI video clip|Yes|  
|button|[CButton](../VS_csharp/cbutton-class.md)|Pushbuttons that cause an action; also used for check boxes, radio buttons, and group boxes|No|  
|combo box|[CComboBox](../VS_csharp/ccombobox-class.md)|Combination of an edit box and a list box|No|  
|[date and time picker](../VS_csharp/using-cdatetimectrl.md)|[CDateTimeCtrl](../VS_csharp/cdatetimectrl-class.md)|Allows the user to choose a specific date or time value|Yes|  
|edit box|[CEdit](../VS_csharp/cedit-class.md)|Boxes for entering text|No|  
|[extended combo box](../VS_csharp/using-ccomboboxex.md)|[CComboBoxEx](../VS_csharp/ccomboboxex-class.md)|A combo box control with the ability to display images|Yes|  
|[header](../VS_csharp/using-cheaderctrl.md)|[CHeaderCtrl](../VS_csharp/cheaderctrl-class.md)|Button that appears above a column of text; controls width of text displayed|Yes|  
|[hotkey](../VS_csharp/using-chotkeyctrl.md)|[CHotKeyCtrl](../VS_csharp/chotkeyctrl-class.md)|Window that enables user to create a "hot key" to perform an action quickly|Yes|  
|[image list](../VS_csharp/using-cimagelist.md)|[CImageList](../VS_csharp/cimagelist-class.md)|Collection of images used to manage large sets of icons or bitmaps (image list isn't really a control; it supports lists used by other controls)|Yes|  
|[list](../VS_csharp/using-clistctrl.md)|[CListCtrl](../VS_csharp/clistctrl-class.md)|Window that displays a list of text with icons|Yes|  
|list box|[CListBox](../VS_csharp/clistbox-class.md)|Box that contains a list of strings|No|  
|[month calendar](../VS_csharp/using-cmonthcalctrl.md)|[CMonthCalCtrl](../VS_csharp/cmonthcalctrl-class.md)|Control that displays date information|Yes|  
|[progress](../VS_csharp/using-cprogressctrl.md)|[CProgressCtrl](../VS_csharp/cprogressctrl-class.md)|Window that indicates progress of a long operation|Yes|  
|[rebar](../VS_csharp/using-crebarctrl.md)|[CRebarCtrl](../VS_csharp/crebarctrl-class.md)|Tool bar that can contain additional child windows in the form of controls|Yes|  
|[rich edit](../VS_csharp/using-cricheditctrl.md)|[CRichEditCtrl](../VS_csharp/cricheditctrl-class.md)|Window in which user can edit with character and paragraph formatting (see [Classes Related to Rich Edit Controls](../VS_csharp/classes-related-to-rich-edit-controls.md))|Yes|  
|scroll bar|[CScrollBar](../VS_csharp/cscrollbar-class.md)|Scroll bar used as a control inside a dialog box (not on a window)|No|  
|[slider](../VS_csharp/using-csliderctrl.md)|[CSliderCtrl](../VS_csharp/csliderctrl-class.md)|Window containing a slider control with optional tick marks|Yes|  
|[spin button](../VS_csharp/using-cspinbuttonctrl.md)|[CSpinButtonCtrl](../VS_csharp/cspinbuttonctrl-class.md)|Pair of arrow buttons user can click to increment or decrement a value|Yes|  
|static-text|[CStatic](../VS_csharp/cstatic-class.md)|Text for labeling other controls|No|  
|[status bar](../VS_csharp/using-cstatusbarctrl.md)|[CStatusBarCtrl](../VS_csharp/cstatusbarctrl-class.md)|Window for displaying status information, similar to MFC class `CStatusBar`|Yes|  
|[tab](../VS_csharp/using-ctabctrl.md)|[CTabCtrl](../VS_csharp/ctabctrl-class.md)|Analogous to the dividers in a notebook; used in "tab dialog boxes" or property sheets|Yes|  
|[toolbar](../VS_csharp/using-ctoolbarctrl.md)|[CToolBarCtrl](../VS_csharp/ctoolbarctrl-class.md)|Window with command-generating buttons, similar to MFC class `CToolBar`|Yes|  
|[tool tip](../VS_csharp/using-ctooltipctrl.md)|[CToolTipCtrl](../VS_csharp/ctooltipctrl-class.md)|Small pop-up window that describes purpose of a toolbar button or other tool|Yes|  
|[tree](../VS_csharp/using-ctreectrl.md)|[CTreeCtrl](../VS_csharp/ctreectrl-class.md)|Window that displays a hierarchical list of items|Yes|  
  
### What do you want to know more about?  
  
-   An individual control: see the table [Windows Common Controls and MFC Classes](#_core_windows_common_controls_and_mfc_classes) in this topic for links to all controls  
  
-   [Making and using controls](../VS_csharp/making-and-using-controls.md)  
  
-   [Using the dialog editor to add controls](../VS_csharp/using-the-dialog-editor-to-add-controls.md)  
  
-   [Adding controls to a dialog box by hand](../VS_csharp/adding-controls-by-hand.md)  
  
-   [Deriving control classes from the MFC control classes](../VS_csharp/deriving-controls-from-a-standard-control.md)  
  
-   [Using common controls as child windows](../VS_csharp/using-a-common-control-as-a-child-window.md)  
  
-   [Notifications from common controls](../VS_csharp/receiving-notification-from-common-controls.md)  
  
-   [Add common controls to a dialog box](../VS_csharp/using-common-controls-in-a-dialog-box.md).  
  
-   [Derive a control from a standard Windows control](../VS_csharp/deriving-controls-from-a-standard-control.md)  
  
-   [Access dialog-box controls with type safety](../VS_csharp/type-safe-access-to-controls-in-a-dialog-box.md)  
  
-   [Receive notification messages from common controls](../VS_csharp/receiving-notification-from-common-controls.md)  
  
-   [Samples](../VS_csharp/common-control-sample-list.md)  
  
 For information about Windows common controls in the [!INCLUDE[winSDK](../VS_csharp/includes/winsdk_md.md)], see [Common Controls](http://msdn.microsoft.com/library/windows/desktop/bb775493).  
  
## See Also  
 [User Interface Elements](../VS_csharp/user-interface-elements--mfc-.md)   
 [Dialog Editor](../VS_csharp/dialog-editor.md)