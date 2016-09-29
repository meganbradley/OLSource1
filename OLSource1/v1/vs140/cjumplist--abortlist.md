---
title: "CJumpList::AbortList"
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
  - "AbortList"
  - "afxadv/CJumpList::AbortList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AbortList"
ms.assetid: 6e86a2af-5144-4bcd-96a6-44cd41372eb1
caps.latest.revision: 10
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CJumpList::AbortList
Aborts a list-building transaction without committing.  
  
## Syntax  
  
```  
void AbortList();  
```  
  
## Remarks  
 Calling this method has the same effect as destroying `CJumpList` without calling `CommitList`.  
  
## Requirements  
 **Header:** afxadv.h  
  
## See Also  
 [CJumpList](../vs140/cjumplist-class.md)