---
title: "CStringT::Delete"
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
  - "ATL.CStringT.Delete"
  - "CStringT.Delete"
  - "ATL::CStringT::Delete"
  - "CStringT::Delete"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Delete method"
ms.assetid: f92059aa-1e23-4c0f-994d-d0d38d2b2b16
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStringT::Delete
Deletes a character or characters from a string starting with the character at the given index.  
  
## Syntax  
  
```  
int Delete(  
   int iIndex,  
   int nCount = 1  
);  
```  
  
#### Parameters  
 `iIndex`  
 The zero-based index of the first character in the `CStringT` object to delete.  
  
 `nCount`  
 The number of characters to be removed.  
  
## Return Value  
 The length of the changed string.  
  
## Remarks  
 If `nCount` is longer than the string, the rest of the string will be removed.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#113](../vs140/codesnippet/CPP/cstringt--delete_1.cpp)]  
  
 **Before: Soccer is best, but hockey is quicker!**  
**After: Soccer best, but hockey is quicker!**   
## Requirements  
 **Header:** cstringt.h  
  
## See Also  
 [CStringT Class](../vs140/cstringt-class.md)