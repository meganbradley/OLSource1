---
title: "CAtlList::RemoveHead"
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
  - "ATL.CAtlList.RemoveHead"
  - "CAtlList::RemoveHead"
  - "CAtlList.RemoveHead"
  - "ATL::CAtlList::RemoveHead"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RemoveHead method"
ms.assetid: cbb91bda-f376-44f8-b99a-99ce91d874f0
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlList::RemoveHead
Call this method to remove the element at the head of the list.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns the element at the head of the list.  
  
## Remarks  
 The head element is deleted from the list, and memory is freed. A copy of the element is returned. In debug builds, an assertion failure will occur if the list is empty.  
  
## Example  
 [!code[NVC_ATL_Utilities#28](../vs140/codesnippet/CPP/catllist--removehead_1.cpp)]  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlList Class](../vs140/catllist-class.md)   
 [CAtlList::RemoveHeadNoReturn](../vs140/catllist--removeheadnoreturn.md)