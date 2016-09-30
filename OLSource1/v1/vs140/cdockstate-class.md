---
title: "CDockState Class"
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
  - "CDockState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "dock state"
  - "size"
  - "docking control bars"
  - "CDockState class"
  - "states, dockable control bar"
  - "position, control bar"
  - "size, control bar"
  - "docking tool windows"
ms.assetid: 09e7c10b-3abd-4cb2-ad36-42420fe6bc36
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockState Class
A serialized <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> class that loads, unloads, or clears the state of one or more docking control bars in persistent memory (a file).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CDockState::Clear](#cdockstate__clear)|Clears the dock state information.|  
|[CDockState::GetVersion](#cdockstate__getversion)|Retrieves the version number of the stored bar state.|  
|[CDockState::LoadState](#cdockstate__loadstate)|Retrieves state information from the registry or .INI file.|  
|[CDockState::SaveState](#cdockstate__savestate)|Saves state information to the registry or INI file.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CDockState::m_arrBarInfo](#cdockstate__m_arrbarinfo)|Array of pointers to the stored dock state information with one entry for each control bar.|  
  
## Remarks  
 The dock state includes the size and position of the bar and whether or not it is docked. When retrieving the stored dock state, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> checks the bar's position and, if the bar is not visible with the current screen settings, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> scales the bar's position so that it is visible. The main purpose of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is to hold the entire state of a number of control bars and to allow that state to be saved and loaded either to the registry, the application's .INI file, or in binary form as part of a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object's contents.  
  
 The bar can be any dockable control bar, including a toolbar, status bar, or dialog bar. <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> objects are written and read to or from a file via a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object.  
  
 [CFrameWnd::GetDockState](../vs140/cframewnd-class.md#cframewnd__getdockstate) retrieves the state information of all the frame window's <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> objects and puts it into the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object. You can then write the contents of the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object to storage with [Serialize](../vs140/cobject-class.md#cobject__serialize) or [CDockState::SaveState](#cdockstate__savestate). If you later want to restore the state of the control bars in the frame window, you can load the state with <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> or [CDockState::LoadState](#cdockstate__loadstate), then use [CFrameWnd::SetDockState](../vs140/cframewnd-class.md#cframewnd__setdockstate) to apply the saved state to the frame window's control bars.  
  
 For more information on docking control bars, see the articles [Control Bars](../vs140/control-bars.md), [Toolbars: Docking and Floating](../vs140/docking-and-floating-toolbars.md), and [Frame Windows](../vs140/frame-windows.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxadv.h  
  
##  \<a name="cdockstate__clear">\</a>  CDockState::Clear  
 Call this function to clear all docking information stored in the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 This includes not only whether the bar is docked or not, but the bar's size and position and whether or not it is visible.  
  
##  \<a name="cdockstate__getversion">\</a>  CDockState::GetVersion  
 Call this function to retrieve the version number of the stored bar state.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 1 if the stored bar information is older than current bar state; 2 if the stored bar information is the same as the current bar state.  
  
### Remarks  
 Version support enables a revised bar to add new persistent properties and still be able to detect and load the persistent state created by an earlier version of the bar.  
  
##  \<a name="cdockstate__loadstate">\</a>  CDockState::LoadState  
 Call this function to retrieve state information from the registry or .INI file.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 Points to a null-teminated string that specifies the name of a section in the initialization file or a key in the Windows registry where state information is stored.  
  
### Remarks  
 The profile name is the section of the application's .INI file or the registry that contains the bars' state information. You can save control bar state information to the registry or .INI file with <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
##  \<a name="cdockstate__m_arrbarinfo">\</a>  CDockState::m_arrBarInfo  
 A <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object that is an array of pointers to the stored control bar information for each control bar that has saved state information in the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
##  \<a name="cdockstate__savestate">\</a>  CDockState::SaveState  
 Call this function to save the state information to the registry or .INI file.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 Points to a null-teminated string that specifies the name of a section in the initialization file or a key in the Windows registry where state information is stored.  
  
### Remarks  
 The profile name is the section of the application's .INI file or the registry that contains the control bar's state information. <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> also saves the current screen size. You can retrieve control bar information from the registry or .INI file with <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
## See Also  
 [Base Class](../vs140/cobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)