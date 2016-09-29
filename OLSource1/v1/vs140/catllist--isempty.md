---
title: "CAtlList::IsEmpty"
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
  - "ATL.CAtlList.IsEmpty"
  - "CAtlList.IsEmpty"
  - "ATL::CAtlList::IsEmpty"
  - "CAtlList::IsEmpty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsEmpty method"
ms.assetid: 4419e0ff-881a-4442-99e8-b199e79cde9d
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlList::IsEmpty
Call this method to determine if the list is empty.  
  
## Syntax  
  
```  
  
bool IsEmpty( ) const throw( );  
  
```  
  
## Return Value  
 Returns true if the list contains no objects, otherwise false.  
  
## Example  
 [!code[NVC_ATL_Utilities#25](../vs140/codesnippet/CPP/catllist--isempty_1.cpp)]  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlList Class](../vs140/catllist-class.md)   
 [CAtlList::GetCount](../vs140/catllist--getcount.md)