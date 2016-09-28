---
title: "CStringT::Remove"
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
  - "ATL.CStringT.Remove"
  - "CStringT.Remove"
  - "CStringT::Remove"
  - "ATL::CStringT::Remove"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Remove method"
ms.assetid: 6d86d512-ab97-4a31-9953-ef8de5f1cacc
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStringT::Remove
Removes all instances of the specified character from the string.  
  
## Syntax  
  
```  
int Remove(  
   XCHAR chRemove  
);  
```  
  
#### Parameters  
 `chRemove`  
 The character to be removed from a string.  
  
## Return Value  
 The count of characters removed from the string. Zero if the string is not changed.  
  
## Remarks  
 Comparisons for the character are case sensitive.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#129](../vs140/codesnippet/CPP/cstringt--remove_1.cpp)]  
  
## Requirements  
 **Header:** cstringt.h  
  
## See Also  
 [CStringT Class](../vs140/cstringt-class.md)