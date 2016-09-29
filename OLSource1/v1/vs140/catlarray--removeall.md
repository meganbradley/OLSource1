---
title: "CAtlArray::RemoveAll"
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
  - "CAtlArray::RemoveAll"
  - "ATL.CAtlArray.RemoveAll"
  - "CAtlArray.RemoveAll"
  - "ATL::CAtlArray::RemoveAll"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RemoveAll method"
ms.assetid: c6de79c9-5748-4ccd-a0c8-e4bd8b48025b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlArray::RemoveAll
Call this method to remove all elements from the array object.  
  
## Syntax  
  
```  
  
void RemoveAll( ) throw( );  
  
```  
  
## Remarks  
 Removes all of the elements from the array object.  
  
 This method calls [CAtlArray::SetCount](../vs140/catlarray--setcount.md) to resize the array and subsequently frees any allocated memory.  
  
## Example  
 See the example for [CAtlArray::IsEmpty](../vs140/catlarray--isempty.md).  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlArray Class](../vs140/catlarray-class.md)   
 [CAtlArray::RemoveAt](../vs140/catlarray--removeat.md)   
 [CAtlArray::FreeExtra](../vs140/catlarray--freeextra.md)