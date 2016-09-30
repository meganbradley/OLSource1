---
title: "CSplitterWnd Class"
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
  - "CSplitterWnd"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "static splitter windows"
  - "multiple views"
  - "splitter windows"
  - "views, multiple per frame"
  - "dynamic splitter windows"
  - "CSplitterWnd class"
ms.assetid: fd0de258-6dbe-4552-9e47-a39de0471d51
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSplitterWnd Class
Provides the functionality of a splitter window, which is a window that contains multiple panes.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CSplitterWnd::CSplitterWnd](#csplitterwnd__csplitterwnd)|Call to construct a <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CSplitterWnd::ActivateNext](#csplitterwnd__activatenext)|Performs the Next Pane or Previous Pane command.|  
|[CSplitterWnd::CanActivateNext](#csplitterwnd__canactivatenext)|Checks to see if the Next Pane or Previous Pane command is currently possible.|  
|[CSplitterWnd::Create](#csplitterwnd__create)|Call to create a dynamic splitter window and attach it to the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> object.|  
|[CSplitterWnd::CreateScrollBarCtrl](#csplitterwnd__createscrollbarctrl)|Creates a shared scroll bar control.|  
|[CSplitterWnd::CreateStatic](#csplitterwnd__createstatic)|Call to create a static splitter window and attach it to the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> object.|  
|[CSplitterWnd::CreateView](#csplitterwnd__createview)|Call to create a pane in a splitter window.|  
|[CSplitterWnd::DeleteColumn](#csplitterwnd__deletecolumn)|Deletes a column from the splitter window.|  
|[CSplitterWnd::DeleteRow](#csplitterwnd__deleterow)|Deletes a row from the splitter window.|  
|[CSplitterWnd::DeleteView](#csplitterwnd__deleteview)|Deletes a view from the splitter window.|  
|[CSplitterWnd::DoKeyboardSplit](#csplitterwnd__dokeyboardsplit)|Performs the keyboard split command, usually "Window Split."|  
|[CSplitterWnd::DoScroll](#csplitterwnd__doscroll)|Performs synchronized scrolling of split windows.|  
|[CSplitterWnd::DoScrollBy](#csplitterwnd__doscrollby)|Scrolls split windows by a given number of pixels.|  
|[CSplitterWnd::GetActivePane](#csplitterwnd__getactivepane)|Determines the active pane from the focus or active view in the frame.|  
|[CSplitterWnd::GetColumnCount](#csplitterwnd__getcolumncount)|Returns the current pane column count.|  
|[CSplitterWnd::GetColumnInfo](#csplitterwnd__getcolumninfo)|Returns information on the specified column.|  
|[CSplitterWnd::GetPane](#csplitterwnd__getpane)|Returns the pane at the specified row and column.|  
|[CSplitterWnd::GetRowCount](#csplitterwnd__getrowcount)|Returns the current pane row count.|  
|[CSplitterWnd::GetRowInfo](#csplitterwnd__getrowinfo)|Returns information on the specified row.|  
|[CSplitterWnd::GetScrollStyle](#csplitterwnd__getscrollstyle)|Returns the shared scroll-bar style.|  
|[CSplitterWnd::IdFromRowCol](#csplitterwnd__idfromrowcol)|Returns the child window ID of the pane at the specified row and column.|  
|[CSplitterWnd::IsChildPane](#csplitterwnd__ischildpane)|Call to determine whether the window is currently a child pane of this splitter window.|  
|[CSplitterWnd::IsTracking](#csplitterwnd__istracking)|Determines if splitter bar is currently being moved.|  
|[CSplitterWnd::RecalcLayout](#csplitterwnd__recalclayout)|Call to redisplay the splitter window after adjusting row or column size.|  
|[CSplitterWnd::SetActivePane](#csplitterwnd__setactivepane)|Sets a pane to be the active one in the frame.|  
|[CSplitterWnd::SetColumnInfo](#csplitterwnd__setcolumninfo)|Call to set the specified column information.|  
|[CSplitterWnd::SetRowInfo](#csplitterwnd__setrowinfo)|Call to set the specified row information.|  
|[CSplitterWnd::SetScrollStyle](#csplitterwnd__setscrollstyle)|Specifies the new scroll-bar style for the splitter window's shared scroll-bar support.|  
|[CSplitterWnd::SplitColumn](#csplitterwnd__splitcolumn)|Indicates where a frame window splits vertically.|  
|[CSplitterWnd::SplitRow](#csplitterwnd__splitrow)|Indicates where a frame window splits horizontally.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CSplitterWnd::OnDraw](#csplitterwnd__ondraw)|Called by the framework to draw the splitter window.|  
|[CSplitterWnd::OnDrawSplitter](#csplitterwnd__ondrawsplitter)|Renders an image of a split window.|  
|[CSplitterWnd::OnInvertTracker](#csplitterwnd__oninverttracker)|Renders the image of a split window to be the same size and shape as the frame window.|  
  
## Remarks  
 A pane is usually an application-specific object derived from [CView](../vs140/cview-class.md), but it can be any [CWnd](../vs140/cwnd-class.md) object that has the appropriate child window ID.  
  
 A <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object is usually embedded in a parent [CFrameWnd](../vs140/cframewnd-class.md) or [CMDIChildWnd](../vs140/cmdichildwnd-class.md) object. Create a <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object using the following steps:  
  
1.  Embed a <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> member variable in the parent frame.  
  
2.  Override the parent frame's [CFrameWnd::OnCreateClient](../vs140/cframewnd-class.md#cframewnd__oncreateclient) member function.  
  
3.  From within the overridden <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, call the [Create](#csplitterwnd__create) or [CreateStatic](#csplitterwnd__createstatic) member function of <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>.  
  
 Call the **Create** member function to create a dynamic splitter window. A dynamic splitter window typically is used to create and scroll a number of individual panes, or views, of the same document. The framework automatically creates an initial pane for the splitter; then the framework creates, resizes, and disposes of additional panes as the user operates the splitter window's controls.  
  
 When you call **Create**, you specify a minimum row height and column width that determine when the panes are too small to be fully displayed. After you call **Create**, you can adjust these minimums by calling the [SetColumnInfo](#csplitterwnd__setcolumninfo) and [SetRowInfo](#csplitterwnd__setrowinfo) member functions.  
  
 Also use the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> member functions to set an "ideal" width for a column and "ideal" height for a row. When the framework displays a splitter window, it first displays the parent frame, then the splitter window. The framework then lays out the panes in columns and rows according to their ideal dimensions, working from the upper-left to the lower-right corner of the splitter window's client area.  
  
 All panes in a dynamic splitter window must be of the same class. Familiar applications that support dynamic splitter windows include Microsoft Word and Microsoft Excel.  
  
 Use the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> member function to create a static splitter window. The user can change only the size of the panes in a static splitter window, not their number or order.  
  
 You must specifically create all the static splitter's panes when you create the static splitter. Make sure you create all the panes before the parent frame's <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> member function returns, or the framework will not display the window correctly.  
  
 The <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> member function automatically initializes a static splitter with a minimum row height and column width of 0. After you call **Create**, adjust these minimums by calling the [SetColumnInfo](#csplitterwnd__setcolumninfo) and [SetRowInfo](#csplitterwnd__setrowinfo) member functions. Also use <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> after you call <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> to indicate desired ideal pane dimensions.  
  
 The individual panes of a static splitter often belong to different classes. For examples of static splitter windows, see the graphics editor and the Windows File Manager.  
  
 A splitter window supports special scroll bars (apart from the scroll bars that panes may have). These scroll bars are children of the <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> object and are shared with the panes.  
  
 You create these special scroll bars when you create the splitter window. For example, a <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> that has one row, two columns, and the **WS_VSCROLL** style will display a vertical scroll bar that is shared by the two panes. When the user moves the scroll bar, <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> messages are sent to both panes. When the panes set the scroll-bar position, the shared scroll bar is set.  
  
 For further information on splitter windows, see:  
  
-   [Technical Note 29](../vs140/tn029--splitter-windows.md)  
  
-   Knowledge Base article Q262024: HOWTO: Use CPropertySheet as a Child of CSplitterWnd  
  
 For more information on how to create dynamic splitter windows, see:  
  
-   MFC sample [Scribble](../vs140/visual-c---samples.md)  
  
-   MFC sample [VIEWEX](../vs140/visual-c---samples.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxext.h  
  
##  \<a name="csplitterwnd__activatenext">\</a>  CSplitterWnd::ActivateNext  
 Called by the framework to perform the Next Pane or Previous Pane command.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 Indicates which window to activate. **TRUE** for previous; **FALSE** for next.  
  
### Remarks  
 This member function is a high level command that is used by the [CView](../vs140/cview-class.md) class to delegate to the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> implementation.  
  
##  \<a name="csplitterwnd__canactivatenext">\</a>  CSplitterWnd::CanActivateNext  
 Called by the framework to check to see if the Next Pane or Previous Pane command is currently possible.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 Indicates which window to activate. **TRUE** for previous; **FALSE** for next.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 This member function is a high level command that is used by the [CView](../vs140/cview-class.md) class to delegate to the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> implementation.  
  
##  \<a name="csplitterwnd__create">\</a>  CSplitterWnd::Create  
 To create a dynamic splitter window, call the **Create** member function.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 The parent frame window of the splitter window.  
  
 *nMaxRows*  
 The maximum number of rows in the splitter window. This value must not exceed 2.  
  
 *nMaxCols*  
 The maximum number of columns in the splitter window. This value must not exceed 2.  
  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 Specifies the minimum size at which a pane may be displayed.  
  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 A pointer to a [CCreateContext](../vs140/ccreatecontext-structure.md) structure. In most cases, this can be the <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> passed to the parent frame window.  
  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 Specifies the window style.  
  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 The child window ID of the window. The ID can be **AFX_IDW_PANE_FIRST** unless the splitter window is nested inside another splitter window.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 You can embed a <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> in a parent [CFrameWnd](../vs140/cframewnd-class.md) or [CMDIChildWnd](../vs140/cmdichildwnd-class.md) object by taking the following steps:  
  
1.  Embed a <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> member variable in the parent frame.  
  
2.  Override the parent frame's [CFrameWnd::OnCreateClient](../vs140/cframewnd-class.md#cframewnd__oncreateclient) member function.  
  
3.  Call the **Create** member function from within the overridden <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>.  
  
 When you create a splitter window from within a parent frame, pass the parent frame's <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> parameter to the splitter window. Otherwise, this parameter can be **NULL**.  
  
 The initial minimum row height and column width of a dynamic splitter window are set by the <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> parameter. These minimums, which determine whether a pane is too small to be shown in its entirety, can be changed with the [SetRowInfo](#csplitterwnd__setrowinfo) and [SetColumnInfo](#csplitterwnd__setcolumninfo) member functions.  
  
 For more on dynamic splitter windows, see "Splitter Windows" in the article [Multiple Document Types, Views, and Frame Windows](../vs140/multiple-document-types--views--and-frame-windows.md), [Technical Note 29](../vs140/tn029--splitter-windows.md), and the [CSplitterWnd](../vs140/csplitterwnd-class.md) class overview.  
  
### Example  
 [!code[NVC_MFCWindowing#125](../vs140/codesnippet/CPP/csplitterwnd-class_1.cpp)]  
  
##  \<a name="csplitterwnd__createscrollbarctrl">\</a>  CSplitterWnd::CreateScrollBarCtrl  
 Called by the framework to create a shared scroll bar control.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 Specifies the window style.  
  
 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
 The child window ID of the window. The ID can be **AFX_IDW_PANE_FIRST** unless the splitter window is nested inside another splitter window.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 Override <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> to include extra controls next to a scroll bar. The default behavior is to create normal Windows scroll bar controls.  
  
##  \<a name="csplitterwnd__createstatic">\</a>  CSplitterWnd::CreateStatic  
 To create a static splitter window, call the <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> member function.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
 The parent frame window of the splitter window.  
  
 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
 The number of rows. This value must not exceed 16.  
  
 *nCols*  
 The number of columns. This value must not exceed 16.  
  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
 Specifies the window style.  
  
 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 The child window ID of the window. The ID can be **AFX_IDW_PANE_FIRST** unless the splitter window is nested inside another splitter window.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 A <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> is usually embedded in a parent <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> or [CMDIChildWnd](../vs140/cmdichildwnd-class.md) object by taking the following steps:  
  
1.  Embed a <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> member variable in the parent frame.  
  
2.  Override the parent frame's <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> member function.  
  
3.  Call the <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> member function from within the overridden [CFrameWnd::OnCreateClient](../vs140/cframewnd-class.md#cframewnd__oncreateclient).  
  
 A static splitter window contains a fixed number of panes, often from different classes.  
  
 When you create a static splitter window, you must at the same time create all its panes. The [CreateView](#csplitterwnd__createview) member function is usually used for this purpose, but you can create other nonview classes as well.  
  
 The initial minimum row height and column width for a static splitter window is 0. These minimums, which determine when a pane is too small to be shown in its entirety, can be changed with the [SetRowInfo](#csplitterwnd__setrowinfo) and [SetColumnInfo](#csplitterwnd__setcolumninfo) member functions.  
  
 To add scroll bars to a static splitter window, add the **WS_HSCROLL** and **WS_VSCROLL** styles to <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>.  
  
 See "Splitter Windows" in the article [Multiple Document Types, Views, and Frame Windows](../vs140/multiple-document-types--views--and-frame-windows.md), [Technical Note 29](../vs140/tn029--splitter-windows.md), and the [CSplitterWnd](../vs140/csplitterwnd-class.md) class overview for more on static splitter windows.  
  
##  \<a name="csplitterwnd__createview">\</a>  CSplitterWnd::CreateView  
 Creates the panes for a static splitter window.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
 Specifies the splitter window row in which to place the new view.  
  
 <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
 Specifies the splitter window column in which to place the new view.  
  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 Specifies the [CRuntimeClass](../vs140/cruntimeclass-structure.md) of the new view.  
  
 *sizeInit*  
 Specifies the initial size of the new view.  
  
 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
 A pointer to a creation context used to create the view (usually the <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> passed into the parent frame's overridden [CFrameWnd::OnCreateClient](../vs140/cframewnd-class.md#cframewnd__oncreateclient) member function in which the splitter window is being created).  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 All panes of a static splitter window must be created before the framework displays the splitter.  
  
 The framework also calls this member function to create new panes when the user of a dynamic splitter window splits a pane, row, or column.  
  
### Example  
 [!code[NVC_MFCWindowing#4](../vs140/codesnippet/CPP/csplitterwnd-class_2.cpp)]  
  
##  \<a name="csplitterwnd__csplitterwnd">\</a>  CSplitterWnd::CSplitterWnd  
 Call to construct a <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Remarks  
 Construct a <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> object in two steps. First, call the constructor, which creates the <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> object, and then call the [Create](#csplitterwnd__create) member function, which creates the splitter window and attaches it to the <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> object.  
  
##  \<a name="csplitterwnd__deletecolumn">\</a>  CSplitterWnd::DeleteColumn  
 Deletes a column from the splitter window.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 *colDelete*  
 Specifies the column to be deleted.  
  
### Remarks  
 This member function is called by the framework to implement the logic of the dynamic splitter window (that is, if the splitter window has the **SPLS_DYNAMIC_SPLIT** style). It can be customized, along with the virtual function [CreateView](#csplitterwnd__createview), to implement more advanced dynamic splitters.  
  
##  \<a name="csplitterwnd__deleterow">\</a>  CSplitterWnd::DeleteRow  
 Deletes a row from the splitter window.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 *rowDelete*  
 Specifies the row to be deleted.  
  
### Remarks  
 This member function is called by the framework to implement the logic of the dynamic splitter window (that is, if the splitter window has the **SPLS_DYNAMIC_SPLIT** style). It can be customized, along with the virtual function [CreateView](#csplitterwnd__createview), to implement more advanced dynamic splitters.  
  
##  \<a name="csplitterwnd__deleteview">\</a>  CSplitterWnd::DeleteView  
 Deletes a view from the splitter window.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
 Specifies the splitter window row at which to delete the view.  
  
 <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
 Specifies the splitter window column at which to delete the view.  
  
### Remarks  
 If the active view is being deleted, the next view will become active. The default implementation assumes the view will auto delete in [PostNcDestroy](../vs140/cwnd-class.md#cwnd__postncdestroy).  
  
 This member function is called by the framework to implement the logic of the dynamic splitter window (that is, if the splitter window has the **SPLS_DYNAMIC_SPLIT** style). It can be customized, along with the virtual function [CreateView](#csplitterwnd__createview), to implement more advanced dynamic splitters.  
  
##  \<a name="csplitterwnd__dokeyboardsplit">\</a>  CSplitterWnd::DoKeyboardSplit  
 Performs the keyboard split command, usually "Window Split."  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 This member function is a high level command that is used by the [CView](../vs140/cview-class.md) class to delegate to the <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> implementation.  
  
##  \<a name="csplitterwnd__doscroll">\</a>  CSplitterWnd::DoScroll  
 Performs synchronized scrolling of split windows.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
 A pointer to the view from which the scrolling message originates.  
  
 <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
 A scroll-bar code that indicates the user's scrolling request. This parameter is composed of two parts: a low-order byte, which determines the type of scrolling occurring horizontally, and a high-order byte, which determines the type of scrolling occurring vertically:  
  
-   **SB_BOTTOM** Scrolls to bottom.  
  
-   **SB_LINEDOWN** Scrolls one line down.  
  
-   **SB_LINEUP** Scrolls one line up.  
  
-   **SB_PAGEDOWN** Scrolls one page down.  
  
-   **SB_PAGEUP** Scrolls one page up.  
  
-   **SB_TOP** Scrolls to top.  
  
 <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
 Determines whether the specified scrolling action occurs. If <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> is **TRUE** (that is, if a child window exists, and if the split windows have a scroll range), then the specified scrolling action can take place; if <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> is **FALSE** (that is, if no child window exists, or the split views have no scroll range), then scrolling does not occur.  
  
### Return Value  
 Nonzero if synchronized scrolling occurs; otherwise 0.  
  
### Remarks  
 This member function is called by the framework to perform synchronized scrolling of split windows when the view receives a scroll message. Override to require an action by the user before synchronized scrolling is allowed.  
  
##  \<a name="csplitterwnd__doscrollby">\</a>  CSplitterWnd::DoScrollBy  
 Scrolls split windows by a given number of pixels.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
 A pointer to the view from which the scrolling message originates.  
  
 <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
 Number of pixels to be scrolled horizontally and vertically.  
  
 bDoScroll  
 Determines whether the specified scrolling action occurs. If <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> is **TRUE** (that is, if a child window exists, and if the split windows have a scroll range), then the specified scrolling action can take place; if <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> is **FALSE** (that is, if no child window exists, or the split views have no scroll range), then scrolling does not occur.  
  
### Return Value  
 Nonzero if synchronized scrolling occurs; otherwise 0.  
  
### Remarks  
 This member function is called by the framework in response to a scroll message, to perform synchronized scrolling of the split windows by the amount, in pixels, indicated by <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>. Positive values indicate scrolling down and to the right; negative values indicate scrolling up and to the left.  
  
 Override to require an action by the user before allowing scroll.  
  
##  \<a name="csplitterwnd__getactivepane">\</a>  CSplitterWnd::GetActivePane  
 Determines the active pane from the focus or active view in the frame.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>  
 A pointer to an **int** to retrieve the row number of the active pane.  
  
 <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  
 A pointer to an **int** to retrieve the column number of the active pane.  
  
### Return Value  
 Pointer to the active pane. **NULL** if no active pane exists.  
  
### Remarks  
 This member function is called by the framework to determine the active pane in a splitter window. Override to require an action by the user before getting the active pane.  
  
##  \<a name="csplitterwnd__getcolumncount">\</a>  CSplitterWnd::GetColumnCount  
 Returns the current pane column count.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
 Returns the current number of columns in the splitter. For a static splitter, this will also be the maximum number of columns.  
  
##  \<a name="csplitterwnd__getcolumninfo">\</a>  CSplitterWnd::GetColumnInfo  
 Returns information on the specified column.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>  
 Specifies a column.  
  
 *cxCur*  
 A reference to an <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> to be set to the current width of the column.  
  
 <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
 A reference to an <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> to be set to the current minimum width of the column.  
  
##  \<a name="csplitterwnd__getpane">\</a>  CSplitterWnd::GetPane  
 Returns the pane at the specified row and column.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
 Specifies a row.  
  
 <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>  
 Specifies a column.  
  
### Return Value  
 Returns the pane at the specified row and column. The returned pane is usually a [CView](../vs140/cview-class.md)-derived class.  
  
##  \<a name="csplitterwnd__getrowcount">\</a>  CSplitterWnd::GetRowCount  
 Returns the current pane row count.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Return Value  
 Returns the current number of rows in the splitter window. For a static splitter window, this will also be the maximum number of rows.  
  
##  \<a name="csplitterwnd__getrowinfo">\</a>  CSplitterWnd::GetRowInfo  
 Returns information on the specified row.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>  
 Specifies a row.  
  
 <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>  
 Reference to <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> to be set to the current height of the row in pixels.  
  
 <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>  
 Reference to <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> to be set to the current minimum height of the row in pixels.  
  
### Remarks  
 Call this member function to obtain information about the specified row. The <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> parameter is filled with the current height of the specified row, and <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> is filled with the minimum height of the row.  
  
##  \<a name="csplitterwnd__getscrollstyle">\</a>  CSplitterWnd::GetScrollStyle  
 Returns the shared scroll-bar style for the splitter window.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Return Value  
 One or more of the following windows style flags, if successful:  
  
-   **WS_HSCROLL** If the splitter currently manages shared horizontal scroll bars.  
  
-   **WS_VSCROLL** If the splitter currently manages shared vertical scroll bars.  
  
 If zero, the splitter window does not currently manage any shared scroll bars.  
  
##  \<a name="csplitterwnd__idfromrowcol">\</a>  CSplitterWnd::IdFromRowCol  
 Obtains the child window ID for the pane at the specified row and column.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>  
 Specifies the splitter window row.  
  
 <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  
 Specifies the splitter window column.  
  
### Return Value  
 The child window ID for the pane.  
  
### Remarks  
 This member function is used for creating nonviews as panes and may be called before the pane exists.  
  
### Example  
 [!code[NVC_MFCWindowing#5](../vs140/codesnippet/CPP/csplitterwnd-class_3.cpp)]  
  
##  \<a name="csplitterwnd__ischildpane">\</a>  CSplitterWnd::IsChildPane  
 Determines whether <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> is currently a child pane of this splitter window.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>  
 A pointer to a [CWnd](../vs140/cwnd-class.md) object to be tested.  
  
 <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>  
 A pointer to an <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> in which to store row number.  
  
 <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>  
 A pointer to an <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> in which to store a column number.  
  
### Return Value  
 If nonzero, <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> is currently a child pane of this splitter window, and <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> are filled in with the position of the pane in the splitter window. If <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> is not a child pane of this splitter window, 0 is returned.  
  
### Remarks  
 In Visual C++ versions prior to 6.0, this function was defined as  
  
 <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>  
  
 This version is now obsolete and should not be used.  
  
##  \<a name="csplitterwnd__istracking">\</a>  CSplitterWnd::IsTracking  
 Call this member function to determine if the splitter bar in the window is currently being moved.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if a splitter operation is in progress; otherwise 0.  
  
##  \<a name="csplitterwnd__ondrawsplitter">\</a>  CSplitterWnd::OnDrawSplitter  
 Renders an image of a split window.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>  
 A pointer to the device context in which to draw. If <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> is **NULL**, then [CWnd::RedrawWindow](../vs140/cwnd-class.md#cwnd__redrawwindow) is called by the framework and no split window is drawn.  
  
 <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>  
 A value of the **enum ESplitType**, which can be one of the following:  
  
-   **splitBox** The splitter drag box.  
  
-   <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> The bar that appears between the two split windows.  
  
-   **splitIntersection** The intersection of the split windows. This element will not be called when running on Windows 95/98.  
  
-   **splitBorder** The split window borders.  
  
 <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>  
 A reference to a [CRect](../vs140/crect-class.md) object specifying the size and shape of the split windows.  
  
### Remarks  
 This member function is called by the framework to draw and specify the exact characteristics of a splitter window. Override <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> for advanced customization of the imagery for the various graphical components of a splitter window. The default imagery is similar to the splitter in Microsoft Works for Windows or Microsoft Windows 95/98, in that the intersections of the splitter bars are blended together.  
  
 For more on dynamic splitter windows, see "Splitter Windows" in the article [Multiple Document Types, Views, and Frame Windows](../vs140/multiple-document-types--views--and-frame-windows.md), [Technical Note 29](../vs140/tn029--splitter-windows.md), and the [CSplitterWnd](../vs140/csplitterwnd-class.md) class overview.  
  
##  \<a name="csplitterwnd__oninverttracker">\</a>  CSplitterWnd::OnInvertTracker  
 Renders the image of a split window to be the same size and shape as the frame window.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>  
 Reference to a <CodeContentPlaceHolder>140\</CodeContentPlaceHolder> object specifying the tracking rectangle.  
  
### Remarks  
 This member function is called by the framework during resizing of splitters. Override <CodeContentPlaceHolder>141\</CodeContentPlaceHolder> for advanced customization of the imagery of the splitter window. The default imagery is similar to the splitter in Microsoft Works for Windows or Microsoft Windows 95/98, in that the intersections of the splitter bars are blended together.  
  
 For more on dynamic splitter windows, see "Splitter Windows" in the article [Multiple Document Types, Views, and Frame Windows](../vs140/multiple-document-types--views--and-frame-windows.md), [Technical Note 29](../vs140/tn029--splitter-windows.md), and the [CSplitterWnd](../vs140/csplitterwnd-class.md) class overview.  
  
##  \<a name="csplitterwnd__recalclayout">\</a>  CSplitterWnd::RecalcLayout  
 Call to redisplay the splitter window after adjusting row or column size.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Remarks  
 Call this member function to correctly redisplay the splitter window after you have adjusted row and column sizes with the [SetRowInfo](#csplitterwnd__setrowinfo) and [SetColumnInfo](#csplitterwnd__setcolumninfo) member functions. If you change row and column sizes as part of the creation process before the splitter window is visible, it is not necessary to call this member function.  
  
 The framework calls this member function whenever the user resizes the splitter window or moves a split.  
  
### Example  
  See the example for [CSplitterWnd::SetColumnInfo](#csplitterwnd__setcolumninfo).  
  
##  \<a name="csplitterwnd__setactivepane">\</a>  CSplitterWnd::SetActivePane  
 Sets a pane to be the active one in the frame.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>143\</CodeContentPlaceHolder> is **NULL**, specifies the row in the pane that will be active.  
  
 <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>145\</CodeContentPlaceHolder> is **NULL**, specifies the column in the pane that will be active.  
  
 <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>147\</CodeContentPlaceHolder> object. If **NULL**, the pane specified by <CodeContentPlaceHolder>148\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>149\</CodeContentPlaceHolder> is set active. If not **NULL**, specifies the pane that is set active.  
  
### Remarks  
 This member function is called by the framework to set a pane as active when the user changes the focus to a pane within the frame window. You can explicitly call <CodeContentPlaceHolder>150\</CodeContentPlaceHolder> to change the focus to the specified view.  
  
 Specify pane by providing either row and column, **or** by providing <CodeContentPlaceHolder>151\</CodeContentPlaceHolder>.  
  
##  \<a name="csplitterwnd__setcolumninfo">\</a>  CSplitterWnd::SetColumnInfo  
 Call to set the specified column information.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>  
 Specifies a splitter window column.  
  
 *cxIdeal*  
 Specifies an ideal width for the splitter window column in pixels.  
  
 <CodeContentPlaceHolder>153\</CodeContentPlaceHolder>  
 Specifies a minimum width for the splitter window column in pixels.  
  
### Remarks  
 Call this member function to set a new minimum width and ideal width for a column. The column minimum value determines when the column will be too small to be fully displayed.  
  
 When the framework displays the splitter window, it lays out the panes in columns and rows according to their ideal dimensions, working from the upper-left to the lower-right corner of the splitter window's client area.  
  
### Example  
 [!code[NVC_MFCWindowing#6](../vs140/codesnippet/CPP/csplitterwnd-class_4.cpp)]  
  
##  \<a name="csplitterwnd__setrowinfo">\</a>  CSplitterWnd::SetRowInfo  
 Call to set the specified row information.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>154\</CodeContentPlaceHolder>  
 Specifies a splitter window row.  
  
 *cyIdeal*  
 Specifies an ideal height for the splitter window row in pixels.  
  
 <CodeContentPlaceHolder>155\</CodeContentPlaceHolder>  
 Specifies a minimum height for the splitter window row in pixels.  
  
### Remarks  
 Call this member function to set a new minimum height and ideal height for a row. The row minimum value determines when the row will be too small to be fully displayed.  
  
 When the framework displays the splitter window, it lays out the panes in columns and rows according to their ideal dimensions, working from the upper-left to the lower-right corner of the splitter window's client area.  
  
##  \<a name="csplitterwnd__setscrollstyle">\</a>  CSplitterWnd::SetScrollStyle  
 Specifies the new scroll style for the splitter window's shared scroll-bar support.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>  
 The new scroll style for the splitter window's shared scroll-bar support, which can be one of the following values:  
  
-   **WS_HSCROLL** Create/show horizontal shared scroll bars.  
  
-   **WS_VSCROLL** Create/show vertical shared scroll bars.  
  
### Remarks  
 Once a scroll bar is created it will not be destroyed even if <CodeContentPlaceHolder>157\</CodeContentPlaceHolder> is called without that style; instead those scroll bars are hidden. This allows the scroll bars to retain their state even though they are hidden. After calling <CodeContentPlaceHolder>158\</CodeContentPlaceHolder> it is necessary to call [RecalcLayout](#csplitterwnd__recalclayout) for all the changes to take effect.  
  
##  \<a name="csplitterwnd__splitcolumn">\</a>  CSplitterWnd::SplitColumn  
 Indicates where a frame window splits vertically.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 *cxBefore*  
 The position, in pixels, before which the split occurs.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 This member function is called when a vertical splitter window is created. <CodeContentPlaceHolder>159\</CodeContentPlaceHolder> indicates the default location where the split occurs.  
  
 <CodeContentPlaceHolder>160\</CodeContentPlaceHolder> is called by the framework to implement the logic of the dynamic splitter window (that is, if the splitter window has the **SPLS_DYNAMIC_SPLIT** style). It can be customized, along with the virtual function [CreateView](#csplitterwnd__createview), to implement more advanced dynamic splitters.  
  
##  \<a name="csplitterwnd__splitrow">\</a>  CSplitterWnd::SplitRow  
 Indicates where a frame window splits horizontally.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Parameters  
 *cyBefore*  
 The position, in pixels, before which the split occurs.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 This member function is called when a horizontal splitter window is created. <CodeContentPlaceHolder>161\</CodeContentPlaceHolder> indicates the default location where the split occurs.  
  
 <CodeContentPlaceHolder>162\</CodeContentPlaceHolder> is called by the framework to implement the logic of the dynamic splitter window (that is, if the splitter window has the **SPLS_DYNAMIC_SPLIT** style). It can be customized, along with the virtual function [CreateView](#csplitterwnd__createview), to implement more advanced dynamic splitters.  
  
##  \<a name="csplitterwnd__ondraw">\</a>  CSplitterWnd::OnDraw  
 Called by the framework to draw the splitter window.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>163\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
### Remarks  
  
## See Also  
 [MFC Sample VIEWEX](../vs140/visual-c---samples.md)   
 [Base Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CView](../vs140/cview-class.md)   
 [CWnd](../vs140/cwnd-class.md)