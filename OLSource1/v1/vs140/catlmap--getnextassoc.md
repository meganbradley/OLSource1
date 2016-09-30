---
title: "CAtlMap::GetNextAssoc"
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
  - "ATL.CAtlMap.GetNextAssoc"
  - "ATL::CAtlMap::GetNextAssoc"
  - "CAtlMap::GetNextAssoc"
  - "CAtlMap.GetNextAssoc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetNextAssoc method"
ms.assetid: d4cb97c8-c446-4b63-9507-9518f16a9f97
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlMap::GetNextAssoc
Gets the next element for iterating.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The position counter, returned by a previous call to [CAtlMap::GetNextAssoc](#vclrfcatlmapgetnextassoc) or [CAtlMap::GetStartPosition](../vs140/catlmap--getstartposition.md).  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Template parameter specifying the type of the map's key.  
  
 *value*  
 Template parameter specifying the type of the map's value.  
  
## Remarks  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> position counter is updated after each call. If the retrieved element is the last in the map, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is set to NULL.  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlMap Class](../vs140/catlmap-class.md)   
 [CAtlMap::GetNext](../vs140/catlmap--getnext.md)   
 [CAtlMap::GetNextKey](../vs140/catlmap--getnextkey.md)   
 [CAtlMap::GetNextValue](../vs140/catlmap--getnextvalue.md)   
 [CAtlMap::GetStartPosition](../vs140/catlmap--getstartposition.md)