---
title: "CJumpList::ClearAllDestinations"
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
  - "ClearAllDestinations"
  - "afxadv/CJumpList::ClearAllDestinations"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ClearAllDestinations"
ms.assetid: 31be675b-7eec-44aa-9934-fd3ce36dc2bb
caps.latest.revision: 10
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CJumpList::ClearAllDestinations
Removes all destinations that have been added to the current instance of CJumpList so far.  
  
## Syntax  
  
```  
void ClearAllDestinations();  
```  
  
## Remarks  
 Call this function if you need to remove all destinations that have been added so far in the current session of destination list building and add other destinations again. If the internal `ICustomDestinationList` has been initialized, it's left alive.  
  
## Requirements  
 **Header:** afxadv.h  
  
## See Also  
 [CJumpList](../vs140/cjumplist-class.md)