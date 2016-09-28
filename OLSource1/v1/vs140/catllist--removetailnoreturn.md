---
title: "CAtlList::RemoveTailNoReturn"
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
  - "CAtlList.RemoveTailNoReturn"
  - "CAtlList::RemoveTailNoReturn"
  - "ATL::CAtlList::RemoveTailNoReturn"
  - "RemoveTailNoReturn"
  - "ATL.CAtlList.RemoveTailNoReturn"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RemoveTailNoReturn method"
ms.assetid: 284f0bc2-6ad2-4bc5-adde-cad5f1044382
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlList::RemoveTailNoReturn
Call this method to remove the element at the tail of the list without returning a value.  
  
## Syntax  
  
```  
  
void RemoveTailNoReturn( ) throw( );  
  
```  
  
## Remarks  
 The tail element is deleted from the list, and memory is freed. In debug builds, an assertion failure will occur if the list is empty.  
  
## Example  
 See the example for [CAtlList::IsEmpty](../vs140/catllist--isempty.md).  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlList Class](../vs140/catllist-class.md)   
 [CAtlList::RemoveTail](../vs140/catllist--removetail.md)   
 [CAtlList::RemoveHead](../vs140/catllist--removehead.md)   
 [CAtlList::RemoveHeadNoReturn](../vs140/catllist--removeheadnoreturn.md)