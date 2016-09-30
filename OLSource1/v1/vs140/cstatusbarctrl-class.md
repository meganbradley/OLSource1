---
title: "CStatusBarCtrl Class"
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
  - "CStatusBarCtrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Windows common controls [C++], CStatusBarCtrl"
  - "CStatusBarCtrl class"
  - "status bar controls"
ms.assetid: 8504ad38-7b91-4746-aede-ac98886eb47b
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStatusBarCtrl Class
Provides the functionality of the Windows common status bar control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CStatusBarCtrl::CStatusBarCtrl](#cstatusbarctrl__cstatusbarctrl)|Constructs a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CStatusBarCtrl::Create](#cstatusbarctrl__create)|Creates a status bar control and attaches it to a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object.|  
|[CStatusBarCtrl::CreateEx](#cstatusbarctrl__createex)|Creates a status bar control with the specified Windows extended styles and attaches it to a <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object.|  
|[CStatusBarCtrl::DrawItem](#cstatusbarctrl__drawitem)|Called when a visual aspect of an owner-draw status bar control changes.|  
|[CStatusBarCtrl::GetBorders](#cstatusbarctrl__getborders)|Retrieves the current widths of the horizontal and vertical borders of a status bar control.|  
|[CStatusBarCtrl::GetIcon](#cstatusbarctrl__geticon)|Retrieves the icon for a part (also known as a pane) in the current status bar control.|  
|[CStatusBarCtrl::GetParts](#cstatusbarctrl__getparts)|Retrieves a count of the parts in a status bar control.|  
|[CStatusBarCtrl::GetRect](#cstatusbarctrl__getrect)|Retrieves the bounding rectangle of a part in a status bar control.|  
|[CStatusBarCtrl::GetText](#cstatusbarctrl__gettext)|Retrieves the text from the given part of a status bar control.|  
|[CStatusBarCtrl::GetTextLength](#cstatusbarctrl__gettextlength)|Retrieve the length, in characters, of the text from the given part of a status bar control.|  
|[CStatusBarCtrl::GetTipText](#cstatusbarctrl__gettiptext)|Retrieves the tooltip text for a pane in a status bar.|  
|[CStatusBarCtrl::IsSimple](#cstatusbarctrl__issimple)|Checks a status window control to determine if it is in simple mode.|  
|[CStatusBarCtrl::SetBkColor](#cstatusbarctrl__setbkcolor)|Sets the background color in a status bar.|  
|[CStatusBarCtrl::SetIcon](#cstatusbarctrl__seticon)|Sets the icon for a pane in a status bar.|  
|[CStatusBarCtrl::SetMinHeight](#cstatusbarctrl__setminheight)|Sets the minimum height of a status bar control's drawing area.|  
|[CStatusBarCtrl::SetParts](#cstatusbarctrl__setparts)|Sets the number of parts in a status bar control and the coordinate of the right edge of each part.|  
|[CStatusBarCtrl::SetSimple](#cstatusbarctrl__setsimple)|Specifies whether a status bar control displays simple text or displays all control parts set by a previous call to <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.|  
|[CStatusBarCtrl::SetText](#cstatusbarctrl__settext)|Sets the text in the given part of a status bar control.|  
|[CStatusBarCtrl::SetTipText](#cstatusbarctrl__settiptext)|Sets the tooltip text for a pane in a status bar.|  
  
## Remarks  
 A "status bar control" is a horizontal window, usually displayed at the bottom of a parent window, in which an application can display various kinds of status information. The status bar control can be divided into parts to display more than one type of information.  
  
 This control (and therefore the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> class) is available only to programs running under Windows 95/98 and Windows NT version 3.51 and later.  
  
 For more information on using <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, see [Controls](../vs140/controls--mfc-.md) and [Using CStatusBarCtrl](../vs140/using-cstatusbarctrl.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxcmn.h  
  
##  \<a name="cstatusbarctrl__create">\</a>  CStatusBarCtrl::Create  
 Creates a status bar control and attaches it to a <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 Specifies the status bar control's style. Apply any combination of status bar control styles listed in                                 [Common Control Styles](http://msdn.microsoft.com/library/windows/desktop/bb775498) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. This parameter must include the **WS_CHILD** style. It should also include the **WS_VISIBLE** style.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 Specifies the status bar control's size and position. It can be either a [CRect](../vs140/crect-class.md) object or a                                 [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure.  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 Specifies the status bar control's parent window, usually a <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>. It must not be **NULL.**  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 Specifies the status bar control's ID.  
  
### Return Value  
 Nonzero if successful; otherwise zero.  
  
### Remarks  
 You construct a <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> in two steps. First, call the constructor, and then call **Create**, which creates the status bar control and attaches it to the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> object.  
  
 The default position of a status window is along the bottom of the parent window, but you can specify the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> style to have it appear at the top of the parent window's client area. You can specify the **SBARS_SIZEGRIP** style to include a sizing grip at the right end of the status window. Combining the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> and **SBARS_SIZEGRIP** styles is not recommended, because the resulting sizing grip is not functional even though the system draws it in the status window.  
  
 To create a status bar with extended window styles, call [CStatusBarCtrl::CreateEx](#cstatusbarctrl__createex) instead of **Create**.  
  
### Example  
 [!code[NVC_MFC_CStatusBarCtrl#1](../vs140/codesnippet/CPP/cstatusbarctrl-class_1.cpp)]  
  
##  \<a name="cstatusbarctrl__createex">\</a>  CStatusBarCtrl::CreateEx  
 Creates a control (a child window) and associates it with the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 Specifies the extended style of the control being created. For a list of extended Windows styles, see the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> parameter for                                 [CreateWindowEx](http://msdn.microsoft.com/library/windows/desktop/ms632680) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 Specifies the status bar control's style. Apply any combination of status bar control styles listed in                                 [Common Control Styles](http://msdn.microsoft.com/library/windows/desktop/bb775498) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. This parameter must include the **WS_CHILD** style. It should also include the **WS_VISIBLE** style.  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 A reference to a                                 [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure describing the size and position of the window to be created, in client coordinates of <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 A pointer to the window that is the control's parent.  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 The control's child-window ID.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 Use <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> instead of [Create](#cstatusbarctrl__create) to apply extended Windows styles, specified by the Windows extended style preface **WS_EX_**.  
  
##  \<a name="cstatusbarctrl__cstatusbarctrl">\</a>  CStatusBarCtrl::CStatusBarCtrl  
 Constructs a <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="cstatusbarctrl__drawitem">\</a>  CStatusBarCtrl::DrawItem  
 Called by the framework when a visual aspect of an owner-draw status bar control changes.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 A long pointer to a                                 [DRAWITEMSTRUCT](http://msdn.microsoft.com/library/windows/desktop/bb775802) structure that contains information about the type of drawing required.  
  
### Remarks  
 The **itemAction** member of the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> structure defines the drawing action that is to be performed.  
  
 By default, this member function does nothing. Override this member function to implement drawing for an owner-draw <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> object.  
  
 The application should restore all graphics device interface (GDI) objects selected for the display context supplied in <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> before this member function terminates.  
  
##  \<a name="cstatusbarctrl__getborders">\</a>  CStatusBarCtrl::GetBorders  
 Retrieves the status bar control's current widths of the horizontal and vertical borders and of the space between rectangles.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 *pBorders*  
 Address of an integer array having three elements. The first element receives the width of the horizontal border, the second receives the width of the vertical border, and the third receives the width of the border between rectangles.  
  
 *nHorz*  
 Reference to an integer that receives the width of the horizontal border.  
  
 *nVert*  
 Reference to an integer that receives the width of the vertical border.  
  
 *nSpacing*  
 Reference to an integer that receives the width of the border between rectangles.  
  
### Return Value  
 Nonzero if successful; otherwise zero.  
  
### Remarks  
 These borders determine the spacing between the outside edge of the control and the rectangles within the control that contain text.  
  
### Example  
 [!code[NVC_MFC_CStatusBarCtrl#2](../vs140/codesnippet/CPP/cstatusbarctrl-class_2.cpp)]  
  
##  \<a name="cstatusbarctrl__geticon">\</a>  CStatusBarCtrl::GetIcon  
 Retrieves the icon for a part (also known as a pane) in the current status bar control.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|The zero-based index of the part that contains the icon to be retrieved. If this parameter is -1, the status bar is assumed to be a simple mode status bar.|  
  
### Return Value  
 The handle to the icon if the method successful; otherwise, <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method sends the                         [SB_GETICON](http://msdn.microsoft.com/library/windows/desktop/bb760744) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 A status bar control consists of a row of text output panes, which are also known as parts. For more information about the status bar, see [Status Bar Implementation in MFC](../vs140/status-bar-implementation-in-mfc.md) and [Setting the Mode of a CStatusBarCtrl Object](../vs140/setting-the-mode-of-a-cstatusbarctrl-object.md).  
  
### Example  
 The following code example defines a variable, <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>, that is used to access the current status bar control. This variable is used in the next example.  
  
 [!code[NVC_MFC_CStatusBarCtrl_s1#1](../vs140/codesnippet/CPP/cstatusbarctrl-class_3.h)]  
  
### Example  
 The following code example copies an icon to two panes of the current status bar control. In an earlier section of the code example we created a status bar control with three panes and then added an icon to the first pane. This example retrieves the icon from the first pane and then adds it to the second and third pane.  
  
 [!code[NVC_MFC_CStatusBarCtrl_s1#2](../vs140/codesnippet/CPP/cstatusbarctrl-class_4.cpp)]  
  
##  \<a name="cstatusbarctrl__getparts">\</a>  CStatusBarCtrl::GetParts  
 Retrieves a count of the parts in a status bar control.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 Number of parts for which to retrieve coordinates. If this parameter is greater than the number of parts in the control, the message retrieves coordinates for existing parts only.  
  
 *pParts*  
 Address of an integer array having the same number of elements as the number of parts specified by <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>. Each element in the array receives the client coordinate of the right edge of the corresponding part. If an element is set to – 1, the position of the right edge for that part extends to the right edge of the status bar.  
  
### Return Value  
 The number of parts in the control if successful, or zero otherwise.  
  
### Remarks  
 This member function also retrieves the coordinate of the right edge of the given number of parts.  
  
### Example  
 [!code[NVC_MFC_CStatusBarCtrl#3](../vs140/codesnippet/CPP/cstatusbarctrl-class_5.cpp)]  
  
##  \<a name="cstatusbarctrl__getrect">\</a>  CStatusBarCtrl::GetRect  
 Retrieves the bounding rectangle of a part in a status bar control.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 Zero-based index of the part whose bounding rectangle is to be retrieved.  
  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 Address of a                                 [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure that receives the bounding rectangle.  
  
### Return Value  
 Nonzero if successful; otherwise zero.  
  
### Example  
 [!code[NVC_MFC_CStatusBarCtrl#4](../vs140/codesnippet/CPP/cstatusbarctrl-class_6.cpp)]  
  
##  \<a name="cstatusbarctrl__gettext">\</a>  CStatusBarCtrl::GetText  
 Retrieves the text from the given part of a status bar control.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 Address of the buffer that receives the text. This parameter is a null-terminated string.  
  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 Zero-based index of the part from which to retrieve text.  
  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 Pointer to an integer that receives the type information. The type can be one of these values:  
  
-   **0** The text is drawn with a border to appear lower than the plane of the status bar.  
  
-   <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> The text is drawn without borders.  
  
-   <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> The text is drawn with a border to appear higher than the plane of the status bar.  
  
-   <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> If the text has the <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> drawing type, <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> receives this message and returns the 32-bit value associated with the text instead of the length and operation type.  
  
### Return Value  
 The length, in characters, of the text or a [CString](../vs140/cstringt-class.md) containing the current text.  
  
### Example  
 [!code[NVC_MFC_CStatusBarCtrl#5](../vs140/codesnippet/CPP/cstatusbarctrl-class_7.cpp)]  
  
##  \<a name="cstatusbarctrl__gettextlength">\</a>  CStatusBarCtrl::GetTextLength  
 Retrieves the length, in characters, of the text from the given part of a status bar control.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 Zero-based index of the part from which to retrieve text.  
  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 Pointer to an integer that receives the type information. The type can be one of these values:  
  
-   **0** The text is drawn with a border to appear lower than the plane of the status bar.  
  
-   <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> The text is drawn without borders.  
  
-   <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> The text is drawn by the parent window.  
  
-   <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> The text is drawn with a border to appear higher than the plane of the status bar.  
  
### Return Value  
 The length, in characters, of the text.  
  
### Example  
 [!code[NVC_MFC_CStatusBarCtrl#6](../vs140/codesnippet/CPP/cstatusbarctrl-class_8.cpp)]  
  
##  \<a name="cstatusbarctrl__gettiptext">\</a>  CStatusBarCtrl::GetTipText  
 Retrieves the tooltip text for a pane in a status bar.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
 The zero-based index of status bar pane to receive the tooltip text.  
  
### Return Value  
 A [CString](../vs140/cstringt-class.md) object containing the text to be used in the tooltip.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [SB_GETTIPTEXT](http://msdn.microsoft.com/library/windows/desktop/bb760751), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_MFC_CStatusBarCtrl#7](../vs140/codesnippet/CPP/cstatusbarctrl-class_9.cpp)]  
  
##  \<a name="cstatusbarctrl__issimple">\</a>  CStatusBarCtrl::IsSimple  
 Checks a status window control to determine if it is in simple mode.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the status window control is in simple mode; otherwise zero.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [SB_ISSIMPLE](http://msdn.microsoft.com/library/windows/desktop/bb760753), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cstatusbarctrl__setbkcolor">\</a>  CStatusBarCtrl::SetBkColor  
 Sets the background color in a status bar.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 **COLORREF** value that specifies the new background color. Specify the <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> value to cause the status bar to use its default background color.  
  
### Return Value  
 A                         [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) value that represents the previous default background color.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [SB_SETBKCOLOR](http://msdn.microsoft.com/library/windows/desktop/bb760754), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_MFC_CStatusBarCtrl#8](../vs140/codesnippet/CPP/cstatusbarctrl-class_10.cpp)]  
  
##  \<a name="cstatusbarctrl__seticon">\</a>  CStatusBarCtrl::SetIcon  
 Sets the icon for a pane in a status bar.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
 The zero-based index of the pane that will receive the icon. If this parameter is -1, the status bar is assumed to be a simple status bar.  
  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
 Handle to the icon to be set. If this value is **NULL**, the icon is removed from the part.  
  
### Return Value  
 Nonzero if successful; otherwise zero.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [SB_SETICON](http://msdn.microsoft.com/library/windows/desktop/bb760755), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
  See the example for [CStatusBarCtrl::SetBkColor](#cstatusbarctrl__setbkcolor).  
  
##  \<a name="cstatusbarctrl__setminheight">\</a>  CStatusBarCtrl::SetMinHeight  
 Sets the minimum height of a status bar control's drawing area.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 Minimum height, in pixels, of the control.  
  
### Remarks  
 The minimum height is the sum of <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> and twice the width, in pixels, of the vertical border of the status bar control.  
  
### Example  
 [!code[NVC_MFC_CStatusBarCtrl#9](../vs140/codesnippet/CPP/cstatusbarctrl-class_11.cpp)]  
  
##  \<a name="cstatusbarctrl__setparts">\</a>  CStatusBarCtrl::SetParts  
 Sets the number of parts in a status bar control and the coordinate of the right edge of each part.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 Number of parts to set. The number of parts cannot be greater than 255.  
  
 *pWidths*  
 Address of an integer array having the same number of elements as parts specified by <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>. Each element in the array specifies the position, in client coordinates, of the right edge of the corresponding part. If an element is – 1, the position of the right edge for that part extends to the right edge of the control.  
  
### Return Value  
 Nonzero if successful; otherwise zero.  
  
### Example  
 [!code[NVC_MFC_CStatusBarCtrl#10](../vs140/codesnippet/CPP/cstatusbarctrl-class_12.cpp)]  
  
##  \<a name="cstatusbarctrl__setsimple">\</a>  CStatusBarCtrl::SetSimple  
 Specifies whether a status bar control displays simple text or displays all control parts set by a previous call to [SetParts](#cstatusbarctrl__setparts).  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
 Display-type flag. If this parameter is <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>, the control displays simple text; if it is <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>, it displays multiple parts.  
  
### Return Value  
 Always returns 0.  
  
### Remarks  
 If your application changes the status bar control from non-simple to simple, or vice versa, the system immediately redraws the control.  
  
##  \<a name="cstatusbarctrl__settext">\</a>  CStatusBarCtrl::SetText  
 Sets the text in the given part of a status bar control.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
 Address of a null-terminated string specifying the text to set. If <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> represents 32 bits of data.  
  
 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
 Zero-based index of the part to set. If this value is 255, the status bar control is assumed to be a simple control having only one part.  
  
 <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
 Type of drawing operation. See                                 [SB_SETTEXT message](http://msdn.microsoft.com/library/bb760758\(VS.85\).aspx) for a list of possible values.  
  
### Return Value  
 Nonzero if successful; otherwise zero.  
  
### Remarks  
 The message invalidates the portion of the control that has changed, causing it to display the new text when the control next receives the <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> message.  
  
### Example  
 [!code[NVC_MFC_CStatusBarCtrl#11](../vs140/codesnippet/CPP/cstatusbarctrl-class_13.cpp)]  
  
##  \<a name="cstatusbarctrl__settiptext">\</a>  CStatusBarCtrl::SetTipText  
 Sets the tooltip text for a pane in a status bar.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
 The zero-based index of status bar pane to receive the tooltip text.  
  
 *pszTipText*  
 A pointer to a string containing the tooltip text.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [SB_SETTIPTEXT](http://msdn.microsoft.com/library/windows/desktop/bb760759), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_MFC_CStatusBarCtrl#12](../vs140/codesnippet/CPP/cstatusbarctrl-class_14.cpp)]  
  
## See Also  
 [Base Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBarCtrl](../vs140/ctoolbarctrl-class.md)