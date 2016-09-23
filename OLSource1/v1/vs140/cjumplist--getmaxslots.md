---
title: "CJumpList::GetMaxSlots"
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
  - GetMaxSlots
  - afxadv/CJumpList::GetMaxSlots
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetMaxSlots
ms.assetid: 20063cc2-6dea-42ae-abd9-ab3416a6defc
caps.latest.revision: 10
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CJumpList::GetMaxSlots
Retrieves the maximum number of items, including category headers that can display in the calling application's destination menu.  
  
## Syntax  
  
```  
UINT GetMaxSlots() const;  
```  
  
## Return Value  
  
## Remarks  
 Applications may only report a number of items and category headers combined up to this value. If calls to `AppendCategory`, `AppendKnownCategory`, or `AddUserTasks` exceed this number, they will return failure.  
  
## Requirements  
 **Header:** afxadv.h  
  
## See Also  
 [CJumpList](../vs140/cjumplist-class.md)