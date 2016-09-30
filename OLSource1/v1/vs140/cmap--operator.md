---
title: "CMap::operator"
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
  - "CMap::operator[]"
  - "CMap.operator[]"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMap class, operators"
  - "operator[], map objects"
  - "operator [], map objects"
  - "[] operator"
ms.assetid: 4f300572-3eff-4ca9-b052-444f7d6699a1
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMap::operator
A convenient substitute for the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> member function.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *VALUE*  
 Template parameter specifying the type of the map value.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Template parameter specifying the type of the key value.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The key used to retrieve the value from the map.  
  
## Remarks  
 Thus it can be used only on the left side of an assignment statement (an l-value). If there is no map element with the specified key, then a new element is created.  
  
 There is no "right side" (r-value) equivalent to this operator because there is a possibility that a key may not be found in the map. Use the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> member function for element retrieval.  
  
## Example  
 See the example for [CMap::Lookup](../vs140/cmap--lookup.md).  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CMap Class](../vs140/cmap-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMap::SetAt](../vs140/cmap--setat.md)   
 [CMap::Lookup](../vs140/cmap--lookup.md)