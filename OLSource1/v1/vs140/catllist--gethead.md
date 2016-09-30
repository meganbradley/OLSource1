---
title: "CAtlList::GetHead"
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
  - "CAtlList.GetHead"
  - "ATL::CAtlList::GetHead"
  - "ATL.CAtlList.GetHead"
  - "CAtlList::GetHead"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetHead method"
ms.assetid: 93f6e2b4-c239-4589-9047-e658717c2711
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlList::GetHead
Call this method to return the element at the head of the list.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns a reference to, or a copy of, the element at the head of the list.  
  
## Remarks  
 If the list is **const**, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> returns a copy of the element at the head of the list. This allows the method to be used only on the right side of an assignment statement and protects the list from modification.  
  
 If the list is not **const**, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> returns a reference to the element at the head of the list. This allows the method to be used on either side of an assignment statement and thus allows the list entries to be modified.  
  
 In debug builds, an assertion failure will occur if the head of the list points to NULL.  
  
## Example  
 See the example for [CAtlList::AddHead](../vs140/catllist--addhead.md).  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlList Class](../vs140/catllist-class.md)   
 [CAtlList::GetHeadPosition](../vs140/catllist--getheadposition.md)   
 [CAtlList::GetTail](../vs140/catllist--gettail.md)