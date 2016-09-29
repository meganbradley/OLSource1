---
title: "CMapStringToOb::RemoveAll"
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
  - "CMapStringToOb.RemoveAll"
  - "CMapStringToOb::RemoveAll"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RemoveAll method"
  - "CMapStringToOb class, operations"
ms.assetid: 23a8d68e-b35e-4228-8a34-bfc5e8611202
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMapStringToOb::RemoveAll
Removes all the elements from this map and destroys the `CString` key objects.  
  
## Syntax  
  
```  
  
void RemoveAll( );  
```  
  
## Remarks  
 The `CObject` objects referenced by each key are not destroyed. The `RemoveAll` function can cause memory leaks if you do not ensure that the referenced `CObject` objects are destroyed.  
  
 The function works correctly if the map is already empty.  
  
 The following table shows other member functions that are similar to `CMapStringToOb::RemoveAll`.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CMapPtrToPtr](../vs140/cmapptrtoptr-class.md)|**void RemoveAll( );**|  
|[CMapPtrToWord](../vs140/cmapptrtoword-class.md)|**void RemoveAll( );**|  
|[CMapStringToPtr](../vs140/cmapstringtoptr-class.md)|**void RemoveAll( );**|  
|[CMapStringToString](../vs140/cmapstringtostring-class.md)|**void RemoveAll( );**|  
|[CMapWordToOb](../vs140/cmapwordtoob-class.md)|**void RemoveAll( );**|  
|[CMapWordToPtr](../vs140/cmapwordtoptr-class.md)|**void RemoveAll( );**|  
  
## Example  
 See [CObList::CObList](../vs140/coblist--coblist.md) for a listing of the `CAge` class used in all collection examples.  
  
 [!code[NVC_MFCCollections#69](../vs140/codesnippet/CPP/cmapstringtoob--removeall_1.cpp)]  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CMapStringToOb Class](../vs140/cmapstringtoob-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMapStringToOb::RemoveKey](../vs140/cmapstringtoob--removekey.md)