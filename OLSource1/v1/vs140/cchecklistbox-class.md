---
title: "CCheckListBox Class"
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
  - "CCheckListBox"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CCheckListBox class"
  - "checklist boxes"
ms.assetid: 1dd78438-00e8-441c-b36f-9c4f9ac0d019
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCheckListBox Class
Provides the functionality of a Windows checklist box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CCheckListBox::CCheckListBox](#cchecklistbox__cchecklistbox)|Constructs a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CCheckListBox::Create](#cchecklistbox__create)|Creates the Windows checklist box and attaches it to the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object.|  
|[CCheckListBox::DrawItem](#cchecklistbox__drawitem)|Called by the framework when a visual aspect of an owner-draw list box changes.|  
|[CCheckListBox::Enable](#cchecklistbox__enable)|Enables or disables a checklist box item.|  
|[CCheckListBox::GetCheck](#cchecklistbox__getcheck)|Gets the state of an item's check box.|  
|[CCheckListBox::GetCheckStyle](#cchecklistbox__getcheckstyle)|Gets the style of the control's check boxes.|  
|[CCheckListBox::IsEnabled](#cchecklistbox__isenabled)|Determines whether an item is enabled.|  
|[CCheckListBox::MeasureItem](#cchecklistbox__measureitem)|Called by the framework when a list box with an owner-draw style is created.|  
|[CCheckListBox::OnGetCheckPosition](#cchecklistbox__ongetcheckposition)|Called by the framework to get the position of an item's check box.|  
|[CCheckListBox::SetCheck](#cchecklistbox__setcheck)|Sets the state of an item's check box.|  
|[CCheckListBox::SetCheckStyle](#cchecklistbox__setcheckstyle)|Sets the style of the control's check boxes.|  
  
## Remarks  
 A "checklist box" displays a list of items, such as filenames. Each item in the list has a check box next to it that the user can check or clear.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is only for owner-drawn controls because the list contains more than text strings. At its simplest, a checklist box contains text strings and check boxes, but you do not need to have text at all. For example, you could have a list of small bitmaps with a check box next to each item.  
  
 To create your own checklist box, you must derive your own class from <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. To derive your own class, write a constructor for the derived class, then call **Create**.  
  
 If you want to handle Windows notification messages sent by a list box to its parent (usually a class derived from [CDialog](../vs140/cdialog-class.md)), add a message-map entry and message-handler member function to the parent class for each message.  
  
 Each message-map entry takes the following form:  
  
 **ON_**Notification **(**<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>**)**  
  
 where <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> specifies the child window ID of the control sending the notification and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is the name of the parent member function you have written to handle the notification.  
  
 The parent's function prototype is as follows:  
  
 **afx_msg** <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> **( );**  
  
 There is only one message-map entry that pertains specifically to **CCheckListBox** (but see also the message-map entries for [CListBox](../vs140/clistbox-class.md)):  
  
-   **ON_CLBN_CHKCHANGE** The user has changed the state of an item's checkbox.  
  
 If your checklist box is a default checklist box (a list of strings with the default-sized checkboxes to the left of each), you can use the default [CCheckListBox::DrawItem](#cchecklistbox__drawitem) to draw the checklist box. Otherwise, you must override the [CListBox::CompareItem](../vs140/clistbox-class.md#clistbox__compareitem) function and the [CCheckListBox::DrawItem](#cchecklistbox__drawitem) and [CCheckListBox::MeasureItem](#cchecklistbox__measureitem) functions.  
  
 You can create a checklist box either from a dialog template or directly in your code.  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CListBox](../vs140/clistbox-class.md)  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxwin.h  
  
##  \<a name="cchecklistbox__cchecklistbox">\</a>  CCheckListBox::CCheckListBox  
 Constructs a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 You construct a <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object in two steps. First define a class derived from <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, then call **Create**, which initializes the Windows checklist box and attaches it to the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object.  
  
### Example  
 [!code[NVC_MFCControlLadenDialog#60](../vs140/codesnippet/CPP/cchecklistbox-class_1.cpp)]  
  
##  \<a name="cchecklistbox__create">\</a>  CCheckListBox::Create  
 Creates the Windows checklist box and attaches it to the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 Specifies the style of the checklist box. The style must be **LBS_HASSTRINGS** and either **LBS_OWNERDRAWFIXED** (all items in the list are the same height) or **LBS_OWNERDRAWVARIABLE** (items in the list are of varying heights). This style can be combined with other [list-box styles](../vs140/list-box-styles.md) except **LBS_USETABSTOPS**.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 Specifies the checklist-box size and position. Can be either a [CRect](../vs140/crect-class.md) object or a [RECT](../vs140/rect-structure.md) structure.  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 Specifies the checklist box's parent window (usually a <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object). It must not be **NULL**.  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 Specifies the checklist box's control ID.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 You construct a <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> object in two steps. First, define a class derived from **CcheckListBox** and then call **Create**, which initializes the Windows checklist box and attaches it to the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>. See [CCheckListBox::CCheckListBox](#cchecklistbox__cchecklistbox) for a sample.  
  
 When **Create** executes, Windows sends the [WM_NCCREATE](../vs140/cwnd-class.md#cwnd__onnccreate), [WM_CREATE](../vs140/cwnd-class.md#cwnd__oncreate), [WM_NCCALCSIZE](../vs140/cwnd-class.md#cwnd__onnccalcsize), and [WM_GETMINMAXINFO](../vs140/cwnd-class.md#cwnd__ongetminmaxinfo) messages to the checklist-box control.  
  
 These messages are handled by default by the [OnNcCreate](../vs140/cwnd-class.md#cwnd__onnccreate), [OnCreate](../vs140/cwnd-class.md#cwnd__oncreate), [OnNcCalcSize](../vs140/cwnd-class.md#cwnd__onnccalcsize), and [OnGetMinMaxInfo](../vs140/cwnd-class.md#cwnd__ongetminmaxinfo) member functions in the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> base class. To extend the default message handling, add a message map to the your derived class and override the preceding message-handler member functions. Override <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, for example, to perform needed initialization for a new class.  
  
 Apply the following [window styles](../vs140/window-styles.md) to a checklist-box control:  
  
-   **WS_CHILD** Always  
  
-   **WS_VISIBLE** Usually  
  
-   **WS_DISABLED** Rarely  
  
-   **WS_VSCROLL** To add a vertical scroll bar  
  
-   **WS_HSCROLL** To add a horizontal scroll bar  
  
-   **WS_GROUP** To group controls  
  
-   **WS_TABSTOP** To allow tabbing to this control  
  
##  \<a name="cchecklistbox__drawitem">\</a>  CCheckListBox::DrawItem  
 Called by the framework when a visual aspect of an owner-drawn checklist box changes.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 A long pointer to a [DRAWITEMSTRUCT](../vs140/drawitemstruct-structure.md) structure that contains information about the type of drawing required.  
  
### Remarks  
 The **itemAction** and **itemState** members of the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> structure define the drawing action that is to be performed.  
  
 By default, this function draws a default checkbox list, consisting of a list of strings each with a default-sized checkbox to the left. The checkbox list size is the one specified in [Create](#cchecklistbox__create).  
  
 Override this member function to implement drawing of owner-draw checklist boxes that are not the default, such as checklist boxes with lists that aren't strings, with variable-height items, or with checkboxes that aren't on the left. The application should restore all graphics device interface (GDI) objects selected for the display context supplied in <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> before the termination of this member function.  
  
 If checklist box items are not all the same height, the checklist box style (specified in **Create**) must be **LBS_OWNERVARIABLE**, and you must override the [MeasureItem](#cchecklistbox__measureitem) function.  
  
##  \<a name="cchecklistbox__enable">\</a>  CCheckListBox::Enable  
 Call this function to enable or disable a checklist box item.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 Index of the checklist box item to be enabled.  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 Specifies whether the item is enabled or disabled.  
  
##  \<a name="cchecklistbox__getcheck">\</a>  CCheckListBox::GetCheck  
 Retrieves the state of the specified check box.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 Zero-based index of a check box that is contained in the list box.  
  
### Return Value  
 The state of the specified check box. The following table lists possible values.  
  
|Value|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|The check box is checked.|  
|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|The check box is not checked.|  
|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|The check box state is indeterminate.|  
  
##  \<a name="cchecklistbox__getcheckstyle">\</a>  CCheckListBox::GetCheckStyle  
 Call this function to get the checklist box's style.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 The style of the control's check boxes.  
  
### Remarks  
 For information on possible styles, see [SetCheckStyle](#cchecklistbox__setcheckstyle).  
  
##  \<a name="cchecklistbox__isenabled">\</a>  CCheckListBox::IsEnabled  
 Call this function to determine whether an item is enabled.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 Index of the item.  
  
### Return Value  
 Nonzero if the item is enabled; otherwise 0.  
  
##  \<a name="cchecklistbox__measureitem">\</a>  CCheckListBox::MeasureItem  
 Called by the framework when a checklist box with a nondefault style is created.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 A long pointer to a [MEASUREITEMSTRUCT](../vs140/measureitemstruct-structure.md) structure.  
  
### Remarks  
 By default, this member function does nothing. Override this member function and fill in the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> structure to inform Windows of the dimensions of checklist-box items. If the checklist box is created with the [LBS_OWNERDRAWVARIABLE](../vs140/list-box-styles.md) style, the framework calls this member function for each item in the list box. Otherwise, this member is called only once.  
  
##  \<a name="cchecklistbox__ongetcheckposition">\</a>  CCheckListBox::OnGetCheckPosition  
 The framework calls this function to get the position and size of the check box in an item.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 *rectItem*  
 The position and size of the list item.  
  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 The default position and size of an item's check box.  
  
### Return Value  
 The position and size of an item's check box.  
  
### Remarks  
 The default implementation only returns the default position and size of the check box ( <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>). By default, a check box is aligned in the upper-left corner of an item and is the standard check box size. There may be cases where you want the check boxes on the right, or want a larger or smaller check box. In these cases, override <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> to change the check box position and size within the item.  
  
##  \<a name="cchecklistbox__setcheck">\</a>  CCheckListBox::SetCheck  
 Sets the state of the specified check box.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 Zero-based index of a check box that is contained in the list box.  
  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 The button state for the specified check box. See the Remarks section for possible values.  
  
### Remarks  
 The following table lists possible values for the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> parameter.  
  
|Value|Description|  
|-----------|-----------------|  
|**BST_CHECKED**|Select the specified check box.|  
|**BST_UNCHECKED**|Clear the specified check box.|  
|**BST_INDETERMINATE**|Set the specified check box state to indeterminate.\<br />\<br /> This state is only available if the check box style is <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>. For more information, see [Button Styles](../vs140/button-styles.md).|  
  
##  \<a name="cchecklistbox__setcheckstyle">\</a>  CCheckListBox::SetCheckStyle  
 Call this function to set the style of check boxes in the checklist box.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 Determines the style of check boxes in the checklist box.  
  
### Remarks  
 Valid styles are:  
  
-   **BS_CHECKBOX**  
  
-   **BS_AUTOCHECKBOX**  
  
-   **BS_AUTO3STATE**  
  
-   **BS_3STATE**  
  
 For information on these styles, see [Button Styles](../vs140/button-styles.md).  
  
## See Also  
 [MFC Sample TSTCON](../vs140/visual-c---samples.md)   
 [Base Class](../vs140/clistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListBox](../vs140/clistbox-class.md)