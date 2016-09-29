---
title: "CFileTime::operator !="
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
  - "ATL.CFileTime.operator!="
  - "ATL::CFileTime::operator!="
  - "CFileTime.operator!="
  - "CFileTime::operator!="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator !=, file time"
  - "!= operator"
  - "operator!=, file time"
ms.assetid: a30b9071-e050-415d-a41a-ba5c0b7f13f8
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFileTime::operator !=
This operator compares two `CFileTime` objects for inequality.  
  
## Syntax  
  
```  
  
      bool operator!=(  
   CFileTime ft   
) const throw( );  
```  
  
#### Parameters  
 `ft`  
 The `CFileTime` object to be compared.  
  
## Return Value  
 Returns **true** if the item being compared is not equal to the `CFileTime` object, otherwise **false**.  
  
## Requirements  
 **Header:** atltime.h  
  
## See Also  
 [CFileTime Class](../vs140/cfiletime-class.md)