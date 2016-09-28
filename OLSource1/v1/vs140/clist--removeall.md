---
title: "CList::RemoveAll"
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
  - "CList::RemoveAll"
  - "CList.RemoveAll"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CList class, operations"
  - "RemoveAll method"
ms.assetid: ac41902b-7e5e-4eb9-858a-2b5414f05a0e
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CList::RemoveAll
Removes all the elements from this list and frees the associated memory.  
  
## Syntax  
  
```  
  
void RemoveAll( );  
```  
  
## Remarks  
 No error is generated if the list is already empty.  
  
## Example  
 [!code[NVC_MFCCollections#51](../vs140/codesnippet/CPP/clist--removeall_1.cpp)]  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CList Class](../vs140/clist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CList::RemoveAt](../vs140/clist--removeat.md)