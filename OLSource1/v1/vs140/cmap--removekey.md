---
title: "CMap::RemoveKey"
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
  - "CMap.RemoveKey"
  - "CMap::RemoveKey"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMap class, operations"
  - "RemoveKey method"
ms.assetid: e18362f0-28de-4ab1-bf52-9039e6cbdb68
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMap::RemoveKey
Looks up the map entry corresponding to the supplied key; then, if the key is found, removes the entry.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Template parameter specifying the type of the key.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Key for the element to be removed.  
  
## Return Value  
 Nonzero if the entry was found and successfully removed; otherwise 0.  
  
## Remarks  
 The **DestructElements** helper function is used to remove the entry.  
  
## Example  
 See the example for [CMap::SetAt](../vs140/cmap--setat.md).  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CMap Class](../vs140/cmap-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMap::RemoveAll](../vs140/cmap--removeall.md)