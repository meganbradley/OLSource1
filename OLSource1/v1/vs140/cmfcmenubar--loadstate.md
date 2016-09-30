---
title: "CMFCMenuBar::LoadState"
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
  - "CMFCMenuBar.LoadState"
  - "CMFCMenuBar::LoadState"
  - "LoadState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LoadState method"
ms.assetid: fca3d59c-2f52-4068-8fb8-607bbe233e9e
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCMenuBar::LoadState
Loads the state of the menu bar from the Windows registry.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A string that contains the path of a Windows registry key.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The control ID for the menu bar.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A reserved value.  
  
## Return Value  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if the method was successful; otherwise <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Remarks  
 Use the [CMFCMenuBar::SaveState](../vs140/cmfcmenubar--savestate.md) method to save the state of the menu bar to the registry. The saved information includes the menu items, the dock state, and the position of the menu bar.  
  
 In most cases your application does not call <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. The framework calls this method when it initializes the workspace.  
  
## Requirements  
 **Header:** afxmenubar.h  
  
## See Also  
 [CMFCMenuBar Class](../vs140/cmfcmenubar-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCMenuBar::SaveState](../vs140/cmfcmenubar--savestate.md)