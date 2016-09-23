---
title: "CFrameWnd::SaveBarState"
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
  - CFrameWnd::SaveBarState
  - CFrameWnd.SaveBarState
  - SaveBarState
dev_langs: 
  - C++
helpviewer_keywords: 
  - SaveBarState method
  - CFrameWnd class, initialization
ms.assetid: 3b4e7f29-935f-4693-8d6c-9de2e86f5295
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CFrameWnd::SaveBarState
Call this function to store information about each control bar owned by the frame window.  
  
## Syntax  
  
```  
  
      void SaveBarState(  
   LPCTSTR lpszProfileName   
) const;  
```  
  
#### Parameters  
 `lpszProfileName`  
 Name of a section in the initialization file or a key in the Windows registry where state information is stored.  
  
## Remarks  
 This information can be read from the initialization file using [LoadBarState](../vs140/cframewnd--loadbarstate.md). Information stored includes visibility, horizontal/vertical orientation, docking state, and control bar position.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CFrameWnd Class](../vs140/cframewnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFrameWnd::LoadBarState](../vs140/cframewnd--loadbarstate.md)   
 [CWinApp::SetRegistryKey](../vs140/cwinapp--setregistrykey.md)   
 [CWinApp::m_pszProfileName](../vs140/cwinapp--m_pszprofilename.md)