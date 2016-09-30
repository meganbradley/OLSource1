---
title: "CScrollBar Class"
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
  - "CScrollBar"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CScrollBar class"
  - "SCROLLBAR window class"
  - "scroll bars"
  - "Windows common controls [C++], CScrollBar"
  - "controls [MFC], scroll bar"
ms.assetid: f3735ca5-73ea-46dc-918b-4d824c9fe47f
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CScrollBar Class
Provides the functionality of a Windows scroll-bar control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CScrollBar::CScrollBar](#cscrollbar__cscrollbar)|Constructs a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CScrollBar::Create](#cscrollbar__create)|Creates the Windows scroll bar and attaches it to the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object.|  
|[CScrollBar::EnableScrollBar](#cscrollbar__enablescrollbar)|Enables or disables one or both arrows of a scroll bar.|  
|[CScrollBar::GetScrollBarInfo](#cscrollbar__getscrollbarinfo)|Retrieves information about the scroll bar using a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> structure.|  
|[CScrollBar::GetScrollInfo](#cscrollbar__getscrollinfo)|Retrieves information about the scroll bar.|  
|[CScrollBar::GetScrollLimit](#cscrollbar__getscrolllimit)|Retrieves the limit of the scroll bar|  
|[CScrollBar::GetScrollPos](#cscrollbar__getscrollpos)|Retrieves the current position of a scroll box.|  
|[CScrollBar::GetScrollRange](#cscrollbar__getscrollrange)|Retrieves the current minimum and maximum scroll-bar positions for the given scroll bar.|  
|[CScrollBar::SetScrollInfo](#cscrollbar__setscrollinfo)|Sets information about the scroll bar.|  
|[CScrollBar::SetScrollPos](#cscrollbar__setscrollpos)|Sets the current position of a scroll box.|  
|[CScrollBar::SetScrollRange](#cscrollbar__setscrollrange)|Sets minimum and maximum position values for the given scroll bar.|  
|[CScrollBar::ShowScrollBar](#cscrollbar__showscrollbar)|Shows or hides a scroll bar.|  
  
## Remarks  
 You create a scroll-bar control in two steps. First, call the constructor <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> to construct the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object, then call the [Create](#cscrollbar__create) member function to create the Windows scroll-bar control and attach it to the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object.  
  
 If you create a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object within a dialog box (through a dialog resource), the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is automatically destroyed when the user closes the dialog box.  
  
 If you create a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object within a window, you may also need to destroy it.  
  
 If you create the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object on the stack, it is destroyed automatically. If you create the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object on the heap by using the **new** function, you must call **delete** on the object to destroy it when the user terminates the Windows scroll bar.  
  
 If you allocate any memory in the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object, override the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> destructor to dispose of the allocations.  
  
 For related information about using <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, see [Controls](../vs140/controls--mfc-.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxwin.h  
  
##  \<a name="cscrollbar__create">\</a>  CScrollBar::Create  
 Creates the Windows scroll bar and attaches it to the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 Specifies the scroll bar's style. Apply any combination of [scroll-bar styles](../vs140/scroll-bar-styles.md) to the scroll bar.  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 Specifies the scroll bar's size and position. Can be either a <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> structure or a <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 Specifies the scroll bar's parent window, usually a <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> object. It must not be **NULL**.  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 The scroll bar's control ID.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 You construct a <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> object in two steps. First, call the constructor, which constructs the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object; then call **Create**, which creates and initializes the associated Windows scroll bar and attaches it to the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object.  
  
 Apply the following [window styles](../vs140/window-styles.md) to a scroll bar:  
  
-   **WS_CHILD** Always  
  
-   **WS_VISIBLE** Usually  
  
-   **WS_DISABLED** Rarely  
  
-   **WS_GROUP** To group controls  
  
### Example  
 [!code[NVC_MFC_CScrollBar#1](../vs140/codesnippet/CPP/cscrollbar-class_1.cpp)]  
  
##  \<a name="cscrollbar__cscrollbar">\</a>  CScrollBar::CScrollBar  
 Constructs a <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 After constructing the object, call the **Create** member function to create and initialize the Windows scroll bar.  
  
### Example  
 [!code[NVC_MFC_CScrollBar#2](../vs140/codesnippet/CPP/cscrollbar-class_2.h)]  
  
##  \<a name="cscrollbar__enablescrollbar">\</a>  CScrollBar::EnableScrollBar  
 Enables or disables one or both arrows of a scroll bar.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 Specifies whether the scroll arrows are enabled or disabled and which arrows are enabled or disabled. This parameter can be one of the following values:  
  
-   **ESB_ENABLE_BOTH** Enables both arrows of a scroll bar.  
  
-   **ESB_DISABLE_LTUP** Disables the left arrow of a horizontal scroll bar or the up arrow of a vertical scroll bar.  
  
-   **ESB_DISABLE_RTDN** Disables the right arrow of a horizontal scroll bar or the down arrow of a vertical scroll bar.  
  
-   **ESB_DISABLE_BOTH** Disables both arrows of a scroll bar.  
  
### Return Value  
 Nonzero if the arrows are enabled or disabled as specified; otherwise 0, which indicates that the arrows are already in the requested state or that an error occurred.  
  
### Example  
  See the example for [CScrollBar::SetScrollRange](#cscrollbar__setscrollrange).  
  
##  \<a name="cscrollbar__getscrollbarinfo">\</a>  CScrollBar::GetScrollBarInfo  
 Retrieves the information that the **SCROLLBARINFO** structure maintains about a scroll bar.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 *pScrollInfo*  
 A pointer to the                                 [SCROLLBARINFO](http://msdn.microsoft.com/library/windows/desktop/bb787535) structure.  
  
### Return Value  
 Returns **TRUE** on success, **FALSE** on failure.  
  
### Remarks  
 This member function emulates the functionality of the                         [SBM_SCROLLBARINFO](http://msdn.microsoft.com/library/windows/desktop/bb787545) message, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cscrollbar__getscrollinfo">\</a>  CScrollBar::GetScrollInfo  
 Retrieves the information that the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> structure maintains about a scroll bar.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 A pointer to a                                 [SCROLLINFO](http://msdn.microsoft.com/library/windows/desktop/bb787537) structure. See the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information about this structure.  
  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 Specifies the scroll bar parameters to retrieve. Typical usage, SIF_ALL, specifies a combination of SIF_PAGE, SIF_POS, SIF_TRACKPOS, and SIF_RANGE. See <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> for more information on the nMask values.  
  
### Return Value  
 If the message retrieved any values, the return is **TRUE**. Otherwise, it is **FALSE**.  
  
### Remarks  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> enables applications to use 32-bit scroll positions.  
  
 The                         [SCROLLINFO](http://msdn.microsoft.com/library/windows/desktop/bb787537) structure contains information about a scroll bar, including the minimum and maximum scrolling positions, the page size, and the position of the scroll box (the thumb). See the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> structure topic in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information about changing the structure defaults.  
  
 The MFC Windows message handlers that indicate scroll bar position, [CWnd::OnHScroll](../vs140/cwnd-class.md#cwnd__onhscroll) and [CWnd::OnVScroll](../vs140/cwnd-class.md#cwnd__onvscroll), provide only 16 bits of position data. <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> provide 32 bits of scroll bar position data. Thus, an application can call <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> while processing either <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> to obtain 32-bit scroll bar position data.  
  
### Example  
  See the example for [CWnd::OnHScroll](../vs140/cwnd-class.md#cwnd__onhscroll).  
  
##  \<a name="cscrollbar__getscrolllimit">\</a>  CScrollBar::GetScrollLimit  
 Retrieves the maximum scrolling position of the scroll bar.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 Specifies the maximum position of a scroll bar if successful; otherwise 0.  
  
### Example  
  See the example for [CWnd::OnHScroll](../vs140/cwnd-class.md#cwnd__onhscroll).  
  
##  \<a name="cscrollbar__getscrollpos">\</a>  CScrollBar::GetScrollPos  
 Retrieves the current position of a scroll box.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 Specifies the current position of the scroll box if successful; otherwise 0.  
  
### Remarks  
 The current position is a relative value that depends on the current scrolling range. For example, if the scrolling range is 100 to 200 and the scroll box is in the middle of the bar, the current position is 150.  
  
### Example  
  See the example for [CWnd::OnHScroll](../vs140/cwnd-class.md#cwnd__onhscroll).  
  
##  \<a name="cscrollbar__getscrollrange">\</a>  CScrollBar::GetScrollRange  
 Copies the current minimum and maximum scroll-bar positions for the given scroll bar to the locations specified by <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 Points to the integer variable that is to receive the minimum position.  
  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 Points to the integer variable that is to receive the maximum position.  
  
### Remarks  
 The default range for a scroll-bar control is empty (both values are 0).  
  
### Example  
  See the example for [CWnd::OnHScroll](../vs140/cwnd-class.md#cwnd__onhscroll).  
  
##  \<a name="cscrollbar__setscrollinfo">\</a>  CScrollBar::SetScrollInfo  
 Sets the information that the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> structure maintains about a scroll bar.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 A pointer to a                                 [SCROLLINFO](http://msdn.microsoft.com/library/windows/desktop/bb787537) structure.  
  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 Specifies whether the scroll bar should be redrawn to reflect the new information. If <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> is **TRUE**, the scroll bar is redrawn. If it is **FALSE**, it is not redrawn. The scroll bar is redrawn by default.  
  
### Return Value  
 If successful, the return is **TRUE**. Otherwise, it is **FALSE**.  
  
### Remarks  
 You must provide the values required by the <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> structure parameters, including the flag values.  
  
 The <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> structure contains information about a scroll bar, including the minimum and maximum scrolling positions, the page size, and the position of the scroll box (the thumb). See the                         [SCROLLINFO](http://msdn.microsoft.com/library/windows/desktop/bb787537) structure topic in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information about changing the structure defaults.  
  
### Example  
 [!code[NVC_MFC_CScrollBar#3](../vs140/codesnippet/CPP/cscrollbar-class_3.cpp)]  
  
##  \<a name="cscrollbar__setscrollpos">\</a>  CScrollBar::SetScrollPos  
 Sets the current position of a scroll box to that specified by <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> and, if specified, redraws the scroll bar to reflect the new position.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 Specifies the new position for the scroll box. It must be within the scrolling range.  
  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 Specifies whether the scroll bar should be redrawn to reflect the new position. If <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> is **TRUE**, the scroll bar is redrawn. If it is **FALSE**, it is not redrawn. The scroll bar is redrawn by default.  
  
### Return Value  
 Specifies the previous position of the scroll box if successful; otherwise 0.  
  
### Remarks  
 Set <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> to **FALSE** whenever the scroll bar will be redrawn by a subsequent call to another function to avoid having the scroll bar redrawn twice within a short interval.  
  
### Example  
  See the example for [CScrollBar::SetScrollRange](#cscrollbar__setscrollrange).  
  
##  \<a name="cscrollbar__setscrollrange">\</a>  CScrollBar::SetScrollRange  
 Sets minimum and maximum position values for the given scroll bar.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 Specifies the minimum scrolling position.  
  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 Specifies the maximum scrolling position.  
  
 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 Specifies whether the scroll bar should be redrawn to reflect the change. If <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> is **TRUE**, the scroll bar is redrawn; if **FALSE**, it is not redrawn. It is redrawn by default.  
  
### Remarks  
 Set <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> to 0 to hide standard scroll bars.  
  
 Do not call this function to hide a scroll bar while processing a scroll-bar notification message.  
  
 If a call to <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> immediately follows a call to the <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> member function, set <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> to 0 to prevent the scroll bar from being redrawn twice.  
  
 The difference between the values specified by <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> must not be greater than 32,767. The default range for a scroll-bar control is empty (both <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> are 0).  
  
### Example  
 [!code[NVC_MFC_CScrollBar#4](../vs140/codesnippet/CPP/cscrollbar-class_4.cpp)]  
  
##  \<a name="cscrollbar__showscrollbar">\</a>  CScrollBar::ShowScrollBar  
 Shows or hides a scroll bar.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
 Specifies whether the scroll bar is shown or hidden. If this parameter is **TRUE**, the scroll bar is shown; otherwise it is hidden.  
  
### Remarks  
 An application should not call this function to hide a scroll bar while processing a scroll-bar notification message.  
  
### Example  
  See the example for [CScrollBar::Create](#cscrollbar__create).  
  
## See Also  
 [Base Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd](../vs140/cwnd-class.md)   
 [CButton](../vs140/cbutton-class.md)   
 [CComboBox](../vs140/ccombobox-class.md)   
 [CEdit](../vs140/cedit-class.md)   
 [CListBox](../vs140/clistbox-class.md)   
 [CStatic](../vs140/cstatic-class.md)   
 [CDialog](../vs140/cdialog-class.md)