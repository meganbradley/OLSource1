---
title: "CMapStringToString::PGetFirstAssoc"
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
  - "CMapStringToString.PGetFirstAssoc"
  - "CMapStringToString::PGetFirstAssoc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PGetFirstAssoc method"
  - "CMapStringToString class, operations"
ms.assetid: e2658177-5858-42e9-b0c6-10fc580716b2
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMapStringToString::PGetFirstAssoc
Returns the first entry of the map object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A pointer to the first entry in the map; see [CMapStringToString::CPair](../vs140/cmapstringtostring--cpair.md). If the map is empty, the value is <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Remarks  
 Call this function to return a pointer the first element in the map object.  
  
## Example  
 [!code[NVC_MFCCollections#73](../vs140/codesnippet/CPP/cmapstringtostring--pgetfirstassoc_1.cpp)]  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CMapStringToString Class](../vs140/cmapstringtostring-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMapStringToString::PGetNextAssoc](../vs140/cmapstringtostring--pgetnextassoc.md)   
 [CMapStringToString::PLookup](../vs140/cmapstringtostring--plookup.md)