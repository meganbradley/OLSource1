---
title: "AFX_GLOBAL_DATA Structure"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "GLOBAL_DATA"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AFX_GLOBAL_DATA structure"
  - "AFX_GLOBAL_DATA constructor"
ms.assetid: c7abf2fb-ad5e-4336-a01d-260c29ed53a2
caps.latest.revision: 30
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AFX_GLOBAL_DATA Structure
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> structure contains fields and methods that are used to manage the framework or customize the appearance and behavior of your application.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Constructs a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> structure.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[AFX_GLOBAL_DATA::CleanUp](../vs140/afx_global_data--cleanup.md)|Releases resources that are allocated by the framework, such as brushes, fonts, and DLLs.|  
|[AFX_GLOBAL_DATA::D2D1MakeRotateMatrix](../vs140/afx_global_data--d2d1makerotatematrix.md)|Creates a rotation transformation that rotates by a specified angle around a specified point.|  
|[AFX_GLOBAL_DATA::DrawParentBackground](../vs140/afx_global_data--drawparentbackground.md)|Draws the background of a control's parent in the specified area.|  
|[AFX_GLOBAL_DATA::DrawTextOnGlass](../vs140/afx_global_data--drawtextonglass.md)|Draws the specified text in the visual style of the specified theme.|  
|[AFX_GLOBAL_DATA::ExcludeTag](../vs140/afx_global_data--excludetag.md)|Removes the specified XML tag pair from a specified buffer.|  
|[AFX_GLOBAL_DATA::GetColor](../vs140/afx_global_data--getcolor.md)|Retrieves the current color of the specified user interface element.|  
|[AFX_GLOBAL_DATA::GetDirect2dFactory](../vs140/afx_global_data--getdirect2dfactory.md)|Returns a pointer to the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> interface that is stored in the global data. If the interface is not initialized, it is created and has the default parameters.|  
|[AFX_GLOBAL_DATA::GetHandCursor](../vs140/afx_global_data--gethandcursor.md)|Retrieves the predefined cursor that resembles a hand and whose identifier is <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.|  
|[AFX_GLOBAL_DATA::GetITaskbarList](../vs140/afx_global_data--getitaskbarlist.md)|Creates and stores in the global data a pointer to ITaskBarList interface.|  
|[AFX_GLOBAL_DATA::GetITaskbarList3](../vs140/afx_global_data--getitaskbarlist3.md)|Creates and stores in the global data a pointer to ITaskBarList3 interface.|  
|[AFX_GLOBAL_DATA::GetNonClientMetrics](../vs140/afx_global_data--getnonclientmetrics.md)|Retrieves the metrics associated with the nonclient area of nonminimized windows.|  
|[AFX_GLOBAL_DATA::GetShellAutohideBars](../vs140/afx_global_data--getshellautohidebars.md)|Determines positions of Shell auto hide bars.|  
|[AFX_GLOBAL_DATA::GetTextHeight](../vs140/afx_global_data--gettextheight.md)|Retrieves the height of text characters in the current font.|  
|[AFX_GLOBAL_DATA::GetWICFactory](../vs140/afx_global_data--getwicfactory.md)|Returns a pointer to the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> interface that is stored in the global data. If the interface is not initialized, it is created and has the default parameters.|  
|[AFX_GLOBAL_DATA::GetWriteFactory](../vs140/afx_global_data--getwritefactory.md)|Returns a pointer to the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> interface that is stored in the global data. If the interface is not initialized, it is created and has the default parameters.|  
|[AFX_GLOBAL_DATA::InitD2D](../vs140/afx_global_data--isd2dinitialized.md)|Initializes <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> factories. Call this method before the main window is initialized.|  
|[AFX_GLOBAL_DATA::Is32BitIcons](../vs140/afx_global_data--is32biticons.md)|Indicates whether predefined 32-bit icons are supported.|  
|[AFX_GLOBAL_DATA::IsD2DInitialized](../vs140/afx_global_data--isd2dinitialized.md)|Determines whether the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> was initialized.|  
|[AFX_GLOBAL_DATA::IsDwmCompositionEnabled](../vs140/afx_global_data--isdwmcompositionenabled.md)|Provides a simple way to call the Windows [DwmIsCompositionEnabled](http://msdn.microsoft.com/library/windows/desktop/aa969518) method.|  
|[AFX_GLOBAL_DATA::IsHighContrastMode](../vs140/afx_global_data--ishighcontrastmode.md)|Indicates whether images are currently displayed in high contrast.|  
|[AFX_GLOBAL_DATA::OnSettingChange](../vs140/afx_global_data--onsettingchange.md)|Detects the current state of the desktop's menu animation and taskbar autohide features.|  
|[AFX_GLOBAL_DATA::RegisterWindowClass](../vs140/afx_global_data--registerwindowclass.md)|Registers the specified MFC window class.|  
|[AFX_GLOBAL_DATA::ReleaseTaskBarRefs](../vs140/afx_global_data--releasetaskbarrefs.md)|Releases interfaces obtained through GetITaskbarList and GetITaskbarList3 methods.|  
|[AFX_GLOBAL_DATA::Resume](../vs140/afx_global_data--resume.md)|Reinitializes internal function pointers that access methods that support Windows [themes and visual styles](https://msdn.microsoft.com/en-us/library/windows/desktop/hh270423.aspx).|  
|[AFX_GLOBAL_DATA::SetLayeredAttrib](../vs140/afx_global_data--setlayeredattrib.md)|Provides a simple way to call the Windows [SetLayeredWindowAttributes](http://msdn.microsoft.com/library/windows/desktop/ms633540) method.|  
|[AFX_GLOBAL_DATA::SetMenuFont](../vs140/afx_global_data--setmenufont.md)|Creates the specified logical font.|  
|[AFX_GLOBAL_DATA::ShellCreateItemFromParsingName](../vs140/afx_global_data--shellcreateitemfromparsingname.md)|Creates and initializes a Shell item object from a parsing name.|  
|[AFX_GLOBAL_DATA::UpdateFonts](../vs140/afx_global_data--updatefonts.md)|Reintializes the logical fonts that are used by the framework.|  
|[AFX_GLOBAL_DATA::UpdateSysColors](../vs140/afx_global_data--updatesyscolors.md)|Initializes the colors, color depth, brushes, pens, and images that are used by the framework.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[AFX_GLOBAL_DATA::EnableAccessibilitySupport](../vs140/afx_global_data--enableaccessibilitysupport.md)|Enables or disables Microsoft Active Accessibility support. Active Accessibility provides reliable methods for exposing information about user interface elements.|  
|[AFX_GLOBAL_DATA::IsAccessibilitySupport](../vs140/afx_global_data--isaccessibilitysupport.md)|Indicates whether Microsoft Active Accessibility support is enabled.|  
|[AFX_GLOBAL_DATA::IsWindowsLayerSupportAvailable](../vs140/afx_global_data--iswindowslayersupportavailable.md)|Indicates whether the operating system supports layered windows.|  
  
### Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[AFX_GLOBAL_DATA::bIsOSAlphaBlendingSupport](../vs140/afx_global_data--bisosalphablendingsupport.md)|Indicates whether the current operating system supports alpha blending.|  
|[AFX_GLOBAL_DATA::bIsWindows7](../vs140/afx_global_data--biswindows7.md)|Indicates whether the application is being executed under Windows 7 OS or higher|  
|[AFX_GLOBAL_DATA::clrActiveCaptionGradient](../vs140/afx_global_data--clractivecaptiongradient.md)|Specifies gradient color of active caption. Generally used for docking panes.|  
|[AFX_GLOBAL_DATA::clrInactiveCaptionGradient](../vs140/afx_global_data--clrinactivecaptiongradient.md)|Specifies gradient color of inactive active caption. Generally used for docking panes.|  
|[AFX_GLOBAL_DATA::m_bUseBuiltIn32BitIcons](../vs140/afx_global_data--m_busebuiltin32biticons.md)|Indicates whether the framework uses predefined 32-bit color icons or icons of a lower resolution.|  
|[AFX_GLOBAL_DATA::m_bUseSystemFont](../vs140/afx_global_data--m_busesystemfont.md)|Indicates whether a system font is used for menus, toolbars, and ribbons.|  
|[AFX_GLOBAL_DATA::m_hcurHand](../vs140/afx_global_data--m_hcurhand.md)|Stores the handle for the hand cursor.|  
|[AFX_GLOBAL_DATA::m_hcurStretch](../vs140/afx_global_data--m_hcurstretch.md)|Stores the handle for the horizontal stretch cursor.|  
|[AFX_GLOBAL_DATA::m_hcurStretchVert](../vs140/afx_global_data--m_hcurstretchvert.md)|Stores the handle for the vertical stretch cursor.|  
|[AFX_GLOBAL_DATA::m_hiconTool](../vs140/afx_global_data--m_hicontool.md)|Stores the handle for the tool icon.|  
|[AFX_GLOBAL_DATA::m_nAutoHideToolBarMargin](../vs140/afx_global_data--m_nautohidetoolbarmargin.md)|Specifies the offset from the leftmost autohide toolbar to the left side of the docking bar.|  
|[AFX_GLOBAL_DATA::m_nAutoHideToolBarSpacing](../vs140/afx_global_data--m_nautohidetoolbarspacing.md)|Specifies the gap between autohide toolbars.|  
|[AFX_GLOBAL_DATA::m_nDragFrameThicknessDock](../vs140/afx_global_data--m_ndragframethicknessdock.md)|Specifies the thickness of the drag frame that is used to communicate the docked state.|  
|[AFX_GLOBAL_DATA::m_nDragFrameThicknessFloat](../vs140/afx_global_data--m_ndragframethicknessfloat.md)|Specifies the thickness of the drag frame that is used to communicate the floating state.|  
  
## Remarks  
 Most of the data in the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> structure is initialized when your application starts.  
  
## Inheritance Hierarchy  
 [AFX_GLOBAL_DATA](../vs140/afx_global_data-structure.md)  
  
## Requirements  
 **Header:** afxglobals.h  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Structures, Styles, Callbacks, and Message Maps](../vs140/structures--styles--callbacks--and-message-maps.md)