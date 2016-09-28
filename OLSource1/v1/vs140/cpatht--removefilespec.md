---
title: "CPathT::RemoveFileSpec"
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
  - "ATL.CPathT.RemoveFileSpec"
  - "CPathT.RemoveFileSpec"
  - "ATL.CPathT<StringType>.RemoveFileSpec"
  - "ATL::CPathT<StringType>::RemoveFileSpec"
  - "RemoveFileSpec"
  - "CPathT<StringType>::RemoveFileSpec"
  - "ATL::CPathT::RemoveFileSpec"
  - "CPathT::RemoveFileSpec"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RemoveFileSpec method"
ms.assetid: a4a1b669-d465-4261-9964-27ca4d21e9eb
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPathT::RemoveFileSpec
Call this method to remove the trailing file name and backslash from the path, if it has them.  
  
## Syntax  
  
```  
  
BOOL RemoveFileSpec( );  
  
```  
  
## Return Value  
 Returns TRUE on success, FALSE on failure.  
  
## Remarks  
 For more information, see [PathRemoveFileSpec](http://msdn.microsoft.com/library/windows/desktop/bb773748).  
  
## Requirements  
 **Header:** atlpath.h  
  
## See Also  
 [CPathT Class](../vs140/cpatht-class.md)