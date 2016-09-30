---
title: "CAtlList::InsertAfter"
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
  - "ATL::CAtlList::InsertAfter"
  - "ATL.CAtlList.InsertAfter"
  - "CAtlList::InsertAfter"
  - "CAtlList.InsertAfter"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InsertAfter method"
ms.assetid: a085421a-1944-43dc-bd6c-36de196cda8c
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlList::InsertAfter
Call this method to insert a new element into the list after the specified position.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The POSITION value after which the new element will be inserted.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The element to be inserted.  
  
## Return Value  
 Returns the POSITION value of the new element.  
  
## Remarks  
 In debug builds, an assertion failure will occur if the list isn't valid, if the insert fails, or if an attempt is made to insert the element after the tail.  
  
## Example  
 [!code[NVC_ATL_Utilities#23](../vs140/codesnippet/CPP/catllist--insertafter_1.cpp)]  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlList Class](../vs140/catllist-class.md)   
 [CAtlList::InsertBefore](../vs140/catllist--insertbefore.md)