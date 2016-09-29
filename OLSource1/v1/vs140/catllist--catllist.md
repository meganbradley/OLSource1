---
title: "CAtlList::CAtlList"
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
  - "ATL::CAtlList::CAtlList"
  - "CAtlList.CAtlList"
  - "CAtlList::CAtlList"
  - "ATL.CAtlList.CAtlList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CAtlList class, constructor"
  - "CAtlList constructor"
ms.assetid: 74de654b-280a-481a-acb6-ffc7dcce6802
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlList::CAtlList
The constructor.  
  
## Syntax  
  
```  
  
      CAtlList(  
   UINT nBlockSize = 10   
) throw( );  
```  
  
#### Parameters  
 `nBlockSize`  
 The block size.  
  
## Remarks  
 The constructor for the `CAtlList` object. The block size is a measure of the amount of memory allocated when a new element is required. Larger block sizes reduce calls to memory allocation routines, but use more resources.  
  
## Example  
 [!code[NVC_ATL_Utilities#18](../vs140/codesnippet/CPP/catllist--catllist_1.cpp)]  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlList Class](../vs140/catllist-class.md)   
 [CAtlList::~CAtlList](../vs140/catllist--~catllist.md)