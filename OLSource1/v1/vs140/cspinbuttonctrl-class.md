---
title: "CSpinButtonCtrl Class"
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
  - "CSpinButtonCtrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Windows common controls [C++], CSpinButtonCtrl"
  - "CSpinButtonCtrl class"
  - "CSpinButtonCtrl class, common controls"
  - "up-down controls, spin button control"
  - "spin button control"
ms.assetid: 509bfd76-1c5a-4af6-973f-e133c0b87734
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSpinButtonCtrl Class
Provides the functionality of the Windows common spin button control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CSpinButtonCtrl::CSpinButtonCtrl](#cspinbuttonctrl__cspinbuttonctrl)|Constructs a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CSpinButtonCtrl::Create](#cspinbuttonctrl__create)|Creates a spin button control and attaches it to a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object.|  
|[CSpinButtonCtrl::CreateEx](#cspinbuttonctrl__createex)|Creates a spin button control with the specified Windows extended styles and attaches it to a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object.|  
|[CSpinButtonCtrl::GetAccel](#cspinbuttonctrl__getaccel)|Retrieves acceleration information for a spin button control.|  
|[CSpinButtonCtrl::GetBase](#cspinbuttonctrl__getbase)|Retrieves the current base for a spin button control.|  
|[CSpinButtonCtrl::GetBuddy](#cspinbuttonctrl__getbuddy)|Retrieves a pointer to the current buddy window.|  
|[CSpinButtonCtrl::GetPos](#cspinbuttonctrl__getpos)|Retrieves the current position of a spin button control.|  
|[CSpinButtonCtrl::GetRange](#cspinbuttonctrl__getrange)|Retrieves the upper and lower limits (range) for a spin button control.|  
|[CSpinButtonCtrl::SetAccel](#cspinbuttonctrl__setaccel)|Sets the acceleration for a spin button control.|  
|[CSpinButtonCtrl::SetBase](#cspinbuttonctrl__setbase)|Sets the base for a spin button control.|  
|[CSpinButtonCtrl::SetBuddy](#cspinbuttonctrl__setbuddy)|Sets the buddy window for a spin button control.|  
|[CSpinButtonCtrl::SetPos](#cspinbuttonctrl__setpos)|Sets the current position for the control.|  
|[CSpinButtonCtrl::SetRange](#cspinbuttonctrl__setrange)|Sets the upper and lower limits (range) for a spin button control.|  
  
## Remarks  
 A "spin button control" (also known as an up-down control) is a pair of arrow buttons that the user can click to increment or decrement a value, such as a scroll position or a number displayed in a companion control. The value associated with a spin button control is called its current position. A spin button control is most often used with a companion control, called a "buddy window."  
  
 This control (and therefore the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> class) is available only to programs running under Windows 95/98 and Windows NT version 3.51 and later.  
  
 To the user, a spin button control and its buddy window often look like a single control. You can specify that a spin button control automatically position itself next to its buddy window, and that it automatically set the caption of the buddy window to its current position. You can use a spin button control with an edit control to prompt the user for numeric input.  
  
 Clicking the up arrow moves the current position toward the maximum, and clicking the down arrow moves the current position toward the minimum. By default, the minimum is 100 and the maximum is 0. Any time the minimum setting is greater than the maximum setting (for example, when the default settings are used), clicking the up arrow decreases the position value and clicking the down arrow increases it.  
  
 A spin button control without a buddy window functions as a sort of simplified scroll bar. For example, a tab control sometimes displays a spin button control to enable the user to scroll additional tabs into view.  
  
 For more information on using <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, see [Controls](../vs140/controls--mfc-.md) and [Using CSpinButtonCtrl](../vs140/using-cspinbuttonctrl.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxcmn.h  
  
##  \<a name="cspinbuttonctrl__create">\</a>  CSpinButtonCtrl::Create  
 Creates a spin button control and attaches it to a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object..  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 Specifies the spin button control's style. Apply any combination of spin button control styles to the control. These styles are described in                                 [Up-Down Control Styles](http://msdn.microsoft.com/library/windows/desktop/bb759885) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 Specifies the spin button control's size and position. It can be either a [CRect](../vs140/crect-class.md) object or a                                 [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 A pointer to the spin button control's parent window, usually a <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. It must not be **NULL.**  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 Specifies the spin button control's ID.  
  
### Return Value  
 Nonzero if initialization was successful; otherwise 0.  
  
### Remarks  
 You construct a <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object in two steps First, call the constructor, and then call **Create**, which creates the spin button control and attaches it to the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object.  
  
 To create a spin button control with extended window styles, call [CSpinButtonCtrl::CreateEx](#cspinbuttonctrl__createex) instead of **Create**.  
  
##  \<a name="cspinbuttonctrl__createex">\</a>  CSpinButtonCtrl::CreateEx  
 Creates a control (a child window) and associates it with the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 Specifies the extended style of the control being created. For a list of extended windows styles, see the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> parameter for                                 [CreateWindowEx](http://msdn.microsoft.com/library/windows/desktop/ms632680) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 Specifies the spin button control's style. Apply any combination of spin button control styles to the control. These styles are described in                                 [Up-Down Control Styles](http://msdn.microsoft.com/library/windows/desktop/bb759885) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 A reference to a                                 [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure describing the size and position of the window to be created, in client coordinates of <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 A pointer to the window that is the control's parent.  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 The control's child-window ID.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 Use <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> instead of [Create](#cspinbuttonctrl__create) to apply extended Windows styles, specified by the Windows extended style preface **WS_EX_**.  
  
##  \<a name="cspinbuttonctrl__cspinbuttonctrl">\</a>  CSpinButtonCtrl::CSpinButtonCtrl  
 Constructs a <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="cspinbuttonctrl__getaccel">\</a>  CSpinButtonCtrl::GetAccel  
 Retrieves acceleration information for a spin button control.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 Number of elements in the array specified by <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 Pointer to an array of                                 [UDACCEL](http://msdn.microsoft.com/library/windows/desktop/bb759897) structures that receives acceleration information.  
  
### Return Value  
 Number of accelerator structures retrieved.  
  
##  \<a name="cspinbuttonctrl__getbase">\</a>  CSpinButtonCtrl::GetBase  
 Retrieves the current base for a spin button control.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 The current base value.  
  
##  \<a name="cspinbuttonctrl__getbuddy">\</a>  CSpinButtonCtrl::GetBuddy  
 Retrieves a pointer to the current buddy window.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the current buddy window.  
  
##  \<a name="cspinbuttonctrl__getpos">\</a>  CSpinButtonCtrl::GetPos  
 Retrieves the current position of a spin button control.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 *lpbError*  
 A pointer to a boolean value that is set to zero if the value is successfully retrieved or non-zero if an error occurs. If this parameter is set to **NULL**, errors are not reported.  
  
### Return Value  
 The first version returns the 16-bit current position in the low-order word. The high-order word is nonzero if an error occurred.  
  
 The second version returns the 32-bit position.  
  
### Remarks  
 When it processes the value returned, the control updates its current position based on the caption of the buddy window. The control returns an error if there is no buddy window or if the caption specifies an invalid or out-of-range value.  
  
##  \<a name="cspinbuttonctrl__getrange">\</a>  CSpinButtonCtrl::GetRange  
 Retrieves the upper and lower limits (range) for a spin button control.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 *lower*  
 Reference to an integer that receives the lower limit for the control.  
  
 *upper*  
 Reference to an integer that receives the upper limit for the control.  
  
### Return Value  
 The first version returns a 32-bit value containing the upper and lower limits. The low-order word is the upper limit for the control, and the high-order word is the lower limit.  
  
### Remarks  
 The member function <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> retrieves the spin button control's range as a 32-bit integer.  
  
##  \<a name="cspinbuttonctrl__setaccel">\</a>  CSpinButtonCtrl::SetAccel  
 Sets the acceleration for a spin button control.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 Number of                                 [UDACCEL](http://msdn.microsoft.com/library/windows/desktop/bb759897) structures specified by <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 Pointer to an array of <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> structures, which contain acceleration information. Elements should be sorted in ascending order based on the **nSec** member.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
##  \<a name="cspinbuttonctrl__setbase">\</a>  CSpinButtonCtrl::SetBase  
 Sets the base for a spin button control.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 New base value for the control. It can be 10 for decimal or 16 for hexadecimal.  
  
### Return Value  
 The previous base value if successful, or zero if an invalid base is given.  
  
### Remarks  
 The base value determines whether the buddy window displays numbers in decimal or hexadecimal digits. Hexadecimal numbers are always unsigned; decimal numbers are signed.  
  
##  \<a name="cspinbuttonctrl__setbuddy">\</a>  CSpinButtonCtrl::SetBuddy  
 Sets the buddy window for a spin button control.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 Pointer to the new buddy window.  
  
### Return Value  
 A pointer to the previous buddy window.  
  
### Remarks  
 A spin control is almost always associated with another window, such as an edit control, that displays some content. This other window is called the "buddy" of the spin control.  
  
##  \<a name="cspinbuttonctrl__setpos">\</a>  CSpinButtonCtrl::SetPos  
 Sets the current position for a spin button control.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 New position for the control. This value must be in the range specified by the upper and lower limits for the control.  
  
### Return Value  
 The previous position (16-bit precision for <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>, 32-bit precision for <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>).  
  
### Remarks  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> sets the 32-bit position.  
  
##  \<a name="cspinbuttonctrl__setrange">\</a>  CSpinButtonCtrl::SetRange  
 Sets the upper and lower limits (range) for a spin button control.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>and <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 Upper and lower limits for the control. For <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>, neither limit can be greater than **UD_MAXVAL** or less than **UD_MINVAL**; in addition, the difference between the two limits cannot exceed **UD_MAXVAL**. <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> places no restrictions on the limits; use any integers.  
  
### Remarks  
 The member function <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> sets the 32-bit range for the spin button control.  
  
> [!NOTE]
>  The default range for the spin button has the maximum set to zero (0) and the minimum set to 100. Because the maximum value is less than the minimum value, clicking the up arrow will decrease the position and clicking the down arrow will increase it. Use <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> to adjust these values.  
  
## See Also  
 [MFC Sample CMNCTRL2](../vs140/visual-c---samples.md)   
 [Base Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSliderCtrl](../vs140/csliderctrl-class.md)