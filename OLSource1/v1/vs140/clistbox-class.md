---
title: "CListBox Class"
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
  - "CListBox"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CListBox class"
  - "list boxes"
ms.assetid: 7ba3c699-c286-4cd9-9066-532c41ec05d1
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListBox Class
Provides the functionality of a Windows list box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CListBox::CListBox](#clistbox__clistbox)|Constructs a <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CListBox::AddString](#clistbox__addstring)|Adds a string to a list box.|  
|[CListBox::CharToItem](#clistbox__chartoitem)|Override to provide custom <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> handling for owner-draw list boxes which don't have strings.|  
|[CListBox::CompareItem](#clistbox__compareitem)|Called by the framework to determine the position of a new item in a sorted owner-draw list box.|  
|[CListBox::Create](#clistbox__create)|Creates the Windows list box and attaches it to the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> object.|  
|[CListBox::DeleteItem](#clistbox__deleteitem)|Called by the framework when the user deletes an item from an owner-draw list box.|  
|[CListBox::DeleteString](#clistbox__deletestring)|Deletes a string from a list box.|  
|[CListBox::Dir](#clistbox__dir)|Adds filenames, drives, or both from the current directory to a list box.|  
|[CListBox::DrawItem](#clistbox__drawitem)|Called by the framework when a visual aspect of an owner-draw list box changes.|  
|[CListBox::FindString](#clistbox__findstring)|Searches for a string in a list box.|  
|[CListBox::FindStringExact](#clistbox__findstringexact)|Finds the first list-box string that matches a specified string.|  
|[CListBox::GetAnchorIndex](#clistbox__getanchorindex)|Retrieves the zero-based index of the current anchor item in a list box.|  
|[CListBox::GetCaretIndex](#clistbox__getcaretindex)|Determines the index of the item that has the focus rectangle in a multiple-selection list box.|  
|[CListBox::GetCount](#clistbox__getcount)|Returns the number of strings in a list box.|  
|[CListBox::GetCurSel](#clistbox__getcursel)|Returns the zero-based index of the currently selected string in a list box.|  
|[CListBox::GetHorizontalExtent](#clistbox__gethorizontalextent)|Returns the width in pixels that a list box can be scrolled horizontally.|  
|[CListBox::GetItemData](#clistbox__getitemdata)|Returns the 32-bit value associated with the list-box item.|  
|[CListBox::GetItemDataPtr](#clistbox__getitemdataptr)|Returns a pointer to a list-box item.|  
|[CListBox::GetItemHeight](#clistbox__getitemheight)|Determines the height of items in a list box.|  
|[CListBox::GetItemRect](#clistbox__getitemrect)|Returns the bounding rectangle of the list-box item as it is currently displayed.|  
|[CListBox::GetListBoxInfo](#clistbox__getlistboxinfo)|Retrieves the number of items per column.|  
|[CListBox::GetLocale](#clistbox__getlocale)|Retrieves the locale identifier for a list box.|  
|[CListBox::GetSel](#clistbox__getsel)|Returns the selection state of a list-box item.|  
|[CListBox::GetSelCount](#clistbox__getselcount)|Returns the number of strings currently selected in a multiple-selection list box.|  
|[CListBox::GetSelItems](#clistbox__getselitems)|Returns the indices of the strings currently selected in a list box.|  
|[CListBox::GetText](#clistbox__gettext)|Copies a list-box item into a buffer.|  
|[CListBox::GetTextLen](#clistbox__gettextlen)|Returns the length in bytes of a list-box item.|  
|[CListBox::GetTopIndex](#clistbox__gettopindex)|Returns the index of the first visible string in a list box.|  
|[CListBox::InitStorage](#clistbox__initstorage)|Preallocates blocks of memory for list box items and strings.|  
|[CListBox::InsertString](#clistbox__insertstring)|Inserts a string at a specific location in a list box.|  
|[CListBox::ItemFromPoint](#clistbox__itemfrompoint)|Returns the index of the list-box item nearest a point.|  
|[CListBox::MeasureItem](#clistbox__measureitem)|Called by the framework when an owner-draw list box is created to determine list-box dimensions.|  
|[CListBox::ResetContent](#clistbox__resetcontent)|Clears all the entries from a list box.|  
|[CListBox::SelectString](#clistbox__selectstring)|Searches for and selects a string in a single-selection list box.|  
|[CListBox::SelItemRange](#clistbox__selitemrange)|Selects or deselects a range of strings in a multiple-selection list box.|  
|[CListBox::SetAnchorIndex](#clistbox__setanchorindex)|Sets the anchor in a multiple-selection list box to begin an extended selection.|  
|[CListBox::SetCaretIndex](#clistbox__setcaretindex)|Sets the focus rectangle to the item at the specified index in a multiple-selection list box.|  
|[CListBox::SetColumnWidth](#clistbox__setcolumnwidth)|Sets the column width of a multicolumn list box.|  
|[CListBox::SetCurSel](#clistbox__setcursel)|Selects a list-box string.|  
|[CListBox::SetHorizontalExtent](#clistbox__sethorizontalextent)|Sets the width in pixels that a list box can be scrolled horizontally.|  
|[CListBox::SetItemData](#clistbox__setitemdata)|Sets the 32-bit value associated with the list-box item.|  
|[CListBox::SetItemDataPtr](#clistbox__setitemdataptr)|Sets a pointer to the list-box item.|  
|[CListBox::SetItemHeight](#clistbox__setitemheight)|Sets the height of items in a list box.|  
|[CListBox::SetLocale](#clistbox__setlocale)|Sets the locale identifier for a list box.|  
|[CListBox::SetSel](#clistbox__setsel)|Selects or deselects a list-box item in a multiple-selection list box.|  
|[CListBox::SetTabStops](#clistbox__settabstops)|Sets the tab-stop positions in a list box.|  
|[CListBox::SetTopIndex](#clistbox__settopindex)|Sets the zero-based index of the first visible string in a list box.|  
|[CListBox::VKeyToItem](#clistbox__vkeytoitem)|Override to provide custom <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> handling for list boxes with the **LBS_WANTKEYBOARDINPUT** style set.|  
  
## Remarks  
 A list box displays a list of items, such as filenames, that the user can view and select.  
  
 In a single-selection list box, the user can select only one item. In a multiple-selection list box, a range of items can be selected. When the user selects an item, it is highlighted and the list box sends a notification message to the parent window.  
  
 You can create a list box either from a dialog template or directly in your code. To create it directly, construct the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> object, then call the [Create](#clistbox__create) member function to create the Windows list-box control and attach it to the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> object. To use a list box in a dialog template, declare a list-box variable in your dialog box class, then use <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> in your dialog box class's <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> function to connect the member variable to the control. (this is done for you automatically when you add a control variable to your dialog box class.)  
  
 Construction can be a one-step process in a class derived from <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>. Write a constructor for the derived class and call **Create** from within the constructor.  
  
 If you want to handle Windows notification messages sent by a list box to its parent (usually a class derived from [CDialog](../vs140/cdialog-class.md)), add a message-map entry and message-handler member function to the parent class for each message.  
  
 Each message-map entry takes the following form:  
  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
  
 where <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> specifies the child window ID of the list-box control sending the notification and <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> is the name of the parent member function you have written to handle the notification.  
  
 The parent's function prototype is as follows:  
  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
  
 Following is a list of potential message-map entries and a description of the cases in which they would be sent to the parent:  
  
-   **ON_LBN_DBLCLK** The user double-clicks a string in a list box. Only a list box that has the [LBS_NOTIFY](../vs140/list-box-styles.md) style will send this notification message.  
  
-   **ON_LBN_ERRSPACE** The list box cannot allocate enough memory to meet the request.  
  
-   **ON_LBN_KILLFOCUS** The list box is losing the input focus.  
  
-   **ON_LBN_SELCANCEL** The current list-box selection is canceled. This message is only sent when a list box has the **LBS_NOTIFY** style.  
  
-   **ON_LBN_SELCHANGE** The selection in the list box has changed. This notification is not sent if the selection is changed by the [CListBox::SetCurSel](#clistbox__setcursel) member function. This notification applies only to a list box that has the **LBS_NOTIFY** style. The **LBN_SELCHANGE** notification message is sent for a multiple-selection list box whenever the user presses an arrow key, even if the selection does not change.  
  
-   **ON_LBN_SETFOCUS** The list box is receiving the input focus.  
  
-   **ON_WM_CHARTOITEM** An owner-draw list box that has no strings receives a <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> message.  
  
-   **ON_WM_VKEYTOITEM** A list box with the **LBS_WANTKEYBOARDINPUT** style receives a <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> message.  
  
 If you create a <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> object within a dialog box (through a dialog resource), the <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> object is automatically destroyed when the user closes the dialog box.  
  
 If you create a <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> object within a window, you may need to destroy the <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> object. If you create the <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> object on the stack, it is destroyed automatically. If you create the <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> object on the heap by using the **new** function, you must call **delete** on the object to destroy it when the user closes the parent window.  
  
 If you allocate any memory in the <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> object, override the <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> destructor to dispose of the allocation.  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxwin.h  
  
##  \<a name="clistbox__addstring">\</a>  CListBox::AddString  
 Adds a string to a list box.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
 Points to the null-terminated string that is to be added.  
  
### Return Value  
 The zero-based index to the string in the list box. The return value is **LB_ERR** if an error occurs; the return value is **LB_ERRSPACE** if insufficient space is available to store the new string.  
  
### Remarks  
 If the list box was not created with the [LBS_SORT](../vs140/list-box-styles.md) style, the string is added to the end of the list. Otherwise, the string is inserted into the list, and the list is sorted. If the list box was created with the **LBS_SORT** style but not the [LBS_HASSTRINGS](../vs140/list-box-styles.md) style, the framework sorts the list by one or more calls to the <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> member function.  
  
 Use [InsertString](#clistbox__insertstring) to insert a string into a specific location within the list box.  
  
### Example  
 [!code[NVC_MFC_CListBox#3](../vs140/codesnippet/CPP/clistbox-class_1.cpp)]  
  
##  \<a name="clistbox__chartoitem">\</a>  CListBox::CharToItem  
 Called by the framework when the list box's parent window receives a <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> message from the list box.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 The ANSI code of the character the user typed.  
  
 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
 The current position of the list-box caret.  
  
### Return Value  
 Returns – 1 or – 2 for no further action or a nonnegative number to specify an index of a list-box item on which to perform the default action for the keystroke. The default implementation returns – 1.  
  
### Remarks  
 The <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> message is sent by the list box when it receives a <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> message, but only if the list box meets all of these criteria:  
  
-   Is an owner-draw list box.  
  
-   Does not have the [LBS_HASSTRINGS](../vs140/list-box-styles.md) style set.  
  
-   Has at least one item.  
  
 You should never call this function yourself. Override this function to provide your own custom handling of keyboard messages.  
  
 In your override, you must return a value to tell the framework what action you performed. A return value of – 1 or – 2 indicates that you handled all aspects of selecting the item and requires no further action by the list box. Before returning – 1 or – 2, you could set the selection or move the caret or both. To set the selection, use [SetCurSel](#clistbox__setcursel) or [SetSel](#clistbox__setsel). To move the caret, use [SetCaretIndex](#clistbox__setcaretindex).  
  
 A return value of 0 or greater specifies the index of an item in the list box and indicates that the list box should perform the default action for the keystroke on the given item.  
  
### Example  
 [!code[NVC_MFC_CListBox#4](../vs140/codesnippet/CPP/clistbox-class_2.cpp)]  
  
##  \<a name="clistbox__clistbox">\</a>  CListBox::CListBox  
 Constructs a <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 You construct a <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> object in two steps. First, call the constructor **ClistBox** and then call **Create**, which initializes the Windows list box and attaches it to the <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>.  
  
### Example  
 [!code[NVC_MFC_CListBox#1](../vs140/codesnippet/CPP/clistbox-class_3.cpp)]  
  
##  \<a name="clistbox__compareitem">\</a>  CListBox::CompareItem  
 Called by the framework to determine the relative position of a new item in a sorted owner-draw list box.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
 A long pointer to a <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> structure.  
  
### Return Value  
 Indicates the relative position of the two items described in the [COMPAREITEMSTRUCT](../vs140/compareitemstruct-structure.md) structure. It may be any of the following values:  
  
|Value|Meaning|  
|-----------|-------------|  
|–1|Item 1 sorts before item 2.|  
|0|Item 1 and item 2 sort the same.|  
|1|Item 1 sorts after item 2.|  
  
 See [CWnd::OnCompareItem](../vs140/cwnd-class.md#cwnd__oncompareitem) for a description of the <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> structure.  
  
### Remarks  
 By default, this member function does nothing. If you create an owner-draw list box with the **LBS_SORT** style, you must override this member function to assist the framework in sorting new items added to the list box.  
  
### Example  
 [!code[NVC_MFC_CListBox#5](../vs140/codesnippet/CPP/clistbox-class_4.cpp)]  
  
##  \<a name="clistbox__create">\</a>  CListBox::Create  
 Creates the Windows list box and attaches it to the <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
 Specifies the style of the list box. Apply any combination of [list-box styles](../vs140/list-box-styles.md) to the box.  
  
 <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
 Specifies the list-box size and position. Can be either a <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> object or a <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> structure.  
  
 <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
 Specifies the list box's parent window (usually a <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> object). It must not be **NULL**.  
  
 <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
 Specifies the list box's control ID.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 You construct a <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> object in two steps. First, call the constructor and then call **Create**, which initializes the Windows list box and attaches it to the <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> object.  
  
 When **Create** executes, Windows sends the [WM_NCCREATE](../vs140/cwnd-class.md#cwnd__onnccreate), [WM_CREATE](../vs140/cwnd-class.md#cwnd__oncreate), [WM_NCCALCSIZE](../vs140/cwnd-class.md#cwnd__onnccalcsize), and [WM_GETMINMAXINFO](../vs140/cwnd-class.md#cwnd__ongetminmaxinfo) messages to the list-box control.  
  
 These messages are handled by default by the [OnNcCreate](../vs140/cwnd-class.md#cwnd__onnccreate), [OnCreate](../vs140/cwnd-class.md#cwnd__oncreate), [OnNcCalcSize](../vs140/cwnd-class.md#cwnd__onnccalcsize), and [OnGetMinMaxInfo](../vs140/cwnd-class.md#cwnd__ongetminmaxinfo) member functions in the <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> base class. To extend the default message handling, derive a class from <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>, add a message map to the new class, and override the preceding message-handler member functions. Override <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>, for example, to perform needed initialization for a new class.  
  
 Apply the following [window styles](../vs140/window-styles.md) to a list-box control.  
  
-   **WS_CHILD** Always  
  
-   **WS_VISIBLE** Usually  
  
-   **WS_DISABLED** Rarely  
  
-   **WS_VSCROLL** To add a vertical scroll bar  
  
-   **WS_HSCROLL** To add a horizontal scroll bar  
  
-   **WS_GROUP** To group controls  
  
-   **WS_TABSTOP** To allow tabbing to this control  
  
### Example  
 [!code[NVC_MFC_CListBox#2](../vs140/codesnippet/CPP/clistbox-class_5.cpp)]  
  
##  \<a name="clistbox__deleteitem">\</a>  CListBox::DeleteItem  
 Called by the framework when the user deletes an item from an owner-draw <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> object or destroys the list box.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
 A long pointer to a Windows [DELETEITEMSTRUCT](../vs140/deleteitemstruct-structure.md) structure that contains information about the deleted item.  
  
### Remarks  
 The default implementation of this function does nothing. Override this function to redraw an owner-draw list box as needed.  
  
 See [CWnd::OnDeleteItem](../vs140/cwnd-class.md#cwnd__ondeleteitem) for a description of the <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> structure.  
  
### Example  
 [!code[NVC_MFC_CListBox#6](../vs140/codesnippet/CPP/clistbox-class_6.cpp)]  
  
##  \<a name="clistbox__deletestring">\</a>  CListBox::DeleteString  
 Deletes the item in position <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> from the list box.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  
 Specifies the zero-based index of the string to be deleted.  
  
### Return Value  
 A count of the strings remaining in the list. The return value is **LB_ERR** if <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> specifies an index greater than the number of items in the list.  
  
### Remarks  
 All items following <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> now move down one position. For example, if a list box contains two items, deleting the first item will cause the remaining item to now be in the first position. <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>=0 for the item in the first position.  
  
### Example  
 [!code[NVC_MFC_CListBox#7](../vs140/codesnippet/CPP/clistbox-class_7.cpp)]  
  
##  \<a name="clistbox__dir">\</a>  CListBox::Dir  
 Adds a list of filenames, drives, or both to a list box.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>  
 Can be any combination of the <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> values described in **CFile::GetStatu**[s](../vs140/cfile-class.md#cfile__getstatus), or any combination of the following values:  
  
|Value|Meaning|  
|-----------|-------------|  
|0x0000|File can be read from or written to.|  
|0x0001|File can be read from but not written to.|  
|0x0002|File is hidden and does not appear in a directory listing.|  
|0x0004|File is a system file.|  
|0x0010|The name specified by <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> specifies a directory.|  
|0x0020|File has been archived.|  
|0x4000|Include all drives that match the name specified by <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>.|  
|0x8000|Exclusive flag. If the exclusive flag is set, only files of the specified type are listed. Otherwise, files of the specified type are listed in addition to "normal" files.|  
  
 <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
 Points to a file-specification string. The string can contain wildcards (for example, *.\*).  
  
### Return Value  
 The zero-based index of the last filename added to the list. The return value is **LB_ERR** if an error occurs; the return value is **LB_ERRSPACE** if insufficient space is available to store the new strings.  
  
### Example  
 [!code[NVC_MFC_CListBox#8](../vs140/codesnippet/CPP/clistbox-class_8.cpp)]  
  
##  \<a name="clistbox__drawitem">\</a>  CListBox::DrawItem  
 Called by the framework when a visual aspect of an owner-draw list box changes.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>  
 A long pointer to a [DRAWITEMSTRUCT](../vs140/drawitemstruct-structure.md) structure that contains information about the type of drawing required.  
  
### Remarks  
 The **itemAction** and **itemState** members of the <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> structure define the drawing action that is to be performed.  
  
 By default, this member function does nothing. Override this member function to implement drawing for an owner-draw <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> object. The application should restore all graphics device interface (GDI) objects selected for the display context supplied in <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> before this member function terminates.  
  
 See [CWnd::OnDrawItem](../vs140/cwnd-class.md#cwnd__ondrawitem) for a description of the <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> structure.  
  
### Example  
 [!code[NVC_MFC_CListBox#9](../vs140/codesnippet/CPP/clistbox-class_9.cpp)]  
  
##  \<a name="clistbox__findstring">\</a>  CListBox::FindString  
 Finds the first string in a list box that contains the specified prefix without changing the list-box selection.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>  
 Contains the zero-based index of the item before the first item to be searched. When the search reaches the bottom of the list box, it continues from the top of the list box back to the item specified by <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> is –1, the entire list box is searched from the beginning.  
  
 <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>  
 Points to the null-terminated string that contains the prefix to search for. The search is case independent, so this string may contain any combination of uppercase and lowercase letters.  
  
### Return Value  
 The zero-based index of the matching item, or **LB_ERR** if the search was unsuccessful.  
  
### Remarks  
 Use the [SelectString](#clistbox__selectstring) member function to both find and select a string.  
  
### Example  
 [!code[NVC_MFC_CListBox#10](../vs140/codesnippet/CPP/clistbox-class_10.cpp)]  
  
##  \<a name="clistbox__findstringexact">\</a>  CListBox::FindStringExact  
 Finds the first list-box string that matches the string specified in <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>  
 Specifies the zero-based index of the item before the first item to be searched. When the search reaches the bottom of the list box, it continues from the top of the list box back to the item specified by <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> is –1, the entire list box is searched from the beginning.  
  
 <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>  
 Points to the null-terminated string to search for. This string can contain a complete filename, including the extension. The search is not case sensitive, so the string can contain any combination of uppercase and lowercase letters.  
  
### Return Value  
 The index of the matching item, or **LB_ERR** if the search was unsuccessful.  
  
### Remarks  
 If the list box was created with an owner-draw style but without the [LBS_HASSTRINGS](../vs140/list-box-styles.md) style, the <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> member function attempts to match the doubleword value against the value of <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>.  
  
### Example  
 [!code[NVC_MFC_CListBox#11](../vs140/codesnippet/CPP/clistbox-class_11.cpp)]  
  
##  \<a name="clistbox__getanchorindex">\</a>  CListBox::GetAnchorIndex  
 Retrieves the zero-based index of the current anchor item in the list box.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 The index of the current anchor item, if successful; otherwise **LB_ERR**.  
  
### Remarks  
 In a multiple-selection list box, the anchor item is the first or last item in a block of contiguous selected items.  
  
### Example  
  See the example for [CListBox::SetAnchorIndex](#clistbox__setanchorindex).  
  
##  \<a name="clistbox__getcaretindex">\</a>  CListBox::GetCaretIndex  
 Determines the index of the item that has the focus rectangle in a multiple-selection list box.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 The zero-based index of the item that has the focus rectangle in a list box. If the list box is a single-selection list box, the return value is the index of the item that is selected, if any.  
  
### Remarks  
 The item may or may not be selected.  
  
### Example  
  See the example for [CListBox::SetCaretIndex](#clistbox__setcaretindex).  
  
##  \<a name="clistbox__getcount">\</a>  CListBox::GetCount  
 Retrieves the number of items in a list box.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 The number of items in the list box, or **LB_ERR** if an error occurs.  
  
### Remarks  
 The returned count is one greater than the index value of the last item (the index is zero-based).  
  
### Example  
 [!code[NVC_MFC_CListBox#12](../vs140/codesnippet/CPP/clistbox-class_12.cpp)]  
  
##  \<a name="clistbox__getcursel">\</a>  CListBox::GetCurSel  
 Retrieves the zero-based index of the currently selected item, if any, in a single-selection list box.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
 The zero-based index of the currently selected item if it is a single-selection list box. It is <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> if no item is currently selected.  
  
 In a multiple-selection list box, the index of the item that has the focus.  
  
### Remarks  
 Do not call <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> for a multiple-selection list box. Use [CListBox::GetSelItems](#clistbox__getselitems) instead.  
  
### Example  
 [!code[NVC_MFC_CListBox#13](../vs140/codesnippet/CPP/clistbox-class_13.cpp)]  
  
##  \<a name="clistbox__gethorizontalextent">\</a>  CListBox::GetHorizontalExtent  
 Retrieves from the list box the width in pixels by which it can be scrolled horizontally.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Return Value  
 The scrollable width of the list box, in pixels.  
  
### Remarks  
 This is applicable only if the list box has a horizontal scroll bar.  
  
### Example  
 [!code[NVC_MFC_CListBox#14](../vs140/codesnippet/CPP/clistbox-class_14.cpp)]  
  
##  \<a name="clistbox__getitemdata">\</a>  CListBox::GetItemData  
 Retrieves the application-supplied doubleword value associated with the specified list-box item.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>  
 Specifies the zero-based index of the item in the list box.  
  
### Return Value  
 The 32-bit value associated with the item, or **LB_ERR** if an error occurs.  
  
### Remarks  
 The doubleword value was the <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> parameter of a [SetItemData](#clistbox__setitemdata) call.  
  
### Example  
 [!code[NVC_MFC_CListBox#15](../vs140/codesnippet/CPP/clistbox-class_15.cpp)]  
  
##  \<a name="clistbox__getitemdataptr">\</a>  CListBox::GetItemDataPtr  
 Retrieves the application-supplied 32-bit value associated with the specified list-box item as a pointer ( **void\***).  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>  
 Specifies the zero-based index of the item in the list box.  
  
### Return Value  
 Retrieves a pointer, or –1 if an error occurs.  
  
### Example  
 [!code[NVC_MFC_CListBox#16](../vs140/codesnippet/CPP/clistbox-class_16.cpp)]  
  
##  \<a name="clistbox__getitemheight">\</a>  CListBox::GetItemHeight  
 Determines the height of items in a list box.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>  
 Specifies the zero-based index of the item in the list box. This parameter is used only if the list box has the **LBS_OWNERDRAWVARIABLE** style; otherwise, it should be set to 0.  
  
### Return Value  
 The height, in pixels, of the items in the list box. If the list box has the [LBS_OWNERDRAWVARIABLE](../vs140/list-box-styles.md) style, the return value is the height of the item specified by <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>. If an error occurs, the return value is **LB_ERR**.  
  
### Example  
 [!code[NVC_MFC_CListBox#17](../vs140/codesnippet/CPP/clistbox-class_17.cpp)]  
  
##  \<a name="clistbox__getitemrect">\</a>  CListBox::GetItemRect  
 Retrieves the dimensions of the rectangle that bounds a list-box item as it is currently displayed in the list-box window.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>  
 Specifies the zero-based index of the item.  
  
 <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>  
 Specifies a long pointer to a [RECT](../vs140/rect-structure.md) structure that receives the list-box client coordinates of the item.  
  
### Return Value  
 **LB_ERR** if an error occurs.  
  
### Example  
 [!code[NVC_MFC_CListBox#18](../vs140/codesnippet/CPP/clistbox-class_18.cpp)]  
  
##  \<a name="clistbox__getlistboxinfo">\</a>  CListBox::GetListBoxInfo  
 Retrieves the number of items per column.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Return Value  
 Number of items per column of the <CodeContentPlaceHolder>137\</CodeContentPlaceHolder> object.  
  
### Remarks  
 This member function emulates the functionality of the                         [LB_GETLISTBOXINFO](http://msdn.microsoft.com/library/windows/desktop/bb775208) message, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="clistbox__getlocale">\</a>  CListBox::GetLocale  
 Retrieves the locale used by the list box.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Return Value  
 The locale identifier (LCID) value for the strings in the list box.  
  
### Remarks  
 The locale is used, for example, to determine the sort order of the strings in a sorted list box.  
  
### Example  
  See the example for [CListBox::SetLocale](#clistbox__setlocale).  
  
##  \<a name="clistbox__getsel">\</a>  CListBox::GetSel  
 Retrieves the selection state of an item.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>  
 Specifies the zero-based index of the item.  
  
### Return Value  
 A positive number if the specified item is selected; otherwise, it is 0. The return value is <CodeContentPlaceHolder>139\</CodeContentPlaceHolder> if an error occurs.  
  
### Remarks  
 This member function works with both single- and multiple-selection list boxes.  
  
 To retrieve the index of the currently-selected list box item, use [CListBox::GetCurSel](#clistbox__getcursel).  
  
### Example  
 [!code[NVC_MFC_CListBox#19](../vs140/codesnippet/CPP/clistbox-class_19.cpp)]  
  
##  \<a name="clistbox__getselcount">\</a>  CListBox::GetSelCount  
 Retrieves the total number of selected items in a multiple-selection list box.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Return Value  
 The count of selected items in a list box. If the list box is a single-selection list box, the return value is **LB_ERR**.  
  
### Example  
  See the example for [CListBox::GetSelItems](#clistbox__getselitems).  
  
##  \<a name="clistbox__getselitems">\</a>  CListBox::GetSelItems  
 Fills a buffer with an array of integers that specifies the item numbers of selected items in a multiple-selection list box.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>  
 Specifies the maximum number of selected items whose item numbers are to be placed in the buffer.  
  
 <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>  
 Specifies a pointer to a buffer large enough for the number of integers specified by <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>.  
  
### Return Value  
 The actual number of items placed in the buffer. If the list box is a single-selection list box, the return value is <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>.  
  
### Example  
 [!code[NVC_MFC_CListBox#20](../vs140/codesnippet/CPP/clistbox-class_20.cpp)]  
  
##  \<a name="clistbox__gettext">\</a>  CListBox::GetText  
 Gets a string from a list box.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>  
 Specifies the zero-based index of the string to be retrieved.  
  
 <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>  
 Points to the buffer that receives the string. The buffer must have sufficient space for the string and a terminating null character. The size of the string can be determined ahead of time by calling the <CodeContentPlaceHolder>146\</CodeContentPlaceHolder> member function.  
  
 <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>148\</CodeContentPlaceHolder> object.  
  
### Return Value  
 The length (in bytes) of the string, excluding the terminating null character. If <CodeContentPlaceHolder>149\</CodeContentPlaceHolder> does not specify a valid index, the return value is **LB_ERR**.  
  
### Remarks  
 The second form of this member function fills a <CodeContentPlaceHolder>150\</CodeContentPlaceHolder> object with the string text.  
  
### Example  
 [!code[NVC_MFC_CListBox#21](../vs140/codesnippet/CPP/clistbox-class_21.cpp)]  
  
##  \<a name="clistbox__gettextlen">\</a>  CListBox::GetTextLen  
 Gets the length of a string in a list-box item.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>151\</CodeContentPlaceHolder>  
 Specifies the zero-based index of the string.  
  
### Return Value  
 The length of the string in characters, excluding the terminating null character. If <CodeContentPlaceHolder>152\</CodeContentPlaceHolder> does not specify a valid index, the return value is **LB_ERR**.  
  
### Example  
  See the example for [CListBox::GetText](#clistbox__gettext).  
  
##  \<a name="clistbox__gettopindex">\</a>  CListBox::GetTopIndex  
 Retrieves the zero-based index of the first visible item in a list box.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Return Value  
 The zero-based index of the first visible item in a list box if successful, **LB_ERR** otherwise.  
  
### Remarks  
 Initially, item 0 is at the top of the list box, but if the list box is scrolled, another item may be at the top.  
  
### Example  
 [!code[NVC_MFC_CListBox#22](../vs140/codesnippet/CPP/clistbox-class_22.cpp)]  
  
##  \<a name="clistbox__initstorage">\</a>  CListBox::InitStorage  
 Allocates memory for storing list-box items.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>153\</CodeContentPlaceHolder>  
 Specifies the number of items to add.  
  
 <CodeContentPlaceHolder>154\</CodeContentPlaceHolder>  
 Specifies the amount of memory, in bytes, to allocate for item strings.  
  
### Return Value  
 If successful, the maximum number of items that the list box can store before a memory reallocation is needed, otherwise **LB_ERRSPACE**, meaning not enough memory is available.  
  
### Remarks  
 Call this function before adding a large number of items to a <CodeContentPlaceHolder>155\</CodeContentPlaceHolder>.  
  
 This function helps speed up the initialization of list boxes that have a large number of items (more than 100). It preallocates the specified amount of memory so that subsequent [AddString](#clistbox__addstring), [InsertString](#clistbox__insertstring), and [Dir](#clistbox__dir) functions take the shortest possible time. You can use estimates for the parameters. If you overestimate, some extra memory is allocated; if you underestimate, the normal allocation is used for items that exceed the preallocated amount.  
  
 Windows 95/98 only: The <CodeContentPlaceHolder>156\</CodeContentPlaceHolder> parameter is limited to 16-bit values. This means list boxes cannot contain more than 32,767 items. Although the number of items is restricted, the total size of the items in a list box is limited only by available memory.  
  
### Example  
 [!code[NVC_MFC_CListBox#23](../vs140/codesnippet/CPP/clistbox-class_23.cpp)]  
  
##  \<a name="clistbox__insertstring">\</a>  CListBox::InsertString  
 Inserts a string into the list box.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>157\</CodeContentPlaceHolder>  
 Specifies the zero-based index of the position to insert the string. If this parameter is –1, the string is added to the end of the list.  
  
 <CodeContentPlaceHolder>158\</CodeContentPlaceHolder>  
 Points to the null-terminated string that is to be inserted.  
  
### Return Value  
 The zero-based index of the position at which the string was inserted. The return value is **LB_ERR** if an error occurs; the return value is **LB_ERRSPACE** if insufficient space is available to store the new string.  
  
### Remarks  
 Unlike the [AddString](#clistbox__addstring) member function, <CodeContentPlaceHolder>159\</CodeContentPlaceHolder> does not cause a list with the [LBS_SORT](../vs140/list-box-styles.md) style to be sorted.  
  
### Example  
 [!code[NVC_MFC_CListBox#24](../vs140/codesnippet/CPP/clistbox-class_24.cpp)]  
  
##  \<a name="clistbox__itemfrompoint">\</a>  CListBox::ItemFromPoint  
 Determines the list-box item nearest the point specified in <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>161\</CodeContentPlaceHolder>  
 Point for which to find the nearest item, specified relative to the upper-left corner of the client area of the list box.  
  
 <CodeContentPlaceHolder>162\</CodeContentPlaceHolder>  
 Reference to a <CodeContentPlaceHolder>163\</CodeContentPlaceHolder> variable which will be set to <CodeContentPlaceHolder>164\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>165\</CodeContentPlaceHolder> is outside the client area of the nearest list box item, <CodeContentPlaceHolder>166\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>167\</CodeContentPlaceHolder> is inside the client area of the nearest list box item.  
  
### Return Value  
 The index of the nearest item to the point specified in <CodeContentPlaceHolder>168\</CodeContentPlaceHolder>.  
  
### Remarks  
 You could use this function to determine which list-box item the mouse cursor moves over.  
  
### Example  
  See the example for [CListBox::SetAnchorIndex](#clistbox__setanchorindex).  
  
##  \<a name="clistbox__measureitem">\</a>  CListBox::MeasureItem  
 Called by the framework when a list box with an owner-draw style is created.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>169\</CodeContentPlaceHolder>  
 A long pointer to a [MEASUREITEMSTRUCT](../vs140/measureitemstruct-structure.md) structure.  
  
### Remarks  
 By default, this member function does nothing. Override this member function and fill in the <CodeContentPlaceHolder>170\</CodeContentPlaceHolder> structure to inform Windows of the list-box dimensions. If the list box is created with the [LBS_OWNERDRAWVARIABLE](../vs140/list-box-styles.md) style, the framework calls this member function for each item in the list box. Otherwise, this member is called only once.  
  
 For further information about using the [LBS_OWNERDRAWFIXED](../vs140/list-box-styles.md) style in an owner-draw list box created with the <CodeContentPlaceHolder>171\</CodeContentPlaceHolder> member function of <CodeContentPlaceHolder>172\</CodeContentPlaceHolder>, see the discussion in [Technical Note 14](../vs140/tn014--custom-controls.md).  
  
 See [CWnd::OnMeasureItem](../vs140/cwnd-class.md#cwnd__onmeasureitem) for a description of the <CodeContentPlaceHolder>173\</CodeContentPlaceHolder> structure **.**  
  
### Example  
 [!code[NVC_MFC_CListBox#25](../vs140/codesnippet/CPP/clistbox-class_25.cpp)]  
  
##  \<a name="clistbox__resetcontent">\</a>  CListBox::ResetContent  
 Removes all items from a list box.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Example  
 [!code[NVC_MFC_CListBox#26](../vs140/codesnippet/CPP/clistbox-class_26.cpp)]  
  
##  \<a name="clistbox__selectstring">\</a>  CListBox::SelectString  
 Searches for a list-box item that matches the specified string, and if a matching item is found, it selects the item.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>  
 Contains the zero-based index of the item before the first item to be searched. When the search reaches the bottom of the list box, it continues from the top of the list box back to the item specified by <CodeContentPlaceHolder>175\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>176\</CodeContentPlaceHolder> is –1, the entire list box is searched from the beginning.  
  
 <CodeContentPlaceHolder>177\</CodeContentPlaceHolder>  
 Points to the null-terminated string that contains the prefix to search for. The search is case independent, so this string may contain any combination of uppercase and lowercase letters.  
  
### Return Value  
 The index of the selected item if the search was successful. If the search was unsuccessful, the return value is **LB_ERR** and the current selection is not changed.  
  
### Remarks  
 The list box is scrolled, if necessary, to bring the selected item into view.  
  
 This member function cannot be used with a list box that has the [LBS_MULTIPLESEL](../vs140/list-box-styles.md) style.  
  
 An item is selected only if its initial characters (from the starting point) match the characters in the string specified by <CodeContentPlaceHolder>178\</CodeContentPlaceHolder>.  
  
 Use the <CodeContentPlaceHolder>179\</CodeContentPlaceHolder> member function to find a string without selecting the item.  
  
### Example  
 [!code[NVC_MFC_CListBox#27](../vs140/codesnippet/CPP/clistbox-class_27.cpp)]  
  
##  \<a name="clistbox__selitemrange">\</a>  CListBox::SelItemRange  
 Selects multiple consecutive items in a multiple-selection list box.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>180\</CodeContentPlaceHolder>  
 Specifies how to set the selection. If <CodeContentPlaceHolder>181\</CodeContentPlaceHolder> is **TRUE**, the string is selected and highlighted; if **FALSE**, the highlight is removed and the string is no longer selected.  
  
 <CodeContentPlaceHolder>182\</CodeContentPlaceHolder>  
 Specifies the zero-based index of the first item to set.  
  
 <CodeContentPlaceHolder>183\</CodeContentPlaceHolder>  
 Specifies the zero-based index of the last item to set.  
  
### Return Value  
 **LB_ERR** if an error occurs.  
  
### Remarks  
 Use this member function only with multiple-selection list boxes. If you need to select only one item in a multiple-selection list box — that is, if <CodeContentPlaceHolder>184\</CodeContentPlaceHolder> is equal to <CodeContentPlaceHolder>185\</CodeContentPlaceHolder> — call the [SetSel](#clistbox__setsel) member function instead.  
  
### Example  
 [!code[NVC_MFC_CListBox#28](../vs140/codesnippet/CPP/clistbox-class_28.cpp)]  
  
##  \<a name="clistbox__setanchorindex">\</a>  CListBox::SetAnchorIndex  
 Sets the anchor in a multiple-selection list box to begin an extended selection.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>186\</CodeContentPlaceHolder>  
 Specifies the zero-based index of the list-box item that will be the anchor.  
  
### Remarks  
 In a multiple-selection list box, the anchor item is the first or last item in a block of contiguous selected items.  
  
### Example  
 [!code[NVC_MFC_CListBox#29](../vs140/codesnippet/CPP/clistbox-class_29.cpp)]  
  
##  \<a name="clistbox__setcaretindex">\</a>  CListBox::SetCaretIndex  
 Sets the focus rectangle to the item at the specified index in a multiple-selection list box.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>187\</CodeContentPlaceHolder>  
 Specifies the zero-based index of the item to receive the focus rectangle in the list box.  
  
 *bScroll*  
 If this value is 0, the item is scrolled until it is fully visible. If this value is not 0, the item is scrolled until it is at least partially visible.  
  
### Return Value  
 **LB_ERR** if an error occurs.  
  
### Remarks  
 If the item is not visible, it is scrolled into view.  
  
### Example  
 [!code[NVC_MFC_CListBox#30](../vs140/codesnippet/CPP/clistbox-class_30.cpp)]  
  
##  \<a name="clistbox__setcolumnwidth">\</a>  CListBox::SetColumnWidth  
 Sets the width in pixels of all columns in a multicolumn list box (created with the [LBS_MULTICOLUMN](../vs140/list-box-styles.md) style).  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>188\</CodeContentPlaceHolder>  
 Specifies the width in pixels of all columns.  
  
### Example  
 [!code[NVC_MFC_CListBox#31](../vs140/codesnippet/CPP/clistbox-class_31.cpp)]  
  
##  \<a name="clistbox__setcursel">\</a>  CListBox::SetCurSel  
 Selects a string and scrolls it into view, if necessary.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>189\</CodeContentPlaceHolder>  
 Specifies the zero-based index of the string to be selected. If <CodeContentPlaceHolder>190\</CodeContentPlaceHolder> is –1, the list box is set to have no selection.  
  
### Return Value  
 <CodeContentPlaceHolder>191\</CodeContentPlaceHolder> if an error occurs.  
  
### Remarks  
 When the new string is selected, the list box removes the highlight from the previously selected string.  
  
 Use this member function only with single-selection list boxes.  
  
 To set or remove a selection in a multiple-selection list box, use [CListBox::SetSel](#clistbox__setsel).  
  
### Example  
 [!code[NVC_MFC_CListBox#32](../vs140/codesnippet/CPP/clistbox-class_32.cpp)]  
  
##  \<a name="clistbox__sethorizontalextent">\</a>  CListBox::SetHorizontalExtent  
 Sets the width, in pixels, by which a list box can be scrolled horizontally.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Parameters  
 *cxExtent*  
 Specifies the number of pixels by which the list box can be scrolled horizontally.  
  
### Remarks  
 If the size of the list box is smaller than this value, the horizontal scroll bar will horizontally scroll items in the list box. If the list box is as large or larger than this value, the horizontal scroll bar is hidden.  
  
 To respond to a call to <CodeContentPlaceHolder>192\</CodeContentPlaceHolder>, the list box must have been defined with the [WS_HSCROLL](../vs140/window-styles.md) style.  
  
 This member function is not useful for multicolumn list boxes. For multicolumn list boxes, call the <CodeContentPlaceHolder>193\</CodeContentPlaceHolder> member function.  
  
### Example  
 [!code[NVC_MFC_CListBox#33](../vs140/codesnippet/CPP/clistbox-class_33.cpp)]  
  
##  \<a name="clistbox__setitemdata">\</a>  CListBox::SetItemData  
 Sets a 32-bit value associated with the specified item in a list box.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>194\</CodeContentPlaceHolder>  
 Specifies the zero-based index of the item.  
  
 <CodeContentPlaceHolder>195\</CodeContentPlaceHolder>  
 Specifies the value to be associated with the item.  
  
### Return Value  
 **LB_ERR** if an error occurs.  
  
### Example  
 [!code[NVC_MFC_CListBox#34](../vs140/codesnippet/CPP/clistbox-class_34.cpp)]  
  
##  \<a name="clistbox__setitemdataptr">\</a>  CListBox::SetItemDataPtr  
 Sets the 32-bit value associated with the specified item in a list box to be the specified pointer ( **void\***).  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>196\</CodeContentPlaceHolder>  
 Specifies the zero-based index of the item.  
  
 <CodeContentPlaceHolder>197\</CodeContentPlaceHolder>  
 Specifies the pointer to be associated with the item.  
  
### Return Value  
 **LB_ERR** if an error occurs.  
  
### Remarks  
 This pointer remains valid for the life of the list box, even though the item's relative position within the list box might change as items are added or removed. Hence, the item's index within the box can change, but the pointer remains reliable.  
  
### Example  
 [!code[NVC_MFC_CListBox#35](../vs140/codesnippet/CPP/clistbox-class_35.cpp)]  
  
##  \<a name="clistbox__setitemheight">\</a>  CListBox::SetItemHeight  
 Sets the height of items in a list box.  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>198\</CodeContentPlaceHolder>  
 Specifies the zero-based index of the item in the list box. This parameter is used only if the list box has the **LBS_OWNERDRAWVARIABLE** style; otherwise, it should be set to 0.  
  
 <CodeContentPlaceHolder>199\</CodeContentPlaceHolder>  
 Specifies the height, in pixels, of the item.  
  
### Return Value  
 **LB_ERR** if the index or height is invalid.  
  
### Remarks  
 If the list box has the [LBS_OWNERDRAWVARIABLE](../vs140/list-box-styles.md) style, this function sets the height of the item specified by <CodeContentPlaceHolder>200\</CodeContentPlaceHolder>. Otherwise, this function sets the height of all items in the list box.  
  
### Example  
 [!code[NVC_MFC_CListBox#36](../vs140/codesnippet/CPP/clistbox-class_36.cpp)]  
  
##  \<a name="clistbox__setlocale">\</a>  CListBox::SetLocale  
 Sets the locale identifier for this list box.  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>201\</CodeContentPlaceHolder>  
 The new locale identifier (LCID) value to set for the list box.  
  
### Return Value  
 The previous locale identifier (LCID) value for this list box.  
  
### Remarks  
 If **SetLocale** is not called, the default locale is obtained from the system. This system default locale can be modified by using Control Panel's Regional (or International) application.  
  
### Example  
 [!code[NVC_MFC_CListBox#37](../vs140/codesnippet/CPP/clistbox-class_37.cpp)]  
  
##  \<a name="clistbox__setsel">\</a>  CListBox::SetSel  
 Selects a string in a multiple-selection list box.  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>202\</CodeContentPlaceHolder>  
 Contains the zero-based index of the string to be set. If –1, the selection is added to or removed from all strings, depending on the value of <CodeContentPlaceHolder>203\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>204\</CodeContentPlaceHolder>  
 Specifies how to set the selection. If <CodeContentPlaceHolder>205\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>206\</CodeContentPlaceHolder>, the string is selected and highlighted; if <CodeContentPlaceHolder>207\</CodeContentPlaceHolder>, the highlight is removed and the string is no longer selected. The specified string is selected and highlighted by default.  
  
### Return Value  
 <CodeContentPlaceHolder>208\</CodeContentPlaceHolder> if an error occurs.  
  
### Remarks  
 Use this member function only with multiple-selection list boxes.  
  
 To select an item from a single-selection list box, use [CListBox::SetCurSel](#clistbox__setcursel).  
  
### Example  
 [!code[NVC_MFC_CListBox#38](../vs140/codesnippet/CPP/clistbox-class_38.cpp)]  
  
##  \<a name="clistbox__settabstops">\</a>  CListBox::SetTabStops  
 Sets the tab-stop positions in a list box.  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>209\</CodeContentPlaceHolder>  
 Tab stops are set at every <CodeContentPlaceHolder>210\</CodeContentPlaceHolder> dialog units. See                                 *rgTabStops* for a description of a dialog unit.  
  
 <CodeContentPlaceHolder>211\</CodeContentPlaceHolder>  
 Specifies the number of tab stops to have in the list box.  
  
 <CodeContentPlaceHolder>212\</CodeContentPlaceHolder>  
 Points to the first member of an array of integers containing the tab-stop positions in dialog units. A dialog unit is a horizontal or vertical distance. One horizontal dialog unit is equal to one-fourth of the current dialog base width unit, and one vertical dialog unit is equal to one-eighth of the current dialog base height unit. The dialog base units are computed based on the height and width of the current system font. The **GetDialogBaseUnits** Windows function returns the current dialog base units in pixels. The tab stops must be sorted in increasing order; back tabs are not allowed.  
  
### Return Value  
 Nonzero if all the tabs were set; otherwise 0.  
  
### Remarks  
 To set tab stops to the default size of 2 dialog units, call the parameterless version of this member function. To set tab stops to a size other than 2, call the version with the <CodeContentPlaceHolder>213\</CodeContentPlaceHolder> argument.  
  
 To set tab stops to an array of sizes, use the version with the <CodeContentPlaceHolder>214\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>215\</CodeContentPlaceHolder> arguments. A tab stop will be set for each value in <CodeContentPlaceHolder>216\</CodeContentPlaceHolder>, up to the number specified by <CodeContentPlaceHolder>217\</CodeContentPlaceHolder>.  
  
 To respond to a call to the <CodeContentPlaceHolder>218\</CodeContentPlaceHolder> member function, the list box must have been created with the [LBS_USETABSTOPS](../vs140/list-box-styles.md) style.  
  
### Example  
 [!code[NVC_MFC_CListBox#39](../vs140/codesnippet/CPP/clistbox-class_39.cpp)]  
  
##  \<a name="clistbox__settopindex">\</a>  CListBox::SetTopIndex  
 Ensures that a particular list-box item is visible.  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>219\</CodeContentPlaceHolder>  
 Specifies the zero-based index of the list-box item.  
  
### Return Value  
 Zero if successful, or **LB_ERR** if an error occurs.  
  
### Remarks  
 The system scrolls the list box until either the item specified by <CodeContentPlaceHolder>220\</CodeContentPlaceHolder> appears at the top of the list box or the maximum scroll range has been reached.  
  
### Example  
 [!code[NVC_MFC_CListBox#40](../vs140/codesnippet/CPP/clistbox-class_40.cpp)]  
  
##  \<a name="clistbox__vkeytoitem">\</a>  CListBox::VKeyToItem  
 Called by the framework when the list box's parent window receives a <CodeContentPlaceHolder>221\</CodeContentPlaceHolder> message from the list box.  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>222\</CodeContentPlaceHolder>  
 The virtual key code of the key the user pressed. For a list of of standard virtual key codes, see Winuser.h  
  
 <CodeContentPlaceHolder>223\</CodeContentPlaceHolder>  
 The current position of the list-box caret.  
  
### Return Value  
 Returns – 2 for no further action, – 1 for default action, or a nonnegative number to specify an index of a list box item on which to perform the default action for the keystroke.  
  
### Remarks  
 The <CodeContentPlaceHolder>224\</CodeContentPlaceHolder> message is sent by the list box when it receives a <CodeContentPlaceHolder>225\</CodeContentPlaceHolder> message, but only if the list box meets both of the following:  
  
-   Has the [LBS_WANTKEYBOARDINPUT](../vs140/list-box-styles.md) style set.  
  
-   Has at least one item.  
  
 You should never call this function yourself. Override this function to provide your own custom handling of keyboard messages.  
  
 You must return a value to tell the framework what action your override performed. A return value of – 2 indicates that the application handled all aspects of selecting the item and requires no further action by the list box. Before returning – 2, you could set the selection or move the caret or both. To set the selection, use [SetCurSel](#clistbox__setcursel) or [SetSel](#clistbox__setsel). To move the caret, use [SetCaretIndex](#clistbox__setcaretindex).  
  
 A return value of – 1 indicates that the list box should perform the default action in response to the keystroke.The default implementation returns – 1.  
  
 A return value of 0 or greater specifies the index of an item in the list box and indicates that the list box should perform the default action for the keystroke on the given item.  
  
### Example  
 [!code[NVC_MFC_CListBox#41](../vs140/codesnippet/CPP/clistbox-class_41.cpp)]  
  
## See Also  
 [MFC Sample CTRLTEST](../vs140/visual-c---samples.md)   
 [Base Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd](../vs140/cwnd-class.md)   
 [CButton](../vs140/cbutton-class.md)   
 [CComboBox](../vs140/ccombobox-class.md)   
 [CEdit](../vs140/cedit-class.md)   
 [CScrollBar](../vs140/cscrollbar-class.md)   
 [CStatic](../vs140/cstatic-class.md)