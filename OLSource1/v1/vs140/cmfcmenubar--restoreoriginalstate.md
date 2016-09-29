---
title: "CMFCMenuBar::RestoreOriginalstate"
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
  - "CMFCMenuBar::RestoreOriginalstate"
  - "CMFCMenuBar.RestoreOriginalstate"
  - "RestoreOriginalstate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RestoreOriginalstate method"
ms.assetid: 5e969a1f-928a-495f-bc19-a6d2a04a15fa
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCMenuBar::RestoreOriginalstate
Called by the framework when the user selects **Reset** from the **Customize** dialog box.  
  
## Syntax  
  
```  
virtual BOOL RestoreOriginalstate();  
```  
  
## Return Value  
 Nonzero if the method is successful; otherwise 0.  
  
## Remarks  
 This method is called when the user selects **Reset** from the customization menu. You can also manually call this method to programmatically reset the state of the menu bar. This method loads the original state from the resource file.  
  
 Override this method if you want to do any processing when the user selects the **Reset** option.  
  
## Requirements  
 **Header:** afxmenubar.h  
  
## See Also  
 [CMFCMenuBar Class](../vs140/cmfcmenubar-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)