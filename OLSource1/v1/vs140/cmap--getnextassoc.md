---
title: "CMap::GetNextAssoc"
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
  - "CMap::GetNextAssoc"
  - "CMap.GetNextAssoc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMap class, operations"
  - "GetNextAssoc method"
ms.assetid: c5574410-587f-4c31-8c37-6b51a5616c56
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMap::GetNextAssoc
Retrieves the map element at <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, then updates <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to refer to the next element in the map.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies a reference to a **POSITION** value returned by a previous <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> call.  
  
 *KEY*  
 Template parameter specifying the type of the map's key.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Specifies the returned key of the retrieved element.  
  
 *VALUE*  
 Template parameter specifying the type of the map's value.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Specifies the returned value of the retrieved element.  
  
## Remarks  
 This function is most useful for iterating through all the elements in the map. Note that the position sequence is not necessarily the same as the key value sequence.  
  
 If the retrieved element is the last in the map, then the new value of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is set to **NULL**.  
  
## Example  
 See the example for [CMap::SetAt](../vs140/cmap--setat.md).  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CMap Class](../vs140/cmap-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMap::GetStartPosition](../vs140/cmap--getstartposition.md)