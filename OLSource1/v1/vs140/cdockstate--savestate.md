---
title: "CDockState::SaveState"
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
  - "CDockState.SaveState"
  - "CDockState::SaveState"
  - "SaveState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SaveState method"
ms.assetid: 1b6bc9af-bbd6-4dbe-a2e8-99e743f51d3d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockState::SaveState
Call this function to save the state information to the registry or .INI file.  
  
## Syntax  
  
```  
  
      void SaveState(  
   LPCTSTR lpszProfileName   
);  
```  
  
#### Parameters  
 `lpszProfileName`  
 Points to a null-teminated string that specifies the name of a section in the initialization file or a key in the Windows registry where state information is stored.  
  
## Remarks  
 The profile name is the section of the application's .INI file or the registry that contains the control bar's state information. `SaveState` also saves the current screen size. You can retrieve control bar information from the registry or .INI file with `LoadState`.  
  
## Requirements  
 **Header:** afxadv.h  
  
## See Also  
 [CDockState Class](../vs140/cdockstate-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDockState::LoadState](../vs140/cdockstate--loadstate.md)   
 [CDockState::GetVersion](../vs140/cdockstate--getversion.md)   
 [CDockState::Clear](../vs140/cdockstate--clear.md)   
 [CFrameWnd::GetDockState](../vs140/cframewnd--getdockstate.md)   
 [CFrameWnd::SetDockState](../vs140/cframewnd--setdockstate.md)