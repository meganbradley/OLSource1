---
title: "CPathT::CommonPrefix"
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
  - "ATL.CPathT<StringType>.CommonPrefix"
  - "ATL::CPathT::CommonPrefix"
  - "CPathT::CommonPrefix"
  - "CPathT<StringType>::CommonPrefix"
  - "CPathT.CommonPrefix"
  - "CommonPrefix"
  - "ATL.CPathT.CommonPrefix"
  - "ATL::CPathT<StringType>::CommonPrefix"
  - "CPathT<StringType>.CommonPrefix"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CommonPrefix method"
ms.assetid: 676c32c6-1433-411b-9185-8d353e468ba2
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPathT::CommonPrefix
Call this method to determine whether the specified path shares a common prefix with the current path.  
  
## Syntax  
  
```  
  
      CPathT< StringType > CommonPrefix(  
   PCXSTR pszOther   
);  
```  
  
#### Parameters  
 `pszOther`  
 The path to compare to the current one.  
  
## Return Value  
 Returns the common prefix.  
  
## Remarks  
 A prefix is one of these types: "C:\\\\", ".", "..", "..\\\\". For more information, see [PathCommonPrefix](http://msdn.microsoft.com/library/windows/desktop/bb773574).  
  
## Requirements  
 **Header:** atlpath.h  
  
## See Also  
 [CPathT Class](../vs140/cpatht-class.md)