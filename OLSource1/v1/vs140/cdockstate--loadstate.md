---
title: "CDockState::LoadState"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CDockState.LoadState
  - CDockState::LoadState
  - LoadState
dev_langs: 
  - C++
helpviewer_keywords: 
  - LoadState method
ms.assetid: dd3448c4-4104-4847-ba96-7a44d0cd9994
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDockState::LoadState
Call this function to retrieve state information from the registry or .INI file.  
  
## Syntax  
  
```  
  
      void LoadState(  
   LPCTSTR lpszProfileName   
);  
```  
  
#### Parameters  
 `lpszProfileName`  
 Points to a null-teminated string that specifies the name of a section in the initialization file or a key in the Windows registry where state information is stored.  
  
## Remarks  
 The profile name is the section of the application's .INI file or the registry that contains the bars' state information. You can save control bar state information to the registry or .INI file with `SaveState`.  
  
## Requirements  
 **Header:** afxadv.h  
  
## See Also  
 [CDockState Class](../vs140/cdockstate-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDockState::SaveState](../vs140/cdockstate--savestate.md)   
 [CDockState::GetVersion](../vs140/cdockstate--getversion.md)   
 [CDockState::Clear](../vs140/cdockstate--clear.md)   
 [CFrameWnd::GetDockState](../vs140/cframewnd--getdockstate.md)   
 [CFrameWnd::SetDockState](../vs140/cframewnd--setdockstate.md)