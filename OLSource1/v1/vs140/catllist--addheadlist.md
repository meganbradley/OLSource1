---
title: "CAtlList::AddHeadList"
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
  - "ATL::CAtlList::AddHeadList"
  - "ATL.CAtlList.AddHeadList"
  - "CAtlList.AddHeadList"
  - "AddHeadList"
  - "CAtlList::AddHeadList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddHeadList method"
ms.assetid: 36499b62-279d-4ecb-a342-94e28b71e6b6
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlList::AddHeadList
Call this method to add an existing list to the head of the list.  
  
## Syntax  
  
```  
  
      void AddHeadList(  
   const CAtlList< E, ETraits >* plNew   
);  
```  
  
#### Parameters  
 `plNew`  
 The list to be added.  
  
## Remarks  
 The list pointed to by `plNew` is inserted at the start of the existing list. In debug builds, an assertion failure will occur if `plNew` is equal to NULL.  
  
## Example  
 [!code[NVC_ATL_Utilities#14](../vs140/codesnippet/CPP/catllist--addheadlist_1.cpp)]  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlList Class](../vs140/catllist-class.md)   
 [CAtlList::AddHead](../vs140/catllist--addhead.md)   
 [CAtlList::AddTailList](../vs140/catllist--addtaillist.md)