---
title: "CMapStringToOb::GetSize"
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
  - "CMapStringToOb::GetSize"
  - "CMapStringToOb.GetSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetSize method"
ms.assetid: 5d9ae412-3998-4da1-b947-ee7298149ad5
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMapStringToOb::GetSize
Returns the number of map elements.  
  
## Syntax  
  
```  
  
INT_PTR GetSize( ) const;  
```  
  
## Return Value  
 The number of items in the map.  
  
## Remarks  
 Call this method to retrieve the number of elements in the map.  
  
 The following table shows other member functions that are similar to `CMapStringToOb::GetSize`.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CMapPtrToPtr](../vs140/cmapptrtoptr-class.md)|**INT_PTR GetSize( ) const;**|  
|[CMapPtrToWord](../vs140/cmapptrtoword-class.md)|**INT_PTR GetSize( ) const;**|  
|[CMapStringToPtr](../vs140/cmapstringtoptr-class.md)|**INT_PTR GetSize( ) const;**|  
|[CMapStringToString](../vs140/cmapstringtostring-class.md)|**INT_PTR GetSize( ) const;**|  
|[CMapWordToOb](../vs140/cmapwordtoob-class.md)|**INT_PTR GetSize( ) const;**|  
|[CMapWordToPtr](../vs140/cmapwordtoptr-class.md)|**INT_PTR GetSize( ) const;**|  
  
## Example  
 [!code[NVC_MFCCollections#67](../vs140/codesnippet/CPP/cmapstringtoob--getsize_1.cpp)]  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CMapStringToOb Class](../vs140/cmapstringtoob-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)