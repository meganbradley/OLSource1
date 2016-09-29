---
title: "CMapStringToOb::HashKey"
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
  - "CMapStringToOb::HashKey"
  - "CMapStringToOb.HashKey"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HashKey method"
  - "CMapStringToOb class, operations"
ms.assetid: 3c2673ab-3abd-4d12-a72d-20c2cbc7d4d0
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMapStringToOb::HashKey
Calculates the hash value of a specified key.  
  
## Syntax  
  
```  
  
      UINT HashKey(  
   LPCTSTR key  
) const;  
```  
  
#### Parameters  
 `key`  
 The key whose hash value is to be calculated.  
  
## Return Value  
 The Key's hash value  
  
## Remarks  
 The following table shows other member functions that are similar to `CMapStringToOb::HashKey`.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CMapPtrToPtr](../vs140/cmapptrtoptr-class.md)|**UINT HashKey( void\***  `key`  **) const;**|  
|[CMapPtrToWord](../vs140/cmapptrtoword-class.md)|**UINT HashKey( void\***  `key`  **) const;**|  
|[CMapStringToString](../vs140/cmapstringtostring-class.md)|**UINT HashKey( LPCTSTR**  `key`  **) const;**|  
|[CMapStringToPtr](../vs140/cmapstringtoptr-class.md)|**UINT HashKey( LPCTSTR**  `key`  **) const;**|  
|[CMapWordToOb](../vs140/cmapwordtoob-class.md)|**UINT HashKey( WORD**  `key`  **) const;**|  
|[CMapWordToPtr](../vs140/cmapwordtoptr-class.md)|**UINT HashKey( WORD**  `key`  **) const;**|  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CMapStringToOb Class](../vs140/cmapstringtoob-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)