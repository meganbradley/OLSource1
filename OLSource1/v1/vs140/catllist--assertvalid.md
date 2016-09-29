---
title: "CAtlList::AssertValid"
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
  - "ATL.CAtlList.AssertValid"
  - "CAtlList.AssertValid"
  - "CAtlList::AssertValid"
  - "ATL::CAtlList::AssertValid"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AssertValid method"
ms.assetid: a8d027a7-686e-4135-b57c-86844a49022b
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlList::AssertValid
Call this method to confirm the list is valid.  
  
## Syntax  
  
```  
  
void AssertValid( ) const;  
  
```  
  
## Remarks  
 In debug builds, an assertion failure will occur if the list object is not valid. To be valid, an empty list must have both the head and tail pointing to NULL, and a list that is not empty must have both the head and tail pointing to valid addresses.  
  
## Example  
 [!code[NVC_ATL_Utilities#17](../vs140/codesnippet/CPP/catllist--assertvalid_1.cpp)]  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlList Class](../vs140/catllist-class.md)   
 [CAtlList::IsEmpty](../vs140/catllist--isempty.md)