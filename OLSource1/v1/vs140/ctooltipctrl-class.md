---
title: "CToolTipCtrl Class"
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
  - "CToolTipCtrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "tool tips [C++], tool tip controls"
  - "data tips [C++]"
  - "CToolTipCtrl class"
ms.assetid: 8973f70c-b73a-46c7-908d-758f364b9a97
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolTipCtrl Class
Encapsulates the functionality of a "tool tip control," a small pop-up window that displays a single line of text describing the purpose of a tool in an application.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CToolTipCtrl::CToolTipCtrl](#ctooltipctrl__ctooltipctrl)|Constructs a <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CToolTipCtrl::Activate](#ctooltipctrl__activate)|Activates and deactivates the tool tip control.|  
|[CToolTipCtrl::AddTool](#ctooltipctrl__addtool)|Registers a tool with the tool tip control.|  
|[CToolTipCtrl::AdjustRect](#ctooltipctrl__adjustrect)|Converts between a tool tip control's text display rectangle and its window rectangle.|  
|[CToolTipCtrl::Create](#ctooltipctrl__create)|Creates a tool tip control and attaches it to a <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> object.|  
|[CToolTipCtrl::CreateEx](#ctooltipctrl__createex)|Creates a tool tip control with the specified Windows extended styles and attaches it to a <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> object.|  
|[CToolTipCtrl::DelTool](#ctooltipctrl__deltool)|Removes a tool from the tool tip control.|  
|[CToolTipCtrl::GetBubbleSize](#ctooltipctrl__getbubblesize)|Retrieves the size of the tool tip.|  
|[CToolTipCtrl::GetCurrentTool](#ctooltipctrl__getcurrenttool)|Retrieves information, such as the size, position, and text, of the tooltip window that the current tooltip control displays.|  
|[CToolTipCtrl::GetDelayTime](#ctooltipctrl__getdelaytime)|Retrieves the initial, pop-up, and reshow durations that are currently set for a tool tip control.|  
|[CToolTipCtrl::GetMargin](#ctooltipctrl__getmargin)|Retrieves the top, left, bottom, and right margins that are set for a tool tip window.|  
|[CToolTipCtrl::GetMaxTipWidth](#ctooltipctrl__getmaxtipwidth)|Retrieves the maximum width for a tool tip window.|  
|[CToolTipCtrl::GetText](#ctooltipctrl__gettext)|Retrieves the text that a tool tip control maintains for a tool.|  
|[CToolTipCtrl::GetTipBkColor](#ctooltipctrl__gettipbkcolor)|Retrieves the background color in a tool tip window.|  
|[CToolTipCtrl::GetTipTextColor](#ctooltipctrl__gettiptextcolor)|Retrieves the text color in a tool tip window.|  
|[CToolTipCtrl::GetTitle](#ctooltipctrl__gettitle)|Retrieves the title of the current tooltip control.|  
|[CToolTipCtrl::GetToolCount](#ctooltipctrl__gettoolcount)|Retrieves a count of the tools maintained by a tool tip control.|  
|[CToolTipCtrl::GetToolInfo](#ctooltipctrl__gettoolinfo)|Retrieves the information that a tool tip control maintains about a tool.|  
|[CToolTipCtrl::HitTest](#ctooltipctrl__hittest)|Tests a point to determine whether it is within the bounding rectangle of the given tool. If so, retrieves information about the tool.|  
|[CToolTipCtrl::Pop](#ctooltipctrl__pop)|Removes a displayed tool tip window from view.|  
|[CToolTipCtrl::Popup](#ctooltipctrl__popup)|Causes the current ToolTip control to display at the coordinates of the last mouse message.|  
|[CToolTipCtrl::RelayEvent](#ctooltipctrl__relayevent)|Passes a mouse message to a tool tip control for processing.|  
|[CToolTipCtrl::SetDelayTime](#ctooltipctrl__setdelaytime)|Sets the initial, pop-up, and reshow durations for a tool tip control.|  
|[CToolTipCtrl::SetMargin](#ctooltipctrl__setmargin)|Sets the top, left, bottom, and right margins for a tool tip window.|  
|[CToolTipCtrl::SetMaxTipWidth](#ctooltipctrl__setmaxtipwidth)|Sets the maximum width for a tool tip window.|  
|[CToolTipCtrl::SetTipBkColor](#ctooltipctrl__settipbkcolor)|Sets the background color in a tool tip window.|  
|[CToolTipCtrl::SetTipTextColor](#ctooltipctrl__settiptextcolor)|Sets the text color in a tool tip window.|  
|[CToolTipCtrl::SetTitle](#ctooltipctrl__settitle)|Adds a standard icon and title string to a tool tip.|  
|[CToolTipCtrl::SetToolInfo](#ctooltipctrl__settoolinfo)|Sets the information that a tool tip maintains for a tool.|  
|[CToolTipCtrl::SetToolRect](#ctooltipctrl__settoolrect)|Sets a new bounding rectangle for a tool.|  
|[CToolTipCtrl::SetWindowTheme](#ctooltipctrl__setwindowtheme)|Sets the visual style of the tool tip window.|  
|[CToolTipCtrl::Update](#ctooltipctrl__update)|Forces the current tool to be redrawn.|  
|[CToolTipCtrl::UpdateTipText](#ctooltipctrl__updatetiptext)|Sets the tool tip text for a tool.|  
  
## Remarks  
 A "tool" is either a window, such as a child window or control, or an application-defined rectangular area within a window's client area. A tool tip is hidden most of the time, appearing only when the user puts the cursor on a tool and leaves it there for approximately one-half second. The tool tip appears near the cursor and disappears when the user clicks a mouse button or moves the cursor off the tool.  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> provides the functionality to control the initial time and duration of the tool tip, the margin widths surrounding the tool tip text, the width of the tool tip window itself, and the background and text color of the tool tip. A single tool tip control can provide information for more than one tool.  
  
 The <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> class provides the functionality of the Windows common tool tip control. This control (and therefore the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> class) is available only to programs running under Windows 95/98 and Windows NT versions 3.51 and later.  
  
 For more information about enabling tool tips, see [Tool Tips in Windows not Derived from CFrameWnd](../vs140/tool-tips-in-windows-not-derived-from-cframewnd.md).  
  
 For more information on using <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, see [Controls](../vs140/controls--mfc-.md) and [Using CToolTipCtrl](../vs140/using-ctooltipctrl.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxcmn.h  
  
##  \<a name="ctooltipctrl__activate">\</a>  CToolTipCtrl::Activate  
 Call this function to activate or deactivate a tool tip control.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 Specifies whether the tool tip control is to be activated or deactivated.  
  
### Remarks  
 If <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> is **TRUE**, the control is activated; if **FALSE**, it is deactivated.  
  
 When a tool tip control is active, the tool tip information appears when the cursor is on a tool that is registered with the control; when it is inactive, the tool tip information does not appear, even when the cursor is on a tool.  
  
### Example  
  See the example for [CPropertySheet::GetTabControl](../vs140/cpropertysheet-class.md#cpropertysheet__gettabcontrol).  
  
##  \<a name="ctooltipctrl__addtool">\</a>  CToolTipCtrl::AddTool  
 Registers a tool with the tool tip control.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 Pointer to the window that contains the tool.  
  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 ID of the string resource that contains the text for the tool.  
  
 *lpRectTool*  
 Pointer to a                                 [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure containing coordinates of the tool's bounding rectangle. The coordinates are relative to the upper-left corner of the client area of the window identified by <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 ID of the tool.  
  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 Pointer to the text for the tool. If this parameter contains the value **LPSTR_TEXTCALLBACK**, **TTN_NEEDTEXT** notification messages go to the parent of the window that <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> points to.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 The **lpRectTool** and **nIDTool** parameters must both be valid, or if **lpRectTool** is NULL, **nIDTool** must be 0.  
  
 A tool tip control can be associated with more than one tool. Call this function to register a tool with the tool tip control, so that the information stored in the tool tip is displayed when the cursor is on the tool.  
  
> [!NOTE]
>  You cannot set a tool tip to a static control using <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>.  
  
### Example  
  See the example for [CPropertySheet::GetTabControl](../vs140/cpropertysheet-class.md#cpropertysheet__gettabcontrol).  
  
##  \<a name="ctooltipctrl__adjustrect">\</a>  CToolTipCtrl::AdjustRect  
 Converts between a tooltip control's text display rectangle and its window rectangle.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 Pointer to a                                 [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure that holds either a tool tip window rectangle or a text display rectangle.  
  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 If **TRUE**, <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> is used to specify a text-display rectangle, and it receives the corresponding window rectangle. If **FALSE**, <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> is used to specify a window rectangle, and it receives the corresponding text display rectangle.  
  
### Return Value  
 Nonzero if the rectangle is successfully adjusted; otherwise 0.  
  
### Remarks  
 This member function calculates a tool tip control's text display rectangle from its window rectangle, or the tool tip window rectangle needed to display a specified text display rectangle.  
  
 This member function implements the behavior of the Win32 message                         [TTM_ADJUSTRECT](http://msdn.microsoft.com/library/windows/desktop/bb760352), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ctooltipctrl__create">\</a>  CToolTipCtrl::Create  
 Creates a tool tip control and attaches it to a <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 Specifies the tool tip control's parent window, usually a <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>. It must not be **NULL**.  
  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 Specifies the tool tip control's style. See the **Remarks** section for more information.  
  
### Return Value  
 Nonzero if the <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> object is successfully created; otherwise 0.  
  
### Remarks  
 You construct a <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> in two steps. First, call the constructor to construct the <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> object, and then call **Create** to create the tool tip control and attach it to the <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> object.  
  
 The <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> parameter can be any combination of [Window Styles](../vs140/window-styles.md). In addition, a tool tip control has two class-specific styles: **TTS_ALWAYSTIP** and **TTS_NOPREFIX**.  
  
|Style|Meaning|  
|-----------|-------------|  
|**TTS_ALWAYSTIP**|Specifies that the tool tip will appear when the cursor is on a tool, regardless of whether the tool tip control's owner window is active or inactive. Without this style, the tool tip control appears when the tool's owner window is active, but not when it is inactive.|  
|**TTS_NOPREFIX**|This style prevents the system from stripping the ampersand (&) character from a string. If a tool tip control does not have the **TTS_NOPREFIX** style, the system automatically strips ampersand characters, allowing an application to use the same string as both a menu item and as text in a tool tip control.|  
  
 A tool tip control has the <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> and **WS_EX_TOOLWINDOW** window styles, regardless of whether you specify them when creating the control.  
  
 To create a tool tip control with extended windows styles, call [CToolTipCtrl::CreateEx](#ctooltipctrl__createex) instead of **Create**.  
  
### Example  
  See the example for [CPropertySheet::GetTabControl](../vs140/cpropertysheet-class.md#cpropertysheet__gettabcontrol).  
  
##  \<a name="ctooltipctrl__createex">\</a>  CToolTipCtrl::CreateEx  
 Creates a control (a child window) and associate it with the <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 A pointer to the window that is the control's parent.  
  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 Specifies the tool tip control's style. See the **Remarks** section of [Create](#ctooltipctrl__create) for more information.  
  
 *dwStyleEx*  
 Specifies the extended style of the control being created. For a list of extended Windows styles, see the <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> parameter for                                 [CreateWindowEx](http://msdn.microsoft.com/library/windows/desktop/ms632680) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Return Value  
 Nonzero if successful otherwise 0.  
  
### Remarks  
 Use <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> instead of **Create** to apply extended Windows styles, specified by the Windows extended style preface **WS_EX_**.  
  
##  \<a name="ctooltipctrl__ctooltipctrl">\</a>  CToolTipCtrl::CToolTipCtrl  
 Constructs a <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Remarks  
 You must call **Create** after constructing the object.  
  
### Example  
 [!code[NVC_MFCControlLadenDialog#74](../vs140/codesnippet/CPP/ctooltipctrl-class_1.h)]  
  
##  \<a name="ctooltipctrl__deltool">\</a>  CToolTipCtrl::DelTool  
 Removes the tool specified by <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> from the collection of tools supported by a tool tip control.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
 Pointer to the window that contains the tool.  
  
 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
 ID of the tool.  
  
##  \<a name="ctooltipctrl__getbubblesize">\</a>  CToolTipCtrl::GetBubbleSize  
 Retrieves the size of the tool tip.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
 A pointer to the tool tip's                                 [TOOLINFO](http://msdn.microsoft.com/library/windows/desktop/bb760256) structure.  
  
### Return Value  
 The size of the tool tip.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [TTM_GETBUBBLESIZE](http://msdn.microsoft.com/library/windows/desktop/bb760387), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ctooltipctrl__getcurrenttool">\</a>  CToolTipCtrl::GetCurrentTool  
 Retrieves information, such as the size, position, and text, of the tooltip window displayed by the current tooltip control.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[out] <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>|Pointer to a                                         [TOOLINFO](http://msdn.microsoft.com/library/windows/desktop/bb760256) structure that receives information about the current tooltip window.|  
  
### Return Value  
 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> if the information is retrieved successfully; otherwise, <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
  
### Remarks  
 This method sends the                         [TTM_GETCURRENTTOOL](http://msdn.microsoft.com/library/windows/desktop/bb760389) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 The following code example retrieves information about the current tooltip window.  
  
 [!code[NVC_MFC_CToolBarCtrl_s1#6](../vs140/codesnippet/CPP/ctooltipctrl-class_2.cpp)]  
  
##  \<a name="ctooltipctrl__getdelaytime">\</a>  CToolTipCtrl::GetDelayTime  
 Retrieves the initial, pop-up, and reshow durations currently set for a tool tip control.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
 Flag that specifies which duration value will be retrieved. This parameter can be one of the following values:  
  
-   <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> Retrieve the length of time the tool tip window remains visible if the pointer is stationary within a tool's bounding rectangle.  
  
-   <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> Retrieve the length of time the pointer must remain stationary within a tool's bounding rectangle before the tool tip window appears.  
  
-   <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> Retrieve the length of time it takes for subsequent tool tip windows to appear as the pointer moves from one tool to another.  
  
### Return Value  
 The specified delay time, in milliseconds  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [TTM_GETDELAYTIME](http://msdn.microsoft.com/library/windows/desktop/bb760390), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ctooltipctrl__getmargin">\</a>  CToolTipCtrl::GetMargin  
 Retrieves the top, left, bottom, and right margins set for a tool tip window.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
 Address of a <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> structure that will receive the margin information. The members of the                                 [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure do not define a bounding rectangle. For the purpose of this message, the structure members are interpreted as follows:  
  
|Member|Representation|  
|------------|--------------------|  
|**top**|Distance between top border and top of tool tip text, in pixels.|  
|**left**|Distance between left border and left end of tip text, in pixels.|  
|**bottom**|Distance between bottom border and bottom of tip text, in pixels.|  
|**right**|Distance between right border and right end of tip text, in pixels.|  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [TTM_GETMARGIN](http://msdn.microsoft.com/library/windows/desktop/bb760391), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ctooltipctrl__getmaxtipwidth">\</a>  CToolTipCtrl::GetMaxTipWidth  
 Retrieves the maximum width for a tool tip window.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 The maximum width for a tool tip window.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [TTM_GETMAXTIPWIDTH](http://msdn.microsoft.com/library/windows/desktop/bb760392), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ctooltipctrl__gettext">\</a>  CToolTipCtrl::GetText  
 Retrieves the text that a tool tip control maintains for a tool.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 Reference to a <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> object that receives the tool's text.  
  
 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
 Pointer to the window that contains the tool.  
  
 <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
 ID of the tool.  
  
### Remarks  
 The <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> parameters identify the tool. If that tool has been previously registered with the tool tip control through a previous call to **CToolTipCtrl::AddTool**, the object referenced by the <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> parameter is assigned the tool's text.  
  
##  \<a name="ctooltipctrl__gettipbkcolor">\</a>  CToolTipCtrl::GetTipBkColor  
 Retrieves the background color in a tool tip window.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 A                         [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) value that represents the background color.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [TTM_GETTIPBKCOLOR](http://msdn.microsoft.com/library/windows/desktop/bb760394), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ctooltipctrl__gettiptextcolor">\</a>  CToolTipCtrl::GetTipTextColor  
 Retrieves the text color in a tool tip window.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
 A                         [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) value that represents the text color.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [TTM_GETTIPTEXTCOLOR](http://msdn.microsoft.com/library/windows/desktop/bb760395), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ctooltipctrl__gettitle">\</a>  CToolTipCtrl::GetTitle  
 Retrieves the title of the current tooltip control.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[out] <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>|Pointer to a                                         [TTGETTITLE](http://msdn.microsoft.com/library/windows/desktop/bb760260) structure that contains information about the ToolTip control. When this method returns, the <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> member of the                                         [TTGETTITLE](http://msdn.microsoft.com/library/windows/desktop/bb760260) structure points to the text of the title.|  
  
### Remarks  
 This method sends the                         [TTM_GETTITLE](http://msdn.microsoft.com/library/windows/desktop/bb760396) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ctooltipctrl__gettoolcount">\</a>  CToolTipCtrl::GetToolCount  
 Retrieves a count of the tools registered with the tool tip control.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
 A count of tools registered with the tool tip control.  
  
##  \<a name="ctooltipctrl__gettoolinfo">\</a>  CToolTipCtrl::GetToolInfo  
 Retrieves the information that a tool tip control maintains about a tool.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 *ToolInfo*  
 Reference to a <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> object that receives the tool's text.  
  
 <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
 Pointer to the window that contains the tool.  
  
 <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
 ID of the tool.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 The **hwnd** and **uId** members of the                         [TOOLINFO](http://msdn.microsoft.com/library/windows/desktop/bb760256) structure referenced by                         *CToolInfo* identify the tool. If that tool has been registered with the tool tip control through a previous call to <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> structure is filled with information about the tool.  
  
##  \<a name="ctooltipctrl__hittest">\</a>  CToolTipCtrl::HitTest  
 Tests a point to determine whether it is within the bounding rectangle of the given tool and, if so, retrieve information about the tool.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
 Pointer to the window that contains the tool.  
  
 <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
 Pointer to a <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> object containing the coordinates of the point to be tested.  
  
 <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>  
 Pointer to                                 [TOOLINFO](http://msdn.microsoft.com/library/windows/desktop/bb760256) structure that contains information about the tool.  
  
### Return Value  
 Nonzero if the point specified by the hit-test information is within the tool's bounding rectangle; otherwise 0.  
  
### Remarks  
 If this function returns a nonzero value, the structure pointed to by <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> is filled with information on the tool within whose rectangle the point lies.  
  
 The <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> structure is defined as follows:  
  
 <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
  
 **hwnd**  
 Specifies the tool's handle.  
  
 **pt**  
 Specifies the coordinates of a point if the point is in the tool's bounding rectangle.  
  
 **ti**  
 Information about the tool. For more information about the <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> structure, see [CToolTipCtrl::GetToolInfo](#ctooltipctrl__gettoolinfo).  
  
##  \<a name="ctooltipctrl__pop">\</a>  CToolTipCtrl::Pop  
 Removes a displayed tool tip window from the view.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Remarks  
 This member function implements the behavior of the Win32 message                         [TTM_POP](http://msdn.microsoft.com/library/windows/desktop/bb760401), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ctooltipctrl__popup">\</a>  CToolTipCtrl::Popup  
 Causes the current tooltip control to display at the coordinates of the last mouse message.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Remarks  
 This method sends the                         [TTM_POPUP](http://msdn.microsoft.com/library/windows/desktop/bb760402) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 The following code example displays a tooltip window.  
  
 [!code[NVC_MFC_CToolBarCtrl_s1#7](../vs140/codesnippet/CPP/ctooltipctrl-class_3.cpp)]  
  
##  \<a name="ctooltipctrl__relayevent">\</a>  CToolTipCtrl::RelayEvent  
 Passes a mouse message to a tool tip control for processing.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
 Pointer to a                                 [MSG](http://msdn.microsoft.com/library/windows/desktop/ms644958) structure that contains the message to relay.  
  
### Remarks  
 A tool tip control processes only the following messages, which are sent to it by <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>:  
  
|WM_LBUTTONDOWN|WM_MOUSEMOVE|  
|---------------------|-------------------|  
|<CodeContentPlaceHolder>113\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>114\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>115\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>116\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>117\</CodeContentPlaceHolder>||  
  
### Example  
  See the example for [CPropertySheet::GetTabControl](../vs140/cpropertysheet-class.md#cpropertysheet__gettabcontrol).  
  
##  \<a name="ctooltipctrl__setdelaytime">\</a>  CToolTipCtrl::SetDelayTime  
 Sets the delay time for a tool tip control.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 *nDelay*  
 Specifies the new delay time, in milliseconds.  
  
 <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>  
 Flag that specifies which duration value will be retrieved. See [CToolTipCtrl::GetDelayTime](#ctooltipctrl__getdelaytime) for a description of the valid values.  
  
 *iTime*  
 The specified delay time, in milliseconds.  
  
### Remarks  
 The delay time is the length of time the cursor must remain on a tool before the tool tip window appears. The default delay time is 500 milliseconds.  
  
##  \<a name="ctooltipctrl__setmargin">\</a>  CToolTipCtrl::SetMargin  
 Sets the top, left, bottom, and right margins for a tool tip window.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>  
 Address of a <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> structure that contains the margin information to be set. The members of the <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> structure do not define a bounding rectangle. See [CToolTipCtrl::GetMargin](#ctooltipctrl__getmargin) for a description of the margin information.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [TTM_SETMARGIN](http://msdn.microsoft.com/library/windows/desktop/bb760406), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ctooltipctrl__setmaxtipwidth">\</a>  CToolTipCtrl::SetMaxTipWidth  
 Sets the maximum width for a tool tip window.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 *iWidth*  
 The maximum tool tip window width to be set.  
  
### Return Value  
 The previous maximum tip width.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [TTM_SETMAXTIPWIDTH](http://msdn.microsoft.com/library/windows/desktop/bb760408), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ctooltipctrl__settipbkcolor">\</a>  CToolTipCtrl::SetTipBkColor  
 Sets the background color in a tool tip window.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>  
 The new background color.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [TTM_SETTIPBKCOLOR](http://msdn.microsoft.com/library/windows/desktop/bb760411), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ctooltipctrl__settiptextcolor">\</a>  CToolTipCtrl::SetTipTextColor  
 Sets the text color in a tool tip window.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>  
 The new text color.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [TTM_SETTIPTEXTCOLOR](http://msdn.microsoft.com/library/windows/desktop/bb760413), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ctooltipctrl__settitle">\</a>  CToolTipCtrl::SetTitle  
 Adds a standard icon and title string to a tool tip.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 *uIcon*  
 See                                 *icon* in                                 [TTM_SETTITLE](http://msdn.microsoft.com/library/windows/desktop/bb760414) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 *lpstrTitle*  
 Pointer to the title string.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [TTM_SETTITLE](http://msdn.microsoft.com/library/windows/desktop/bb760414), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ctooltipctrl__settoolinfo">\</a>  CToolTipCtrl::SetToolInfo  
 Sets the information that a tool tip maintains for a tool.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>  
 A pointer to a                                 [TOOLINFO](http://msdn.microsoft.com/library/windows/desktop/bb760256) structure that specifies the information to set.  
  
##  \<a name="ctooltipctrl__settoolrect">\</a>  CToolTipCtrl::SetToolRect  
 Sets a new bounding rectangle for a tool.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>  
 Pointer to the window that contains the tool.  
  
 <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>  
 ID of the tool.  
  
 <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>  
 Pointer to a                                 [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure specifying the new bounding rectangle.  
  
##  \<a name="ctooltipctrl__setwindowtheme">\</a>  CToolTipCtrl::SetWindowTheme  
 Sets the visual style of the tool tip window.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>  
 A pointer to a Unicode string that contains the visual style to set.  
  
### Return Value  
 The return value is not used.  
  
### Remarks  
 This member function emulates the functionality of the                         [TTM_SETWINDOWTHEME](http://msdn.microsoft.com/library/windows/desktop/bb760418) message, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ctooltipctrl__update">\</a>  CToolTipCtrl::Update  
 Forces the current tool to be redrawn.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
##  \<a name="ctooltipctrl__updatetiptext">\</a>  CToolTipCtrl::UpdateTipText  
 Updates the tool tip text for this control's tools.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>  
 Pointer to the text for the tool.  
  
 <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>  
 Pointer to the window that contains the tool.  
  
 <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>  
 ID of the tool.  
  
 <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>  
 ID of the string resource that contains the text for the tool.  
  
## See Also  
 [Base Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolbar](../vs140/ctoolbar-class.md)