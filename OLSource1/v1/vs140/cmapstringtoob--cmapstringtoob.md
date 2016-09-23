---
title: "CMapStringToOb::CMapStringToOb"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CMapStringToOb.CMapStringToOb
  - CMapStringToOb::CMapStringToOb
dev_langs: 
  - C++
helpviewer_keywords: 
  - CMapStringToOb class, constructor
ms.assetid: 6528521d-a2e8-4c22-906e-2fba2a8604b9
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMapStringToOb::CMapStringToOb
Constructs an empty `CString`-to-`CObject*` map.  
  
## Syntax  
  
```  
  
      CMapStringToOb(  
   INT_PTR nBlockSize = 10   
);  
```  
  
#### Parameters  
 `nBlockSize`  
 Specifies the memory-allocation granularity for extending the map.  
  
## Remarks  
 As the map grows, memory is allocated in units of `nBlockSize` entries.  
  
 The following table shows other member functions that are similar to **CMapStringToOb:: CMapStringToOb**.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CMapPtrToPtr](../vs140/cmapptrtoptr-class.md)|**CMapPtrToPtr( INT_PTR**  `nBlockSize`  **= 10 );**|  
|[CMapPtrToWord](../vs140/cmapptrtoword-class.md)|**CMapPtrToWord( INT_PTR**  `nBlockSize`  **= 10 );**|  
|[CMapStringToPtr](../vs140/cmapstringtoptr-class.md)|**CMapStringToPtr( INT_PTR**  `nBlockSize`  **= 10 );**|  
|[CMapStringToString](../vs140/cmapstringtostring-class.md)|**CMapStringToString( INT_PTR**  `nBlockSize`  **= 10 );**|  
|[CMapWordToOb](../vs140/cmapwordtoob-class.md)|**CMapWordToOb( INT_PTR**  `nBlockSize`  **= 10 );**|  
|[CMapWordToPtr](../vs140/cmapwordtoptr-class.md)|**MapWordToPtr( INT_PTR**  `nBlockSize`  **= 10 );**|  
  
## Example  
 [!code[NVC_MFCCollections#63](../vs140/codesnippet/CPP/cmapstringtoob--cmapstringtoob_1.cpp)]
  
  
 See [CObList::CObList](../vs140/coblist--coblist.md) for a listing of the `CAge` class used in all collection examples.  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CMapStringToOb Class](../vs140/cmapstringtoob-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)