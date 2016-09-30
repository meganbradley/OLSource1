---
title: "CControlBar Class"
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
  - "CControlBar"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CControlBar class"
  - "OLE resize bars"
  - "OLE resize bars, base class"
  - "dialog bars, base class"
  - "toolbars [C++], base class"
  - "control bars [C++], base class"
  - "status bars, base class"
ms.assetid: 4d668c55-9b42-4838-97ac-cf2b3000b82c
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CControlBar Class
The base class for the control-bar classes [CStatusBar](../vs140/cstatusbar-class.md), [CToolBar](../vs140/ctoolbar-class.md), [CDialogBar](../vs140/cdialogbar-class.md), [CReBar](../vs140/crebar-class.md), and [COleResizeBar](../vs140/coleresizebar-class.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Protected Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CControlBar::CControlBar](#ccontrolbar__ccontrolbar)|Constructs a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CControlBar::CalcDynamicLayout](#ccontrolbar__calcdynamiclayout)|Returns the size of a dynamic control bar as a [CSize](../vs140/csize-class.md) object.|  
|[CControlBar::CalcFixedLayout](#ccontrolbar__calcfixedlayout)|Returns the size of the control bar as a [CSize](../vs140/csize-class.md) object.|  
|[CControlBar::CalcInsideRect](#ccontrolbar__calcinsiderect)|Returns the current dimensions of the control bar area; including the borders.|  
|[CControlBar::DoPaint](#ccontrolbar__dopaint)|Renders the borders and gripper of the control bar.|  
|[CControlBar::DrawBorders](#ccontrolbar__drawborders)|Renders the borders of the control bar.|  
|[CControlBar::DrawGripper](#ccontrolbar__drawgripper)|Renders the gripper of the control bar.|  
|[CControlBar::EnableDocking](#ccontrolbar__enabledocking)|Allows a control bar to be docked or floating.|  
|[CControlBar::GetBarStyle](#ccontrolbar__getbarstyle)|Retrieves the control bar style settings.|  
|[CControlBar::GetBorders](#ccontrolbar__getborders)|Retrieves the border values of the control bar.|  
|[CControlBar::GetCount](#ccontrolbar__getcount)|Returns the number of non- <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> elements in the control bar.|  
|[CControlBar::GetDockingFrame](#ccontrolbar__getdockingframe)|Returns a pointer to the frame to which a control bar is docked.|  
|[CControlBar::IsFloating](#ccontrolbar__isfloating)|Returns a nonzero value if the control bar in question is a floating control bar.|  
|[CControlBar::OnUpdateCmdUI](#ccontrolbar__onupdatecmdui)|Calls the Command UI handlers.|  
|[CControlBar::SetBarStyle](#ccontrolbar__setbarstyle)|Modifies the control bar style settings.|  
|[CControlBar::SetBorders](#ccontrolbar__setborders)|Sets the border values of the control bar.|  
|[CControlBar::SetInPlaceOwner](#ccontrolbar__setinplaceowner)|Changes the in-place owner of a control bar.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CControlBar::m_bAutoDelete](#ccontrolbar__m_bautodelete)|If nonzero, the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object is deleted when the Windows control bar is destroyed.|  
|[CControlBar::m_pInPlaceOwner](#ccontrolbar__m_pinplaceowner)|The in-place owner of the control bar.|  
  
## Remarks  
 A control bar is a window that is usually aligned to the left or right of a frame window. It may contain child items that are either <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>-based controls, which are windows that generate and respond to Windows messages, or non- <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>-based items, which are not windows and are managed by application code or framework code. List boxes and edit controls are examples of <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>-based controls; status-bar panes and bitmap buttons are examples of non- <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>-based controls.  
  
 Control-bar windows are usually child windows of a parent frame window and are usually siblings to the client view or MDI client of the frame window. A <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object uses information about the parent window's client rectangle to position itself. It then informs the parent window as to how much space remains unallocated in the parent window's client area.  
  
 For more information on <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, see:  
  
-   [Control Bars](../vs140/control-bars.md)  
  
-   [Technical Note 31: Control Bars](../vs140/tn031--control-bars.md).  
  
-   Knowledge Base article Q242577 : PRB: Update Command UI Handlers Do Not Work for Menu Attached to a Dialog Box  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxext.h  
  
##  \<a name="ccontrolbar__calcdynamiclayout">\</a>  CControlBar::CalcDynamicLayout  
 The framework calls this member function to calculate the dimensions of a dynamic toolbar.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 The requested dimension of the control bar, either horizontal or vertical, depending on <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 The following predefined flags are used to determine the height and width of the dynamic control bar. Use the bitwise-OR (&#124;) operator to combine the flags.  
  
|Layout mode flags|What it means|  
|-----------------------|-------------------|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|Indicates whether the control bar should be stretched to the size of the frame. Set if the bar is not a docking bar (not available for docking). Not set when the bar is docked or floating (available for docking). If set, <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> ignores <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> and returns dimensions based on the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> state. <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> works similarly to the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> parameter used in [CalcFixedLayout](#ccontrolbar__calcfixedlayout); see that member function for more information about the relationship between stretching and orientation.|  
|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|Indicates that the bar is horizontally or vertically oriented. Set if the bar is horizontally oriented, and if it is vertically oriented, it is not set. <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> works similarly to the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> parameter used in [CalcFixedLayout](#ccontrolbar__calcfixedlayout); see that member function for more information about the relationship between stretching and orientation.|  
|**LM_MRUWIDTH**|Most Recently Used Dynamic Width. Ignores <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> parameter and uses the remembered most recently used width.|  
|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|Horizontal Docked Dimensions. Ignores <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> parameter and returns the dynamic size with the largest width.|  
|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|Vertical Docked Dimensions. Ignores <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> parameter and returns the dynamic size with the largest height.|  
|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|Set if <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> indicates height (Y-direction) instead of width.|  
|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|Resets **LM_MRUWIDTH** to current width of floating control bar.|  
  
### Return Value  
 The control bar size, in pixels, of a [CSize](../vs140/csize-class.md) object.  
  
### Remarks  
 Override this member function to provide your own dynamic layout in classes you derive from <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>. MFC classes derived from <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>, such as [CToolbar](../vs140/ctoolbar-class.md), override this member function and provide their own implementation.  
  
##  \<a name="ccontrolbar__calcfixedlayout">\</a>  CControlBar::CalcFixedLayout  
 Call this member function to calculate the horizontal size of a control bar.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 Indicates whether the bar should be stretched to the size of the frame. The <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> parameter is nonzero when the bar is not a docking bar (not available for docking) and is 0 when it is docked or floating (available for docking).  
  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 Indicates that the bar is horizontally or vertically oriented. The <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> parameter is nonzero if the bar is horizontally oriented and is 0 if it is vertically oriented.  
  
### Return Value  
 The control bar size, in pixels, of a <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> object.  
  
### Remarks  
 Control bars such as toolbars can stretch horizontally or vertically to accommodate the buttons contained in the control bar.  
  
 If <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> is **TRUE**, stretch the dimension along the orientation provided by <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>. In other words, if <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> is **FALSE**, the control bar is stretched vertically. If <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> is **FALSE**, no stretch occurs. The following table shows the possible permutations, and resulting control-bar styles, of <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>.  
  
|bStretch|bHorz|Stretching|Orientation|Docking/Not docking|  
|--------------|-----------|----------------|-----------------|--------------------------|  
|**TRUE**|**TRUE**|Horizontal stretching|Horizontally oriented|Not docking|  
|**TRUE**|**FALSE**|Vertical stretching|Vertically oriented|Not docking|  
|**FALSE**|**TRUE**|No stretching available|Horizontally oriented|Docking|  
|**FALSE**|**FALSE**|No stretching available|Vertically oriented|Docking|  
  
##  \<a name="ccontrolbar__calcinsiderect">\</a>  CControlBar::CalcInsideRect  
 The framework calls this function to calculate the client area of the control bar.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 Contains the current dimensions of the control bar; including the borders.  
  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 Indicates that the bar is horizontally or vertically oriented. The <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> parameter is nonzero if the bar is horizontally oriented and is 0 if it is vertically oriented.  
  
### Remarks  
 This function is called before the control bar is painted.  
  
 Override this function to customize the rendering of the borders and gripper bar of the control bar.  
  
##  \<a name="ccontrolbar__ccontrolbar">\</a>  CControlBar::CControlBar  
 Constructs a <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
##  \<a name="ccontrolbar__dopaint">\</a>  CControlBar::DoPaint  
 Called by the framework to render the borders and gripper bar of the control bar.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 Points to the device context to be used for rendering the borders and gripper of the control bar.  
  
### Remarks  
 Override this function to customize the drawing behavior of the control bar.  
  
 Another customization method is to override the <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> functions and add custom drawing code for the borders and gripper. Because these methods are called by the default <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> method, an override of <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> is not needed.  
  
##  \<a name="ccontrolbar__drawborders">\</a>  CControlBar::DrawBorders  
 Called by the framework to render the borders of the control bar.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 Points to the device context to be used for rendering the borders of the control bar.  
  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> object containing the dimensions of the control bar.  
  
### Remarks  
 Override this function to customize the appearance of the control bar borders.  
  
##  \<a name="ccontrolbar__drawgripper">\</a>  CControlBar::DrawGripper  
 Called by the framework to render the gripper of the control bar.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
 Points to the device context to be used for rendering the control bar gripper.  
  
 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> object containing the dimensions of the control bar gripper.  
  
### Remarks  
 Override this function to customize the appearance of the control bar gripper.  
  
##  \<a name="ccontrolbar__enabledocking">\</a>  CControlBar::EnableDocking  
 Call this function to enable a control bar to be docked.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 Specifies whether the control bar supports docking and the sides of its parent window to which the control bar can be docked, if supported. Can be one or more of the following:  
  
-   <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> Allows docking at the top of the client area.  
  
-   <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> Allows docking at the bottom of the client area.  
  
-   <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> Allows docking on the left side of the client area.  
  
-   <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> Allows docking on the right side of the client area.  
  
-   <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> Allows docking on any side of the client area.  
  
-   <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> Allows multiple control bars to be floated in a single mini-frame window.  
  
 If 0 (that is, indicating no flags), the control bar will not dock.  
  
### Remarks  
 The sides specified must match one of the sides enabled for docking in the destination frame window, or the control bar cannot be docked to that frame window.  
  
##  \<a name="ccontrolbar__getbarstyle">\</a>  CControlBar::GetBarStyle  
 Call this function to determine which **CBRS_** (control bar styles) settings are currently set for the control bar.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 The current **CBRS_** (control bar styles) settings for the control bar. See [CControlBar::SetBarStyle](#ccontrolbar__setbarstyle) for the complete list of available styles.  
  
### Remarks  
 Does not handle **WS_** (window style) styles.  
  
##  \<a name="ccontrolbar__getborders">\</a>  CControlBar::GetBorders  
 Returns the current border values for the control bar.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> object that contains the current width (in pixels) of each side of the control bar object. For example, the value of the <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> member, of [CRect](../vs140/crect-class.md) object, is the width of the left hand border.  
  
##  \<a name="ccontrolbar__getcount">\</a>  CControlBar::GetCount  
 Returns the number of non- <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> items on the <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 The number of non- <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> items on the <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> object. This function returns 0 for a [CDialogBar](../vs140/cdialogbar-class.md) object.  
  
### Remarks  
 The type of the item depends on the derived object: panes for [CStatusBar](../vs140/cstatusbar-class.md) objects, and buttons and separators for [CToolBar](../vs140/ctoolbar-class.md) objects.  
  
##  \<a name="ccontrolbar__getdockingframe">\</a>  CControlBar::GetDockingFrame  
 Call this member function to obtain a pointer to the current frame window to which your control bar is docked.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to a frame window if successful; otherwise **NULL**.  
  
 If the control bar is not docked to a frame window (that is, if the control bar is floating), this function will return a pointer to its parent [CMiniFrameWnd](../vs140/cminiframewnd-class.md).  
  
### Remarks  
 For more information about dockable control bars, see [CControlBar::EnableDocking](#ccontrolbar__enabledocking) and [CFrameWnd::DockControlBar](../vs140/cframewnd-class.md#cframewnd__dockcontrolbar).  
  
##  \<a name="ccontrolbar__isfloating">\</a>  CControlBar::IsFloating  
 Call this member function to determine whether the control bar is floating or docked.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the control bar is floating; otherwise 0.  
  
### Remarks  
 To change the state of a control bar from docked to floating, call [CFrameWnd::FloatControlBar](../vs140/cframewnd-class.md#cframewnd__floatcontrolbar).  
  
##  \<a name="ccontrolbar__m_bautodelete">\</a>  CControlBar::m_bAutoDelete  
 If nonzero, the <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> object is deleted when the Windows control bar is destroyed.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> is a public variable of type **BOOL**.  
  
 A control-bar object is usually embedded in a frame-window object. In this case, <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> is 0 because the embedded control-bar object is destroyed when the frame window is destroyed.  
  
 Set this variable to a nonzero value if you allocate a <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> object on the heap and you do not plan to call **delete**.  
  
##  \<a name="ccontrolbar__m_pinplaceowner">\</a>  CControlBar::m_pInPlaceOwner  
 The in-place owner of the control bar.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
##  \<a name="ccontrolbar__onupdatecmdui">\</a>  CControlBar::OnUpdateCmdUI  
 This member function is called by the framework to update the status of the toolbar or status bar.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
 Points to the main frame window of the application. This pointer is used for routing update messages.  
  
 <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
 Flag that indicates whether a control that has no update handler should be automatically displayed as disabled.  
  
### Remarks  
 To update an individual button or pane, use the <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> macro in your message map to set an update handler appropriately. See [ON_UPDATE_COMMAND_UI](../vs140/on_update_command_ui.md) for more information about using this macro.  
  
 <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> is called by the framework when the application is idle. The frame window to be updated must be a child window, at least indirectly, of a visible frame window. <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> is an advanced overridable.  
  
##  \<a name="ccontrolbar__setbarstyle">\</a>  CControlBar::SetBarStyle  
 Call this function to set the desired **CBRS_** styles for the control bar.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
 The desired styles for the control bar. Can be one or more of the following:  
  
-   <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> Allows the control bar to be docked to the top of the client area of a frame window.  
  
-   <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> Allows the control bar to be docked to the bottom of the client area of a frame window.  
  
-   <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> Allows the control bar to be docked to the left side of the client area of a frame window.  
  
-   <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> Allows the control bar to be docked to the right side of the client area of a frame window.  
  
-   <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> Allows the control bar to be docked to any side of the client area of a frame window.  
  
-   <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> Causes a border to be drawn on the top edge of the control bar when it would be visible.  
  
-   <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> Causes a border to be drawn on the bottom edge of the control bar when it would be visible.  
  
-   <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> Causes a border to be drawn on the left edge of the control bar when it would be visible.  
  
-   <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> Causes a border to be drawn on the right edge of the control bar when it would be visible.  
  
-   <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> Allows multiple control bars to be floated in a single mini-frame window.  
  
-   <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> Causes tool tips to be displayed for the control bar.  
  
-   <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> Causes message text to be updated at the same time as tool tips.  
  
-   **CBRS_GRIPPER** Causes a gripper, similar to that used on bands in a **CReBar** object, to be drawn for any <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>-derived class.  
  
### Remarks  
 Does not affect the **WS_** (window style) settings.  
  
##  \<a name="ccontrolbar__setborders">\</a>  CControlBar::SetBorders  
 Call this function to set the size of the control bar's borders.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 *cxLeft*  
 The width (in pixels) of the control bar's left border.  
  
 *cyTop*  
 The height (in pixels) of the control bar's top border.  
  
 *cxRight*  
 The width (in pixels) of the control bar's right border.  
  
 *cyBottom*  
 The height (in pixels) of the control bar's bottom border.  
  
 <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>  
 A pointer to a [CRect](../vs140/crect-class.md) object that contains the current width (in pixels)of each border of the control bar object.  
  
### Example  
 The following code example sets the top and bottom borders of the control bar to 5 pixels, and the left and right borders to 2 pixels:  
  
 [!code[NVC_MFCControlLadenDialog#61](../vs140/codesnippet/CPP/ccontrolbar-class_1.cpp)]  
  
##  \<a name="ccontrolbar__setinplaceowner">\</a>  CControlBar::SetInPlaceOwner  
 Changes the in-place owner of a control bar.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> object.  
  
### Remarks  
  
## See Also  
 [MFC Sample CTRLBARS](../vs140/visual-c---samples.md)   
 [Base Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBar](../vs140/ctoolbar-class.md)   
 [CDialogBar](../vs140/cdialogbar-class.md)   
 [CStatusBar](../vs140/cstatusbar-class.md)   
 [CReBar](../vs140/crebar-class.md)