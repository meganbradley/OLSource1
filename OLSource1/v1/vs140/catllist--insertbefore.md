---
title: "CAtlList::InsertBefore"
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
  - "InsertBefore"
  - "ATL.CAtlList.InsertBefore"
  - "CAtlList::InsertBefore"
  - "ATL::CAtlList::InsertBefore"
  - "CAtlList.InsertBefore"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InsertBefore method"
ms.assetid: 9353d42f-9d11-476f-8ff5-e0f45b6e054a
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlList::InsertBefore
Call this method to insert a new element into the list before the specified position.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The new element will be inserted into the list before this POSITION value.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The element to be inserted.  
  
## Return Value  
 Returns the POSITION value of the new element.  
  
## Remarks  
 In debug builds, an assertion failure will occur if the list isn't valid, if the insert fails, or if an attempt is made to insert the element before the head.  
  
## Example  
 [!code[NVC_ATL_Utilities#24](../vs140/codesnippet/CPP/catllist--insertbefore_1.cpp)]  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlList Class](../vs140/catllist-class.md)   
 [CAtlList::InsertAfter](../vs140/catllist--insertafter.md)