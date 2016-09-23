---
title: "CMFCMenuBar::SetDefaultMenuResId"
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
  - CMFCMenuBar.SetDefaultMenuResId
  - SetDefaultMenuResId
  - CMFCMenuBar::SetDefaultMenuResId
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetDefaultMenuResId method
ms.assetid: 36ef6c5f-7c6d-4309-8e5a-7e09a29d1aaf
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCMenuBar::SetDefaultMenuResId
Sets the default menu for a [CMFCMenuBar](../vs140/cmfcmenubar-class.md) object based on the resource ID.  
  
## Syntax  
  
```  
void SetDefaultMenuResId(  
   UINT uiResId  
);  
```  
  
#### Parameters  
 [in] `uiResId`  
 The resource ID for the new default menu.  
  
## Remarks  
 The [CMFCMenuBar::RestoreOriginalstate](../vs140/cmfcmenubar--restoreoriginalstate.md) method restores the default menu from the resource file.  
  
 Use the [CMFCMenuBar::GetDefaultMenuResId](../vs140/cmfcmenubar--getdefaultmenuresid.md) method to retrieve the default menu without restoring it.  
  
## Requirements  
 **Header:** afxmenubar.h  
  
## See Also  
 [CMFCMenuBar Class](../vs140/cmfcmenubar-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCMenuBar::GetDefaultMenuResId](../vs140/cmfcmenubar--getdefaultmenuresid.md)   
 [CMFCMenuBar::RestoreOriginalstate](../vs140/cmfcmenubar--restoreoriginalstate.md)