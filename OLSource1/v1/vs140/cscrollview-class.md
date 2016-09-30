---
title: "CScrollView Class"
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
  - "CScrollView"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CScrollView class"
  - "views, scrolling"
  - "scrolling views"
ms.assetid: 4ba16dac-1acb-4be0-bb55-5fb695b6948d
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CScrollView Class
A [CView](../vs140/cview-class.md) with scrolling capabilities.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Protected Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CScrollView::CScrollView](#cscrollview__cscrollview)|Constructs a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CScrollView::CheckScrollBars](#cscrollview__checkscrollbars)|Indicates whether the scroll view has horizontal and vertical scroll bars.|  
|[CScrollView::FillOutsideRect](#cscrollview__filloutsiderect)|Fills the area of a view outside the scrolling area.|  
|[CScrollView::GetDeviceScrollPosition](#cscrollview__getdevicescrollposition)|Gets the current scroll position in device units.|  
|[CScrollView::GetDeviceScrollSizes](#cscrollview__getdevicescrollsizes)|Gets the current mapping mode, the total size, and the line and page sizes of the scrollable view. Sizes are in device units.|  
|[CScrollView::GetScrollPosition](#cscrollview__getscrollposition)|Gets the current scroll position in logical units.|  
|[CScrollView::GetTotalSize](#cscrollview__gettotalsize)|Gets the total size of the scroll view in logical units.|  
|[CScrollView::ResizeParentToFit](#cscrollview__resizeparenttofit)|Causes the size of the view to dictate the size of its frame.|  
|[CScrollView::ScrollToPosition](#cscrollview__scrolltoposition)|Scrolls the view to a given point, specified in logical units.|  
|[CScrollView::SetScaleToFitSize](#cscrollview__setscaletofitsize)|Puts the scroll view into scale-to-fit mode.|  
|[CScrollView::SetScrollSizes](#cscrollview__setscrollsizes)|Sets the scroll view's mapping mode, total size, and horizontal and vertical scroll amounts.|  
  
## Remarks  
 You can handle standard scrolling yourself in any class derived from <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> by overriding the message-mapped [OnHScroll](../vs140/cwnd-class.md#cwnd__onhscroll) and [OnVScroll](../vs140/cwnd-class.md#cwnd__onvscroll) member functions. But <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> adds the following features to its <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> capabilities:  
  
-   It manages window and viewport sizes and mapping modes.  
  
-   It scrolls automatically in response to scroll-bar messages.  
  
-   It scrolls automatically in response to messages from the keyboard, a non-scrolling mouse, or the IntelliMouse wheel.  
  
 To scroll automatically in response to messages from the keyboard, add a WM_KEYDOWN message, and test for VK_DOWN, VK_PREV and call                 [SetScrollPos](http://msdn.microsoft.com/library/windows/desktop/bb787597).  
  
 You can handle mouse wheel scrolling yourself by overriding the message-mapped [OnMouseWheel](../vs140/cwnd-class.md#cwnd__onmousewheel) and [OnRegisteredMouseWheel](../vs140/cwnd-class.md#cwnd__onregisteredmousewheel) member functions. As they are for <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, these member functions support the recommended behaviour for                 [WM_MOUSEWHEEL](http://msdn.microsoft.com/library/windows/desktop/ms645617), the wheel rotation message.  
  
 To take advantage of automatic scrolling, derive your view class from <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> instead of from <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. When the view is first created, if you want to calculate the size of the scrollable view based on the size of the document, call the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> member function from your override of either [CView::OnInitialUpdate](../vs140/cview-class.md#cview__oninitialupdate) or [CView::OnUpdate](../vs140/cview-class.md#cview__onupdate). (You must write your own code to query the size of the document. For an example, see the [Scribble sample](../vs140/visual-c---samples.md).)  
  
 The call to the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> member function sets the view's mapping mode, the total dimensions of the scroll view, and the amounts to scroll horizontally and vertically. All sizes are in logical units. The logical size of the view is usually calculated from data stored in the document, but in some cases you may want to specify a fixed size. For examples of both approaches, see [CScrollView::SetScrollSizes](#cscrollview__setscrollsizes).  
  
 You specify the amounts to scroll horizontally and vertically in logical units. By default, if the user clicks a scroll bar shaft outside of the scroll box, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> scrolls a "page." If the user clicks a scroll arrow at either end of a scroll bar, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> scrolls a "line." By default, a page is 1/10 of the total size of the view; a line is 1/10 of the page size. Override these default values by passing custom sizes in the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> member function. For example, you might set the horizontal size to some fraction of the width of the total size and the vertical size to the height of a line in the current font.  
  
 Instead of scrolling, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> can automatically scale the view to the current window size. In this mode, the view has no scroll bars and the logical view is stretched or shrunk to exactly fit the window's client area. To use this scale-to-fit capability, call [CScrollView::SetScaleToFitSize](#cscrollview__setscaletofitsize). (Call either <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, but not both.)  
  
 Before the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> member function of your derived view class is called, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> automatically adjusts the viewport origin for the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> device-context object that it passes to <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
 To adjust the viewport origin for the scrolling window, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> overrides [CView::OnPrepareDC](../vs140/cview-class.md#cview__onpreparedc). This adjustment is automatic for the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> device context that <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> passes to <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, but you must call **CScrollView::OnPrepareDC** yourself for any other device contexts you use, such as a <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>. You can override **CScrollView::OnPrepareDC** to set the pen, background color, and other drawing attributes, but call the base class to do scaling.  
  
 Scroll bars can appear in three places relative to a view, as shown in the following cases:  
  
-   Standard window-style scroll bars can be set for the view using the **WS_HSCROLL** and **WS_VSCROLL**[Windows Styles](../vs140/window-styles.md).  
  
-   Scroll-bar controls can also be added to the frame containing the view, in which case the framework forwards <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> messages from the frame window to the currently active view.  
  
-   The framework also forwards scroll messages from a <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> splitter control to the currently active splitter pane (a view). When placed in a [CSplitterWnd](../vs140/csplitterwnd-class.md) with shared scroll bars, a <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> object will use the shared ones rather than creating its own.  
  
 For more information on using <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, see [Document/View Architecture](../vs140/document-view-architecture.md) and [Derived View Classes Available in MFC](../vs140/derived-view-classes-available-in-mfc.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CView](../vs140/cview-class.md)  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxwin.h  
  
##  \<a name="cscrollview__checkscrollbars">\</a>  CScrollView::CheckScrollBars  
 Call this member function to determine if the scroll view has horizontal and vertical bars.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 *bHasHorzBar*  
 Indicates the application has a horizontal scroll bar.  
  
 *bHasVertBar*  
 Indicates the application has a vertical scroll bar.  
  
##  \<a name="cscrollview__cscrollview">\</a>  CScrollView::CScrollView  
 Constructs a <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 You must call either <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> before the scroll view is usable.  
  
##  \<a name="cscrollview__filloutsiderect">\</a>  CScrollView::FillOutsideRect  
 Call <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> to fill the area of the view that appears outside of the scrolling area.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 Device context in which the filling is to be done.  
  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 Brush with which the area is to be filled.  
  
### Remarks  
 Use <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> in your scroll view's <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> handler function to prevent excessive background repainting.  
  
### Example  
 [!code[NVC_MFCDocView#164](../vs140/codesnippet/CPP/cscrollview-class_1.cpp)]  
  
##  \<a name="cscrollview__getdevicescrollposition">\</a>  CScrollView::GetDeviceScrollPosition  
 Call <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> when you need the current horizontal and vertical positions of the scroll boxes in the scroll bars.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 The horizontal and vertical positions (in device units) of the scroll boxes as a <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> object.  
  
### Remarks  
 This coordinate pair corresponds to the location in the document to which the upper-left corner of the view has been scrolled. This is useful for offsetting mouse-device positions to scroll-view device positions.  
  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> returns values in device units. If you want logical units, use <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> instead.  
  
##  \<a name="cscrollview__getdevicescrollsizes">\</a>  CScrollView::GetDeviceScrollSizes  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> gets the current mapping mode, the total size, and the line and page sizes of the scrollable view.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 Returns the current mapping mode for this view. For a list of possible values, see <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 Returns the current total size of the scroll view in device units.  
  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 Returns the current horizontal and vertical amounts to scroll in each direction in response to a mouse click in a scroll-bar shaft. The **cx** member contains the horizontal amount. The **cy** member contains the vertical amount.  
  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 Returns the current horizontal and vertical amounts to scroll in each direction in response to a mouse click in a scroll arrow. The **cx** member contains the horizontal amount. The **cy** member contains the vertical amount.  
  
### Remarks  
 Sizes are in device units. This member function is rarely called.  
  
##  \<a name="cscrollview__getscrollposition">\</a>  CScrollView::GetScrollPosition  
 Call <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> when you need the current horizontal and vertical positions of the scroll boxes in the scroll bars.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 The horizontal and vertical positions (in logical units) of the scroll boxes as a <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> object.  
  
### Remarks  
 This coordinate pair corresponds to the location in the document to which the upper-left corner of the view has been scrolled.  
  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> returns values in logical units. If you want device units, use <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> instead.  
  
##  \<a name="cscrollview__gettotalsize">\</a>  CScrollView::GetTotalSize  
 Call <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> to retrieve the current horizontal and vertical sizes of the scroll view.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 The total size of the scroll view in logical units. The horizontal size is in the **cx** member of the <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> return value. The vertical size is in the **cy** member.  
  
##  \<a name="cscrollview__resizeparenttofit">\</a>  CScrollView::ResizeParentToFit  
 Call <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> to let the size of your view dictate the size of its frame window.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 *bShrinkOnly*  
 The kind of resizing to perform. The default value, **TRUE**, shrinks the frame window if appropriate. Scroll bars will still appear for large views or small frame windows. A value of **FALSE** causes the view always to resize the frame window exactly. This can be somewhat dangerous since the frame window could get too big to fit inside the multiple document interface (MDI) frame window or the screen.  
  
### Remarks  
 This is recommended only for views in MDI child frame windows. Use <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> in the <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> handler function of your derived <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> class. For an example of this member function, see [CScrollView::SetScrollSizes](#cscrollview__setscrollsizes).  
  
 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> assumes that the size of the view window has been set. If the view window size has not been set when <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> is called, you will get an assertion. To ensure that this does not happen, make the following call before calling <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>:  
  
 [!code[NVC_MFCDocView#165](../vs140/codesnippet/CPP/cscrollview-class_2.cpp)]  
  
##  \<a name="cscrollview__scrolltoposition">\</a>  CScrollView::ScrollToPosition  
 Call <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> to scroll to a given point in the view.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
 The point to scroll to, in logical units. The **x** member must be a positive value (greater than or equal to 0, up to the total size of the view). The same is true for the **y** member when the mapping mode is <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>. The **y** member is negative in mapping modes other than <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>.  
  
### Remarks  
 The view will be scrolled so that this point is at the upper-left corner of the window. This member function must not be called if the view is scaled to fit.  
  
##  \<a name="cscrollview__setscaletofitsize">\</a>  CScrollView::SetScaleToFitSize  
 Call <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> when you want to scale the viewport size to the current window size automatically.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 The horizontal and vertical sizes to which the view is to be scaled. The scroll view's size is measured in logical units. The horizontal size is contained in the **cx** member. The vertical size is contained in the **cy** member. Both **cx** and **cy** must be greater than or equal to 0.  
  
### Remarks  
 With scroll bars, only a portion of the logical view may be visible at any time. But with the scale-to-fit capability, the view has no scroll bars and the logical view is stretched or shrunk to exactly fit the window's client area. When the window is resized, the view draws its data at a new scale based on the size of the window.  
  
 You'll typically place the call to <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> in your override of the view's <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> member function. If you do not want automatic scaling, call the <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> member function instead.  
  
 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> can be used to implement a "Zoom to Fit" operation. Use <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> to reinitialize scrolling.  
  
 <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> assumes that the size of the view window has been set. If the view window size has not been set when <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> is called, you will get an assertion. To ensure that this does not happen, make the following call before calling <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>:  
  
 [!code[NVC_MFCDocView#165](../vs140/codesnippet/CPP/cscrollview-class_2.cpp)]  
  
##  \<a name="cscrollview__setscrollsizes">\</a>  CScrollView::SetScrollSizes  
 Call <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> when the view is about to be updated.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
 The mapping mode to set for this view. Possible values include:  
  
|Mapping Mode|Logical Unit|Positive y-axis Extends...|  
|------------------|------------------|---------------------------------|  
|<CodeContentPlaceHolder>89\</CodeContentPlaceHolder>|1 pixel|Downward|  
|<CodeContentPlaceHolder>90\</CodeContentPlaceHolder>|0.01 mm|Upward|  
|<CodeContentPlaceHolder>91\</CodeContentPlaceHolder>|1/1440 in|Upward|  
|<CodeContentPlaceHolder>92\</CodeContentPlaceHolder>|0.001 in|Upward|  
|<CodeContentPlaceHolder>93\</CodeContentPlaceHolder>|0.1 mm|Upward|  
|<CodeContentPlaceHolder>94\</CodeContentPlaceHolder>|0.01 in|Upward|  
  
 All of these modes are defined by Windows. Two standard mapping modes, <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>, are not used for <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>. The class library provides the <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> member function for scaling the view to window size. Column three in the table above describes the coordinate orientation.  
  
 <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
 The total size of the scroll view. The **cx** member contains the horizontal extent. The **cy** member contains the vertical extent. Sizes are in logical units. Both **cx** and **cy** must be greater than or equal to 0.  
  
 <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
 The horizontal and vertical amounts to scroll in each direction in response to a mouse click in a scroll-bar shaft. The **cx** member contains the horizontal amount. The **cy** member contains the vertical amount.  
  
 <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
 The horizontal and vertical amounts to scroll in each direction in response to a mouse click in a scroll arrow. The **cx** member contains the horizontal amount. The **cy** member contains the vertical amount.  
  
### Remarks  
 Call it in your override of the <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> member function to adjust scrolling characteristics when, for example, the document is initially displayed or when it changes size.  
  
 You will typically obtain size information from the view's associated document by calling a document member function, perhaps called <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>, that you supply with your derived document class. The following code shows this approach:  
  
 [!code[NVC_MFCDocView#166](../vs140/codesnippet/CPP/cscrollview-class_3.cpp)]  
  
 Alternatively, you might sometimes need to set a fixed size, as in the following code:  
  
 [!code[NVC_MFCDocView#167](../vs140/codesnippet/CPP/cscrollview-class_4.cpp)]  
  
 You must set the mapping mode to any of the Windows mapping modes except <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>. If you want to use an unconstrained mapping mode, call the <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> member function instead of <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>.  
  
### Example  
 [!code[NVC_MFCDocView#168](../vs140/codesnippet/CPP/cscrollview-class_5.cpp)]  
  
 [!code[NVC_MFCDocView#169](../vs140/codesnippet/CPP/cscrollview-class_6.cpp)]  
  
## See Also  
 [MFC Sample DIBLOOK](../vs140/visual-c---samples.md)   
 [Base Class](../vs140/cview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CView](../vs140/cview-class.md)   
 [CSplitterWnd](../vs140/csplitterwnd-class.md)