---
title: "CTypedPtrMap::operator"
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
  - "CTypedPtrMap.operator[]"
  - "CTypedPtrMap::operator[]"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator[], map objects"
  - "operator [], map objects"
  - "[] operator"
ms.assetid: 5c77f338-b599-4b78-994f-c1b54c256a9d
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTypedPtrMap::operator
This operator can be used only on the left side of an assignment statement (an l-value).  
  
## Syntax  
  
```  
  
      VALUE  
      & operator [ ](BASE_CLASS::BASE_ARG_KEY key);  
```  
  
#### Parameters  
 *VALUE*  
 Template parameter specifying the type of values stored in this map.  
  
 `BASE_CLASS`  
 Template parameter specifying the base class of this map's class.  
  
 `key`  
 The key of the element to be looked up or created in the map.  
  
## Remarks  
 If there is no map element with the specified key, then a new element is created. There is no "right side" (r-value) equivalent to this operator because there is a possibility that a key may not be found in the map. Use the `Lookup` member function for element retrieval.  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CTypedPtrMap Class](../vs140/ctypedptrmap-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTypedPtrMap::Lookup](../vs140/ctypedptrmap--lookup.md)