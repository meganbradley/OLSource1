---
title: "CTypedPtrMap::GetNextAssoc"
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
  - "CTypedPtrMap.GetNextAssoc"
  - "CTypedPtrMap::GetNextAssoc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetNextAssoc method"
ms.assetid: 96652cce-12a4-4c18-98cd-093c1bb10c0e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTypedPtrMap::GetNextAssoc
Retrieves the map element at <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, then updates <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to refer to the next element in the map.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies a reference to a **POSITION** value returned by a previous <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>**::GetStartPosition** call.  
  
 *KEY*  
 Template parameter specifying the type of the map's keys.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Specifies the returned key of the retrieved element.  
  
 *VALUE*  
 Template parameter specifying the type of the map's values.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Specifies the returned value of the retrieved element.  
  
## Remarks  
 This function is most useful for iterating through all the elements in the map. Note that the position sequence is not necessarily the same as the key value sequence.  
  
 If the retrieved element is the last in the map, then the new value of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is set to **NULL**.  
  
 This inline function calls <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>**::GetNextAssoc**.  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CTypedPtrMap Class](../vs140/ctypedptrmap-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMapStringToOb::GetNextAssoc](../vs140/cmapstringtoob--getnextassoc.md)   
 [CMapStringToOb::GetStartPosition](../vs140/cmapstringtoob--getstartposition.md)