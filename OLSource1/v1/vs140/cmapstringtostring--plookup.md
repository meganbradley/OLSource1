---
title: "CMapStringToString::PLookup"
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
  - "CMapStringToString::PLookup"
  - "CMapStringToString.PLookup"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PLookup method"
  - "CMapStringToString class, operations"
ms.assetid: 2b89bbcb-0d8e-4b60-b31a-4e786cec3f43
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMapStringToString::PLookup
Looks up the value mapped to a given key.  
  
## Syntax  
  
```  
const CPair* PLookup(  
   LPCTSTR key  
) const;  
CPair* PLookup(  
   LPCTSTR key  
);  
```  
  
#### Parameters  
 `key`  
 A pointer to the key for the element to be searched for.  
  
## Return Value  
 A pointer to the specified key.  
  
## Remarks  
 Call this method to search for a map element with a key that exactly matches the given key.  
  
## Example  
 [!code[NVC_MFCCollections#74](../vs140/codesnippet/CPP/cmapstringtostring--plookup_1.cpp)]  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CMapStringToString Class](../vs140/cmapstringtostring-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMapStringToString::PGetNextAssoc](../vs140/cmapstringtostring--pgetnextassoc.md)   
 [CMapStringToString::PGetFirstAssoc](../vs140/cmapstringtostring--pgetfirstassoc.md)