---
title: "CWinApp::LoadStdProfileSettings"
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
  - CWinApp.LoadStdProfileSettings
  - CWinApp::LoadStdProfileSettings
dev_langs: 
  - C++
helpviewer_keywords: 
  - CWinApp class, initialization
  - standard profile settings, loading
  - LoadStdProfileSettings method
  - standard profile settings
ms.assetid: c23205b4-580b-431d-9c68-3710e6aaa29a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWinApp::LoadStdProfileSettings
Call this member function from within the [InitInstance](../vs140/cwinapp--initinstance.md) member function to enable and load the list of most recently used (MRU) files and last preview state.  
  
## Syntax  
  
```  
  
      void LoadStdProfileSettings(  
   UINT nMaxMRU = _AFX_MRU_COUNT   
);  
```  
  
#### Parameters  
 `nMaxMRU`  
 The number of recently used files to track.  
  
## Remarks  
 If `nMaxMRU` is 0, no MRU list will be maintained.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp::OnFileOpen](../vs140/cwinapp--onfileopen.md)   
 [CWinApp::AddToRecentFileList](../vs140/cwinapp--addtorecentfilelist.md)