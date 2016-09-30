---
title: "CDockState::GetVersion"
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
  - "GetVersion"
  - "CDockState::GetVersion"
  - "CDockState.GetVersion"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetVersion method"
ms.assetid: e3d9071b-5abd-4e0e-bcb8-aa9724f95b5c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockState::GetVersion
Call this function to retrieve the version number of the stored bar state.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 1 if the stored bar information is older than current bar state; 2 if the stored bar information is the same as the current bar state.  
  
## Remarks  
 Version support enables a revised bar to add new persistent properties and still be able to detect and load the persistent state created by an earlier version of the bar.  
  
## Requirements  
 **Header:** afxadv.h  
  
## See Also  
 [CDockState Class](../vs140/cdockstate-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDockState::LoadState](../vs140/cdockstate--loadstate.md)   
 [CDockState::SaveState](../vs140/cdockstate--savestate.md)   
 [CDockState::Clear](../vs140/cdockstate--clear.md)   
 [CFrameWnd::GetDockState](../vs140/cframewnd--getdockstate.md)   
 [CFrameWnd::SetDockState](../vs140/cframewnd--setdockstate.md)