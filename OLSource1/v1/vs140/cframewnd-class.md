---
title: "CFrameWnd Class"
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
  - "CFrameWnd"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "frame window classes, base class"
  - "single document interface (SDI), frame windows"
  - "frame windows, creating"
  - "CFrameWnd class"
ms.assetid: e2220aba-5bf4-4002-b960-fbcafcad01f1
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWnd Class
Provides the functionality of a Windows single document interface (SDI) overlapped or pop-up frame window, along with members for managing the window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CFrameWnd::CFrameWnd](#cframewnd__cframewnd)|Constructs a <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CFrameWnd::ActivateFrame](#cframewnd__activateframe)|Makes the frame visible and available to the user.|  
|[CFrameWnd::BeginModalState](#cframewnd__beginmodalstate)|Sets the frame window to modal.|  
|[CFrameWnd::Create](#cframewnd__create)|Call to create and initialize the Windows frame window associated with the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> object.|  
|[CFrameWnd::CreateView](#cframewnd__createview)|Creates a view within a frame that is not derived from <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>.|  
|[CFrameWnd::DockControlBar](#cframewnd__dockcontrolbar)|Docks a control bar.|  
|[CFrameWnd::EnableDocking](#cframewnd__enabledocking)|Allows a control bar to be docked.|  
|[CFrameWnd::EndModalState](#cframewnd__endmodalstate)|Ends the frame window's modal state. Enables all of the windows disabled by <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>.|  
|[CFrameWnd::FloatControlBar](#cframewnd__floatcontrolbar)|Floats a control bar.|  
|[CFrameWnd::GetActiveDocument](#cframewnd__getactivedocument)|Returns the active **CDocument** object.|  
|[CFrameWnd::GetActiveFrame](#cframewnd__getactiveframe)|Returns the active <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> object.|  
|[CFrameWnd::GetActiveView](#cframewnd__getactiveview)|Returns the active <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> object.|  
|[CFrameWnd::GetControlBar](#cframewnd__getcontrolbar)|Retrieves the control bar.|  
|[CFrameWnd::GetDockState](#cframewnd__getdockstate)|Retrieves the dock state of a frame window.|  
|[CFrameWnd::GetMenuBarState](#cframewnd__getmenubarstate)|Retrieves the display state of the menu in the current MFC application.|  
|[CFrameWnd::GetMenuBarVisibility](#cframewnd__getmenubarvisibility)|Indicates whether the default behavior of the menu in the current MFC application is  either hidden or visible.|  
|[CFrameWnd::GetMessageBar](#cframewnd__getmessagebar)|Returns a pointer to the status bar belonging to the frame window.|  
|[CFrameWnd::GetMessageString](#cframewnd__getmessagestring)|Retrieves message corresponding to a command ID.|  
|[CFrameWnd::GetTitle](#cframewnd__gettitle)|Retrieves the title of the related control bar.|  
|[CFrameWnd::InitialUpdateFrame](#cframewnd__initialupdateframe)|Causes the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> member function belonging to all views in the frame window to be called.|  
|[CFrameWnd::InModalState](#cframewnd__inmodalstate)|Returns a value indicating whether or not a frame window is in a modal state.|  
|[CFrameWnd::IsTracking](#cframewnd__istracking)|Determines if splitter bar is currently being moved.|  
|[CFrameWnd::LoadAccelTable](#cframewnd__loadacceltable)|Call to load an accelerator table.|  
|[CFrameWnd::LoadBarState](#cframewnd__loadbarstate)|Call to restore control bar settings.|  
|[CFrameWnd::LoadFrame](#cframewnd__loadframe)|Call to dynamically create a frame window from resource information.|  
|[CFrameWnd::NegotiateBorderSpace](#cframewnd__negotiateborderspace)|Negotiates border space in the frame window.|  
|[CFrameWnd::OnBarCheck](#cframewnd__onbarcheck)|Called whenever an action is performed on the specified control bar.|  
|[CFrameWnd::OnContextHelp](#cframewnd__oncontexthelp)|Handles SHIFT+F1 Help for in-place items.|  
|[CFrameWnd::OnSetPreviewMode](#cframewnd__onsetpreviewmode)|Sets the application's main frame window into and out of print-preview mode.|  
|[CFrameWnd::OnUpdateControlBarMenu](#cframewnd__onupdatecontrolbarmenu)|Called by the framework when the associated menu is updated.|  
|[CFrameWnd::RecalcLayout](#cframewnd__recalclayout)|Repositions the control bars of the <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> object.|  
|[CFrameWnd::SaveBarState](#cframewnd__savebarstate)|Call to save control bar settings.|  
|[CFrameWnd::SetActivePreviewView](#cframewnd__setactivepreviewview)|Designates the specified view to be the active view for Rich Preview.|  
|[CFrameWnd::SetActiveView](#cframewnd__setactiveview)|Sets the active <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> object.|  
|[CFrameWnd::SetDockState](#cframewnd__setdockstate)|Call to dock the frame window in the main window.|  
|[CFrameWnd::SetMenuBarState](#cframewnd__setmenubarstate)|Sets the display state of the menu in the current MFC application to hidden or displayed.|  
|[CFrameWnd::SetMenuBarVisibility](#cframewnd__setmenubarvisibility)|Sets the default behavior of the menu in the current MFC application to be either hidden or visible.|  
|[CFrameWnd::SetMessageText](#cframewnd__setmessagetext)|Sets the text of a standard status bar.|  
|[CFrameWnd::SetProgressBarPosition](#cframewnd__setprogressbarposition)|Sets current position for Windows 7 progress bar displayed on taskbar.|  
|[CFrameWnd::SetProgressBarRange](#cframewnd__setprogressbarrange)|Sets range for Windows 7 progress bar displayed on taskbar.|  
|[CFrameWnd::SetProgressBarState](#cframewnd__setprogressbarstate)|Sets the type and state of the progress indicator displayed on a taskbar button.|  
|[CFrameWnd::SetTaskbarOverlayIcon](#cframewnd__settaskbaroverlayicon)|Overloaded. Applies an overlay to a taskbar button to indicate application status or a notification to the user.|  
|[CFrameWnd::SetTitle](#cframewnd__settitle)|Sets the title of the related control bar.|  
|[CFrameWnd::ShowControlBar](#cframewnd__showcontrolbar)|Call to show the control bar.|  
|[CFrameWnd::ShowOwnedWindows](#cframewnd__showownedwindows)|Shows all windows that are descendants of the <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> object.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CFrameWnd::OnCreateClient](#cframewnd__oncreateclient)|Creates a client window for the frame.|  
|[CFrameWnd::OnHideMenuBar](#cframewnd__onhidemenubar)|Called before the menu in the current MFC application is hidden.|  
|[CFrameWnd::OnShowMenuBar](#cframewnd__onshowmenubar)|Called before the menu in the current MFC application is displayed.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CFrameWnd::m_bAutoMenuEnable](#cframewnd__m_bautomenuenable)|Controls automatic enable and disable functionality for menu items.|  
|[CFrameWnd::rectDefault](#cframewnd__rectdefault)|Pass this static <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> as a parameter when creating a <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> object to allow Windows to choose the window's initial size and position.|  
  
## Remarks  
 To create a useful frame window for your application, derive a class from <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>. Add member variables to the derived class to store data specific to your application. Implement message-handler member functions and a message map in the derived class to specify what happens when messages are directed to the window.  
  
 There are three ways to construct a frame window:  
  
-   Directly construct it using [Create](#cframewnd__create).  
  
-   Directly construct it using [LoadFrame](#cframewnd__loadframe).  
  
-   Indirectly construct it using a document template.  
  
 Before you call either **Create** or <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>, you must construct the frame-window object on the heap using the C++ **new** operator. Before calling **Create**, you can also register a window class with the [AfxRegisterWndClass](../vs140/afxregisterwndclass.md) global function to set the icon and class styles for the frame.  
  
 Use the **Create** member function to pass the frame's creation parameters as immediate arguments.  
  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> requires fewer arguments than **Create**, and instead retrieves most of its default values from resources, including the frame's caption, icon, accelerator table, and menu. To be accessible by <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>, all these resources must have the same resource ID (for example, **IDR_MAINFRAME**).  
  
 When a <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> object contains views and documents, they are created indirectly by the framework instead of directly by the programmer. The <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> object orchestrates the creation of the frame, the creation of the containing views, and the connection of the views to the appropriate document. The parameters of the <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> constructor specify the <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> of the three classes involved (document, frame, and view). A <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> object is used by the framework to dynamically create new frames when specified by the user (for example, by using the File New command or the multiple document interface (MDI) Window New command).  
  
 A frame-window class derived from <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> must be declared with <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> in order for the above <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> mechanism to work correctly.  
  
 A <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> contains default implementations to perform the following functions of a main window in a typical application for Windows:  
  
-   A <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> frame window keeps track of a currently active view that is independent of the Windows active window or the current input focus. When the frame is reactivated, the active view is notified by calling <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>.  
  
-   Command messages and many common frame-notification messages, including those handled by the <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> functions of <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>, are delegated by a <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> frame window to the currently active view.  
  
-   The currently active view (or currently active MDI child frame window in the case of an MDI frame) can determine the caption of the frame window. This feature can be disabled by turning off the **FWS_ADDTOTITLE** style bit of the frame window.  
  
-   A <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> frame window manages the positioning of the control bars, views, and other child windows inside the frame window's client area. A frame window also does idle-time updating of toolbar and other control-bar buttons. A <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> frame window also has default implementations of commands for toggling on and off the toolbar and status bar.  
  
-   A <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> frame window manages the main menu bar. When a pop-up menu is displayed, the frame window uses the **UPDATE_COMMAND_UI** mechanism to determine which menu items should be enabled, disabled, or checked. When the user selects a menu item, the frame window updates the status bar with the message string for that command.  
  
-   A <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> frame window has an optional accelerator table that automatically translates keyboard accelerators.  
  
-   A <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> frame window has an optional help ID set with <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> that is used for context-sensitive help. A frame window is the main orchestrator of semimodal states such as context-sensitive help (SHIFT+F1) and print-preview modes.  
  
-   A <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> frame window will open a file dragged from the File Manager and dropped on the frame window. If a file extension is registered and associated with the application, the frame window responds to the dynamic data exchange (DDE) open request that occurs when the user opens a data file in the File Manager or when the **ShellExecute** Windows function is called.  
  
-   If the frame window is the main application window (that is, <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>), when the user closes the application, the frame window prompts the user to save any modified documents (for <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>).  
  
-   If the frame window is the main application window, the frame window is the context for running WinHelp. Closing the frame window will shut down WINHELP.EXE if it was launched for help for this application.  
  
 Do not use the C++ **delete** operator to destroy a frame window. Use <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> instead. The <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> implementation of <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> will delete the C++ object when the window is destroyed. When the user closes the frame window, the default <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> handler will call <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>.  
  
 For more information on <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>, see [Frame Windows](../vs140/frame-windows.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxwin.h  
  
##  \<a name="cframewnd__activateframe">\</a>  CFrameWnd::ActivateFrame  
 Call this member function to activate and restore the frame window so that it is visible and available to the user.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
 Specifies the parameter to pass to [CWnd::ShowWindow](../vs140/cwnd-class.md#cwnd__showwindow). By default, the frame is shown and correctly restored.  
  
### Remarks  
 This member function is usually called after a non-user interface event such as a DDE, OLE, or other event that may show the frame window or its contents to the user.  
  
 The default implementation activates the frame and brings it to the top of the Z-order and, if necessary, carries out the same steps for the application's main frame window.  
  
 Override this member function to change how a frame is activated. For example, you can force MDI child windows to be maximized. Add the appropriate functionality, then call the base class version with an explicit <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>.  
  
### Example  
 [!code[NVC_MFCWindowing#1](../vs140/codesnippet/CPP/cframewnd-class_1.cpp)]  
  
##  \<a name="cframewnd__beginmodalstate">\</a>  CFrameWnd::BeginModalState  
 Call this member function to make a frame window modal.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
##  \<a name="cframewnd__cframewnd">\</a>  CFrameWnd::CFrameWnd  
 Constructs a <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> object, but does not create the visible frame window.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 Call **Create** to create the visible window.  
  
##  \<a name="cframewnd__create">\</a>  CFrameWnd::Create  
 Call to create and initialize the Windows frame window associated with the <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
 Points to a null-terminated character string that names the Windows class. The class name can be any name registered with the <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> global function or the **RegisterClass** Windows function. If **NULL**, uses the predefined default <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> attributes.  
  
 <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>  
 Points to a null-terminated character string that represents the window name. Used as text for the title bar.  
  
 <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>  
 Specifies the window [style](../vs140/window-styles.md) attributes. Include the **FWS_ADDTOTITLE** style if you want the title bar to automatically display the name of the document represented in the window.  
  
 <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
 Specifies the size and position of the window. The <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> value allows Windows to specify the size and position of the new window.  
  
 <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
 Specifies the parent window of this frame window. This parameter should be **NULL** for top-level frame windows.  
  
 *lpszMenuName*  
 Identifies the name of the menu resource to be used with the window. Use **MAKEINTRESOURCE** if the menu has an integer ID instead of a string. This parameter can be **NULL**.  
  
 <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>  
 Specifies the window extended [style](../vs140/extended-window-styles.md) attributes.  
  
 <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>  
 Specifies a pointer to a [CCreateContext](../vs140/ccreatecontext-structure.md) structure. This parameter can be **NULL**.  
  
### Return Value  
 Nonzero if initialization is successful; otherwise 0.  
  
### Remarks  
 Construct a <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> object in two steps. First, invoke the constructor, which constructs the <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> object, and then call **Create**, which creates the Windows frame window and attaches it to the <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> object. **Create** initializes the window's class name and window name and registers default values for its style, parent, and associated menu.  
  
 Use <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> rather than **Create** to load the frame window from a resource instead of specifying its arguments.  
  
##  \<a name="cframewnd__createview">\</a>  CFrameWnd::CreateView  
 Call <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> to create a view within a frame.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>  
 Specifies the type of view and document.  
  
 <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>  
 The ID number of a view.  
  
### Return Value  
 Pointer to a <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> object if successful; otherwise **NULL**.  
  
### Remarks  
 Use this member function to create "views" that are not <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>-derived within a frame. After calling <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>, you must manually set the view to active and set it to be visible; these tasks are not automatically performed by <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>.  
  
##  \<a name="cframewnd__dockcontrolbar">\</a>  CFrameWnd::DockControlBar  
 Causes a control bar to be docked to the frame window.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>  
 Points to the control bar to be docked.  
  
 <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>  
 Determines which sides of the frame window to consider for docking. It can be 0, or one or more of the following:  
  
-   <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> Dock to the top side of the frame window.  
  
-   **AFX_IDW_DOCKBAR_BOTTOM** Dock to the bottom side of the frame window.  
  
-   <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> Dock to the left side of the frame window.  
  
-   <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> Dock to the right side of the frame window.  
  
 If 0, the control bar can be docked to any side enabled for docking in the destination frame window.  
  
 <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>  
 Determines, in screen coordinates, where the control bar will be docked in the nonclient area of the destination frame window.  
  
### Remarks  
 The control bar will be docked to one of the sides of the frame window specified in the calls to both [CControlBar::EnableDocking](../vs140/ccontrolbar-class.md#ccontrolbar__enabledocking) and [CFrameWnd::EnableDocking](#cframewnd__enabledocking). The side chosen is determined by <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>.  
  
##  \<a name="cframewnd__enabledocking">\</a>  CFrameWnd::EnableDocking  
 Call this function to enable dockable control bars in a frame window.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>  
 Specifies which sides of the frame window can serve as docking sites for control bars. It can be one or more of the following:  
  
-   <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> Allows docking at the top of the client area.  
  
-   <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> Allows docking at the bottom of the client area.  
  
-   <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> Allows docking on the left side of the client area.  
  
-   <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> Allows docking on the right side of the client area.  
  
-   <CodeContentPlaceHolder>137\</CodeContentPlaceHolder> Allows docking on any side of the client area.  
  
### Remarks  
 By default, control bars will be docked to a side of the frame window in the following order: top, bottom, left, right.  
  
### Example  
  See the example for [CToolBar::Create](../vs140/ctoolbar-class.md#ctoolbar__create).  
  
##  \<a name="cframewnd__endmodalstate">\</a>  CFrameWnd::EndModalState  
 Call this member function to change a frame window from modal to modeless.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> enables all of the windows disabled by [BeginModalState](#cframewnd__beginmodalstate).  
  
##  \<a name="cframewnd__floatcontrolbar">\</a>  CFrameWnd::FloatControlBar  
 Call this function to cause a control bar to not be docked to the frame window.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>  
 Points to the control bar to be floated.  
  
 <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>  
 The location, in screen coordinates, where the top left corner of the control bar will be placed.  
  
 <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>  
 Specifies whether to align the control bar horizontally or vertically within its new frame window. It can be any one of the following:  
  
-   <CodeContentPlaceHolder>142\</CodeContentPlaceHolder> Orients the control bar vertically.  
  
-   <CodeContentPlaceHolder>143\</CodeContentPlaceHolder> Orients the control bar vertically.  
  
-   <CodeContentPlaceHolder>144\</CodeContentPlaceHolder> Orients the control bar horizontally.  
  
-   <CodeContentPlaceHolder>145\</CodeContentPlaceHolder> Orients the control bar horizontally.  
  
 If styles are passed specifying both horizontal and vertical orientation, the toolbar will be oriented horizontally.  
  
### Remarks  
 Typically, this is done at application startup when the program is restoring settings from the previous execution.  
  
 This function is called by the framework when the user causes a drop operation by releasing the left mouse button while dragging the control bar over a location that is not available for docking.  
  
##  \<a name="cframewnd__getactivedocument">\</a>  CFrameWnd::GetActiveDocument  
 Call this member function to obtain a pointer to the current **CDocument** attached to the current active view.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the current [CDocument](../vs140/cdocument-class.md). If there is no current document, returns **NULL**.  
  
##  \<a name="cframewnd__getactiveframe">\</a>  CFrameWnd::GetActiveFrame  
 Call this member function to obtain a pointer to the active multiple document interface (MDI) child window of an MDI frame window.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the active MDI child window. If the application is an SDI application, or the MDI frame window has no active document, the implicit **this** pointer will be returned.  
  
### Remarks  
 If there is no active MDI child or the application is a single document interface (SDI), the implicit **this** pointer is returned.  
  
##  \<a name="cframewnd__getactiveview">\</a>  CFrameWnd::GetActiveView  
 Call this member function to obtain a pointer to the active view (if any) attached to a frame window ( <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>).  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the current [CView](../vs140/cview-class.md). If there is no current view, returns **NULL**.  
  
### Remarks  
 This function returns **NULL** when called for an MDI main frame window ( <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>). In an MDI application, the MDI main frame window does not have a view associated with it. Instead, each individual child window ( <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>) has one or more associated views. The active view in an MDI application can be obtained by first finding the active MDI child window and then finding the active view for that child window. The active MDI child window can be found by calling the function <CodeContentPlaceHolder>149\</CodeContentPlaceHolder> or **GetActiveFrame** as demonstrated in the following:  
  
 [!code[NVC_MFCWindowing#2](../vs140/codesnippet/CPP/cframewnd-class_2.cpp)]  
  
##  \<a name="cframewnd__getcontrolbar">\</a>  CFrameWnd::GetControlBar  
 Call <CodeContentPlaceHolder>150\</CodeContentPlaceHolder> to gain access to the control bar that is associated with the ID.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>151\</CodeContentPlaceHolder>  
 The ID number of a control bar.  
  
### Return Value  
 A pointer to the control bar that is associated with the ID.  
  
### Remarks  
 The <CodeContentPlaceHolder>152\</CodeContentPlaceHolder> parameter refers to the unique identifier passed to the **Create** method of the control bar. For more information on control bars, refer to the topic entitled [Control Bars](../vs140/control-bars.md).  
  
 <CodeContentPlaceHolder>153\</CodeContentPlaceHolder> will return the control bar even if it is floating and thus is not currently a child window of the frame.  
  
##  \<a name="cframewnd__getdockstate">\</a>  CFrameWnd::GetDockState  
 Call this member function to store state information about the frame window's control bars in a <CodeContentPlaceHolder>154\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>155\</CodeContentPlaceHolder>  
 Contains the current state of the frame window's control bars upon return.  
  
### Remarks  
 You can then write the contents of <CodeContentPlaceHolder>156\</CodeContentPlaceHolder> to storage using <CodeContentPlaceHolder>157\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>158\</CodeContentPlaceHolder>. If you later want to restore the control bars to a previous state, load the state with <CodeContentPlaceHolder>159\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>, then call <CodeContentPlaceHolder>161\</CodeContentPlaceHolder> to apply the previous state to the frame window's control bars.  
  
##  \<a name="cframewnd__getmenubarstate">\</a>  CFrameWnd::GetMenuBarState  
 Retrieves the display state of the menu in the current MFC application.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
 The return value can have the following values:  
  
-   AFX_MBS_VISIBLE (0x01) – The menu is visible.  
  
-   AFX_MBS_HIDDEN (0x02) – The menu is hidden.  
  
### Remarks  
 If a runtime error occurs, this method asserts in Debug mode and raises an exception derived from the [CException](../vs140/cexception-class.md) class.  
  
##  \<a name="cframewnd__getmenubarvisibility">\</a>  CFrameWnd::GetMenuBarVisibility  
 Indicates whether the default state of the menu in the current MFC application is hidden or visible.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Return Value  
 This method returns one of the following values:  
  
-   AFX_MBV_KEEPVISIBLE (0x01) - The menu is displayed at all times, and by default does not have the focus.  
  
-   AFX_MBV_DISPLAYONFOCUS (0x02) - The menu is hidden by default. If the menu is hidden, press the ALT key to display the menu and give it the focus. If the menu is displayed, press the ALT or ESC key to hide it.  
  
-   AFX_MBV_ DISPLAYONFOCUS (0x02) &#124; AFX_MBV_DISPLAYONF10 (0x04) (bitwise combination (OR)) - The menu is hidden by default. If the menu is hidden, press the F10 key to display the menu and give it the focus. If the menu is displayed, press the F10 key to toggle the focus on or off the menu. The menu is displayed until you press the ALT or ESC key to hide it.  
  
### Remarks  
 If a runtime error occurs, this method asserts in Debug mode and raises an exception derived from the [CException](../vs140/cexception-class.md) class.  
  
##  \<a name="cframewnd__getmessagebar">\</a>  CFrameWnd::GetMessageBar  
 Call this member function to get a pointer to the status bar.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
 Pointer to the status-bar window.  
  
##  \<a name="cframewnd__getmessagestring">\</a>  CFrameWnd::GetMessageString  
 Override this function to provide custom strings for command IDs.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>162\</CodeContentPlaceHolder>  
 Resource ID of the desired message.  
  
 <CodeContentPlaceHolder>163\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>164\</CodeContentPlaceHolder> object into which to place the message.  
  
### Remarks  
 The default implementation simply loads the string specified by <CodeContentPlaceHolder>165\</CodeContentPlaceHolder> from the resource file. This function is called by the framework when the message string in the status bar needs updating.  
  
##  \<a name="cframewnd__gettitle">\</a>  CFrameWnd::GetTitle  
 Retrieves the title of the window object.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Return Value  
 A [CString](../vs140/cstringt-class.md) object containing the current title of the window object.  
  
##  \<a name="cframewnd__initialupdateframe">\</a>  CFrameWnd::InitialUpdateFrame  
 Call **IntitialUpdateFrame** after creating a new frame with **Create**.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>  
 Points to the document to which the frame window is associated. Can be **NULL**.  
  
 <CodeContentPlaceHolder>167\</CodeContentPlaceHolder>  
 If **TRUE**, indicates that the frame should become visible and active. If **FALSE**, no descendants are made visible.  
  
### Remarks  
 This causes all views in that frame window to receive their <CodeContentPlaceHolder>168\</CodeContentPlaceHolder> calls.  
  
 Also, if there was not previously an active view, the primary view of the frame window is made active. The primary view is a view with a child ID of **AFX_IDW_PANE_FIRST**. Finally, the frame window is made visible if <CodeContentPlaceHolder>169\</CodeContentPlaceHolder> is nonzero. If <CodeContentPlaceHolder>170\</CodeContentPlaceHolder> is 0, the current focus and visible state of the frame window will remain unchanged. It is not necessary to call this function when using the framework's implementation of File New and File Open.  
  
##  \<a name="cframewnd__inmodalstate">\</a>  CFrameWnd::InModalState  
 Call this member function to check if a frame window is modal or modeless.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if yes; otherwise 0.  
  
##  \<a name="cframewnd__istracking">\</a>  CFrameWnd::IsTracking  
 Call this member function to determine if the splitter bar in the window is currently being moved.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if a splitter operation is in progress; otherwise 0.  
  
##  \<a name="cframewnd__loadacceltable">\</a>  CFrameWnd::LoadAccelTable  
 Call to load the specified accelerator table.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>  
 Identifies the name of the accelerator resource. Use **MAKEINTRESOURCE** if the resource is identified with an integer ID.  
  
### Return Value  
 Nonzero if the accelerator table was successfully loaded; otherwise 0.  
  
### Remarks  
 Only one table can be loaded at a time.  
  
 Accelerator tables loaded from resources are freed automatically when the application terminates.  
  
 If you call <CodeContentPlaceHolder>172\</CodeContentPlaceHolder> to create the frame window, the framework loads an accelerator table along with the menu and icon resources, and a subsequent call to this member function is then unnecessary.  
  
##  \<a name="cframewnd__loadbarstate">\</a>  CFrameWnd::LoadBarState  
 Call this function to restore the settings of each control bar owned by the frame window.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>173\</CodeContentPlaceHolder>  
 Name of a section in the initialization (INI) file or a key in the Windows registry where state information is stored.  
  
### Remarks  
 Information restored includes visibility, horizontal/vertical orientation, docking state, and control-bar position.  
  
 The settings you want to restore must be written to the registry before you call <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>. Write the information to the registry by calling [CWinApp::SetRegistryKey](../vs140/cwinapp-class.md#cwinapp__setregistrykey). Write the information to the INI file by calling [SaveBarState](#cframewnd__savebarstate).  
  
##  \<a name="cframewnd__loadframe">\</a>  CFrameWnd::LoadFrame  
 Call to dynamically create a frame window from resource information.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>175\</CodeContentPlaceHolder>  
 The ID of shared resources associated with the frame window.  
  
 *dwDefaultStyle*  
 The frame's [style](../vs140/window-styles.md). Include the **FWS_ADDTOTITLE** style if you want the title bar to automatically display the name of the document represented in the window.  
  
 <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>  
 A pointer to the frame's parent.  
  
 <CodeContentPlaceHolder>177\</CodeContentPlaceHolder>  
 A pointer to a [CCreateContext](../vs140/ccreatecontext-structure.md) structure. This parameter can be **NULL**.  
  
### Remarks  
 Construct a <CodeContentPlaceHolder>178\</CodeContentPlaceHolder> object in two steps. First, invoke the constructor, which constructs the <CodeContentPlaceHolder>179\</CodeContentPlaceHolder> object, and then call <CodeContentPlaceHolder>180\</CodeContentPlaceHolder>, which loads the Windows frame window and associated resources and attaches the frame window to the <CodeContentPlaceHolder>181\</CodeContentPlaceHolder> object. The <CodeContentPlaceHolder>182\</CodeContentPlaceHolder> parameter specifies the menu, the accelerator table, the icon, and the string resource of the title for the frame window.  
  
 Use the **Create** member function rather than <CodeContentPlaceHolder>183\</CodeContentPlaceHolder> when you want to specify all of the frame window's creation parameters.  
  
 The framework calls <CodeContentPlaceHolder>184\</CodeContentPlaceHolder> when it creates a frame window using a document template object.  
  
 The framework uses the <CodeContentPlaceHolder>185\</CodeContentPlaceHolder> argument to specify the objects to be connected to the frame window, including any contained view objects. You can set the <CodeContentPlaceHolder>186\</CodeContentPlaceHolder> argument to **NULL** when you call <CodeContentPlaceHolder>187\</CodeContentPlaceHolder>.  
  
##  \<a name="cframewnd__m_bautomenuenable">\</a>  CFrameWnd::m_bAutoMenuEnable  
 When this data member is enabled (which is the default), menu items that do not have <CodeContentPlaceHolder>188\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>189\</CodeContentPlaceHolder> handlers will be automatically disabled when the user pulls down a menu.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Remarks  
 Menu items that have an <CodeContentPlaceHolder>190\</CodeContentPlaceHolder> handler but no <CodeContentPlaceHolder>191\</CodeContentPlaceHolder> handler will be automatically enabled.  
  
 When this data member is set, menu items are automatically enabled in the same way that toolbar buttons are enabled.  
  
> [!NOTE]
>  <CodeContentPlaceHolder>192\</CodeContentPlaceHolder> has no effect on top-level menu items.  
  
 This data member simplifies the implementation of optional commands based on the current selection and reduces the need to write <CodeContentPlaceHolder>193\</CodeContentPlaceHolder> handlers for enabling and disabling menu items.  
  
### Example  
 [!code[NVC_MFCWindowing#3](../vs140/codesnippet/CPP/cframewnd-class_3.cpp)]  
  
##  \<a name="cframewnd__negotiateborderspace">\</a>  CFrameWnd::NegotiateBorderSpace  
 Call this member function to negotiate border space in a frame window during OLE inplace activation.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 *nBorderCmd*  
 Contains one of the following values from the **enum BorderCmd**:  
  
-   **borderGet** = 1  
  
-   **borderRequest** = 2  
  
-   **borderSet** = 3  
  
 <CodeContentPlaceHolder>194\</CodeContentPlaceHolder>  
 Pointer to a [RECT](../vs140/rect-structure.md) structure or a [CRect](../vs140/crect-class.md) object that specifies the coordinates of the border.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 This member function is the **CFrameWnd** implementation of OLE border space negotiation.  
  
##  \<a name="cframewnd__onbarcheck">\</a>  CFrameWnd::OnBarCheck  
 Called whenever an action is performed on the specified control bar.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>195\</CodeContentPlaceHolder>  
 The ID of the control bar being shown.  
  
### Return Value  
 Nonzero if the control bar existed; otherwise 0.  
  
##  \<a name="cframewnd__oncontexthelp">\</a>  CFrameWnd::OnContextHelp  
 Handles SHIFT+F1 Help for in-place items.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Remarks  
 To enable context-sensitive help, you must add an  
  
 [!code[NVC_MFCDocViewSDI#16](../vs140/codesnippet/CPP/cframewnd-class_4.cpp)]  
  
 statement to your <CodeContentPlaceHolder>196\</CodeContentPlaceHolder> class message map and also add an accelerator-table entry, typically SHIFT+F1, to enable this member function.  
  
 If your application is an OLE Container, <CodeContentPlaceHolder>197\</CodeContentPlaceHolder> puts all in-place items contained within the frame window object into Help mode. The cursor changes to an arrow and a question mark, and the user can then move the mouse pointer and press the left mouse button to select a dialog box, window, menu, or command button. This member function calls the Windows function <CodeContentPlaceHolder>198\</CodeContentPlaceHolder> with the Help context of the object under the cursor.  
  
##  \<a name="cframewnd__oncreateclient">\</a>  CFrameWnd::OnCreateClient  
 Called by the framework during the execution of <CodeContentPlaceHolder>199\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>200\</CodeContentPlaceHolder>  
 A pointer to a Windows [CREATESTRUCT](../vs140/createstruct-structure.md) structure                                *.*  
  
 <CodeContentPlaceHolder>201\</CodeContentPlaceHolder>  
 A pointer to a [CCreateContext](../vs140/ccreatecontext-structure.md) structure                                *.*  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 Never call this function.  
  
 The default implementation of this function creates a <CodeContentPlaceHolder>202\</CodeContentPlaceHolder> object from the information provided in <CodeContentPlaceHolder>203\</CodeContentPlaceHolder>, if possible.  
  
 Override this function to override values passed in the <CodeContentPlaceHolder>204\</CodeContentPlaceHolder> object or to change the way controls in the main client area of the frame window are created. The <CodeContentPlaceHolder>205\</CodeContentPlaceHolder> members you can override are described in the [CCreateContext](../vs140/ccreatecontext-structure.md) class.  
  
> [!NOTE]
>  Do not replace values passed in the <CodeContentPlaceHolder>206\</CodeContentPlaceHolder> structure. They are for informational use only. If you want to override the initial window rectangle, for example, override the <CodeContentPlaceHolder>207\</CodeContentPlaceHolder> member function [PreCreateWindow](../vs140/cwnd-class.md#cwnd__precreatewindow).  
  
##  \<a name="cframewnd__onhidemenubar">\</a>  CFrameWnd::OnHideMenuBar  
 This function is called when the system is about to hide the menu bar in the current MFC application.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Remarks  
 This event handler enables your application to perform custom actions when the system is about to hide the menu. You cannot prevent the menu from being hidden, but you can, for example, call other methods to retrieve the menu style or state.  
  
##  \<a name="cframewnd__onsetpreviewmode">\</a>  CFrameWnd::OnSetPreviewMode  
 Call this member function to set the application's main frame window into and out of print-preview mode.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Parameters  
 *bPreview*  
 Specifies whether or not to place the application in print-preview mode. Set to **TRUE** to place in print preview, **FALSE** to cancel preview mode.  
  
 <CodeContentPlaceHolder>208\</CodeContentPlaceHolder>  
 A pointer to a **CPrintPreviewState** structure.  
  
### Remarks  
 The default implementation disables all standard toolbars and hides the main menu and the main client window. This turns MDI frame windows into temporary SDI frame windows.  
  
 Override this member function to customize the hiding and showing of control bars and other frame window parts during print preview. Call the base class implementation from within the overridden version.  
  
##  \<a name="cframewnd__onshowmenubar">\</a>  CFrameWnd::OnShowMenuBar  
 This function is called when the system is about to display the menu bar in the current MFC application.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Remarks  
 This event handler enables your application to perform custom actions when the menu is about to be displayed. You cannot prevent the menu from being displayed, but you can, for example, call other methods to retrieve the menu style or state.  
  
##  \<a name="cframewnd__onupdatecontrolbarmenu">\</a>  CFrameWnd::OnUpdateControlBarMenu  
 Called by the framework when the associated menu is updated.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>209\</CodeContentPlaceHolder>  
 A pointer to a [CCmdUI](../vs140/ccmdui-class.md) object representing the menu that generated the update command. The update handler calls the [Enable](../vs140/ccmdui-class.md#ccmdui__enable) member function of the <CodeContentPlaceHolder>210\</CodeContentPlaceHolder> object through <CodeContentPlaceHolder>211\</CodeContentPlaceHolder> to update the user interface.  
  
##  \<a name="cframewnd__recalclayout">\</a>  CFrameWnd::RecalcLayout  
 Called by the framework when the standard control bars are toggled on or off or when the frame window is resized.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>212\</CodeContentPlaceHolder>  
 Determines whether the active in-place item for the frame window receives notification of the layout change. If **TRUE**, the item is notified; otherwise **FALSE**.  
  
### Remarks  
 The default implementation of this member function calls the <CodeContentPlaceHolder>213\</CodeContentPlaceHolder> member function <CodeContentPlaceHolder>214\</CodeContentPlaceHolder> to reposition all the control bars in the frame as well as in the main client window (usually a <CodeContentPlaceHolder>215\</CodeContentPlaceHolder> or **MDICLIENT**).  
  
 Override this member function to control the appearance and behavior of control bars after the layout of the frame window has changed. For example, call it when you turn control bars on or off or add another control bar.  
  
##  \<a name="cframewnd__rectdefault">\</a>  CFrameWnd::rectDefault  
 Pass this static <CodeContentPlaceHolder>216\</CodeContentPlaceHolder> as a parameter when creating a window to allow Windows to choose the window's initial size and position.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
##  \<a name="cframewnd__savebarstate">\</a>  CFrameWnd::SaveBarState  
 Call this function to store information about each control bar owned by the frame window.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>217\</CodeContentPlaceHolder>  
 Name of a section in the initialization file or a key in the Windows registry where state information is stored.  
  
### Remarks  
 This information can be read from the initialization file using [LoadBarState](#cframewnd__loadbarstate). Information stored includes visibility, horizontal/vertical orientation, docking state, and control bar position.  
  
##  \<a name="cframewnd__setactivepreviewview">\</a>  CFrameWnd::SetActivePreviewView  
 Designates the specified view to be the active view for Rich Preview.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>218\</CodeContentPlaceHolder>  
 A pointer to a view to be activated.  
  
### Remarks  
  
##  \<a name="cframewnd__setactiveview">\</a>  CFrameWnd::SetActiveView  
 Call this member function to set the active view.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Parameters  
 *pViewNew*  
 Specifies a pointer to a [CView](../vs140/cview-class.md) object, or **NULL** for no active view.  
  
 <CodeContentPlaceHolder>219\</CodeContentPlaceHolder>  
 Specifies whether the view is to be notified of activation. If **TRUE**, <CodeContentPlaceHolder>220\</CodeContentPlaceHolder> is called for the new view; if **FALSE**, it is not.  
  
### Remarks  
 The framework will call this function automatically as the user changes the focus to a view within the frame window. You can explicitly call <CodeContentPlaceHolder>221\</CodeContentPlaceHolder> to change the focus to the specified view.  
  
##  \<a name="cframewnd__setdockstate">\</a>  CFrameWnd::SetDockState  
 Call this member function to apply state information stored in a <CodeContentPlaceHolder>222\</CodeContentPlaceHolder> object to the frame window's control bars.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>223\</CodeContentPlaceHolder>  
 Apply the stored state to the frame window's control bars.  
  
### Remarks  
 To restore a previous state of the control bars, you can load the stored state with <CodeContentPlaceHolder>224\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>225\</CodeContentPlaceHolder>, then use <CodeContentPlaceHolder>226\</CodeContentPlaceHolder> to apply it to the frame window's control bars. The previous state is stored in the <CodeContentPlaceHolder>227\</CodeContentPlaceHolder> object with <CodeContentPlaceHolder>228\</CodeContentPlaceHolder>  
  
##  \<a name="cframewnd__setmenubarstate">\</a>  CFrameWnd::SetMenuBarState  
 Sets the display state of the menu in the current MFC application to hidden or displayed.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>229\</CodeContentPlaceHolder>|Specifies whether to display or hide the menu. The <CodeContentPlaceHolder>230\</CodeContentPlaceHolder> parameter can have the following values:\<br />\<br /> -   AFX_MBS_VISIBLE (0x01) – Displays the menu if it is hidden, but has no effect if it is visible.\<br />-   AFX_MBS_HIDDEN (0x02) – Hides the menu if it is visible, but has no effect if it is hidden.|  
  
### Return Value  
 <CodeContentPlaceHolder>231\</CodeContentPlaceHolder> if this method successfully changes the menu state; otherwise, <CodeContentPlaceHolder>232\</CodeContentPlaceHolder>.  
  
### Remarks  
 If a runtime error occurs, this method asserts in Debug mode and raises an exception derived from the [CException](../vs140/cexception-class.md) class.  
  
##  \<a name="cframewnd__setmenubarvisibility">\</a>  CFrameWnd::SetMenuBarVisibility  
 Sets the default behavior of the menu in the current MFC application to be either hidden or visible.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>233\</CodeContentPlaceHolder>|Specifies whether the menu is by default hidden, or is visible and has the focus. The <CodeContentPlaceHolder>234\</CodeContentPlaceHolder> parameter can have the following values:\<br />\<br /> -   AFX_MBV_KEEPVISIBLE (0x01) -\<br />     The menu is displayed at all times, and by default does not have the focus.\<br />-   AFX_MBV_DISPLAYONFOCUS (0x02) -\<br />     The menu is hidden by default. If the menu is hidden, press the ALT key to display the menu and give it the focus. If the menu is displayed, press the ALT or ESC key to hide menu.\<br />-   AFX_MBV_ DISPLAYONFOCUS (0x02) &#124; AFX_MBV_DISPLAYONF10 (0x04)\<br />     (bitwise combination (OR)) - The menu is hidden by default. If the menu is hidden, press the F10 key to display the menu and give it the focus. If the menu is displayed, press the F10 key to toggle the focus on or off the menu. The menu is displayed until you press the ALT or ESC key to hide it.|  
  
### Remarks  
 If the value of the <CodeContentPlaceHolder>235\</CodeContentPlaceHolder> parameter is not valid, this method asserts in Debug mode and raises [CInvalidArgException](../vs140/cinvalidargexception-class.md) in Release mode. In case of other runtime errors, this method asserts in Debug mode and raises an exception derived from the [CException](../vs140/cexception-class.md) class.  
  
 This method affects the state of menus in applications written for [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
##  \<a name="cframewnd__setmessagetext">\</a>  CFrameWnd::SetMessageText  
 Call this function to place a string in the status-bar pane that has an ID of 0.  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>236\</CodeContentPlaceHolder>  
 Points to the string to be placed on the status bar.  
  
 <CodeContentPlaceHolder>237\</CodeContentPlaceHolder>  
 String resource ID of the string to be placed on the status bar.  
  
### Remarks  
 This is typically the leftmost, and longest, pane of the status bar.  
  
##  \<a name="cframewnd__setprogressbarposition">\</a>  CFrameWnd::SetProgressBarPosition  
 Sets the current position for the Windows 7 progress bar displayed on the taskbar.  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>238\</CodeContentPlaceHolder>  
 Specifies the position to set. It must be within the range set by <CodeContentPlaceHolder>239\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cframewnd__setprogressbarrange">\</a>  CFrameWnd::SetProgressBarRange  
 Sets the range for the Windows 7 progress bar displayed on the taskbar.  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>240\</CodeContentPlaceHolder>  
 Minimal value.  
  
 <CodeContentPlaceHolder>241\</CodeContentPlaceHolder>  
 Maximal value.  
  
### Remarks  
  
##  \<a name="cframewnd__setprogressbarstate">\</a>  CFrameWnd::SetProgressBarState  
 Sets the type and state of the progress indicator displayed on a taskbar button.  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>242\</CodeContentPlaceHolder>  
 Flags that control the current state of the progress button. Specify only one of the following flags because all states are mutually exclusive: TBPF_NOPROGRESS, TBPF_INDETERMINATE, TBPF_NORMAL, TBPF_ERROR, TBPF_PAUSED.  
  
### Remarks  
  
##  \<a name="cframewnd__settaskbaroverlayicon">\</a>  CFrameWnd::SetTaskbarOverlayIcon  
 Overloaded. Applies an overlay to a taskbar button to indicate application status or to notify the user.  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>243\</CodeContentPlaceHolder>  
 Specifies the Resource ID of an icon to use as the overlay. See description for <CodeContentPlaceHolder>244\</CodeContentPlaceHolder> for details.  
  
 <CodeContentPlaceHolder>245\</CodeContentPlaceHolder>  
 A pointer to a string that provides an alt text version of the information conveyed by the overlay, for accessibility purposes.  
  
 <CodeContentPlaceHolder>246\</CodeContentPlaceHolder>  
 The handle of an icon to use as the overlay. This should be a small icon, measuring 16x16 pixels at 96 dots per inch (dpi). If an overlay icon is already applied to the taskbar button, that existing overlay is replaced. This value can be <CodeContentPlaceHolder>247\</CodeContentPlaceHolder>. How a <CodeContentPlaceHolder>248\</CodeContentPlaceHolder> value is handled depends on whether the taskbar button represents a single window or a group of windows. It is the responsibility of the calling application to free <CodeContentPlaceHolder>249\</CodeContentPlaceHolder> when it is no longer needed.  
  
### Return Value  
 <CodeContentPlaceHolder>250\</CodeContentPlaceHolder> if successful; <CodeContentPlaceHolder>251\</CodeContentPlaceHolder> if OS version is less than Windows 7 or if an error occurs setting the icon.  
  
### Remarks  
  
##  \<a name="cframewnd__settitle">\</a>  CFrameWnd::SetTitle  
 Sets the title of the window object.  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>252\</CodeContentPlaceHolder>  
 A pointer to a character string containing the title of the window object.  
  
##  \<a name="cframewnd__showcontrolbar">\</a>  CFrameWnd::ShowControlBar  
 Call this member function to show or hide the control bar.  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>253\</CodeContentPlaceHolder>  
 Pointer to the control bar to be shown or hidden.  
  
 <CodeContentPlaceHolder>254\</CodeContentPlaceHolder>  
 If **TRUE**, specifies that the control bar is to be shown. If **FALSE**, specifies that the control bar is to be hidden.  
  
 *bDelay*  
 If **TRUE**, delay showing the control bar. If **FALSE**, show the control bar immediately.  
  
##  \<a name="cframewnd__showownedwindows">\</a>  CFrameWnd::ShowOwnedWindows  
 Call this member function to show all windows that are descendants of the <CodeContentPlaceHolder>255\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>256\</CodeContentPlaceHolder>  
 Specifies whether the owned windows are to be shown or hidden.  
  
## See Also  
 [Base Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd](../vs140/cwnd-class.md)   
 [CMDIFrameWnd](../vs140/cmdiframewnd-class.md)   
 [CMDIChildWnd](../vs140/cmdichildwnd-class.md)   
 [CView](../vs140/cview-class.md)   
 [CDocTemplate](../vs140/cdoctemplate-class.md)   
 [CRuntimeClass](../vs140/cruntimeclass-structure.md)