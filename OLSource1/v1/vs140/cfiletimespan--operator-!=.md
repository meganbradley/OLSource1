---
title: "CFileTimeSpan::operator !="
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CFileTimeSpan.operator!=
  - ATL::CFileTimeSpan::operator!=
  - ATL.CFileTimeSpan.operator!=
  - CFileTimeSpan::operator!=
dev_langs: 
  - C++
helpviewer_keywords: 
  - operator !=, file time
  - != operator
  - operator!=, file time
ms.assetid: 07687ab7-4118-431d-8e7e-794930665744
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CFileTimeSpan::operator !=
Compares two `CFileTimeSpan` objects for inequality.  
  
## Syntax  
  
```  
  
      bool operator!=(  
   CFileTimeSpan span   
) const throw( );  
```  
  
#### Parameters  
 `span`  
 The `CFileTimeSpan` object to be compared.  
  
## Return Value  
 Returns **true** if the item being compared is not equal to the `CFileTimeSpan` object; otherwise **false**.  
  
## Requirements  
 **Header:** atltime.h  
  
## See Also  
 [CFileTimeSpan Class](../vs140/cfiletimespan-class.md)