---
title: "CMapStringToString::CPair"
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
  - "CMapStringToString.CPair"
  - "CMapStringToString::CPair"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CPair class, data members"
  - "CMapStringToString class, data member"
ms.assetid: ebe8739b-10af-48ae-a36f-188f6315bfd6
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMapStringToString::CPair
Contains a key value and the value of the associated string object.  
  
## Remarks  
 This is a nested structure within class [CMapStringToString](../vs140/cmapstringtostring-class.md).  
  
 The structure is composed of two fields:  
  
-   **key** The actual value of the key type.  
  
-   **value** The value of the associated object.  
  
 It is used to store the return values from [CMapStringToString::PLookup](../vs140/cmapstringtostring--plookup.md), [CMapStringToString::PGetFirstAssoc](../vs140/cmapstringtostring--pgetfirstassoc.md), and [CMapStringToString::PGetNextAssoc](../vs140/cmapstringtostring--pgetnextassoc.md).  
  
## Example  
 For an example of usage, see the example for [CMapStringToString::PLookup](../vs140/cmapstringtostring--plookup.md).  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CMapStringToString Class](../vs140/cmapstringtostring-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)