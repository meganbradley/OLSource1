---
title: "CMap::CPair"
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
  - "CMap.CPair"
  - "CMap::CPair"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CPair class, data members"
  - "CMap class, data member"
ms.assetid: 55f47198-498d-4c67-8829-4c40e1250593
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMap::CPair
Contains a key value and the value of the associated object.  
  
## Remarks  
 This is a nested structure within class [CMap](../vs140/cmap-class.md).  
  
 The structure is composed of two fields:  
  
-   **key** The actual value of the key type.  
  
-   **value** The value of the associated object.  
  
 It is used to store the return values from [CMap::PLookup](../vs140/cmap--plookup.md), [CMap::PGetFirstAssoc](../vs140/cmap--pgetfirstassoc.md), and [CMap::PGetNextAssoc](../vs140/cmap--pgetnextassoc.md).  
  
## Example  
 For an example of usage, see the example for [CMap::PLookup](../vs140/cmap--plookup.md).  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CMap Class](../vs140/cmap-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)