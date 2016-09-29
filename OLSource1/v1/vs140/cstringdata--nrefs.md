---
title: "CStringData::nRefs"
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
  - "CStringData.nRefs"
  - "CStringData::nRefs"
  - "nRefs"
  - "ATL.CStringData.nRefs"
  - "ATL::CStringData::nRefs"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "nRefs data member"
ms.assetid: e3dd8f55-319d-4c59-9e2a-3187c34c3614
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStringData::nRefs
Reference count of the string data object.  
  
## Syntax  
  
```  
  
long nRefs;  
  
```  
  
## Remarks  
 Stores the reference count of the string data object. This count indicates the number of higher string objects that are associated with the string data object. A negative value indicates that the string data object is currently locked.  
  
## Requirements  
 **Header:** atlsimpstr.h  
  
## See Also  
 [CStringData Class](../vs140/cstringdata-class.md)   
 [CStringData::Lock](../vs140/cstringdata--lock.md)   
 [CStringData::Unlock](../vs140/cstringdata--unlock.md)