---
title: "CRBMap::RemoveKey"
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
  - "ATL.CRBMap.RemoveKey"
  - "CRBMap.RemoveKey"
  - "ATL::CRBMap::RemoveKey"
  - "CRBMap::RemoveKey"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RemoveKey method"
ms.assetid: 1cdc2f65-541a-4d54-a2b6-873df1f815aa
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRBMap::RemoveKey
Call this method to remove an element from the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object, given the key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The key corresponding to the element pair you want to remove.  
  
## Return Value  
 Returns true if the key is found and removed, false on failure.  
  
## Remarks  
 See the documentation for the base class [CRBTree](../vs140/crbtree-class.md) for information on the other methods available.  
  
## Example  
 [!code[NVC_ATL_Utilities#83](../vs140/codesnippet/CPP/crbmap--removekey_1.cpp)]  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CRBMap Class](../vs140/crbmap-class.md)   
 [CRBMap::SetAt](../vs140/crbmap--setat.md)