---
title: "CMDIChildWndEx Class"
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
  - "CMDIChildWndEx"
  - "GetThisClass"
  - "CMDIChildWndEx::PreTranslateMessage"
  - "CMDIChildWndEx::ActivateFrame"
  - "CMDIChildWndEx.GetThisClass"
  - "CMDIChildWndEx::AddDockSite"
  - "CMDIChildWndEx.CreateObject"
  - "CMDIChildWndEx::CreateObject"
  - "CMDIChildWndEx.ActivateFrame"
  - "CMDIChildWndEx::GetThisClass"
  - "CMDIChildWndEx.PreTranslateMessage"
  - "PreTranslateMessage"
  - "ActivateFrame"
  - "CreateObject"
  - "CMDIChildWndEx.AddDockSite"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMDIChildWndEx class"
  - "ActivateFrame method"
  - "PreTranslateMessage method"
  - "GetThisClass method"
  - "CreateObject method"
ms.assetid: d39fec06-0bd6-4271-917d-35aae3b24d8e
caps.latest.revision: 34
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIChildWndEx Class
The <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> class provides the functionality of a Windows multiple document interface (MDI) child window. It extends the functionality of [CMDIChildWnd](../vs140/cmdichildwnd-class.md). The framework requires this class when an MDI application uses certain MFC classes.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMDIChildWndEx::ActivateTopLevelFrame](#cmdichildwndex__activatetoplevelframe)|Called internally by the framework to activate top level frame when the application should be activated from a taskbar tab.|  
|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|This method is not used or implemented.|  
|[CMDIChildWndEx::AddPane](#cmdichildwndex__addpane)|Adds a pane.|  
|[CMDIChildWndEx::AddTabbedPane](#cmdichildwndex__addtabbedpane)|Adds a tabbed pane.|  
|[CMDIChildWndEx::AdjustDockingLayout](#cmdichildwndex__adjustdockinglayout)|Adjusts the docking layout.|  
|[CMDIChildWndEx::CanShowOnMDITabs](#cmdichildwndex__canshowonmditabs)||  
|[CMDIChildWndEx::CanShowOnTaskBarTabs](#cmdichildwndex__canshowontaskbartabs)|Tells the framework whether this MDI child can be displayed on Windows 7 taskbar tabs.|  
|[CMDIChildWndEx::CanShowOnWindowsList](#cmdichildwndex__canshowonwindowslist)|Returns <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> if the MDI child window name can be displayed in the [CMFCWindowsManagerDialog](../vs140/cmfcwindowsmanagerdialog-class.md) dialog box. Otherwise returns <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>|Called by the framework to create a dynamic instance of this class type.|  
|[CMDIChildWndEx::DockPane](#cmdichildwndex__dockpane)|Docks a pane.|  
|[CMDIChildWndEx::DockPaneLeftOf](#cmdichildwndex__dockpaneleftof)|Docks one pane to the left of another pane.|  
|[CMDIChildWndEx::EnableAutoHidePanes](#cmdichildwndex__enableautohidepanes)|Enables auto-hide mode for panes when they are docked at the specified sides of the window.|  
|[CMDIChildWndEx::EnableDocking](#cmdichildwndex__enabledocking)|Enables docking of the child window to the main frame.|  
|[CMDIChildWndEx::EnableTaskbarThumbnailClipRect](#cmdichildwndex__enabletaskbarthumbnailcliprect)|Enables or disables automatic selection of a portion of a window's client area to display  as that window's thumbnail in the taskbar.|  
|[CMDIChildWndEx::GetDockingManager](#cmdichildwndex__getdockingmanager)||  
|[CMDIChildWndEx::GetDocumentName](#cmdichildwndex__getdocumentname)|Returns the name of the document that is displayed in the MDI child window.|  
|[CMDIChildWndEx::GetFrameIcon](#cmdichildwndex__getframeicon)|Called by the framework to retrieve the MDI child window icon.|  
|[CMDIChildWndEx::GetFrameText](#cmdichildwndex__getframetext)|Called by the framework to retrieve the text for the MDI child window.|  
|[CMDIChildWndEx::GetPane](#cmdichildwndex__getpane)|Finds a pane by the specified control ID.|  
|[CMDIChildWndEx::GetRelatedTabGroup](#cmdichildwndex__getrelatedtabgroup)||  
|[CMDIChildWndEx::GetTabbedPane](#cmdichildwndex__gettabbedpane)|Returns a pointer to an embedded docking pane that was converted to a tabbed document.|  
|[CMDIChildWndEx::GetTabProxyWnd](#cmdichildwndex__gettabproxywnd)|Returns tab proxy window actually registered with Windows 7 taskbar tabs.|  
|[CMDIChildWndEx::GetTaskbarPreviewWnd](#cmdichildwndex__gettaskbarpreviewwnd)|Called by the framework when it needs to obtain a child window (usually a view or splitter window) to be displayed on Windows 7 taskbar tab thumbnail.|  
|[CMDIChildWndEx::GetTaskbarThumbnailClipRect](#cmdichildwndex__gettaskbarthumbnailcliprect)|Called by the framework when it needs to select a portion of a window's client area to display  as that window's thumbnail in the taskbar.|  
|<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>|Called by the framework to obtain a pointer to the [CRuntimeClass](../vs140/cruntimeclass-structure.md) object that is associated with this class type.|  
|[CMDIChildWndEx::GetToolbarButtonToolTipText](#cmdichildwndex__gettoolbarbuttontooltiptext)|Called by the framework to retrieve a tooltip for a toolbar button.|  
|[CMDIChildWndEx::InsertPane](#cmdichildwndex__insertpane)|Registers the specified pane with the docking manager.|  
|[CMDIChildWndEx::InvalidateIconicBitmaps](#cmdichildwndex__invalidateiconicbitmaps)|Invalidates iconic bitmap representation of MDI child.|  
|[CMDIChildWndEx::IsPointNearDockSite](#cmdichildwndex__ispointneardocksite)|Determines whether a specified point is near the dock site.|  
|[CMDIChildWndEx::IsReadOnly](#cmdichildwndex__isreadonly)|Returns <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> if the document that is displayed in the child window is read-only. Otherwise returns <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>.|  
|[CMDIChildWndEx::IsRegisteredWithTaskbarTabs](#cmdichildwndex__isregisteredwithtaskbartabs)|Returns TRUE if MDI child was successfully registered with Windows 7 taskbar tabs.|  
|[CMDIChildWndEx::IsTabbedPane](#cmdichildwndex__istabbedpane)|Returns <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> if the MDI child window contains a docking pane. Otherwise returns <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>.|  
|[CMDIChildWndEx::IsTaskbarTabsSupportEnabled](#cmdichildwndex__istaskbartabssupportenabled)|Tells whether the MDI child can appear on Windows 7 taskbar tabs.|  
|[CMDIChildWndEx::IsTaskbarThumbnailClipRectEnabled](#cmdichildwndex__istaskbarthumbnailcliprectenabled)|Tells whether automatic selection of a portion of a window's client area to display  as that window's thumbnail in the taskbar is enabled or disabled.|  
|[CMDIChildWndEx::m_dwDefaultTaskbarTabPropertyFlags](#cmdichildwndex__m_dwdefaulttaskbartabpropertyflags)|A combination of flags, which is passed by the framework to the SetTaskbarTabProperties method, when a tab (MDI child) is being registered with Windows 7 taskbar tabs. The default combination is STPF_USEAPPTHUMBNAILWHENACTIVE &#124; STPF_USEAPPPEEKWHENACTIVE.|  
|[CMDIChildWndEx::OnGetIconicLivePreviewBitmap](#cmdichildwndex__ongeticoniclivepreviewbitmap)|Called by the framework when it needs to obtain a bitmap for live preview of MDI child.|  
|[CMDIChildWndEx::OnGetIconicThumbnail](#cmdichildwndex__ongeticonicthumbnail)|Called by the framework when it needs to obtain a bitmap for iconic thumbnail of MDI child.|  
|[CMDIChildWndEx::OnMoveMiniFrame](#cmdichildwndex__onmoveminiframe)|Called by the framework to move a mini-frame window.|  
|[CMDIChildWndEx::OnPressTaskbarThmbnailCloseButton](#cmdichildwndex__onpresstaskbarthmbnailclosebutton)|Called by the framework when the user presses close button on Taskbar tab thumbnail..|  
|[CMDIChildWndEx::OnSetPreviewMode](#cmdichildwndex__onsetpreviewmode)|Called by the framework to enter or exit print preview mode.|  
|[CMDIChildWndEx::OnTaskbarTabThumbnailActivate](#cmdichildwndex__ontaskbartabthumbnailactivate)|Called by the framework when the Taskbar tab thumbnail should process WM_ACTIVATE message.|  
|[CMDIChildWndEx::OnTaskbarTabThumbnailMouseActivate](#cmdichildwndex__ontaskbartabthumbnailmouseactivate)|Called by the framework when the Taskbar tab thumbnail should process WM_MOUSEACTIVATE message.|  
|[CMDIChildWndEx::OnTaskbarTabThumbnailStretch](#cmdichildwndex__ontaskbartabthumbnailstretch)|Called by the framework when it needs to stretch a bitmap for Windows 7 taskbar tab thumbnail preview of MDI child.|  
|[CMDIChildWndEx::OnUpdateFrameTitle](#cmdichildwndex__onupdateframetitle)|Called by the framework to update the frame title. (Overrides <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>.)|  
|[CMDIChildWndEx::PaneFromPoint](#cmdichildwndex__panefrompoint)|Returns the pane that contains the given point.|  
|<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>|Used by class [CWinApp](../vs140/cwinapp-class.md) to translate window messages before they are dispatched to the                                         [TranslateMessage](http://msdn.microsoft.com/library/windows/desktop/ms644955) and                                         [DispatchMessage](http://msdn.microsoft.com/library/windows/desktop/ms644934) Windows functions. (Overrides [CWnd::PreTranslateMessage](../vs140/cwnd-class.md#cwnd__pretranslatemessage).)|  
|[CMDIChildWndEx::RecalcLayout](#cmdichildwndex__recalclayout)|Recalculates the layout of the window.|  
|[CMDIChildWndEx::RegisterTaskbarTab](#cmdichildwndex__registertaskbartab)|Registers MDI child with Windows 7 taskbar tabs.|  
|[CMDIChildWndEx::RemovePaneFromDockManager](#cmdichildwndex__removepanefromdockmanager)|Removes a pane from the docking manager.|  
|[CMDIChildWndEx::SetRelatedTabGroup](#cmdichildwndex__setrelatedtabgroup)||  
|[CMDIChildWndEx::SetTaskbarTabActive](#cmdichildwndex__settaskbartabactive)|Activates corresponding Windows 7 taskbar tab.|  
|[CMDIChildWndEx::SetTaskbarTabOrder](#cmdichildwndex__settaskbartaborder)|Inserts MDI child before specified window on Windows 7 taskbar tabs.|  
|[CMDIChildWndEx::SetTaskbarTabProperties](#cmdichildwndex__settaskbartabproperties)|Sets properties for a Windows 7 taskbar tab.|  
|[CMDIChildWndEx::SetTaskbarThumbnailClipRect](#cmdichildwndex__settaskbarthumbnailcliprect)|Called internally by the framework to set clipping rectangle to select a portion of a window's client area to display  as that window's thumbnail in the taskbar.|  
|[CMDIChildWndEx::ShowPane](#cmdichildwndex__showpane)||  
|[CMDIChildWndEx::UnregisterTaskbarTab](#cmdichildwndex__unregistertaskbartab)|Removes MDI child from Windows 7 taskbar tabs.|  
|[CMDIChildWndEx::UpdateTaskbarTabIcon](#cmdichildwndex__updatetaskbartabicon)|Updates Windows 7 taskbar tab icon.|  
  
## Remarks  
 To take advantage of extended docking features in MDI applications, derive the MDI child window class of your application from <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> instead of [CMDIChildWnd](../vs140/cmdichildwnd-class.md).  
  
## Example  
 The following example derives a class from <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>. This code snippet comes from the [VisualStudioDemo Sample: MFC Visual Studio Application](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_VisualStudioDemo#3](../vs140/codesnippet/CPP/cmdichildwndex-class_1.h)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CFrameWnd](../vs140/cframewnd-class.md)  
  
 [CMDIChildWnd](../vs140/cmdichildwnd-class.md)  
  
 [CMDIChildWndEx](../vs140/cmdichildwndex-class.md)  
  
## Requirements  
 **Header:** afxMDIChildWndEx.h  
  
##  \<a name="cmdichildwndex__addpane">\</a>  CMDIChildWndEx::AddPane  
 Adds a pane.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 A pointer to the pane.  
  
 [in] <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> to add the pane to the end of the list of panes for the docking manager; otherwise, <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>.  
  
### Return Value  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> if the pane was successfully registered with the docking manager; otherwise, <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>.  
  
##  \<a name="cmdichildwndex__addtabbedpane">\</a>  CMDIChildWndEx::AddTabbedPane  
 Adds a tabbed pane.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
 A pointer to the pane.  
  
##  \<a name="cmdichildwndex__adjustdockinglayout">\</a>  CMDIChildWndEx::AdjustDockingLayout  
 Adjusts the docking layout.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
 Handle to a deferred window position structure.  
  
##  \<a name="cmdichildwndex__canshowonmditabs">\</a>  CMDIChildWndEx::CanShowOnMDITabs  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmdichildwndex__canshowonwindowslist">\</a>  CMDIChildWndEx::CanShowOnWindowsList  
 Specifies whether the MDI child window name can be displayed in the [CMFCWindowsManagerDialog](../vs140/cmfcwindowsmanagerdialog-class.md) dialog box.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> if the window can be displayed in the **Windows** dialog box; otherwise, <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>.  
  
### Remarks  
 Override this method in a derived class and return <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> if the window should not be displayed in the **Windows** dialog box. This function is called from <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>.  
  
##  \<a name="cmdichildwndex__dockpane">\</a>  CMDIChildWndEx::DockPane  
 Docks a pane.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
 A pointer to the pane.  
  
 [in] <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
 The ID of the pane.  
  
 [in] <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
 A pointer to a rectangle.  
  
### Remarks  
 The <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> parameter is not used.  
  
##  \<a name="cmdichildwndex__dockpaneleftof">\</a>  CMDIChildWndEx::DockPaneLeftOf  
 Docks one pane to the left of another pane.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
 A pointer to the pane that is to be docked.  
  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 A pointer to the pane that serves as the point of reference.  
  
### Return Value  
 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> on success, <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> on failure.  
  
### Remarks  
 This method takes the pane specified by <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> and docks it at the left side of the pane specified by <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>.  
  
 Call this method when you want to dock several panes in predefined order.  
  
##  \<a name="cmdichildwndex__enableautohidepanes">\</a>  CMDIChildWndEx::EnableAutoHidePanes  
 Enables auto-hide mode for panes when they are docked at the specified sides of the window.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
 Specifies the sides of the main frame window that is enabled. Use one or more of the following flags.  
  
-   <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
  
### Return Value  
 <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> if the method succeeds; otherwise <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>.  
  
##  \<a name="cmdichildwndex__enabledocking">\</a>  CMDIChildWndEx::EnableDocking  
 Enables docking of the child window to the main frame.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
 Specifies the docking alignment to enable.  
  
### Return Value  
 <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> if the method succeeds; otherwise <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>.  
  
### Remarks  
 Call this method to enable docking alignment to the main frame. You can pass a combination of CBRS_ALIGN_ flags (for more information, see [CControlBar::EnableDocking](../vs140/ccontrolbar-class.md#ccontrolbar__enabledocking)).  
  
##  \<a name="cmdichildwndex__getdockingmanager">\</a>  CMDIChildWndEx::GetDockingManager  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmdichildwndex__getdocumentname">\</a>  CMDIChildWndEx::GetDocumentName  
 Returns the name of the document that is displayed in the MDI child window.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to a string that contains the name of a document.  
  
### Remarks  
 A document is what the MDI child window displays. Generally, the window displays data that is loaded from or saved to a file. Therefore, the name of the document is the name of the file. The default implementation of <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> returns a string obtained from <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>.  
  
 If the window displays a document that is not loaded from a file, override this method in a derived class and return a unique document identifier.  
  
 <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> is called by the framework when it saves the state of all opened documents. The returned string is written to the registry.  
  
 When the framework is restoring state later, the document name is read from the registry and passed to [CMDIFrameWndEx::CreateDocumentWindow](../vs140/cmdiframewndex-class.md#cmdiframewndex__createdocumentwindow). Override this method in a [CMDIFrameWndEx](../vs140/cmdiframewndex-class.md)-derived class and create or open a document that has this name and read in the file that has this name. If the document is not based on a file, create the document based on the document identifier itself. You should do the preceding actions only if you intend to save and restore documents.  
  
### Example  
 The following example demonstrates the use of the <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> method. This code snippet comes from the [VisualStudioDemo Sample: MFC Visual Studio Application](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_VisualStudioDemo#17](../vs140/codesnippet/CPP/cmdichildwndex-class_2.cpp)]  
  
##  \<a name="cmdichildwndex__getframeicon">\</a>  CMDIChildWndEx::GetFrameIcon  
 Called by the framework to retrieve the icon of the MDI child window.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 A handle to the window icon.  
  
### Remarks  
 This method is called by the framework to determine what icon to display on the MDI tab that contains the MDI child frame window.  
  
 By default this method returns the window icon. Override <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> in a <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>-derived class to customize this behavior.  
  
##  \<a name="cmdichildwndex__getframetext">\</a>  CMDIChildWndEx::GetFrameText  
 Called by the framework to retrieve the text for the MDI child window.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 A string that contains the frame window text.  
  
### Remarks  
 This method is called by the framework to determine what text to display on the MDI tab that contains the MDI child frame window.  
  
 By default this method returns the window text. Override <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> in a <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>-derived class to customize this behavior.  
  
##  \<a name="cmdichildwndex__getpane">\</a>  CMDIChildWndEx::GetPane  
 Finds a pane by the specified control ID.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>  
 The control ID of the pane to find.  
  
### Return Value  
 A pointer to the pane if found, otherwise <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>.  
  
##  \<a name="cmdichildwndex__getrelatedtabgroup">\</a>  CMDIChildWndEx::GetRelatedTabGroup  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmdichildwndex__gettabbedpane">\</a>  CMDIChildWndEx::GetTabbedPane  
 Returns a pointer to a docking pane that is part of a group of MDI tabbed documents.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to a docking pane that is part of a group of MDI tabbed documents.  
  
##  \<a name="cmdichildwndex__gettoolbarbuttontooltiptext">\</a>  CMDIChildWndEx::GetToolbarButtonToolTipText  
 Called by the framework to retrieve a tooltip for a toolbar button.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> if the tooltip has been displayed. The default implementation returns <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>.  
  
### Remarks  
 Override this method if you want to display custom tool tips for toolbar buttons.  
  
##  \<a name="cmdichildwndex__insertpane">\</a>  CMDIChildWndEx::InsertPane  
 Registers the specified pane with the docking manager.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>  
 A pointer to the pane to insert.  
  
 [in] <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>  
 A pointer to the adjacent pane.  
  
 [in] <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> is inserted after <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> is inserted before <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>.  
  
### Return Value  
 <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> if the method succeeds, <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> otherwise.  
  
##  \<a name="cmdichildwndex__ispointneardocksite">\</a>  CMDIChildWndEx::IsPointNearDockSite  
 Determines whether a specified point is near the dock site.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>  
 The specified point.  
  
 [in] <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>  
 Specifies which edge the point is near. Possible values are <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>  
  
 [in] <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> if the point is near the outer border of the dock site; <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> otherwise.  
  
### Return Value  
 <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> if the point is near the dock site; otherwise <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>.  
  
### Remarks  
 The point is near the dock site when it is within the sensitivity set in the docking manager. The default sensitivity is 15 pixels.  
  
##  \<a name="cmdichildwndex__isreadonly">\</a>  CMDIChildWndEx::IsReadOnly  
 Specifies whether the document that is displayed in the child window is read-only.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> if the document is read-only; otherwise <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>.  
  
### Remarks  
 This function is used to prevent saving of read-only documents.  
  
### Example  
 The following example demonstrates overriding the <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> method. This code snippet comes from the [VisualStudioDemo Sample: MFC Visual Studio Application](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_VisualStudioDemo#2](../vs140/codesnippet/CPP/cmdichildwndex-class_3.cpp)]  
  
##  \<a name="cmdichildwndex__istabbedpane">\</a>  CMDIChildWndEx::IsTabbedPane  
 Specifies whether the MDI child window contains a docking pane.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>137\</CodeContentPlaceHolder> if the MDI child window contains a docking pane that was converted to a tabbed document; otherwise <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>.  
  
##  \<a name="cmdichildwndex__onmoveminiframe">\</a>  CMDIChildWndEx::OnMoveMiniFrame  
 Called by the framework to move a mini-frame window.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>  
 A pointer to a mini-frame window.  
  
### Return Value  
 <CodeContentPlaceHolder>140\</CodeContentPlaceHolder> if the method succeeds, otherwise <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>.  
  
##  \<a name="cmdichildwndex__onsetpreviewmode">\</a>  CMDIChildWndEx::OnSetPreviewMode  
 Called by the framework to enter or exit print preview mode.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>, enter print preview mode. If <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>, exit print preview mode.  
  
 [in] <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>  
 A pointer to the print preview state structure.  
  
##  \<a name="cmdichildwndex__onupdateframetitle">\</a>  CMDIChildWndEx::OnUpdateFrameTitle  
 Called by the framework to update the frame title.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>, add the document name to the title.  
  
##  \<a name="cmdichildwndex__panefrompoint">\</a>  CMDIChildWndEx::PaneFromPoint  
 Returns the pane that contains the given point.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>  
 Specifies the point, in screen coordinates, to check.  
  
 [in] <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>  
 Increase the search area by this amount. A pane satisfies the search criteria if the given point falls in the increased area.  
  
 [in] <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>151\</CodeContentPlaceHolder> to ignore the <CodeContentPlaceHolder>152\</CodeContentPlaceHolder> parameter; otherwise, <CodeContentPlaceHolder>153\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>154\</CodeContentPlaceHolder>  
 If not <CodeContentPlaceHolder>155\</CodeContentPlaceHolder>, the method searches only panes of the specified type.  
  
 [in] <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>  
 If a pane is found at the specified point, this parameter contains the side of the pane that was closest to the specified point. For more information, see the Remarks section.  
  
### Return Value  
 A pointer to the <CodeContentPlaceHolder>157\</CodeContentPlaceHolder>-derived object that contains the given point, or <CodeContentPlaceHolder>158\</CodeContentPlaceHolder> if no pane was found.  
  
### Remarks  
 Call this method to determine whether a pane contains the specified point according to the specified conditions such as runtime class and visibility.  
  
 When the function returns and a pane was found, <CodeContentPlaceHolder>159\</CodeContentPlaceHolder> contains the alignment of the specified point. For example, if the point was closest to the top of the pane, <CodeContentPlaceHolder>160\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>161\</CodeContentPlaceHolder>.  
  
##  \<a name="cmdichildwndex__recalclayout">\</a>  CMDIChildWndEx::RecalcLayout  
 Recalculates the layout of the window.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>162\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>163\</CodeContentPlaceHolder>, the active in-place item for the window receives notification of the layout change.  
  
##  \<a name="cmdichildwndex__removepanefromdockmanager">\</a>  CMDIChildWndEx::RemovePaneFromDockManager  
 Removes a pane from the docking manager.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>164\</CodeContentPlaceHolder>  
 A pointer to the pane to remove.  
  
 [in] <CodeContentPlaceHolder>165\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>, the removed pane is destroyed.  
  
 [in] <CodeContentPlaceHolder>167\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>168\</CodeContentPlaceHolder>, adjust the docking layout immediately.  
  
 [in] <CodeContentPlaceHolder>169\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>170\</CodeContentPlaceHolder>, the docking layout is related to the list of autohide bars. If <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>, the docking layout is related to the list of regular panes.  
  
 [in] <CodeContentPlaceHolder>172\</CodeContentPlaceHolder>  
 A pointer to a pane that replaces the removed pane.  
  
##  \<a name="cmdichildwndex__setrelatedtabgroup">\</a>  CMDIChildWndEx::SetRelatedTabGroup  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>173\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmdichildwndex__showpane">\</a>  CMDIChildWndEx::ShowPane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>175\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>177\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmdichildwndex__updatetaskbartabicon">\</a>  CMDIChildWndEx::UpdateTaskbarTabIcon  
 Updates the Windows 7 taskbar tab icon.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>178\</CodeContentPlaceHolder>  
 A handle to an icon to display on the Windows 7 taskbar tab.  
  
### Remarks  
  
##  \<a name="cmdichildwndex__unregistertaskbartab">\</a>  CMDIChildWndEx::UnregisterTaskbarTab  
 Removes the MDI child from Windows 7 taskbar tabs.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>179\</CodeContentPlaceHolder>  
 Specifies whether this function needs to check the number of MDI children registered with MDI tabs. If this number is 0, then this function removes the clipping rectangle from the application's taskbar thumbnail.  
  
### Remarks  
  
##  \<a name="cmdichildwndex__settaskbarthumbnailcliprect">\</a>  CMDIChildWndEx::SetTaskbarThumbnailClipRect  
 Called by the framework to set the clipping rectangle to select a portion of a window's client area to display as that window's thumbnail in the taskbar.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>180\</CodeContentPlaceHolder>  
 Specifies the new clipping rectangle. If the rectangle is empty or null, the clipping is removed.  
  
### Return Value  
 <CodeContentPlaceHolder>181\</CodeContentPlaceHolder> if successful; otherwise <CodeContentPlaceHolder>182\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmdichildwndex__settaskbartabproperties">\</a>  CMDIChildWndEx::SetTaskbarTabProperties  
 Sets properties for a Windows 7 taskbar tab.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>183\</CodeContentPlaceHolder>  
 A combination of STPFLAG values. For more information, see                                 [ITaskbarList4::SetTabProperties](http://msdn.microsoft.com/library/dd562049\(VS.85\).aspx).  
  
### Remarks  
  
##  \<a name="cmdichildwndex__settaskbartaborder">\</a>  CMDIChildWndEx::SetTaskbarTabOrder  
 Inserts the MDI child before the specified window on Windows 7 taskbar tabs.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>184\</CodeContentPlaceHolder>  
 A pointer to the MDI child window whose thumbnail is inserted to the left. This window must already be registered through <CodeContentPlaceHolder>185\</CodeContentPlaceHolder>. If this value is <CodeContentPlaceHolder>186\</CodeContentPlaceHolder>, the new thumbnail is added to the end of the list.  
  
### Remarks  
  
##  \<a name="cmdichildwndex__settaskbartabactive">\</a>  CMDIChildWndEx::SetTaskbarTabActive  
 Activates the corresponding Windows 7 taskbar tab.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmdichildwndex__registertaskbartab">\</a>  CMDIChildWndEx::RegisterTaskbarTab  
 Registers the MDI child with Windows 7 taskbar tabs.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>187\</CodeContentPlaceHolder>  
 A pointer to the MDI child window whose thumbnail is inserted to the left. This window must already be registered through <CodeContentPlaceHolder>188\</CodeContentPlaceHolder>. If this value is <CodeContentPlaceHolder>189\</CodeContentPlaceHolder>, the new thumbnail is added to the end of the list.  
  
### Remarks  
  
##  \<a name="cmdichildwndex__ontaskbartabthumbnailstretch">\</a>  CMDIChildWndEx::OnTaskbarTabThumbnailStretch  
 Called by the framework when it needs to stretch a bitmap for a Windows 7 taskbar tab thumbnail preview of the MDI child.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>190\</CodeContentPlaceHolder>  
 A handle to a destination bitmap.  
  
 <CodeContentPlaceHolder>191\</CodeContentPlaceHolder>  
 Specifies the destination rectangle.  
  
 <CodeContentPlaceHolder>192\</CodeContentPlaceHolder>  
 A handle to a source bitmap.  
  
 <CodeContentPlaceHolder>193\</CodeContentPlaceHolder>  
 Specifies the source rectangle.  
  
### Remarks  
 Requirementher or him him him him him him him                         **:** afxmdichildwndex.h  
  
##  \<a name="cmdichildwndex__ontaskbartabthumbnailmouseactivate">\</a>  CMDIChildWndEx::OnTaskbarTabThumbnailMouseActivate  
 Called by the framework when the Taskbar tab thumbnail should process the WM_MOUSEACTIVATE message.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>194\</CodeContentPlaceHolder>  
 Specifies a pointer to the top-level parent window of the window being activated. The pointer may be temporary and should not be stored.  
  
 <CodeContentPlaceHolder>195\</CodeContentPlaceHolder>  
 Specifies the hit-test area code. A hit test is a test that determines the location of the cursor.  
  
 <CodeContentPlaceHolder>196\</CodeContentPlaceHolder>  
 Specifies the mouse message number.  
  
### Remarks  
 The default implementation activates the related MDI child frame.  
  
##  \<a name="cmdichildwndex__ontaskbartabthumbnailactivate">\</a>  CMDIChildWndEx::OnTaskbarTabThumbnailActivate  
 Called by the framework when the Taskbar tab thumbnail should process the WM_ACTIVATE message.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>197\</CodeContentPlaceHolder>  
 Specifies whether the <CodeContentPlaceHolder>198\</CodeContentPlaceHolder> is being activated or deactivated.  
  
 <CodeContentPlaceHolder>199\</CodeContentPlaceHolder>  
 Pointer to the <CodeContentPlaceHolder>200\</CodeContentPlaceHolder> being activated or deactivated. The pointer can be <CodeContentPlaceHolder>201\</CodeContentPlaceHolder>, and it may be temporary.  
  
 <CodeContentPlaceHolder>202\</CodeContentPlaceHolder>  
 Specifies the minimized state of the <CodeContentPlaceHolder>203\</CodeContentPlaceHolder> being activated or deactivated. A value of <CodeContentPlaceHolder>204\</CodeContentPlaceHolder> indicates the window is minimized.  
  
### Remarks  
 The default implementation activates the related MDI child frame.  
  
##  \<a name="cmdichildwndex__onpresstaskbarthmbnailclosebutton">\</a>  CMDIChildWndEx::OnPressTaskbarThmbnailCloseButton  
 Called by the framework when the user presses the close button on the Taskbar tab thumbnail.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmdichildwndex__ongeticonicthumbnail">\</a>  CMDIChildWndEx::OnGetIconicThumbnail  
 Called by the framework when it needs to obtain a bitmap for the iconic thumbnail of the MDI child.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>205\</CodeContentPlaceHolder>  
 Specifies the width of the required bitmap.  
  
 <CodeContentPlaceHolder>206\</CodeContentPlaceHolder>  
 Specifies the height of the required bitmap.  
  
### Remarks  
  
##  \<a name="cmdichildwndex__ongeticoniclivepreviewbitmap">\</a>  CMDIChildWndEx::OnGetIconicLivePreviewBitmap  
 Called by the framework when it needs to obtain a bitmap for live preview of the MDI child.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>207\</CodeContentPlaceHolder>  
 This parameter is <CodeContentPlaceHolder>208\</CodeContentPlaceHolder> if the bitmap is requested for the MDI child, which is currently active and the main window is not minimized. The default processing in this case takes a snapshot of the main window.  
  
 <CodeContentPlaceHolder>209\</CodeContentPlaceHolder>  
 Specifies the location of the bitmap in the main (top level) window client coordinates. This point should be provided by the callee.  
  
### Return Value  
 If processed, returns a handle to a valid 32bpp bitmap, otherwise <CodeContentPlaceHolder>210\</CodeContentPlaceHolder>.  
  
### Remarks  
 Override this method in a derived class and return a valid 32bpp bitmap for live preview of MDI child. This method is called only when the MDI child is displayed on Windows 7 taskbar tabs. If you return <CodeContentPlaceHolder>211\</CodeContentPlaceHolder>, MFC calls the default handlers and obtains bitmaps using <CodeContentPlaceHolder>212\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>213\</CodeContentPlaceHolder>.  
  
##  \<a name="cmdichildwndex__m_dwdefaulttaskbartabpropertyflags">\</a>  CMDIChildWndEx::m_dwDefaultTaskbarTabPropertyFlags  
 A combination of flags, which is passed by the framework to the <CodeContentPlaceHolder>214\</CodeContentPlaceHolder> method, when a tab (MDI child) is being registered with Windows 7 taskbar tabs.  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Remarks  
 The default combination is STPF_USEAPPTHUMBNAILWHENACTIVE &#124; STPF_USEAPPPEEKWHENACTIVE.  
  
##  \<a name="cmdichildwndex__istaskbarthumbnailcliprectenabled">\</a>  CMDIChildWndEx::IsTaskbarThumbnailClipRectEnabled  
 Tells whether automatic selection of a portion of a window's client area to display as that window's thumbnail in the taskbar is enabled or disabled.  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Return Value  
 Returns <CodeContentPlaceHolder>215\</CodeContentPlaceHolder> if automatic selection of a portion of a window's client area to display is enabled; otherwise <CodeContentPlaceHolder>216\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmdichildwndex__istaskbartabssupportenabled">\</a>  CMDIChildWndEx::IsTaskbarTabsSupportEnabled  
 Tells whether the MDI child can appear on Windows 7 taskbar tabs.  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>217\</CodeContentPlaceHolder> if the MDI child can appear on Windows 7 taskbar tabs; <CodeContentPlaceHolder>218\</CodeContentPlaceHolder> if the MDI child can not appear on Windows 7 taskbar tabs.  
  
### Remarks  
  
##  \<a name="cmdichildwndex__isregisteredwithtaskbartabs">\</a>  CMDIChildWndEx::IsRegisteredWithTaskbarTabs  
 Returns <CodeContentPlaceHolder>219\</CodeContentPlaceHolder> if the MDI child was successfully registered with Windows 7 taskbar tabs.  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>220\</CodeContentPlaceHolder> if the MDI child is registered with Windows 7 taskbar tabs; otherwise <CodeContentPlaceHolder>221\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmdichildwndex__invalidateiconicbitmaps">\</a>  CMDIChildWndEx::InvalidateIconicBitmaps  
 Invalidates an iconic bitmap representation of a MDI child.  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
### Return Value  
 Returns <CodeContentPlaceHolder>222\</CodeContentPlaceHolder> if Windows 7 taskbar support is disabled or the MDI child is not registered with Windows 7 taskbar tabs; otherwise returns <CodeContentPlaceHolder>223\</CodeContentPlaceHolder>.  
  
### Remarks  
 Should be called when the live content or size of a MDI child has changed.  
  
##  \<a name="cmdichildwndex__gettaskbarthumbnailcliprect">\</a>  CMDIChildWndEx::GetTaskbarThumbnailClipRect  
 Called by the framework when it needs to select a portion of a window's client area to display as that window's thumbnail in the taskbar.  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
### Return Value  
 A rectangle in windows coordinates. This rectangle is mapped to the client area of the top level frame. The rectangle should be empty to clear the clipping rectangle.  
  
### Remarks  
  
##  \<a name="cmdichildwndex__gettaskbarpreviewwnd">\</a>  CMDIChildWndEx::GetTaskbarPreviewWnd  
 Called by the framework when it needs to obtain a child window (usually a view or splitter window) to be displayed on a Windows 7 taskbar tab thumbnail.  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
### Return Value  
 Should return a valid pointer to a <CodeContentPlaceHolder>224\</CodeContentPlaceHolder> object, whose preview should be displayed on a Windows 7 taskbar tab related to this MDI child. The default implementation returns a child window of this MDI child with AFX_IDW_PANE_FIRST control ID (which is usually a <CodeContentPlaceHolder>225\</CodeContentPlaceHolder>-derived class).  
  
### Remarks  
  
##  \<a name="cmdichildwndex__gettabproxywnd">\</a>  CMDIChildWndEx::GetTabProxyWnd  
 Returns the tab proxy window registered with Windows 7 taskbar tabs.  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to a <CodeContentPlaceHolder>226\</CodeContentPlaceHolder> object, which is registered with Windows 7 taskbar tabs.  
  
### Remarks  
  
##  \<a name="cmdichildwndex__enabletaskbarthumbnailcliprect">\</a>  CMDIChildWndEx::EnableTaskbarThumbnailClipRect  
 Enables or disables automatic selection of a portion of a window's client area to display as that window's thumbnail in the taskbar.  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>227\</CodeContentPlaceHolder>  
 Specifies whether to enable ( <CodeContentPlaceHolder>228\</CodeContentPlaceHolder>), or disable ( <CodeContentPlaceHolder>229\</CodeContentPlaceHolder>) automatic selection of a portion of a window's client area to display.  
  
### Remarks  
  
##  \<a name="cmdichildwndex__canshowontaskbartabs">\</a>  CMDIChildWndEx::CanShowOnTaskBarTabs  
 Tells the framework whether this MDI child can be displayed on Windows 7 taskbar tabs.  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>230\</CodeContentPlaceHolder> if the content of the MDI child can be displayed on Windows 7 taskbar thumbnails.  
  
### Remarks  
 Override this method in a derived class and return <CodeContentPlaceHolder>231\</CodeContentPlaceHolder> to disable the appearance of this MDI child on Windows 7 taskbar tabs.  
  
##  \<a name="cmdichildwndex__activatetoplevelframe">\</a>  CMDIChildWndEx::ActivateTopLevelFrame  
 Called by the framework to activate the top level frame when the application is activated from a taskbar tab.  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
### Remarks  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMDIChildWnd](../vs140/cmdichildwnd-class.md)   
 [CMFCWindowsManagerDialog](../vs140/cmfcwindowsmanagerdialog-class.md)   
 [CMDIFrameWnd](../vs140/cmdiframewndex-class.md)