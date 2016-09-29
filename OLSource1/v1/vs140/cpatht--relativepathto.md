---
title: "CPathT::RelativePathTo"
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
  - "ATL.CPathT.RelativePathTo"
  - "ATL::CPathT<StringType>::RelativePathTo"
  - "ATL.CPathT<StringType>.RelativePathTo"
  - "CPathT::RelativePathTo"
  - "ATL::CPathT::RelativePathTo"
  - "CPathT<StringType>::RelativePathTo"
  - "RelativePathTo"
  - "CPathT.RelativePathTo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RelativePathTo method"
ms.assetid: e58852c8-077c-4f27-ab01-3dd26e9a4224
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPathT::RelativePathTo
Call this method to create a relative path from one file or folder to another.  
  
## Syntax  
  
```  
  
      BOOL RelativePathTo(  
   PCXSTR pszFrom,  
   DWORD dwAttrFrom,  
   PCXSTR pszTo,  
   DWORD dwAttrTo   
);  
```  
  
#### Parameters  
 `pszFrom`  
 The start of the relative path.  
  
 *dwAttrFrom*  
 The File attributes of `pszFrom`. If this value contains FILE_ATTRIBUTE_DIRECTORY, `pszFrom` is assumed to be a directory; otherwise, `pszFrom` is assumed to be a file.  
  
 `pszTo`  
 The end point of the relative path.  
  
 *dwAttrTo*  
 The File attributes of `pszTo`. If this value contains FILE_ATTRIBUTE_DIRECTORY, `pszTo` is assumed to be a directory; otherwise, `pszTo` is assumed to be a file.  
  
## Return Value  
 Returns TRUE on success, FALSE on failure.  
  
## Remarks  
 For more information, see [PathRelativePathTo](http://msdn.microsoft.com/library/windows/desktop/bb773740).  
  
## Requirements  
 **Header:** atlpath.h  
  
## See Also  
 [CPathT Class](../vs140/cpatht-class.md)