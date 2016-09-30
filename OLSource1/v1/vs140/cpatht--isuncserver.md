---
title: "CPathT::IsUNCServer"
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
  - "ATL::CPathT<StringType>::IsUNCServer"
  - "CPathT<StringType>.IsUNCServer"
  - "IsUNCServer"
  - "ATL.CPathT<StringType>.IsUNCServer"
  - "CPathT<StringType>::IsUNCServer"
  - "ATL.CPathT.IsUNCServer"
  - "CPathT.IsUNCServer"
  - "CPathT::IsUNCServer"
  - "ATL::CPathT::IsUNCServer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsUNCServer method"
ms.assetid: 23a98449-e28a-4ece-9388-4eb3c5e19dc1
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPathT::IsUNCServer
Call this method to determine whether the path is a valid UNC (universal naming convention) path for a server only.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns TRUE if the string is a valid UNC path for a server only (no share name), or FALSE otherwise.  
  
## Remarks  
 For more information, see [PathIsUNCServer](http://msdn.microsoft.com/library/windows/desktop/bb773722).  
  
## Requirements  
 **Header:** atlpath.h  
  
## See Also  
 [CPathT Class](../vs140/cpatht-class.md)   
 [CPathT::IsUNCServerShare](../vs140/cpatht--isuncservershare.md)