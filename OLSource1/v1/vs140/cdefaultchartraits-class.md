---
title: "CDefaultCharTraits Class"
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
  - "CDefaultCharTraits"
  - "ATL::CDefaultCharTraits<T>"
  - "ATL.CDefaultCharTraits"
  - "ATL.CDefaultCharTraits<T>"
  - "ATL::CDefaultCharTraits"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDefaultCharTraits class"
ms.assetid: f94a3934-597f-401d-8513-ed6924ae069a
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDefaultCharTraits Class
This class provides two static functions for converting characters between uppercase and lowercase.  
  
## Syntax  
  
```  
  
template <  
      typename  T>  
   class CDefaultCharTraits  
  
```  
  
#### Parameters  
 `T`  
 The type of data to be stored in the collection.  
  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CDefaultCharTraits::CharToLower](../vs140/cdefaultchartraits--chartolower.md)|(Static) Call this function to convert a character to uppercase.|  
|[CDefaultCharTraits::CharToUpper](../vs140/cdefaultchartraits--chartoupper.md)|(Static) Call this function to convert a character to lowercase.|  
  
## Remarks  
 This class provides functions that are utilized by the class [CStringElementTraitsI](../vs140/cstringelementtraitsi-class.md).  
  
## Requirements  
 **Header:** atlcoll.h  
  
##  \<a name="cdefaultchartraits__chartolower"></a>  CDefaultCharTraits::CharToLower  
 Call this function to convert a character to lowercase.  
  
```  
  
static wchar_t CharToLower(  
      wchar_t  x  
   );  
   static char CharToLower(  
      char  x  
   );  
  
```  
  
### Parameters  
 *x*  
 The character to convert to lowercase.  
  
### Example  
 [!code[NVC_ATL_Utilities#132](../vs140/codesnippet/CPP/cdefaultchartraits-class_1.cpp)]  
  
##  \<a name="cdefaultchartraits__chartoupper"></a>  CDefaultCharTraits::CharToUpper  
 Call this function to convert a character to uppercase.  
  
```  
  
static wchar_t CharToUpper(  
      wchar_t  x  
   );  
   static char CharToUpper(  
      char  x  
   );  
  
```  
  
### Parameters  
 *x*  
 The character to convert to uppercase.  
  
## See Also  
 [Class Overview](../vs140/atl-class-overview.md)