---
title: "CAtlList::AddTail"
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
  - "CAtlList.AddTail"
  - "ATL::CAtlList::AddTail"
  - "ATL.CAtlList.AddTail"
  - "CAtlList::AddTail"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddTail method"
ms.assetid: cc36cb17-00f2-4927-8a93-596b557fa383
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlList::AddTail
Call this method to add an element to the tail of this list.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The element to add.  
  
## Return Value  
 Returns the POSITION of the newly added element.  
  
## Remarks  
 If the first version is used, an empty element is created using its default constructor, rather than its copy constructor. The element is added to the end of the list, and so it now becomes the tail. This method can be used with an empty list.  
  
## Example  
 [!code[NVC_ATL_Utilities#15](../vs140/codesnippet/CPP/catllist--addtail_1.cpp)]  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlList Class](../vs140/catllist-class.md)   
 [CAtlList::AddTailList](../vs140/catllist--addtaillist.md)   
 [CAtlList::AddHead](../vs140/catllist--addhead.md)