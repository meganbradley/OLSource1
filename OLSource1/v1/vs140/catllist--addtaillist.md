---
title: "CAtlList::AddTailList"
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
  - "AddTailList"
  - "ATL.CAtlList.AddTailList"
  - "ATL::CAtlList::AddTailList"
  - "CAtlList.AddTailList"
  - "CAtlList::AddTailList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddTailList method"
ms.assetid: 9b98b3b5-896e-4abc-ad3a-3fc153cb01bb
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlList::AddTailList
Call this method to add an existing list to the tail of this list.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The list to be added.  
  
## Remarks  
 The list pointed to by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is inserted after the last element (if any) in the list object. The last element in the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> list therefore becomes the tail. In debug builds, an assertion failure will occur if *plNew* is equal to NULL.  
  
## Example  
 [!code[NVC_ATL_Utilities#16](../vs140/codesnippet/CPP/catllist--addtaillist_1.cpp)]  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlList Class](../vs140/catllist-class.md)   
 [CAtlList::AddTail](../vs140/catllist--addtail.md)   
 [CAtlList::AddHead](../vs140/catllist--addhead.md)