---
title: "CContextMenuManager::GetMenuNames"
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
  - CContextMenuManager::GetMenuNames
  - GetMenuNames
  - CContextMenuManager.GetMenuNames
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetMenuNames method
ms.assetid: e4b704f3-b901-4410-a350-736bc30c79cb
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CContextMenuManager::GetMenuNames
Returns the list of menu names added to the [CContextMenuManager](../vs140/ccontextmenumanager-class.md).  
  
## Syntax  
  
```  
void GetMenuNames(  
   CStringList& listOfNames   
) const;  
```  
  
#### Parameters  
 [out] `listOfNames`  
 A reference to a [CStringList](../vs140/cstringlist-class.md) parameter. This method writes the list of menu names to this parameter.  
  
## Requirements  
 **Header:** afxcontextmenumanager.h  
  
## See Also  
 [CContextMenuManager Class](../vs140/ccontextmenumanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)