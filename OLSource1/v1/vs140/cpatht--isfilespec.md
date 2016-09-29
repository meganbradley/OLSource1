---
title: "CPathT::IsFileSpec"
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
  - "CPathT::IsFileSpec"
  - "CPathT.IsFileSpec"
  - "CPathT<StringType>::IsFileSpec"
  - "ATL::CPathT<StringType>::IsFileSpec"
  - "IsFileSpec"
  - "CPathT<StringType>.IsFileSpec"
  - "ATL.CPathT.IsFileSpec"
  - "ATL::CPathT::IsFileSpec"
  - "ATL.CPathT<StringType>.IsFileSpec"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsFileSpec method"
ms.assetid: 37f9df76-3dd4-4ef0-aa33-9eb13bbe6d8d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPathT::IsFileSpec
Call this method to search a path for any path-delimiting characters (for example, ':' or '\\' ). If there are no path-delimiting characters present, the path is considered to be a File Spec path.  
  
## Syntax  
  
```  
  
BOOL IsFileSpec( ) const;  
  
```  
  
## Return Value  
 Returns TRUE if there are no path-delimiting characters within the path, or FALSE if there are path-delimiting characters.  
  
## Remarks  
 For more information, see [PathIsFileSpec](http://msdn.microsoft.com/library/windows/desktop/bb773627).  
  
## Requirements  
 **Header:** atlpath.h  
  
## See Also  
 [CPathT Class](../vs140/cpatht-class.md)