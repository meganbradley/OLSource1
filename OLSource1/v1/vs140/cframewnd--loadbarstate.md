---
title: "CFrameWnd::LoadBarState"
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
  - "CFrameWnd.LoadBarState"
  - "LoadBarState"
  - "CFrameWnd::LoadBarState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LoadBarState method"
  - "CFrameWnd class, initialization"
ms.assetid: 55af47fa-0aa4-4959-bbb2-6743286d6797
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWnd::LoadBarState
Call this function to restore the settings of each control bar owned by the frame window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Name of a section in the initialization (INI) file or a key in the Windows registry where state information is stored.  
  
## Remarks  
 Information restored includes visibility, horizontal/vertical orientation, docking state, and control-bar position.  
  
 The settings you want to restore must be written to the registry before you call <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. Write the information to the registry by calling [CWinApp::SetRegistryKey](../vs140/cwinapp--setregistrykey.md). Write the information to the INI file by calling [SaveBarState](../vs140/cframewnd--savebarstate.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CFrameWnd Class](../vs140/cframewnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFrameWnd::SaveBarState](../vs140/cframewnd--savebarstate.md)   
 [CWinApp::m_pszProfileName](../vs140/cwinapp--m_pszprofilename.md)