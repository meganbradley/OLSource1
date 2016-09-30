---
title: "CAutoPtrList::CAutoPtrList"
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
  - "ATL.CAutoPtrList.CAutoPtrList"
  - "CAutoPtrList"
  - "ATL::CAutoPtrList::CAutoPtrList"
  - "CAutoPtrList::CAutoPtrList"
  - "CAutoPtrList.CAutoPtrList"
  - "CAutoPtrList<E>.CAutoPtrList"
  - "CAutoPtrList<E>::CAutoPtrList"
  - "ATL::CAutoPtrList<E>::CAutoPtrList"
  - "ATL.CAutoPtrList<E>.CAutoPtrList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CAutoPtrList constructor"
  - "CAutoPtrList class, constructor"
ms.assetid: 20a0af6a-58e4-4787-84bf-1015460daa84
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAutoPtrList::CAutoPtrList
The constructor.  
  
## Syntax  
  
```  
  
      CAutoPtrList(  
   UINT nBlockSize = 10   
) throw( );  
```  
  
#### Parameters  
 `nBlockSize`  
 The block size, with a default of 10.  
  
## Remarks  
 The block size is a measure of the amount of memory allocated when a new element is required. Larger block sizes reduce calls to memory allocation routines, but use more resources.  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAutoPtrList Class](../vs140/cautoptrlist-class.md)