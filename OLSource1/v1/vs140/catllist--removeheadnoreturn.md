---
title: "CAtlList::RemoveHeadNoReturn"
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
  - "ATL::CAtlList::RemoveHeadNoReturn"
  - "CAtlList::RemoveHeadNoReturn"
  - "CAtlList.RemoveHeadNoReturn"
  - "ATL.CAtlList.RemoveHeadNoReturn"
  - "RemoveHeadNoReturn"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RemoveHeadNoReturn method"
ms.assetid: 7bb54038-d890-4709-a305-401dfb6b07ae
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlList::RemoveHeadNoReturn
Call this method to remove the element at the head of the list without returning a value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The head element is deleted from the list, and memory is freed. In debug builds, an assertion failure will occur if the list is empty.  
  
## Example  
 See the example for [CAtlList::IsEmpty](../vs140/catllist--isempty.md).  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlList Class](../vs140/catllist-class.md)   
 [CAtlList::RemoveHead](../vs140/catllist--removehead.md)   
 [CAtlList::RemoveTailNoReturn](../vs140/catllist--removetailnoreturn.md)   
 [CAtlList::RemoveTail](../vs140/catllist--removetail.md)