---
title: "CMFCMenuBar::SaveState"
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
  - "CMFCMenuBar::SaveState"
  - "CMFCMenuBar.SaveState"
  - "SaveState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SaveState method"
ms.assetid: b0588241-9df7-4aa6-86cf-789b06455500
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCMenuBar::SaveState
Saves the state of the [CMFCMenuBar](../vs140/cmfcmenubar-class.md) object to the Windows registry.  
  
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
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if successful; otherwise <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>;  
  
## Remarks  
 Usually, your application does not call <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. The framework calls this method when the workspace is serialized. For more information, see [CWinAppEx::SaveState](../vs140/cwinappex--savestate.md).  
  
 The saved information includes the menu items, the dock state, and the position of the menu bar.  
  
## Requirements  
 **Header:** afxmenubar.h  
  
## See Also  
 [CMFCMenuBar Class](../vs140/cmfcmenubar-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCMenuBar::LoadState](../vs140/cmfcmenubar--loadstate.md)