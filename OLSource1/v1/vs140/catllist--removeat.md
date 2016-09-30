---
title: "CAtlList::RemoveAt"
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
  - "CAtlList.RemoveAt"
  - "CAtlList::RemoveAt"
  - "ATL::CAtlList::RemoveAt"
  - "ATL.CAtlList.RemoveAt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RemoveAt method"
ms.assetid: 907771c1-59a5-4527-8a4c-62fa0ed034b1
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlList::RemoveAt
Call this method to remove a single element from the list.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The POSITION value of the element to remove.  
  
## Remarks  
 The element referenced by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is removed, and memory is freed. It is acceptable to use <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to remove the head or tail of the list.  
  
 In debug builds, an assertion failure will occur if the list is not valid or if removing the element causes the list to access memory which isn't part of the list structure.  
  
## Example  
 [!code[NVC_ATL_Utilities#27](../vs140/codesnippet/CPP/catllist--removeat_1.cpp)]  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlList Class](../vs140/catllist-class.md)   
 [CAtlList::RemoveAll](../vs140/catllist--removeall.md)   
 [CAtlList::SetAt](../vs140/catllist--setat.md)