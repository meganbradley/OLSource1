---
title: "CRecentFileList::UpdateMenu"
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
  - CRecentFileList.UpdateMenu
  - CRecentFileList::UpdateMenu
  - UpdateMenu
dev_langs: 
  - C++
helpviewer_keywords: 
  - UpdateMenu method
ms.assetid: a289dd7b-7f39-4685-bc16-08b3a8a198ba
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CRecentFileList::UpdateMenu
Updates the menu display of the MRU file list.  
  
## Syntax  
  
```  
  
      virtual void UpdateMenu(  
   CCmdUI* pCmdUI   
);  
```  
  
#### Parameters  
 `pCmdUI`  
 A pointer to the [CCmdUI](../vs140/ccmdui-class.md) object for the most recently used (MRU) file list menu.  
  
## Requirements  
 **Header:** afxadv.h  
  
## See Also  
 [CRecentFileList Class](../vs140/crecentfilelist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRecentFileList::Add](../vs140/crecentfilelist--add.md)   
 [CRecentFileList::Remove](../vs140/crecentfilelist--remove.md)