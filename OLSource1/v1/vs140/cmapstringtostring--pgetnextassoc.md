---
title: "CMapStringToString::PGetNextAssoc"
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
  - "CMapStringToString.PGetNextAssoc"
  - "CMapStringToString::PGetNextAssoc"
  - "PGetNextAssoc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PGetNextAssoc method"
  - "CMapStringToString class, operations"
ms.assetid: f516fe14-171a-40f5-8296-22987e9f2fa3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMapStringToString::PGetNextAssoc
Retrieves the map element pointed to by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *pAssoc*  
 Points to a map entry returned by a previous [PGetNextAssoc](#vclrfcmapstringtostringpgetnextassoc) or [PGetFirstAssoc](../vs140/cmapstringtostring--pgetfirstassoc.md) call.  
  
## Return Value  
 A pointer to the next entry in the map; see [CMapStringToString::CPair](../vs140/cmapstringtostring--cpair.md). If the element is the last in the map, the value is **NULL**.  
  
## Remarks  
 Call this method to iterate through all the elements in the map. Retrieve the first element with a call to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and then iterate through the map with successive calls to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Example  
 See the example for [CMapStringToString::PGetFirstAssoc](../vs140/cmapstringtostring--pgetfirstassoc.md).  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CMapStringToString Class](../vs140/cmapstringtostring-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMapStringToString::PGetFirstAssoc](../vs140/cmapstringtostring--pgetfirstassoc.md)   
 [CMapStringToString::PLookup](../vs140/cmapstringtostring--plookup.md)