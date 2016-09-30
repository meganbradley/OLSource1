---
title: "CMFCToolBarComboBoxButton Class"
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
  - "CMFCToolBarComboBoxButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCToolBarComboBoxButton class"
ms.assetid: 32fa39f7-8e4e-4f0a-a31d-7b540d969a6c
caps.latest.revision: 29
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarComboBoxButton Class
A toolbar button that contains a combo box control ( [CComboBox](../vs140/ccombobox-class.md)).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCToolBarComboBoxButton::CMFCToolbarComboBoxButton](#cmfctoolbarcomboboxbutton__cmfctoolbarcomboboxbutton)|Constructs a <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCToolBarComboBoxButton::AddItem](#cmfctoolbarcomboboxbutton__additem)|Adds an item to the end of the combo box list.|  
|[CMFCToolBarComboBoxButton::AddSortedItem](#cmfctoolbarcomboboxbutton__addsorteditem)|Adds an item to the combo box list. The order of items in the list is specified by <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>.|  
|[CMFCToolBarComboBoxButton::Compare](#cmfctoolbarcomboboxbutton__compare)|Compares two items. Called to sort items that <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> adds to the combo box list.|  
|[CMFCToolBarComboBoxButton::CreateEdit](#cmfctoolbarcomboboxbutton__createedit)|Creates a new edit control for the combo box button.|  
|[CMFCToolBarComboBoxButton::DeleteItem](#cmfctoolbarcomboboxbutton__deleteitem)|Deletes an item from the combo box list.|  
|[CMFCToolBarComboBoxButton::FindItem](#cmfctoolbarcomboboxbutton__finditem)|Returns the index of the item that contains a specified string.|  
|[CMFCToolBarComboBoxButton::GetByCmd](#cmfctoolbarcomboboxbutton__getbycmd)|Returns a pointer to the combo box button with a specified command ID.|  
|[CMFCToolBarComboBoxButton::GetComboBox](#cmfctoolbarcomboboxbutton__getcombobox)|Returns a pointer to the combo box control that is embedded in the combo box button.|  
|[CMFCToolBarComboBoxButton::GetCount](#cmfctoolbarcomboboxbutton__getcount)|Returns the number of items in the combo box list.|  
|[CMFCToolBarComboBoxButton::GetCountAll](#cmfctoolbarcomboboxbutton__getcountall)|Finds the combo box button that has a specified command ID. Returns the number of items in the combo box list of that button.|  
|[CMFCToolBarComboBoxButton::GetCurSel](#cmfctoolbarcomboboxbutton__getcursel)|Returns the index of the selected item in the combo box list.|  
|[CMFCToolBarComboBoxButton::GetCurSelAll](#cmfctoolbarcomboboxbutton__getcurselall)|Finds the combo box button that has a specified command ID, and returns the index of the selected item in the combo box list of that button.|  
|[CMFCToolBarComboBoxButton::GetEditCtrl](#cmfctoolbarcomboboxbutton__geteditctrl)|Returns a pointer to the edit control that is embedded in the combo box button.|  
|[CMFCToolBarComboBoxButton::GetItem](#cmfctoolbarcomboboxbutton__getitem)|Returns the string that is associated with a specified index in the combo box list.|  
|[CMFCToolBarComboBoxButton::GetItemAll](#cmfctoolbarcomboboxbutton__getitemall)|Finds the combo box button that has a specified command ID, and returns the string that is associated with an index in the combo box list of that button.|  
|[CMFCToolBarComboBoxButton::GetItemData](#cmfctoolbarcomboboxbutton__getitemdata)|Returns the 32-bit value that is associated with a specified index in the combo box list.|  
|[CMFCToolBarComboBoxButton::GetItemDataAll](#cmfctoolbarcomboboxbutton__getitemdataall)|Finds the combo box button that has a specified command ID, and returns the 32-bit value that is associated with an index in the combo box list of that button.|  
|[CMFCToolBarComboBoxButton::GetItemDataPtrAll](#cmfctoolbarcomboboxbutton__getitemdataptrall)|Finds the combo box button that has a specified command ID. Retrieves the 32-bit value that is associated an index in the combo box list of that button, and returns the 32-bit value as a pointer.|  
|[CMFCToolBarComboBoxButton::GetText](#cmfctoolbarcomboboxbutton__gettext)|Returns the text from the edit control of the combo box.|  
|[CMFCToolBarComboBoxButton::GetTextAll](#cmfctoolbarcomboboxbutton__gettextall)|Finds the combo box button that has a specified command ID, and returns the text from edit control of that button.|  
|[CMFCToolBarComboBoxButton::IsCenterVert](#cmfctoolbarcomboboxbutton__iscentervert)|Determines whether combo box buttons in the application are centered or aligned with the top of the toolbar.|  
|[CMFCToolBarComboBoxButton::IsFlatMode](#cmfctoolbarcomboboxbutton__isflatmode)|Determines whether combo box buttons in the application have a flat appearance.|  
|[CMFCToolBarComboBoxButton::RemoveAllItems](#cmfctoolbarcomboboxbutton__removeallitems)|Removes all items from the list box and edit control of the combo box.|  
|[CMFCToolBarComboBoxButton::SelectItem](#cmfctoolbarcomboboxbutton__selectitem)|Selects an item in the combo box according to its index, 32-bit value, or string, and notifies the combo box control about the selection.|  
|[CMFCToolBarComboBoxButton::SelectItemAll](#cmfctoolbarcomboboxbutton__selectitemall)|Finds the combo box button that has a specified command ID. Calls <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> to select an item in the combo box of that button according to its string, index, or 32-bit value.|  
|[CMFCToolBarComboBoxButton::SetCenterVert](#cmfctoolbarcomboboxbutton__setcentervert)|Specifies whether combo box buttons in the application are centered vertically or aligned with the top of the toolbar.|  
|[CMFCToolBarComboBoxButton::SetDropDownHeight](#cmfctoolbarcomboboxbutton__setdropdownheight)|Sets the height of the drop-down list box.|  
|[CMFCToolBarComboBoxButton::SetFlatMode](#cmfctoolbarcomboboxbutton__setflatmode)|Specifies whether combo box buttons in the application have a flat appearance.|  
  
## Remarks  
 To add a combo box button to a toolbar, follow these steps:  
  
 1. Reserve a dummy resource ID for the button in the parent toolbar resource.  
  
 2. Construct a <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> object.  
  
 3. In the message handler that processes the <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> message, replace the dummy button with the new combo box button by using [CMFCToolBar::ReplaceButton](../vs140/cmfctoolbar-class.md#cmfctoolbar__replacebutton).  
  
 For more information, see [How to Put Controls on Toolbars](../vs140/walkthrough--putting-controls-on-toolbars.md). For an example of a combo box toolbar button, see the example project VisualStudioDemo.  
  
## Example  
 The following example demonstrates how to use various methods in the <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> class. The example shows how to enable the edit and combo boxes, set the vertical position of combo box buttons in the application, set the height of the list box when it is dropped down, set the flat style appearance of combo box buttons in the application, and set the text in the edit box of the combo box button. This code snippet is part of the [Visual Studio Demo sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_VisualStudioDemo#36](../vs140/codesnippet/CPP/cmfctoolbarcomboboxbutton-class_1.cpp)]  
[!code[NVC_MFC_VisualStudioDemo#37](../vs140/codesnippet/CPP/cmfctoolbarcomboboxbutton-class_2.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CMFCToolBarButton](../vs140/cmfctoolbarbutton-class.md)  
  
 [CMFCToolBarComboBoxButton](../vs140/cmfctoolbarcomboboxbutton-class.md)  
  
## Requirements  
 **Header:** afxtoolbarcomboboxbutton.h  
  
##  \<a name="cmfctoolbarcomboboxbutton__additem">\</a>  CMFCToolBarComboBoxButton::AddItem  
 Appends a unique item to the list box.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 The text of the item to add to the list box.  
  
 [in] <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
 The data associated with the item to add to the list box.  
  
### Return Value  
 The index of the last item in the list box.  
  
### Remarks  
 Do not use this method when the list box style is sorted.  
  
 If the item text is already in the list box, the new data is stored with the existing item. The search for the item is case sensitive.  
  
##  \<a name="cmfctoolbarcomboboxbutton__addsorteditem">\</a>  CMFCToolBarComboBoxButton::AddSortedItem  
 Adds an item to the list box in the order that is defined by the [Compare](#cmfctoolbarcomboboxbutton__compare) method.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
 The text of the item to add to the list box.  
  
 [in] <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 The data associated with the item to add to the list box.  
  
### Return Value  
 Index of the item that was added to the list box.  
  
### Remarks  
 Use this function to add items to the list box in a specific order.  
  
##  \<a name="cmfctoolbarcomboboxbutton__canbestretched">\</a>  CMFCToolBarComboBoxButton::CanBeStretched  
 Indicates whether the combo box button size can change.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 Returns <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfctoolbarcomboboxbutton__cmfctoolbarcomboboxbutton">\</a>  CMFCToolBarComboBoxButton::CMFCToolBarComboBoxButton  
 Constructs a [CMFCToolBarComboBoxButton](../vs140/cmfctoolbarcomboboxbutton-class.md) object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
 The command ID of the new button.  
  
 [in] <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
 The image index of the image associated with the new button.  
  
 [in] <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 The style of the new button.  
  
 [in] <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
 The width, in pixels, of the new button.  
  
### Remarks  
 The default width is 150 pixels.  
  
 For a list of toolbar button styles see [ToolBar Control Styles](../vs140/toolbar-control-styles.md)  
  
##  \<a name="cmfctoolbarcomboboxbutton__cleardata">\</a>  CMFCToolBarComboBoxButton::ClearData  
 Deletes user-defined data.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 By default this method does nothing. Override this method in a derived class if you want to delete any user-defined data.  
  
##  \<a name="cmfctoolbarcomboboxbutton__compare">\</a>  CMFCToolBarComboBoxButton::Compare  
 Compares two strings.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 The first string to compare.  
  
 [in] <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
 The second string to compare.  
  
### Return Value  
 A value that indicates the case-sensitive lexicographic relationship between the strings. The following table lists the possible values:  
  
|Value|Description|  
|-----------|-----------------|  
|\<0|The first string is less than the second.|  
|0|The first string equals the second.|  
|>0|The first string is greater than the second.|  
  
### Remarks  
 Override this method to change how items are sorted in the list box.  
  
 The comparison is case-sensitive.  
  
 This method is called only from the [AddSortedItem](#cmfctoolbarcomboboxbutton__addsorteditem) method.  
  
##  \<a name="cmfctoolbarcomboboxbutton__copyfrom">\</a>  CMFCToolBarComboBoxButton::CopyFrom  
 Copies the state of the specified <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> to the current object.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
 The source <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> object.  
  
##  \<a name="cmfctoolbarcomboboxbutton__createcombo">\</a>  CMFCToolBarComboBoxButton::CreateCombo  
 Creates a new combo box for the combo box button.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
 A pointer to the parent window of the button.  
  
 [in] <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
 Bounding rectangle of the combo box.  
  
### Return Value  
 A pointer to the new combo box if the method was successful; otherwise, <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfctoolbarcomboboxbutton__createedit">\</a>  CMFCToolBarComboBoxButton::CreateEdit  
 Creates a new edit box for the combo box button.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
 A pointer to the parent window of the button.  
  
 [in] <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
 Bounding rectangle of the new edit box.  
  
 [in] <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
 Control style of the new edit box.  
  
### Return Value  
 A pointer to the new edit box if the method was successful; otherwise, <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>.  
  
### Remarks  
 The framework calls this method when it creates a new edit box for a combo box button. Override this method to change how [CMFCToolBarComboBoxEdit](../vs140/cmfctoolbarcomboboxedit-class.md) is created.  
  
##  \<a name="cmfctoolbarcomboboxbutton__deleteitem">\</a>  CMFCToolBarComboBoxButton::DeleteItem  
 Deletes a specified item from the list box.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
 The zero-based index of the item to be deleted.  
  
 [in] <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
 The data associated with the item to be deleted.  
  
 [in] <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
 The text of the item to be deleted. If there are multiple items with the same text, the first item is deleted.  
  
### Return Value  
 <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> if the item was located and successfully deleted; otherwise, <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfctoolbarcomboboxbutton__duplicatedata">\</a>  CMFCToolBarComboBoxButton::DuplicateData  
 Duplicates user-defined data.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Remarks  
 By default this method does nothing. Override this method in a derived class if you want to copy any user-defined data.  
  
##  \<a name="cmfctoolbarcomboboxbutton__enablewindow">\</a>  CMFCToolBarComboBoxButton::EnableWindow  
 Enables or disables the edit and combo boxes.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> to enable the edit and combo boxes; <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> to disable the edit and combo boxes.  
  
### Remarks  
 When disabled, the controls cannot become active and cannot accept user input.  
  
##  \<a name="cmfctoolbarcomboboxbutton__exporttomenubutton">\</a>  CMFCToolBarComboBoxButton::ExportToMenuButton  
 Copies a string from the application string table to the specified menu using the combo box button command ID.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 [out] <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>  
 Reference to a menu button.  
  
### Return Value  
 Always <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfctoolbarcomboboxbutton__finditem">\</a>  CMFCToolBarComboBoxButton::FindItem  
 Returns the index of the first item in the list box that contains a specified string.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
 The text for which to search in the list box.  
  
### Return Value  
 The index of the item; or <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> if the item is not found.  
  
### Remarks  
  
##  \<a name="cmfctoolbarcomboboxbutton__getbycmd">\</a>  CMFCToolBarComboBoxButton::GetByCmd  
 Gets a pointer to the combo box button that has a specified command ID.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>  
 The command ID of a combo box button.  
  
 [in] <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> to search only focused buttons; <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> to search all buttons.  
  
### Return Value  
 A pointer to a combo box button; or <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> if the button is not found.  
  
### Remarks  
  
##  \<a name="cmfctoolbarcomboboxbutton__getcombobox">\</a>  CMFCToolBarComboBoxButton::GetComboBox  
 Returns a pointer to the combo box in the combo box button.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the [CComboBox](../vs140/ccombobox-class.md) object if the method was successful; otherwise <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfctoolbarcomboboxbutton__getcontextmenuid">\</a>  CMFCToolBarComboBoxButton::GetContextMenuID  
 Gets the shortcut menu resource ID for the combo box button.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
 The shortcut menu resource ID.  
  
##  \<a name="cmfctoolbarcomboboxbutton__getcount">\</a>  CMFCToolBarComboBoxButton::GetCount  
 Returns the number of items in the list box.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Return Value  
 The number of items in the list box.  
  
### Remarks  
  
##  \<a name="cmfctoolbarcomboboxbutton__getcountall">\</a>  CMFCToolBarComboBoxButton::GetCountAll  
 Gets the number of items in the list box of a combo box button that has a specified command ID.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>  
 The command ID of a combo box button.  
  
### Return Value  
 The number of items in the list box; otherwise, <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> if the combo box button is not found.  
  
### Remarks  
  
##  \<a name="cmfctoolbarcomboboxbutton__getcursel">\</a>  CMFCToolBarComboBoxButton::GetCurSel  
 Gets the index of the currently selected item in the list box.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Return Value  
 The index of the currently selected item in the list box; or <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> if no item is selected.  
  
### Remarks  
 The list box index is zero-based.  
  
##  \<a name="cmfctoolbarcomboboxbutton__getcurselall">\</a>  CMFCToolBarComboBoxButton::GetCurSelAll  
 Returns the index of the currently selected item in the list box of a combo box button that has a specified command ID.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
 The command ID of a combo box button.  
  
### Return Value  
 The index of the currently selected item in the list box; otherwise, <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> if no item is selected or a combo box button is not found.  
  
### Remarks  
 The list box index is zero-based.  
  
##  \<a name="cmfctoolbarcomboboxbutton__geteditctrl">\</a>  CMFCToolBarComboBoxButton::GetEditCtrl  
 Returns a pointer to the edit box in the combo box button.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the edit box if the method was successful; otherwise, <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfctoolbarcomboboxbutton__gethwnd">\</a>  CMFCToolBarComboBoxButton::GetHwnd  
 Returns the window handle for the combo box.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Return Value  
 The window handle, or <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> if the combo box is not associated with a window object.  
  
##  \<a name="cmfctoolbarcomboboxbutton__getitem">\</a>  CMFCToolBarComboBoxButton::GetItem  
 Returns the string associated with an item at a specified index in the list box.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>  
 Zero-based index of an item in the list box.  
  
### Return Value  
 A pointer to the string that is associated with the item; otherwise, <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> if the index parameter is invalid, or if the index parameter is -1 and there is no selected item in the combo box.  
  
### Remarks  
 An index parameter of -1 returns the string of the item that is currently selected.  
  
##  \<a name="cmfctoolbarcomboboxbutton__getitemall">\</a>  CMFCToolBarComboBoxButton::GetItemAll  
 Returns the string associated with an item at a specified index in the list box of a combo box button that has a specified command ID.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>  
 The command ID of a combo box button.  
  
 [in] <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>  
 The zero-based index of an item in the list box.  
  
### Return Value  
 A pointer to the item's string if the method was successful; otherwise, <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> if the index is invalid, a combo box button is not found, or if index is -1 and there is no selected item in the combo box.  
  
### Remarks  
 An index value of -1 returns the string of the item that is currently selected.  
  
##  \<a name="cmfctoolbarcomboboxbutton__getitemdata">\</a>  CMFCToolBarComboBoxButton::GetItemData  
 Returns the data associated with an item at a specific index in the list box.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>  
 The zero-based index of an item in the list box.  
  
### Return Value  
 The data associated with the item; or 0 if the item does not exist.  
  
### Remarks  
 An index parameter of -1 returns the data associated with the currently selected item.  
  
##  \<a name="cmfctoolbarcomboboxbutton__getitemdataall">\</a>  CMFCToolBarComboBoxButton::GetItemDataAll  
 Returns the data associated with an item at a specific index in the list box of a combo box button that has a specific command ID.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  
 The command ID of a combo box button.  
  
 [in] <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>  
 The zero-based index of an item in the list box.  
  
### Return Value  
 The data associated with the item if the method was successful; otherwise, 0 if the specified index is not valid, or CB_ERR if the combo box button is not found.  
  
### Remarks  
 An index parameter of -1 returns the data associated with the currently selected item.  
  
##  \<a name="cmfctoolbarcomboboxbutton__getitemdataptrall">\</a>  CMFCToolBarComboBoxButton::GetItemDataPtrAll  
 Returns the data associated with an item at a specific index in the list box of a combo box button that has a specific command ID. This data is returned as a pointer.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>  
 The command ID of the combo box button.  
  
 [in] <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>  
 The zero-based index of an item in the list box.  
  
### Return Value  
 A pointer associated with the item if the method was successful; otherwise, -1 if an error occurs, or <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> if the combo box button is not found.  
  
### Remarks  
  
##  \<a name="cmfctoolbarcomboboxbutton__getprompt">\</a>  CMFCToolBarComboBoxButton::GetPrompt  
 Returns the prompt string for the combo box button.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Return Value  
 The prompt string.  
  
### Remarks  
 This method is currently not implemented.  
  
##  \<a name="cmfctoolbarcomboboxbutton__gettext">\</a>  CMFCToolBarComboBoxButton::GetText  
 Gets the text in the edit box.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Return Value  
 The text in the edit box.  
  
### Remarks  
  
##  \<a name="cmfctoolbarcomboboxbutton__gettextall">\</a>  CMFCToolBarComboBoxButton::GetTextAll  
 Gets the text in the edit box of a combo box button that has a specified command ID.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>  
 The command ID of a specific combo box button.  
  
### Return Value  
 The text in the edit box if the method was successful; otherwise, <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfctoolbarcomboboxbutton__hasfocus">\</a>  CMFCToolBarComboBoxButton::HasFocus  
 Indicates whether the combo box currently has the focus.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> if the combo box currently has the focus; otherwise, <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method also returns <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> if any child window of the combo box currently has the focus.  
  
##  \<a name="cmfctoolbarcomboboxbutton__iscentervert">\</a>  CMFCToolBarComboBoxButton::IsCenterVert  
 Returns the vertical position of combo box buttons in the application.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> if the buttons are centered; <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> if the buttons are aligned at the top.  
  
### Remarks  
  
##  \<a name="cmfctoolbarcomboboxbutton__isflatmode">\</a>  CMFCToolBarComboBoxButton::IsFlatMode  
 Returns the flat style appearance of combo box buttons in the application.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> if the buttons have a flat style; otherwise, <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>.  
  
### Remarks  
 The default flat style for combo box buttons is <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>  
  
##  \<a name="cmfctoolbarcomboboxbutton__isownerof">\</a>  CMFCToolBarComboBoxButton::IsOwnerOf  
 Indicates whether the specified handle is associated with the combo box button, or one of its children.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>  
 A window handle.  
  
### Return Value  
 <CodeContentPlaceHolder>137\</CodeContentPlaceHolder> if the handle is assocated with the combo box button, or one of its children; otherwise, <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfctoolbarcomboboxbutton__isribbonbutton">\</a>  CMFCToolBarComboBoxButton::IsRibbonButton  
 Indicates whether the combo box button resides on a ribbon panel.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Return Value  
 Always <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>.  
  
### Remarks  
 By default, this method always returns <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>, which means the combo box button is never displayed on a ribbon panel.  
  
##  \<a name="cmfctoolbarcomboboxbutton__iswindowvisible">\</a>  CMFCToolBarComboBoxButton::IsWindowVisible  
 Returns the visibility state of the combo box button.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Return Value  
 The visibility state of the combo box button.  
  
##  \<a name="cmfctoolbarcomboboxbutton__notifycommand">\</a>  CMFCToolBarComboBoxButton::NotifyCommand  
 Indicates whether the combo box button processes the  message.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>  
 The notification message that is associated with the command.  
  
### Return Value  
 Whether the combo box button processes the  message.  
  
##  \<a name="cmfctoolbarcomboboxbutton__onaddtocustomizepage">\</a>  CMFCToolBarComboBoxButton::OnAddToCustomizePage  
 Called by the framework when the button is added to the **Customize** dialog box.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
##  \<a name="cmfctoolbarcomboboxbutton__oncalculatesize">\</a>  CMFCToolBarComboBoxButton::OnCalculateSize  
 Called by the framework to calculate the size of the button.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>  
 The device context that displays the combo box button.  
  
 [in] <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>  
 The default size of the combo box button.  
  
 [in] <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>  
 The dock state of the parent toolbar. <CodeContentPlaceHolder>145\</CodeContentPlaceHolder> when the toolbar is docked horizontally and <CodeContentPlaceHolder>146\</CodeContentPlaceHolder> when the toolbar is docked vertically.  
  
### Return Value  
 A <CodeContentPlaceHolder>147\</CodeContentPlaceHolder> structure that contains the dimensions of the combo box button, in pixels.  
  
##  \<a name="cmfctoolbarcomboboxbutton__onchangeparentwnd">\</a>  CMFCToolBarComboBoxButton::OnChangeParentWnd  
 Called by the framework when the combo box button is inserted into a new toolbar.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>  
 Pointer to the new parent toolbar.  
  
##  \<a name="cmfctoolbarcomboboxbutton__onclick">\</a>  CMFCToolBarComboBoxButton::OnClick  
 Called by the framework when the user clicks the combo box button.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>  
 Pointer to the parent window of the combo box button.  
  
 [in] <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>  
 Reserved for use in a derived class.  
  
### Return Value  
 <CodeContentPlaceHolder>151\</CodeContentPlaceHolder> if the method handles the event; otherwise, <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfctoolbarcomboboxbutton__onctlcolor">\</a>  CMFCToolBarComboBoxButton::OnCtlColor  
 Called by the framework when the user changes the parent toolbar color to set the combo box button color.  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>153\</CodeContentPlaceHolder>  
 The device context that displays the combo box button.  
  
 [in] <CodeContentPlaceHolder>154\</CodeContentPlaceHolder>  
 Unused.  
  
### Return Value  
 Handle to the brush that the framework uses to paint the background of the combo box button.  
  
### Remarks  
 This method also sets the combo box button text color.  
  
##  \<a name="cmfctoolbarcomboboxbutton__ondraw">\</a>  CMFCToolBarComboBoxButton::OnDraw  
 Called by the framework to draw the combo box button by using the specified styles and options.  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>155\</CodeContentPlaceHolder>  
 The device context that displays the button.  
  
 [in] <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>  
 The bounding rectangle of the button.  
  
 [in] <CodeContentPlaceHolder>157\</CodeContentPlaceHolder>  
 The collection of images that is associated with the button.  
  
 [in] <CodeContentPlaceHolder>158\</CodeContentPlaceHolder>  
 The dock state of the parent toolbar. <CodeContentPlaceHolder>159\</CodeContentPlaceHolder> when the toolbar is docked horizontally and <CodeContentPlaceHolder>160\</CodeContentPlaceHolder> when the toolbar is docked vertically.  
  
 [in] <CodeContentPlaceHolder>161\</CodeContentPlaceHolder>  
 Whether the application is in customization mode.  
  
 [in] <CodeContentPlaceHolder>162\</CodeContentPlaceHolder>  
 Whether to draw the combo box button highlighted.  
  
 [in] <CodeContentPlaceHolder>163\</CodeContentPlaceHolder>  
 Whether to draw the combo box button with a border.  
  
 [in] <CodeContentPlaceHolder>164\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>165\</CodeContentPlaceHolder> to draw shaded disabled buttons; <CodeContentPlaceHolder>166\</CodeContentPlaceHolder> to use the disabled images collection.  
  
##  \<a name="cmfctoolbarcomboboxbutton__ondrawoncustomizelist">\</a>  CMFCToolBarComboBoxButton::OnDrawOnCustomizeList  
 Called by the framework to draw the combo box button in the **Commands** pane of the **Customize** dialog box.  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>167\</CodeContentPlaceHolder>  
 The device context that displays the combo box button.  
  
 [in] <CodeContentPlaceHolder>168\</CodeContentPlaceHolder>  
 The bounding rectangle of the combo box button.  
  
 [in] <CodeContentPlaceHolder>169\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>170\</CodeContentPlaceHolder> if the combo box button is selected; otherwise, <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>.  
  
### Return Value  
 The width, in pixels, of the combo box button.  
  
##  \<a name="cmfctoolbarcomboboxbutton__onglobalfontschanged">\</a>  CMFCToolBarComboBoxButton::OnGlobalFontsChanged  
 Called by the framework to set the combo box button font when the application font changes.  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
##  \<a name="cmfctoolbarcomboboxbutton__onmove">\</a>  CMFCToolBarComboBoxButton::OnMove  
 Called by the framework to change the location of the combo box button when the parent toolbar moves.  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
##  \<a name="cmfctoolbarcomboboxbutton__onshow">\</a>  CMFCToolBarComboBoxButton::OnShow  
 Called by the framework when the combo box button is hidden or displayed.  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>172\</CodeContentPlaceHolder>  
 Whether to hide or display the combo box button.  
  
##  \<a name="cmfctoolbarcomboboxbutton__onsize">\</a>  CMFCToolBarComboBoxButton::OnSize  
 Called by the framework to change the size of the combo box button when the parent toolbar changes size.  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>173\</CodeContentPlaceHolder>  
 The new width of the combo box button.  
  
##  \<a name="cmfctoolbarcomboboxbutton__onupdatetooltip">\</a>  CMFCToolBarComboBoxButton::OnUpdateToolTip  
 Called by the framework when the user changes the tool tip for the combo box button.  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>  
 Pointer to the parent window for the combo box button.  
  
 [in] <CodeContentPlaceHolder>175\</CodeContentPlaceHolder>  
 ID of the combo box button.  
  
 [in] <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>  
 The tool tip to associate with the combo box button.  
  
 [in] <CodeContentPlaceHolder>177\</CodeContentPlaceHolder>  
 The tool tip text.  
  
### Return Value  
 <CodeContentPlaceHolder>178\</CodeContentPlaceHolder> if the method handles the event; otherwise, <CodeContentPlaceHolder>179\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfctoolbarcomboboxbutton__removeallitems">\</a>  CMFCToolBarComboBoxButton::RemoveAllItems  
 Deletes all items from the list and edit boxes.  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
### Remarks  
 Removes all items from the list box and edit control of a combo box.  
  
##  \<a name="cmfctoolbarcomboboxbutton__selectitem">\</a>  CMFCToolBarComboBoxButton::SelectItem  
 Selects an item in the list box.  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>180\</CodeContentPlaceHolder>  
 The zero-based index of an item in the list box.  
  
 [in] <CodeContentPlaceHolder>181\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>182\</CodeContentPlaceHolder> to notify the combo box button of the selection; otherwise <CodeContentPlaceHolder>183\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>184\</CodeContentPlaceHolder>  
 The data associated with an item in the list box.  
  
 [in] <CodeContentPlaceHolder>185\</CodeContentPlaceHolder>  
 The text of an item in the list box.  
  
### Return Value  
 <CodeContentPlaceHolder>186\</CodeContentPlaceHolder> if the method was successful; otherwise <CodeContentPlaceHolder>187\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfctoolbarcomboboxbutton__selectitemall">\</a>  CMFCToolBarComboBoxButton::SelectItemAll  
 Selects an item in the list box of a combo box button that has a specified command ID.  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>188\</CodeContentPlaceHolder>  
 The command ID of the combo box button that contains the list box.  
  
 [in] <CodeContentPlaceHolder>189\</CodeContentPlaceHolder>  
 The zero-based index of the item in the list box. A value of -1 removes any current selection in the list box and clears the edit box.  
  
 [in] <CodeContentPlaceHolder>190\</CodeContentPlaceHolder>  
 The data of an item in the list box.  
  
 [in] <CodeContentPlaceHolder>191\</CodeContentPlaceHolder>  
 The text of an item in the list box.  
  
### Return Value  
 <CodeContentPlaceHolder>192\</CodeContentPlaceHolder> if the method was successful; otherwise <CodeContentPlaceHolder>193\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfctoolbarcomboboxbutton__serialize">\</a>  CMFCToolBarComboBoxButton::Serialize  
 Reads this object from an archive or writes it to an archive.  
  
<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
### Parameters  
 [in, out] <CodeContentPlaceHolder>194\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>195\</CodeContentPlaceHolder> object to serialize.  
  
### Remarks  
 Settings in the <CodeContentPlaceHolder>196\</CodeContentPlaceHolder> object determine whether this method reads or writes to the archive.  
  
##  \<a name="cmfctoolbarcomboboxbutton__setaccdata">\</a>  CMFCToolBarComboBoxButton::SetACCData  
 Populates the specified <CodeContentPlaceHolder>197\</CodeContentPlaceHolder> object by using accessibility data from the combo box button.  
  
<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>198\</CodeContentPlaceHolder>  
 The parent window of the combo box button.  
  
 [out] <CodeContentPlaceHolder>199\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>200\</CodeContentPlaceHolder> object that receives the accessibility data from the combo box button.  
  
### Return Value  
 <CodeContentPlaceHolder>201\</CodeContentPlaceHolder> if the method was successful; otherwise <CodeContentPlaceHolder>202\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfctoolbarcomboboxbutton__setcentervert">\</a>  CMFCToolBarComboBoxButton::SetCenterVert  
 Sets the vertical position of combo box buttons in the application.  
  
<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>203\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>204\</CodeContentPlaceHolder> to center the combo box button in the toolbar; <CodeContentPlaceHolder>205\</CodeContentPlaceHolder> to align the combo box button to the top of the toolbar.  
  
### Remarks  
 By default, combo box buttons are aligned to the top.  
  
##  \<a name="cmfctoolbarcomboboxbutton__setcontextmenuid">\</a>  CMFCToolBarComboBoxButton::SetContextMenuID  
 Sets the shortcut menu resource ID for the combo box button.  
  
<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>206\</CodeContentPlaceHolder>  
 The shortcut menu resource ID.  
  
##  \<a name="cmfctoolbarcomboboxbutton__setdropdownheight">\</a>  CMFCToolBarComboBoxButton::SetDropDownHeight  
 Sets the height of the list box when it is dropped down.  
  
<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>207\</CodeContentPlaceHolder>  
 The height, in pixels, of the list box.  
  
### Remarks  
 The default height is 150 pixels.  
  
##  \<a name="cmfctoolbarcomboboxbutton__setflatmode">\</a>  CMFCToolBarComboBoxButton::SetFlatMode  
 Sets the flat style appearance of combo box buttons in the application.  
  
<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>208\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>209\</CodeContentPlaceHolder> for a flat style appearance; otherwise <CodeContentPlaceHolder>210\</CodeContentPlaceHolder>.  
  
### Remarks  
 The default flat style for combo box buttons is <CodeContentPlaceHolder>211\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfctoolbarcomboboxbutton__setstyle">\</a>  CMFCToolBarComboBoxButton::SetStyle  
 Sets the specified style for the combo box button and redraws the control if it is not disabled.  
  
<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>212\</CodeContentPlaceHolder>  
 A bitwise combination (OR) of toolbar styles.  
  
### Remarks  
 For a list of toolbar button styles see [ToolBar Control Styles](../vs140/toolbar-control-styles.md)  
  
##  \<a name="cmfctoolbarcomboboxbutton__settext">\</a>  CMFCToolBarComboBoxButton::SetText  
 Sets the text in the edit box of the combo box button.  
  
<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>213\</CodeContentPlaceHolder>  
 Pointer to a string that that contains the text for the edit box.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMFCToolbarButton](../vs140/cmfctoolbarbutton-class.md)   
 [CComboBox](../vs140/ccombobox-class.md)   
 [CMFCToolBar::ReplaceButton](../vs140/cmfctoolbar-class.md#cmfctoolbar__replacebutton)   
 [How to Put Controls on Toolbars](../vs140/walkthrough--putting-controls-on-toolbars.md)