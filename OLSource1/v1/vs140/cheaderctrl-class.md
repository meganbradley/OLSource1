---
title: "CHeaderCtrl Class"
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
  - "CHeaderCtrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CHeaderCtrl class"
  - "Windows common controls [C++], CHeaderCtrl"
  - "header controls, CHeaderCtrl class"
ms.assetid: b847ac90-5fae-4a87-88e0-ca45f77b8b3b
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHeaderCtrl Class
Provides the functionality of the Windows common header control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CHeaderCtrl::CHeaderCtrl](#cheaderctrl__cheaderctrl)|Constructs a <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CHeaderCtrl::ClearAllFilters](#cheaderctrl__clearallfilters)|Clears all filters for a header control.|  
|[CHeaderCtrl::ClearFilter](#cheaderctrl__clearfilter)|Clears the filter for a header control.|  
|[CHeaderCtrl::Create](#cheaderctrl__create)|Creates a header control and attaches it to a <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object.|  
|[CHeaderCtrl::CreateDragImage](#cheaderctrl__createdragimage)|Creates a transparent version of an item's image within a header control.|  
|[CHeaderCtrl::CreateEx](#cheaderctrl__createex)|Creates a header control with the specified Windows extended styles and attaches it to a <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object.|  
|[CHeaderCtrl::DeleteItem](#cheaderctrl__deleteitem)|Deletes an item from a header control.|  
|[CHeaderCtrl::DrawItem](#cheaderctrl__drawitem)|Draws the specified item of a header control.|  
|[CHeaderCtrl::EditFilter](#cheaderctrl__editfilter)|Starts editing the specified filter of a header control.|  
|[CHeaderCtrl::GetBitmapMargin](#cheaderctrl__getbitmapmargin)|Retrieves the width of the margin of a bitmap in a header control.|  
|[CHeaderCtrl::GetFocusedItem](#cheaderctrl__getfocuseditem)|Gets the identifier of the item in the current header control that has the focus.|  
|[CHeaderCtrl::GetImageList](#cheaderctrl__getimagelist)|Retrieves the handle of an image list used for drawing header items in a header control.|  
|[CHeaderCtrl::GetItem](#cheaderctrl__getitem)|Retrieves information about an item in a header control.|  
|[CHeaderCtrl::GetItemCount](#cheaderctrl__getitemcount)|Retrieves a count of the items in a header control.|  
|[CHeaderCtrl::GetItemDropDownRect](#cheaderctrl__getitemdropdownrect)|Gets the bounding rectangle information for the specified drop-down button in a header control.|  
|[CHeaderCtrl::GetItemRect](#cheaderctrl__getitemrect)|Retrieves the bounding rectangle for a given item in a header control.|  
|[CHeaderCtrl::GetOrderArray](#cheaderctrl__getorderarray)|Retrieves the left-to-right order of items in a header control.|  
|[CHeaderCtrl::GetOverflowRect](#cheaderctrl__getoverflowrect)|Gets the bounding rectangle of the overflow button for the current header control.|  
|[CHeaderCtrl::HitTest](#cheaderctrl__hittest)|Determines which header item, if any, is located at a specified point.|  
|[CHeaderCtrl::InsertItem](#cheaderctrl__insertitem)|Inserts a new item into a header control.|  
|[CHeaderCtrl::Layout](#cheaderctrl__layout)|Retrieves the size and position of a header control within a given rectangle.|  
|[CHeaderCtrl::OrderToIndex](#cheaderctrl__ordertoindex)|Retrieves the index value for an item based on its order in the header control.|  
|[CHeaderCtrl::SetBitmapMargin](#cheaderctrl__setbitmapmargin)|Sets the width of the margin of a bitmap in a header control.|  
|[CHeaderCtrl::SetFilterChangeTimeout](#cheaderctrl__setfilterchangetimeout)|Sets the timeout interval between the time a change takes place in the filter attributes and the posting of an <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> notification.|  
|[CHeaderCtrl::SetFocusedItem](#cheaderctrl__setfocuseditem)|Sets the focus to a specified header item in the current header control.|  
|[CHeaderCtrl::SetHotDivider](#cheaderctrl__sethotdivider)|Changes the divider between header items to indicate a manual drag and drop of a header item.|  
|[CHeaderCtrl::SetImageList](#cheaderctrl__setimagelist)|Assigns an image list to a header control.|  
|[CHeaderCtrl::SetItem](#cheaderctrl__setitem)|Sets the attributes of the specified item in a header control.|  
|[CHeaderCtrl::SetOrderArray](#cheaderctrl__setorderarray)|Sets the left-to-right order of items in a header control.|  
  
## Remarks  
 A header control is a window that is usually positioned above a set of columns of text or numbers. It contains a title for each column, and it can be divided into parts. The user can drag the dividers that separate the parts to set the width of each column. For an illustration of a header control, see                 [Header Controls](http://msdn.microsoft.com/library/windows/desktop/bb775238).  
  
 This control (and therefore the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> class) is available only to programs that run under Windows 95/98 and Windows NT version 3.51 and later.  
  
 Functionality added for Windows 95/Internet Explorer 4.0 common controls includes the following:  
  
-   Header item custom ordering.  
  
-   Header item drag and drop, for reordering of header items. Use the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> style when you create the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> object.  
  
-   Header column text constantly viewable during column resizing. Use the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> style when you create a <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object.  
  
-   Header hot tracking, which highlights the header item when the pointer is hovering over it. Use the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> style when you create the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> object.  
  
-   Image list support. Header items can contain images stored in a <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> object or text.  
  
 For more information about using <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, see [Controls](../vs140/controls--mfc-.md) and [Using CHeaderCtrl](../vs140/using-cheaderctrl.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxcmn.h  
  
##  \<a name="cheaderctrl__cheaderctrl">\</a>  CHeaderCtrl::CHeaderCtrl  
 Constructs a <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Example  
 [!code[NVC_MFC_CHeaderCtrl#1](../vs140/codesnippet/CPP/cheaderctrl-class_1.cpp)]  
  
##  \<a name="cheaderctrl__clearallfilters">\</a>  CHeaderCtrl::ClearAllFilters  
 Clears all filters for a header control.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> if this method is successful; otherwise, <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method implements the behavior of the Win32 message                         [HDM_CLEARFILTER](http://msdn.microsoft.com/library/windows/desktop/bb775306) with a column value of –1, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_MFC_CHeaderCtrl#2](../vs140/codesnippet/CPP/cheaderctrl-class_2.cpp)]  
  
##  \<a name="cheaderctrl__clearfilter">\</a>  CHeaderCtrl::ClearFilter  
 Clears the filter for a header control.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 Column value indicating which filter to clear.  
  
### Return Value  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> if this method is successful; otherwise, <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method implements the behavior of the Win32 message                         [HDM_CLEARFILTER](http://msdn.microsoft.com/library/windows/desktop/bb775306), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_MFC_CHeaderCtrl#3](../vs140/codesnippet/CPP/cheaderctrl-class_3.cpp)]  
  
##  \<a name="cheaderctrl__create">\</a>  CHeaderCtrl::Create  
 Creates a header control and attaches it to a <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 Specifies the header control's style. For a description of header control styles, see                                 [Header Control Styles](http://msdn.microsoft.com/library/windows/desktop/bb775241) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 Specifies the header control's size and position. It can be either a [CRect](../vs140/crect-class.md) object or a                                 [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure.  
  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 Specifies the header control's parent window, usually a <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>. It must not be **NULL**.  
  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 Specifies the header control's ID.  
  
### Return Value  
 Nonzero if initialization was successful; otherwise zero.  
  
### Remarks  
 You construct a <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> object in two steps. First, call the constructor and then call **Create**, which creates the header control and attaches it to the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> object.  
  
 In addition to the header control styles, you can use the following common control styles to determine how the header control positions and resizes itself (see                         [Common Control Styles](http://msdn.microsoft.com/library/windows/desktop/bb775498) for more information):  
  
-   <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> Causes the control to position itself at the bottom of the parent window's client area and sets the width to be the same as the parent window's width.  
  
-   <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> Prevents a two-pixel highlight from being drawn at the top of the control.  
  
-   <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> Causes the control to resize and move itself horizontally, but not vertically, in response to a <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> message. If the <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> style is used, this style does not apply. Header controls have this style by default.  
  
-   <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> Prevents the control from automatically moving to the top or bottom of the parent window. Instead, the control keeps its position within the parent window despite changes to the size of the parent window. If the <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> style is also used, the height is adjusted to the default, but the position and width remain unchanged.  
  
-   <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> Prevents the control from using the default width and height when setting its initial size or a new size. Instead, the control uses the width and height specified in the request for creation or sizing.  
  
-   <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> Causes the control to position itself at the top of the parent window's client area and sets the width to be the same as the parent window's width.  
  
 You can also apply the following window styles to a header control (see [Window Styles](../vs140/window-styles.md) for more information):  
  
-   **WS_CHILD** Creates a child window. Cannot be used with the <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> style.  
  
-   **WS_VISIBLE** Creates a window that is initially visible.  
  
-   **WS_DISABLED** Creates a window that is initially disabled.  
  
-   **WS_GROUP** Specifies the first control of a group of controls in which the user can move from one control to the next with the arrow keys. All controls defined with the **WS_GROUP** style after the first control belong to the same group. The next control with the **WS_GROUP** style ends the style group and starts the next group (that is, one group ends where the next begins).  
  
-   **WS_TABSTOP** Specifies one of any number of controls through which the user can move by using the TAB key. The TAB key moves the user to the next control specified by the **WS_TABSTOP** style.  
  
 If you want to use extended windows styles with your control, call [CreateEx](#cheaderctrl__createex) instead of **Create**.  
  
### Example  
 [!code[NVC_MFC_CHeaderCtrl#4](../vs140/codesnippet/CPP/cheaderctrl-class_4.cpp)]  
  
##  \<a name="cheaderctrl__createex">\</a>  CHeaderCtrl::CreateEx  
 Creates a control (a child window) and associate it with the <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
 Specifies the extended style of the control being created. For a list of extended Windows styles, see the <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> parameter for                                 [CreateWindowEx](http://msdn.microsoft.com/library/windows/desktop/ms632680) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 The header control's style. For a description of header control styles, see                                 [Header Control Styles](http://msdn.microsoft.com/library/windows/desktop/bb775241) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. See [Create](#cheaderctrl__create) for a list of additional styles.  
  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
 A reference to a                                 [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure describing the size and position of the window to be created, in client coordinates of <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
 A pointer to the window that is the control's parent.  
  
 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 The control's child-window ID.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 Use <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> instead of **Create** to apply extended Windows styles, specified by the Windows extended style preface **WS_EX_**.  
  
##  \<a name="cheaderctrl__createdragimage">\</a>  CHeaderCtrl::CreateDragImage  
 Creates a transparent version of an item's image within a header control.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 The zero-based index of the item within the header control. The image assigned to this item is the basis for the transparent image.  
  
### Return Value  
 A pointer to a [CImageList](../vs140/cimagelist-class.md) object if successful; otherwise **NULL**. The returned list contains only one image.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [HDM_CREATEDRAGIMAGE](http://msdn.microsoft.com/library/windows/desktop/bb775308), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. It is provided to support header item drag and drop.  
  
 The <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> object to which the returned pointer points is a temporary object and is deleted in the next idle-time processing.  
  
##  \<a name="cheaderctrl__deleteitem">\</a>  CHeaderCtrl::DeleteItem  
 Deletes an item from a header control.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
 Specifies the zero-based index of the item to delete.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Example  
 [!code[NVC_MFC_CHeaderCtrl#5](../vs140/codesnippet/CPP/cheaderctrl-class_5.cpp)]  
  
##  \<a name="cheaderctrl__drawitem">\</a>  CHeaderCtrl::DrawItem  
 Called by the framework when a visual aspect of an owner-draw header control changes.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
 A pointer to a                                 [DRAWITEMSTRUCT](http://msdn.microsoft.com/library/windows/desktop/bb775802) structure describing the item to be painted.  
  
### Remarks  
 The **itemAction** member of the <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> structure defines the drawing action that is to be performed.  
  
 By default, this member function does nothing. Override this member function to implement drawing for an owner-draw <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> object.  
  
 The application should restore all graphics device interface (GDI) objects selected for the display context supplied in <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> before this member function terminates.  
  
### Example  
 [!code[NVC_MFC_CHeaderCtrl#6](../vs140/codesnippet/CPP/cheaderctrl-class_6.cpp)]  
  
##  \<a name="cheaderctrl__editfilter">\</a>  CHeaderCtrl::EditFilter  
 Begins to edit the specified filter of a header control.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 The column to edit.  
  
 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
 A value that specifies how to handle the user's editing changes if the user is in the process of editing the filter when the                                 [HDM_EDITFILTER](http://msdn.microsoft.com/library/windows/desktop/bb775312) message is sent.  
  
 Specify <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> to discard the changes made by the user, or <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> to accept the changes made by the user.  
  
### Return Value  
 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> if this method is successful; otherwise, <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method implements the behavior of the Win32 message                         [HDM_EDITFILTER](http://msdn.microsoft.com/library/windows/desktop/bb775312), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_MFC_CHeaderCtrl#7](../vs140/codesnippet/CPP/cheaderctrl-class_7.cpp)]  
  
##  \<a name="cheaderctrl__getbitmapmargin">\</a>  CHeaderCtrl::GetBitmapMargin  
 Retrieves the width of the margin of a bitmap in a header control.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 The width of the bitmap margin in pixels.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [HDM_GETBITMAPMARGIN](http://msdn.microsoft.com/library/windows/desktop/bb775314), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_MFC_CHeaderCtrl#8](../vs140/codesnippet/CPP/cheaderctrl-class_8.cpp)]  
  
##  \<a name="cheaderctrl__getfocuseditem">\</a>  CHeaderCtrl::GetFocusedItem  
 Gets the index of the item that has the focus in the current header control.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 The zero-based index of the header item that has the focus.  
  
### Remarks  
 This method sends the                         [HDM_GETFOCUSEDITEM](http://msdn.microsoft.com/library/windows/desktop/bb775330) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 The following code example defines the variable, <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>, that is used to access the current header control. This variable is used in the next example.  
  
 [!code[NVC_MFC_CHeaderCtrl_s4#6](../vs140/codesnippet/CPP/cheaderctrl-class_9.h)]  
  
### Example  
 The following code example demonstrates the <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> methods. In an earlier section of the code, we created a header control with five columns. However, you can drag a column separator so that the column is not visible. The following example sets and then confirms the last column header as the focus item.  
  
 [!code[NVC_MFC_CHeaderCtrl_s4#4](../vs140/codesnippet/CPP/cheaderctrl-class_10.cpp)]  
  
##  \<a name="cheaderctrl__getimagelist">\</a>  CHeaderCtrl::GetImageList  
 Retrieves the handle of an image list used for drawing header items in a header control.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to a [CImageList](../vs140/cimagelist-class.md) object.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [HDM_GETIMAGELIST](http://msdn.microsoft.com/library/windows/desktop/bb775332), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. The <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> object to which the returned pointer points is a temporary object and is deleted in the next idle-time processing.  
  
### Example  
 [!code[NVC_MFC_CHeaderCtrl#9](../vs140/codesnippet/CPP/cheaderctrl-class_11.cpp)]  
  
##  \<a name="cheaderctrl__getitem">\</a>  CHeaderCtrl::GetItem  
 Retrieves information about a header control item.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
 Specifies the zero-based index of the item to retrieve.  
  
 <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
 Pointer to an                                 [HDITEM](http://msdn.microsoft.com/library/windows/desktop/bb775247) structure that receives the new item. This structure is used with the <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> member functions. Any flags set in the **mask** element ensure that values in the corresponding elements are properly filled in upon return. If the **mask** element is set to zero, values in the other structure elements are meaningless.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Example  
 [!code[NVC_MFC_CHeaderCtrl#10](../vs140/codesnippet/CPP/cheaderctrl-class_12.cpp)]  
  
##  \<a name="cheaderctrl__getitemcount">\</a>  CHeaderCtrl::GetItemCount  
 Retrieves a count of the items in a header control.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 Number of header control items if successful; otherwise – 1.  
  
### Example  
  See the example for [CHeaderCtrl::DeleteItem](#cheaderctrl__deleteitem).  
  
##  \<a name="cheaderctrl__getitemdropdownrect">\</a>  CHeaderCtrl::GetItemDropDownRect  
 Gets the bounding rectangle of the drop-down button for a header item in the current header control.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>|Zero-based index of a header item whose style is <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>. For more information, see the <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> member of the                                         [HDITEM](http://msdn.microsoft.com/library/windows/desktop/bb775247) structure.|  
|[out] <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>|Pointer to a                                         [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure to receive the bounding rectangle information.|  
  
### Return Value  
 <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> if this function is successful; otherwise, <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method sends the                         [HDM_GETITEMDROPDOWNRECT](http://msdn.microsoft.com/library/windows/desktop/bb775339) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 The following code example defines the variable, <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>, that is used to access the current header control. This variable is used in the next example.  
  
 [!code[NVC_MFC_CHeaderCtrl_s4#6](../vs140/codesnippet/CPP/cheaderctrl-class_9.h)]  
  
### Example  
 The following code example demonstrates the <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> method. In an earlier section of the code, we created a header control with five columns. The following code example draws a 3D rectangle around the location on the first column that is reserved for the header drop-down button.  
  
 [!code[NVC_MFC_CHeaderCtrl_s4#2](../vs140/codesnippet/CPP/cheaderctrl-class_13.cpp)]  
  
##  \<a name="cheaderctrl__getitemrect">\</a>  CHeaderCtrl::GetItemRect  
 Retrieves the bounding rectangle for a given item in a header control.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>  
 The zero-based index of the header control item.  
  
 <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>  
 A pointer to the address of a                                 [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure that receives the bounding rectangle information.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 This method implements the behavior of the Win32 message                         [HDM_GETITEMRECT](http://msdn.microsoft.com/library/windows/desktop/bb775341), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cheaderctrl__getorderarray">\</a>  CHeaderCtrl::GetOrderArray  
 Retrieves the left-to-right order of items in a header control.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
 A pointer to the address of a buffer that receives the index values of the items in the header control, in the order in which they appear from left to right.  
  
 <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  
 The number of header control items. Must be non-negative.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [HDM_GETORDERARRAY](http://msdn.microsoft.com/library/windows/desktop/bb775343), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. It is provided to support header item ordering.  
  
### Example  
 [!code[NVC_MFC_CHeaderCtrl#11](../vs140/codesnippet/CPP/cheaderctrl-class_14.cpp)]  
  
##  \<a name="cheaderctrl__getoverflowrect">\</a>  CHeaderCtrl::GetOverflowRect  
 Gets the bounding rectangle of the overflow button of the current header control.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[out] <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>|Pointer to a                                         [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure that receives the bounding rectangle information.|  
  
### Return Value  
 <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> if this function is successful; otherwise, <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>.  
  
### Remarks  
 If the header control contains more items than can be simultaneously displayed, the control can display an overflow button that scrolls to items that are not visible. The header control must have the <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> styles to display the overflow button. The bounding rectangle encloses the overflow button and exists only when the overflow button is displayed. For more information, see                         [Header Control Styles](http://msdn.microsoft.com/library/windows/desktop/bb775241).  
  
 This method sends the                         [HDM_GETOVERFLOWRECT](http://msdn.microsoft.com/library/windows/desktop/bb775345) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 The following code example defines the variable, <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>, that is used to access the current header control. This variable is used in the next example.  
  
 [!code[NVC_MFC_CHeaderCtrl_s4#6](../vs140/codesnippet/CPP/cheaderctrl-class_9.h)]  
  
### Example  
 The following code example demonstrates the <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> method. In an earlier section of the code, we created a header control with five columns. However, you can drag a column separator so that the column is not visible. If some columns are not visible, the header control draws an overflow button. The following code example draws a 3D rectangle around the location of the overflow button.  
  
 [!code[NVC_MFC_CHeaderCtrl_s4#3](../vs140/codesnippet/CPP/cheaderctrl-class_15.cpp)]  
  
##  \<a name="cheaderctrl__hittest">\</a>  CHeaderCtrl::HitTest  
 Determines which header item, if any, is located at a specified point.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in, out] <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>|Pointer to a                                         [HDHITTESTINFO](http://msdn.microsoft.com/library/windows/desktop/bb775245) structure that specifies the point to test and receives the results of the test.|  
  
### Return Value  
 The zero-based index of the header item, if any, at the specified position; otherwise, –1.  
  
### Remarks  
 This method sends the                         [HDM_HITTEST](http://msdn.microsoft.com/library/windows/desktop/bb775349) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 The following code example defines the variable, <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>, that is used to access the current header control. This variable is used in the next example.  
  
 [!code[NVC_MFC_CHeaderCtrl_s4#6](../vs140/codesnippet/CPP/cheaderctrl-class_9.h)]  
  
### Example  
 The following code example demonstrates the <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> method. In an earlier section of this code example, we created a header control with five columns. However, you can drag a column separator so that the column is not visible. This example reports the index of the column if it is visible and -1 if the column is not visible.  
  
 [!code[NVC_MFC_CHeaderCtrl_s4#1](../vs140/codesnippet/CPP/cheaderctrl-class_16.cpp)]  
  
##  \<a name="cheaderctrl__insertitem">\</a>  CHeaderCtrl::InsertItem  
 Inserts a new item into a header control at the specified index.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  
 The zero-based index of the item to be inserted. If the value is zero, the item is inserted at the beginning of the header control. If the value is greater than the maximum value, the item is inserted at the end of the header control.  
  
 *phdi*  
 Pointer to an                                 [HDITEM](http://msdn.microsoft.com/library/windows/desktop/bb775247) structure that contains information about the item to be inserted.  
  
### Return Value  
 Index of the new item if successful; otherwise – 1.  
  
### Example  
 [!code[NVC_MFC_CHeaderCtrl#12](../vs140/codesnippet/CPP/cheaderctrl-class_17.cpp)]  
  
##  \<a name="cheaderctrl__layout">\</a>  CHeaderCtrl::Layout  
 Retrieves the size and position of a header control within a given rectangle.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 *pHeaderLayout*  
 Pointer to an                                 [HDLAYOUT](http://msdn.microsoft.com/library/windows/desktop/bb775249) structure, which contains information used to set the size and position of a header control.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 This function is used to determine the appropriate dimensions for a new header control that is to occupy the given rectangle.  
  
### Example  
 [!code[NVC_MFC_CHeaderCtrl#13](../vs140/codesnippet/CPP/cheaderctrl-class_18.cpp)]  
  
##  \<a name="cheaderctrl__ordertoindex">\</a>  CHeaderCtrl::OrderToIndex  
 Retrieves the index value for an item based on its order in the header control.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 *nOrder*  
 The zero-based order that the item appears in the header control, from left to right.  
  
### Return Value  
 The index of the item, based on its order in the header control. The index counts from left to right, beginning with 0.  
  
### Remarks  
 This member function implements the behavior of the Win32 macro                         [HDM_ORDERTOINDEX](http://msdn.microsoft.com/library/windows/desktop/bb775355), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. It is provided to support header item ordering.  
  
##  \<a name="cheaderctrl__setbitmapmargin">\</a>  CHeaderCtrl::SetBitmapMargin  
 Sets the width of the margin of a bitmap in a header control.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>  
 Width, specified in pixels, of the margin that surrounds a bitmap within an existing header control.  
  
### Return Value  
 The width of the bitmap margin in pixels.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [HDM_SETBITMAPMARGIN](http://msdn.microsoft.com/library/windows/desktop/bb775357), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_MFC_CHeaderCtrl#14](../vs140/codesnippet/CPP/cheaderctrl-class_19.cpp)]  
  
##  \<a name="cheaderctrl__setfilterchangetimeout">\</a>  CHeaderCtrl::SetFilterChangeTimeout  
 Sets the timeout interval between the time a change takes place in the filter attributes and the posting of an                 [HDN_FILTERCHANGE](http://msdn.microsoft.com/library/windows/desktop/bb775277) notification.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 *dwTimeOut*  
 Timeout value, in milliseconds.  
  
### Return Value  
 The index of the filter control being modified.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [HDM_SETFILTERCHANGETIMEOUT](http://msdn.microsoft.com/library/windows/desktop/bb775359), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_MFC_CHeaderCtrl#15](../vs140/codesnippet/CPP/cheaderctrl-class_20.cpp)]  
  
##  \<a name="cheaderctrl__setfocuseditem">\</a>  CHeaderCtrl::SetFocusedItem  
 Sets the focus to a specified header item in the current header control.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>|Zero-based index of a header item.|  
  
### Return Value  
 <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> if this method is successful; otherwise, <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method sends the                         [HDM_SETFOCUSEDITEM](http://msdn.microsoft.com/library/windows/desktop/bb775361) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 The following code example defines the variable, <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>, that is used to access the current header control. This variable is used in the next example.  
  
 [!code[NVC_MFC_CHeaderCtrl_s4#6](../vs140/codesnippet/CPP/cheaderctrl-class_9.h)]  
  
### Example  
 The following code example demonstrates the <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> methods. In an earlier section of the code, we created a header control with five columns. However, you can drag a column separator so that the column is not visible. The following example sets and then confirms the last column header as the focus item.  
  
 [!code[NVC_MFC_CHeaderCtrl_s4#4](../vs140/codesnippet/CPP/cheaderctrl-class_10.cpp)]  
  
##  \<a name="cheaderctrl__sethotdivider">\</a>  CHeaderCtrl::SetHotDivider  
 Changes the divider between header items to indicate a manual drag and drop of a header item.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>  
 The position of the pointer. The header control highlights the appropriate divider based on the pointer's position.  
  
 <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>  
 The index of the highlighted divider.  
  
### Return Value  
 The index of the highlighted divider.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [HDM_SETHOTDIVIDER](http://msdn.microsoft.com/library/windows/desktop/bb775363), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. It is provided to support header item drag and drop.  
  
### Example  
 [!code[NVC_MFC_CHeaderCtrl#16](../vs140/codesnippet/CPP/cheaderctrl-class_21.cpp)]  
  
##  \<a name="cheaderctrl__setimagelist">\</a>  CHeaderCtrl::SetImageList  
 Assigns an image list to a header control.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> object containing the image list to be assigned to the header control.  
  
### Return Value  
 A pointer to the [CImageList](../vs140/cimagelist-class.md) object previously assigned to the header control.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [HDM_SETIMAGELIST](http://msdn.microsoft.com/library/windows/desktop/bb775365), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. The <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> object to which the returned pointer points is a temporary object and is deleted in the next idle-time processing.  
  
### Example  
  See the example for [CHeaderCtrl::GetImageList](#cheaderctrl__getimagelist).  
  
##  \<a name="cheaderctrl__setitem">\</a>  CHeaderCtrl::SetItem  
 Sets the attributes of the specified item in a header control.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>  
 The zero-based index of the item to be manipulated.  
  
 <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>  
 Pointer to an                                 [HDITEM](http://msdn.microsoft.com/library/windows/desktop/bb775247) structure that contains information about the new item.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Example  
  See the example for [CHeaderCtrl::GetItem](#cheaderctrl__getitem).  
  
##  \<a name="cheaderctrl__setorderarray">\</a>  CHeaderCtrl::SetOrderArray  
 Sets the left-to-right order of items in a header control.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>  
 The number of header control items.  
  
 <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>  
 A pointer to the address of a buffer that receives the index values of the items in the header control, in the order in which they appear from left to right.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 This member function implements the behavior of the Win32 macro                         [HDM_SETORDERARRAY](http://msdn.microsoft.com/library/windows/desktop/bb775369), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. It is provided to support header item ordering.  
  
### Example  
  See the example for [CHeaderCtrl::GetOrderArray](#cheaderctrl__getorderarray).  
  
## See Also  
 [Base Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTabCtrl](../vs140/ctabctrl-class.md)   
 [CListCtrl](../vs140/clistctrl-class.md)   
 [CImageList](../vs140/cimagelist-class.md)