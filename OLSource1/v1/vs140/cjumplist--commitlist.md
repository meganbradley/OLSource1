---
title: "CJumpList::CommitList"
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
  - "CommitList"
  - "afxadv/CJumpList::CommitList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CommitList"
ms.assetid: f38ce29b-8169-4fb0-a024-17cc38f0ba16
caps.latest.revision: 10
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CJumpList::CommitList
Ends a list-building transaction and commits the reported list to the associated store (the registry in this case).  
  
## Syntax  
  
```  
BOOL CommitList();  
```  
  
## Return Value  
  
## Remarks  
 The commit is atomic. An error will be returned if the commit fails.  When `CommitList` is called, the current list of removed items will be cleaned up. Calling this method resets the object so that it does not have an active list-building transaction. To update the list, `BeginList` needs to be called again.  
  
## Requirements  
 **Header:** afxadv.h  
  
## See Also  
 [CJumpList](../vs140/cjumplist-class.md)