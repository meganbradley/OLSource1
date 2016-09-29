---
title: "CMapStringToOb::RemoveKey"
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
  - "CMapStringToOb::RemoveKey"
  - "CMapStringToOb.RemoveKey"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMapStringToOb class, operations"
  - "RemoveKey method"
ms.assetid: 66ea5b21-6faf-429d-83a2-95d3cb9ed702
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMapStringToOb::RemoveKey
Looks up the map entry corresponding to the supplied key; then, if the key is found, removes the entry.  
  
## Syntax  
  
```  
  
      BOOL RemoveKey(  
   LPCTSTR key   
);  
```  
  
#### Parameters  
 `key`  
 Specifies the string used for map lookup.  
  
## Return Value  
 Nonzero if the entry was found and successfully removed; otherwise 0.  
  
## Remarks  
 This can cause memory leaks if the `CObject` object is not deleted elsewhere.  
  
 The following table shows other member functions that are similar to `CMapStringToOb::RemoveKey`.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CMapPtrToPtr](../vs140/cmapptrtoptr-class.md)|**BOOL RemoveKey( void\***  `key`  **);**|  
|[CMapPtrToWord](../vs140/cmapptrtoword-class.md)|**BOOL RemoveKey( void\***  `key`  **);**|  
|[CMapStringToPtr](../vs140/cmapstringtoptr-class.md)|**BOOL RemoveKey( LPCTSTR**  `key`  **);**|  
|[CMapStringToString](../vs140/cmapstringtostring-class.md)|**BOOL RemoveKey( LPCTSTR**  `key`  **);**|  
|[CMapWordToOb](../vs140/cmapwordtoob-class.md)|**BOOL RemoveKey( WORD**  `key`  **);**|  
|[CMapWordToPtr](../vs140/cmapwordtoptr-class.md)|**BOOL RemoveKey( WORD**  `key`  **);**|  
  
## Example  
 See [CObList::CObList](../vs140/coblist--coblist.md) for a listing of the `CAge` class used in all collection examples.  
  
 [!code[NVC_MFCCollections#70](../vs140/codesnippet/CPP/cmapstringtoob--removekey_1.cpp)]  
  
 The results from this program are as follows:  
  
 `RemoveKey example: A CMapStringToOb with 3 elements`  
  
 `[Marge] = a CAge at $49A0 35`  
  
 `[Homer] = a CAge at $495E 36`  
  
 `[Bart] = a CAge at $4634 13`  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CMapStringToOb Class](../vs140/cmapstringtoob-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMapStringToOb::RemoveAll](../vs140/cmapstringtoob--removeall.md)