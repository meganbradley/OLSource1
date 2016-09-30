---
title: "CAtlMap::operator"
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
  - "ATL::CAtlMap::operator[]"
  - "CAtlMap::operator[]"
  - "CAtlMap.operator[]"
  - "ATL.CAtlMap.operator[]"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator[], map objects"
  - "operator [], map objects"
  - "[] operator"
ms.assetid: 17bd98b6-b60a-4421-8b83-54329aec2dee
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlMap::operator
Replaces or adds a new element to the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The key of the element to add or replace.  
  
## Return Value  
 Returns a reference to the value associated with the given key.  
  
## Example  
 If the key already exists, the element is replaced. If the key does not exist, a new element is added. See the example for [CAtlMap::CAtlMap](../vs140/catlmap--catlmap.md).  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlMap Class](../vs140/catlmap-class.md)   
 [CAtlMap::SetAt](../vs140/catlmap--setat.md)