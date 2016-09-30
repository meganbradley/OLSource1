---
title: "CPagerCtrl Class"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CPagerCtrl class"
ms.assetid: 65ac58dd-4f5e-4b7e-b15c-e0d435a7e884
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPagerCtrl Class
The <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> class wraps the Windows pager control, which can scroll into view a contained window that does not fit the containing window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CPagerCtrl::CPagerCtrl](#cpagerctrl__cpagerctrl)|Constructs a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CPagerCtrl::Create](#cpagerctrl__create)|Creates a pager control with specified styles and attaches it to the current <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object.|  
|[CPagerCtrl::CreateEx](#cpagerctrl__createex)|Creates a pager control with specified extended styles and attaches it to the current <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object.|  
|[CPagerCtrl::ForwardMouse](#cpagerctrl__forwardmouse)|Enables or disables forwarding                                         [WM_MOUSEMOVE](http://msdn.microsoft.com/library/windows/desktop/ms645616) messages to the window that is contained in the current pager control.|  
|[CPagerCtrl::GetBkColor](#cpagerctrl__getbkcolor)|Retrieves the background color of the current pager control.|  
|[CPagerCtrl::GetBorder](#cpagerctrl__getborder)|Retrieves the border size of the current pager control.|  
|[CPagerCtrl::GetButtonSize](#cpagerctrl__getbuttonsize)|Retrieves the button size of the current pager control.|  
|[CPagerCtrl::GetButtonState](#cpagerctrl__getbuttonstate)|Retrieves the state of the specified button in the current pager control.|  
|[CPagerCtrl::GetDropTarget](#cpagerctrl__getdroptarget)|Retrieves the                                         [IDropTarget](http://msdn.microsoft.com/library/windows/desktop/ms679679) interface for the current pager control.|  
|[CPagerCtrl::GetScrollPos](#cpagerctrl__getscrollpos)|Retrieves the scroll position of the current pager control.|  
|[CPagerCtrl::IsButtonDepressed](#cpagerctrl__isbuttondepressed)|Indicates whether the specified button of the current pager control is in <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> state.|  
|[CPagerCtrl::IsButtonGrayed](#cpagerctrl__isbuttongrayed)|Indicates whether the specified button of the current pager control is in <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> state.|  
|[CPagerCtrl::IsButtonHot](#cpagerctrl__isbuttonhot)|Indicates whether the specified button of the current pager control is in <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> state.|  
|[CPagerCtrl::IsButtonInvisible](#cpagerctrl__isbuttoninvisible)|Indicates whether the specified button of the current pager control is in <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> state.|  
|[CPagerCtrl::IsButtonNormal](#cpagerctrl__isbuttonnormal)|Indicates whether the specified button of the current pager control is in <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> state.|  
|[CPagerCtrl::RecalcSize](#cpagerctrl__recalcsize)|Causes the current pager control to recalculate the size of the contained window.|  
|[CPagerCtrl::SetBkColor](#cpagerctrl__setbkcolor)|Sets the background color of the current pager control.|  
|[CPagerCtrl::SetBorder](#cpagerctrl__setborder)|Sets the border size of the current pager control.|  
|[CPagerCtrl::SetButtonSize](#cpagerctrl__setbuttonsize)|Sets the button size of the current pager control.|  
|[CPagerCtrl::SetChild](#cpagerctrl__setchild)|Sets the contained window for the current pager control.|  
|[CPagerCtrl::SetScrollPos](#cpagerctrl__setscrollpos)|Sets the scroll position of the current pager control.|  
  
## Remarks  
 A pager control is a window that contains another window that is linear and larger than the containing window, and enables you to scroll the contained window into view. The pager control displays two scroll buttons that automatically disappear when the contained window is scrolled to its farthest extent, and reappear otherwise. You can create a pager control that scrolls either horizontally or vertically.  
  
 For example, if your application has a toolbar that is not wide enough to show all of its items, you can assign the toolbar to a pager control and users will be able to scroll the toolbar to the left or right to access all of the items. Microsoft Internet Explorer Version 4.0 (commctrl.dll version 4.71) introduces the pager control.  
  
 The <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> class is derived from the [CWnd](../vs140/cwnd-class.md) class. For more information and an illustration of a pager control, see                 [Pager Controls](http://msdn.microsoft.com/library/windows/desktop/bb760855).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxcmn.h  
  
##  \<a name="cpagerctrl__cpagerctrl">\</a>  CPagerCtrl::CPagerCtrl  
 Constructs a <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 Use the [CPagerCtrl::Create](#cpagerctrl__create) or [CPagerCtrl::CreateEx](#cpagerctrl__createex) method to create a pager control and attach it to the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> object.  
  
##  \<a name="cpagerctrl__create">\</a>  CPagerCtrl::Create  
 Creates a pager control with specified styles and attaches it to the current <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|A bitwise combination (OR) of [window styles](../vs140/window-styles.md) and                                         [pager control styles](http://msdn.microsoft.com/library/windows/desktop/bb760859) to be applied to the control.|  
|[in] <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|A reference to a                                         [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure that contains the position and size of the control in client coordinates.|  
|[in] <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|A pointer to a [CWnd](../vs140/cwnd-class.md) object that is the parent window of the control. This parameter cannot be <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>.|  
|[in] <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|The ID of the control.|  
  
### Return Value  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> if this method is successful; otherwise, <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>.  
  
### Remarks  
 To create a pager control, declare a <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> variable, then call the [CPagerCtrl::Create](#cpagerctrl__create) or [CPagerCtrl::CreateEx](#cpagerctrl__createex) method on that variable.  
  
### Example  
 The following example creates a pager control, then uses the [CPagerCtrl::SetChild](#cpagerctrl__setchild) method to associate a very long button control with the pager control. The example then uses the [CPagerCtrl::SetButtonSize](#cpagerctrl__setbuttonsize) method to set the height of the pager control to 20 pixels, and the [CPagerCtrl::SetBorder](#cpagerctrl__setborder) method to set the border thickness to 1 pixel.  
  
 [!code[NVC_MFC_CSplitButton_s2#1](../vs140/codesnippet/CPP/cpagerctrl-class_1.cpp)]  
  
##  \<a name="cpagerctrl__createex">\</a>  CPagerCtrl::CreateEx  
 Creates a pager control with specified extended styles and attaches it to the current <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|A bitwise combination of extended styles to be applied to the control. For more information, see the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> parameter of the                                         [CreateWindowEx](http://msdn.microsoft.com/library/windows/desktop/ms632680) function.|  
|[in] <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|A bitwise combination (OR) of [window styles](../vs140/window-styles.md) and                                         [pager control styles](http://msdn.microsoft.com/library/windows/desktop/bb760859) to be applied to the control.|  
|[in] <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|A reference to a                                         [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure that contains the position and size of the control in client coordinates.|  
|[in] <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|A pointer to a [CWnd](../vs140/cwnd-class.md) object that is the parent window of the control. This parameter cannot be <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>.|  
|[in] <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|The ID of the control.|  
  
### Return Value  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> if this method is successful; otherwise, <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>.  
  
### Remarks  
 To create a pager control, declare a <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> variable, then call the [CPagerCtrl::Create](#cpagerctrl__create) or [CPagerCtrl::CreateEx](#cpagerctrl__createex) method on that variable.  
  
##  \<a name="cpagerctrl__forwardmouse">\</a>  CPagerCtrl::ForwardMouse  
 Enables or disables forwarding                 [WM_MOUSEMOVE](http://msdn.microsoft.com/library/windows/desktop/ms645616) messages to the window that is contained in the current pager control.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>56\</CodeContentPlaceHolder> to forward mouse messages, or <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> to not forward mouse messages.|  
  
### Remarks  
 This method sends the                         [PGM_FORWARDMOUSE](http://msdn.microsoft.com/library/windows/desktop/bb760867) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cpagerctrl__getborder">\</a>  CPagerCtrl::GetBorder  
 Retrieves the border size of the current pager control.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 The current border size, measured in pixels.  
  
### Remarks  
 This method sends the                         [PGM_GETBORDER](http://msdn.microsoft.com/library/windows/desktop/bb760869) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 The following example uses the [CPagerCtrl::GetBorder](#cpagerctrl__getborder) method to retrieve the thickness of the pager control's border.  
  
 [!code[NVC_MFC_CSplitButton_s2#5](../vs140/codesnippet/CPP/cpagerctrl-class_2.cpp)]  
  
##  \<a name="cpagerctrl__getbkcolor">\</a>  CPagerCtrl::GetBkColor  
 Retrieves the background color of the current pager control.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 A                         [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) value that contains the current background color of the pager control.  
  
### Remarks  
 This method sends the                         [PGM_GETBKCOLOR](http://msdn.microsoft.com/library/windows/desktop/bb760868) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 The following example uses the [CPagerCtrl::SetBkColor](#cpagerctrl__setbkcolor) method to set the background color of the pager control to red, and the [CPagerCtrl::GetBkColor](#cpagerctrl__getbkcolor) method to confirm that the change was made.  
  
 [!code[NVC_MFC_CSplitButton_s2#4](../vs140/codesnippet/CPP/cpagerctrl-class_3.cpp)]  
  
##  \<a name="cpagerctrl__getbuttonsize">\</a>  CPagerCtrl::GetButtonSize  
 Retrieves the button size of the current pager control.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 The current button size, measured in pixels.  
  
### Remarks  
 This method sends the                         [PGM_GETBUTTONSIZE](http://msdn.microsoft.com/library/windows/desktop/bb760870) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 If the pager control has the <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> style, the button size determines the width of the pager buttons, and if the pager control has the <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> style, the button size determines the height of the pager buttons. For more information, see                         [Pager Control Styles](http://msdn.microsoft.com/library/windows/desktop/bb760859).  
  
##  \<a name="cpagerctrl__getbuttonstate">\</a>  CPagerCtrl::GetButtonState  
 Retrieves the state of the specified scroll button in the current pager control.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>|Indicates the button for which the state is retrieved. If the pager control style is <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>, specify <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> for the left button and <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> for the right button. If the pager control style is <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>, specify <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> for the top button and <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> for the bottom button. For more information, see                                         [Pager Control Styles](http://msdn.microsoft.com/library/windows/desktop/bb760859).|  
  
### Return Value  
 The state of the button specified by the <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> parameter. The state is either <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>. For more information, see the Return Value section of the                         [PGM_GETBUTTONSTATE](http://msdn.microsoft.com/library/windows/desktop/bb760871) message.  
  
### Remarks  
 This method sends the                         [PGM_GETBUTTONSTATE](http://msdn.microsoft.com/library/windows/desktop/bb760871) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cpagerctrl__getdroptarget">\</a>  CPagerCtrl::GetDropTarget  
 Retrieves the                 [IDropTarget](http://msdn.microsoft.com/library/windows/desktop/ms679679) interface for the current pager control.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> interface for the current pager control.  
  
### Remarks  
 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> is one of the interfaces you implement to support drag-and-drop operations in your application.  
  
 This method sends the                         [PGM_GETDROPTARGET](http://msdn.microsoft.com/library/windows/desktop/bb760872) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. The caller of this method is responsible for calling the <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> member of the                         [IDropTarget](http://msdn.microsoft.com/library/windows/desktop/ms679679) interface when the interface is no longer needed.  
  
##  \<a name="cpagerctrl__getscrollpos">\</a>  CPagerCtrl::GetScrollPos  
 Retrieves the scroll position of the current pager control.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 The current scroll position, measured in pixels.  
  
### Remarks  
 This method sends the                         [PGM_GETPOS](http://msdn.microsoft.com/library/windows/desktop/bb760874) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 The following example uses the [CPagerCtrl::GetScrollPos](#cpagerctrl__getscrollpos) method to retrieve the current scroll position of the pager control. If the pager control is not already scrolled to zero, the leftmost position, the example uses the [CPagerCtrl::SetScrollPos](#cpagerctrl__setscrollpos) method to set the scroll position to zero.  
  
 [!code[NVC_MFC_CSplitButton_s2#7](../vs140/codesnippet/CPP/cpagerctrl-class_4.cpp)]  
  
##  \<a name="cpagerctrl__isbuttondepressed">\</a>  CPagerCtrl::IsButtonDepressed  
 Indicates whether the specified scroll button of the current pager control is in pressed state.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>|Indicates the button for which the state is retrieved. If the pager control style is <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>, specify <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> for the left button and <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> for the right button. If the pager control style is <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>, specify <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> for the top button and <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> for the bottom button. For more information, see                                         [Pager Control Styles](http://msdn.microsoft.com/library/windows/desktop/bb760859).|  
  
### Return Value  
 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> if the specified button is in pressed state; otherwise, <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method sends the                         [PGM_GETBUTTONSTATE](http://msdn.microsoft.com/library/windows/desktop/bb760871) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. It then tests whether the state that is returned is <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>. For more information, see the Return Value section of the                         [PGM_GETBUTTONSTATE](http://msdn.microsoft.com/library/windows/desktop/bb760871) message.  
  
##  \<a name="cpagerctrl__isbuttongrayed">\</a>  CPagerCtrl::IsButtonGrayed  
 Indicates whether the specified scroll button of the current pager control is in grayed state.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>|Indicates the button for which the state is retrieved. If the pager control style is <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>, specify <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> for the left button and <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> for the right button. If the pager control style is <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>, specify <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> for the top button and <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> for the bottom button. For more information, see                                         [Pager Control Styles](http://msdn.microsoft.com/library/windows/desktop/bb760859).|  
  
### Return Value  
 <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> if the specified button is in grayed state; otherwise, <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method sends the                         [PGM_GETBUTTONSTATE](http://msdn.microsoft.com/library/windows/desktop/bb760871) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. It then tests whether the state that is returned is <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>. For more information, see the Return Value section of the                         [PGM_GETBUTTONSTATE](http://msdn.microsoft.com/library/windows/desktop/bb760871) message.  
  
##  \<a name="cpagerctrl__isbuttonhot">\</a>  CPagerCtrl::IsButtonHot  
 Indicates whether the specified scroll button of the current pager control is in hot state.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>|Indicates the button for which the state is retrieved. If the pager control style is <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>, specify <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> for the left button and <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> for the right button. If the pager control style is <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>, specify <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> for the top button and <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> for the bottom button. For more information, see                                         [Pager Control Styles](http://msdn.microsoft.com/library/windows/desktop/bb760859).|  
  
### Return Value  
 <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> if the specified button is in hot state; otherwise, <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method sends the                         [PGM_GETBUTTONSTATE](http://msdn.microsoft.com/library/windows/desktop/bb760871) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. It then tests whether the state that is returned is <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>. For more information, see the Return Value section of the                         [PGM_GETBUTTONSTATE](http://msdn.microsoft.com/library/windows/desktop/bb760871) message.  
  
##  \<a name="cpagerctrl__isbuttoninvisible">\</a>  CPagerCtrl::IsButtonInvisible  
 Indicates whether the specified scroll button of the current pager control is in invisible state.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>|Indicates the button for which the state is retrieved. If the pager control style is <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>, specify <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> for the left button and <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> for the right button. If the pager control style is <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>, specify <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> for the top button and <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> for the bottom button. For more information, see                                         [Pager Control Styles](http://msdn.microsoft.com/library/windows/desktop/bb760859).|  
  
### Return Value  
 <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> if the specified button is in invisible state; otherwise, <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>.  
  
### Remarks  
 Windows makes the scroll button in a particular direction invisible when the contained window is scrolled to its farthest extent because clicking the button further cannot bring more of the contained window into view.  
  
 This method sends the                         [PGM_GETBUTTONSTATE](http://msdn.microsoft.com/library/windows/desktop/bb760871) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. It then tests whether the state that is returned is <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>. For more information, see the Return Value section of the                         [PGM_GETBUTTONSTATE](http://msdn.microsoft.com/library/windows/desktop/bb760871) message.  
  
### Example  
 The following example uses the [CPagerCtrl::IsButtonInvisible](#cpagerctrl__isbuttoninvisible) method to determine whether the pager control's left and right scroll buttons are visible.  
  
 [!code[NVC_MFC_CSplitButton_s2#6](../vs140/codesnippet/CPP/cpagerctrl-class_5.cpp)]  
  
##  \<a name="cpagerctrl__isbuttonnormal">\</a>  CPagerCtrl::IsButtonNormal  
 Indicates whether the specified scroll button of the current pager control is in normal state.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>|Indicates the button for which the state is retrieved. If the pager control style is <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>, specify <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> for the left button and <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> for the right button. If the pager control style is <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>, specify <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> for the top button and <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> for the bottom button. For more information, see                                         [Pager Control Styles](http://msdn.microsoft.com/library/windows/desktop/bb760859).|  
  
### Return Value  
 <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> if the specified button is in normal state; otherwise, <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method sends the                         [PGM_GETBUTTONSTATE](http://msdn.microsoft.com/library/windows/desktop/bb760871) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. It then tests whether the state that is returned is <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>. For more information, see the Return Value section of the                         [PGM_GETBUTTONSTATE](http://msdn.microsoft.com/library/windows/desktop/bb760871) message.  
  
##  \<a name="cpagerctrl__recalcsize">\</a>  CPagerCtrl::RecalcSize  
 Causes the current pager control to recalculate the size of the contained window.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Remarks  
 This method sends the                         [PGM_RECALCSIZE](http://msdn.microsoft.com/library/windows/desktop/bb760876) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. Consequently, the pager control sends the                         [PGN_CALCSIZE](http://msdn.microsoft.com/library/windows/desktop/bb760864) notification to obtain the scrollable dimensions of the contained window.  
  
### Example  
 The following example uses the [CPagerCtrl::RecalcSize](#cpagerctrl__recalcsize) method to request the current pager control to recalculate its size.  
  
 [!code[NVC_MFC_CSplitButton_s2#3](../vs140/codesnippet/CPP/cpagerctrl-class_6.cpp)]  
  
### Example  
 The following example uses [message reflection](../vs140/tn062--message-reflection-for-windows-controls.md) to enable the pager control to recalculate its own size instead of requiring the control's parent dialog to perform the calculation. The example derives the <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> class from the [CPagerCtrl class](../vs140/cpagerctrl-class.md), then uses a message map to associate the                                 [PGN_CALCSIZE](http://msdn.microsoft.com/library/windows/desktop/bb760864) notification with the <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> notification handler. In this example, the notification handler sets the width and height of the pager control to fixed values.  
  
 [!code[NVC_MFC_CSplitButton_s2#8](../vs140/codesnippet/CPP/cpagerctrl-class_7.cpp)]  
  
##  \<a name="cpagerctrl__setbkcolor">\</a>  CPagerCtrl::SetBkColor  
 Sets the background color of the current pager control.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>|A                                         [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) value that contains the new background color of the pager control.|  
  
### Return Value  
 A                         [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) value that contains the previous background color of the pager control.  
  
### Remarks  
 This method sends the                         [PGM_SETBKCOLOR](http://msdn.microsoft.com/library/windows/desktop/bb760878) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 The following example uses the [CPagerCtrl::SetBkColor](#cpagerctrl__setbkcolor) method to set the background color of the pager control to red, and the [CPagerCtrl::GetBkColor](#cpagerctrl__getbkcolor) method to confirm that the change was made.  
  
 [!code[NVC_MFC_CSplitButton_s2#4](../vs140/codesnippet/CPP/cpagerctrl-class_3.cpp)]  
  
##  \<a name="cpagerctrl__setborder">\</a>  CPagerCtrl::SetBorder  
 Sets the border size of the current pager control.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>|The new border size, measured in pixels. If the <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> parameter is negative, the border size is set to zero.|  
  
### Return Value  
 The previous border size, measured in pixels.  
  
### Remarks  
 This method sends the                         [PGM_SETBORDER](http://msdn.microsoft.com/library/windows/desktop/bb760880) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 The following example creates a pager control, then uses the [CPagerCtrl::SetChild](#cpagerctrl__setchild) method to associate a very long button control with the pager control. The example then uses the [CPagerCtrl::SetButtonSize](#cpagerctrl__setbuttonsize) method to set the height of the pager control to 20 pixels, and the [CPagerCtrl::SetBorder](#cpagerctrl__setborder) method to set the border thickness to 1 pixel.  
  
 [!code[NVC_MFC_CSplitButton_s2#1](../vs140/codesnippet/CPP/cpagerctrl-class_1.cpp)]  
  
##  \<a name="cpagerctrl__setbuttonsize">\</a>  CPagerCtrl::SetButtonSize  
 Sets the button size of the current pager control.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>|The new button size, measured in pixels.|  
  
### Return Value  
 The previous button size, measured in pixels.  
  
### Remarks  
 This method sends the                         [PGM_SETBUTTONSIZE](http://msdn.microsoft.com/library/windows/desktop/bb760886) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 If the pager control has the <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> style, the button size determines the width of the pager buttons, and if the pager control has the <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> style, the button size determines the height of the pager buttons. The default button size is three-fourths of the width of the scroll bar, and the minimum button size is 12 pixels. For more information, see                         [Pager Control Styles](http://msdn.microsoft.com/library/windows/desktop/bb760859).  
  
### Example  
 The following example creates a pager control, then uses the [CPagerCtrl::SetChild](#cpagerctrl__setchild) method to associate a very long button control with the pager control. The example then uses the [CPagerCtrl::SetButtonSize](#cpagerctrl__setbuttonsize) method to set the height of the pager control to 20 pixels, and the [CPagerCtrl::SetBorder](#cpagerctrl__setborder) method to set the border thickness to 1 pixel.  
  
 [!code[NVC_MFC_CSplitButton_s2#1](../vs140/codesnippet/CPP/cpagerctrl-class_1.cpp)]  
  
##  \<a name="cpagerctrl__setchild">\</a>  CPagerCtrl::SetChild  
 Sets the contained window for the current pager control.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>|Handle to the window to be contained.|  
  
### Remarks  
 This method sends the                         [PGM_SETCHILD](http://msdn.microsoft.com/library/windows/desktop/bb760884) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 This method does not change the parent of the contained window; it only assigns a window handle to the pager control for scrolling. In most cases, the contained window will be a child window of the pager control.  
  
### Example  
 The following example creates a pager control, then uses the [CPagerCtrl::SetChild](#cpagerctrl__setchild) method to associate a very long button control with the pager control. The example then uses the [CPagerCtrl::SetButtonSize](#cpagerctrl__setbuttonsize) method to set the height of the pager control to 20 pixels, and the [CPagerCtrl::SetBorder](#cpagerctrl__setborder) method to set the border thickness to 1 pixel.  
  
 [!code[NVC_MFC_CSplitButton_s2#1](../vs140/codesnippet/CPP/cpagerctrl-class_1.cpp)]  
  
##  \<a name="cpagerctrl__setscrollpos">\</a>  CPagerCtrl::SetScrollPos  
 Sets the scroll position of the current pager control.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>|The new scroll position, measured in pixels.|  
  
### Remarks  
 This method sends the                         [PGM_SETPOS](http://msdn.microsoft.com/library/windows/desktop/bb760886) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## See Also  
 [CPagerCtrl Class](../vs140/cpagerctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Pager Controls](http://msdn.microsoft.com/library/windows/desktop/bb760855)