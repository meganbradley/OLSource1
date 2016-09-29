---
title: "CPathT::IsUNCServerShare"
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
  - "CPathT<StringType>::IsUNCServerShare"
  - "IsUNCServerShare"
  - "ATL::CPathT::IsUNCServerShare"
  - "ATL.CPathT.IsUNCServerShare"
  - "ATL.CPathT<StringType>.IsUNCServerShare"
  - "CPathT::IsUNCServerShare"
  - "CPathT.IsUNCServerShare"
  - "ATL::CPathT<StringType>::IsUNCServerShare"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsUNCServerShare method"
ms.assetid: 7b258b2e-13d7-4266-a62c-301be3fede9a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPathT::IsUNCServerShare
Call this method to determine whether the path is a valid UNC (universal naming convention) share path, \\\\*server*\\*share*.  
  
## Syntax  
  
```  
  
BOOL IsUNCServerShare( ) const;  
  
```  
  
## Return Value  
 Returns TRUE if the path is in the form \\\\*server*\\*share*, or FALSE otherwise.  
  
## Remarks  
 For more information, see [PathIsUNCServerShare](http://msdn.microsoft.com/library/windows/desktop/bb773723).  
  
## Requirements  
 **Header:** atlpath.h  
  
## See Also  
 [CPathT Class](../vs140/cpatht-class.md)   
 [CPathT::IsUNCServer](../vs140/cpatht--isuncserver.md)