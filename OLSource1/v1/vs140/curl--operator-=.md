---
title: "CUrl::operator ="
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
  - CUrl::operator=
  - ATL.CUrl.operator=
  - ATL::CUrl::operator=
  - CUrl.operator=
dev_langs: 
  - C++
helpviewer_keywords: 
  - = operator, with specific ATL Server objects
  - operator=, URLs
  - operator =, URLs
ms.assetid: ed70f55d-7519-452c-a986-f8b7c5515dd6
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CUrl::operator =
Assigns the specified `CUrl` object to the current `CUrl` object.  
  
## Syntax  
  
```  
  
      CUrl & operator =(  
   const CUrl & urlThat   
) throw();  
```  
  
#### Parameters  
 `urlThat`  
 The `CUrl` object to copy into the current object.  
  
## Return Value  
 Returns a reference to the current object.  
  
## Requirements  
 **Header:** atlutil.h  
  
## See Also  
 [CUrl Class](../vs140/curl-class.md)