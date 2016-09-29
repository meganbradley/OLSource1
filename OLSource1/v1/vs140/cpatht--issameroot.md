---
title: "CPathT::IsSameRoot"
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
  - "ATL.CPathT<StringType>.IsSameRoot"
  - "ATL.CPathT.IsSameRoot"
  - "ATL::CPathT::IsSameRoot"
  - "CPathT<StringType>::IsSameRoot"
  - "IsSameRoot"
  - "CPathT<StringType>.IsSameRoot"
  - "CPathT::IsSameRoot"
  - "CPathT.IsSameRoot"
  - "ATL::CPathT<StringType>::IsSameRoot"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsSameRoot method"
ms.assetid: 28673f80-5d65-4b1d-93ca-e1642bcac837
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPathT::IsSameRoot
Call this method to determine whether another path has a common root component with the current path.  
  
## Syntax  
  
```  
  
      BOOL IsSameRoot(  
   PCXSTR pszOther   
) const;  
```  
  
#### Parameters  
 `pszOther`  
 The other path.  
  
## Return Value  
 Returns TRUE if both strings have the same root component, or FALSE otherwise.  
  
## Remarks  
 For more information, see [PathIsSameRoot](http://msdn.microsoft.com/library/windows/desktop/bb773687).  
  
## Requirements  
 **Header:** atlpath.h  
  
## See Also  
 [CPathT Class](../vs140/cpatht-class.md)