---
title: "CAtlList::RemoveAll"
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
  - "ATL.CAtlList.RemoveAll"
  - "CAtlList.RemoveAll"
  - "ATL::CAtlList::RemoveAll"
  - "CAtlList::RemoveAll"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RemoveAll method"
ms.assetid: f407d446-704c-4943-b5b4-7be57ea85f4d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlList::RemoveAll
Call this method to remove all of the elements from the list.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 This method removes all of the elements from the list and frees the allocated memory. In debugs builds, an ATLASSERT will be raised if all elements aren't deleted or if the list structure has become corrupted.  
  
## Example  
 See the example for [CAtlList::IsEmpty](../vs140/catllist--isempty.md).  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlList Class](../vs140/catllist-class.md)   
 [CAtlList::RemoveAt](../vs140/catllist--removeat.md)