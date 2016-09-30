---
title: "CMapStringToOb::Lookup"
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
  - "CMapStringToOb.Lookup"
  - "CMapStringToOb::Lookup"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Lookup method"
  - "CMapStringToOb class, operations"
ms.assetid: 3982769d-4d5f-413e-b27b-2075fd3593b1
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMapStringToOb::Lookup
Returns a `CObject` pointer based on a `CString` value.  
  
## Syntax  
  
```  
  
      BOOL Lookup(  
   LPCTSTR key,  
   CObject*& rValue   
) const;  
```  
  
#### Parameters  
 `key`  
 Specifies the string key that identifies the element to be looked up.  
  
 `rValue`  
 Specifies the returned value from the looked-up element.  
  
## Return Value  
 Nonzero if the element was found; otherwise 0.  
  
## Remarks  
 `Lookup` uses a hashing algorithm to quickly find the map element with a key that matches exactly (`CString` value).  
  
 The following table shows other member functions that are similar to `CMapStringToOb::LookUp`.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CMapPtrToPtr](../vs140/cmapptrtoptr-class.md)|**BOOL Lookup( void\***  `key` **, void\*&**  `rValue`  **) const;**|  
|[CMapPtrToWord](../vs140/cmapptrtoword-class.md)|**BOOL Lookup( void\***  `key` **, WORD&**  `rValue`  **) const;**|  
|[CMapStringToPtr](../vs140/cmapstringtoptr-class.md)|**BOOL Lookup( LPCTSTR**  `key` **, void\*&**  `rValue`  **) const;**|  
|[CMapStringToString](../vs140/cmapstringtostring-class.md)|**BOOL Lookup( LPCTSTR**  `key` **, CString&**  `rValue`  **) const;**|  
|[CMapWordToOb](../vs140/cmapwordtoob-class.md)|**BOOL Lookup( WORD**  `key` **, CObject\*&**  `rValue`  **) const;**|  
|[CMapWordToPtr](../vs140/cmapwordtoptr-class.md)|**BOOL Lookup( WORD**  `key` **, void\*&**  `rValue`  **) const;**|  
  
## Example  
 See [CObList::CObList](../vs140/coblist--coblist.md) for a listing of the `CAge` class used in all collection examples.  
  
 [!code[NVC_MFCCollections#68](../vs140/codesnippet/CPP/cmapstringtoob--lookup_1.cpp)]  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CMapStringToOb Class](../vs140/cmapstringtoob-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMapStringToOb::operator](../vs140/cmapstringtoob--operator.md)