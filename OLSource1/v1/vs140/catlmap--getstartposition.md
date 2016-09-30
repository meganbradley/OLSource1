---
title: "CAtlMap::GetStartPosition"
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
  - "ATL::CAtlMap::GetStartPosition"
  - "ATL.CAtlMap.GetStartPosition"
  - "CAtlMap::GetStartPosition"
  - "CAtlMap.GetStartPosition"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetStartPosition method"
ms.assetid: 200586d6-7b83-4952-a681-676c7fd120e5
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlMap::GetStartPosition
Call this method to start a map iteration.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns the start position, or NULL is returned if the map is empty.  
  
## Remarks  
 Call this method to start a map iteration by returning a **POSITION** value that can be passed to the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> method.  
  
> [!NOTE]
>  The iteration sequence is not predictable  
  
## Example  
 See the example for [CAtlMap::CAtlMap](../vs140/catlmap--catlmap.md).  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlMap Class](../vs140/catlmap-class.md)   
 [CAtlMap::GetNextAssoc](../vs140/catlmap--getnextassoc.md)