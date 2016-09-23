---
title: "CFileTimeSpan::CFileTimeSpan"
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
  - CFileTimeSpan
  - ATL::CFileTimeSpan::CFileTimeSpan
  - ATL.CFileTimeSpan.CFileTimeSpan
  - CFileTimeSpan::CFileTimeSpan
  - CFileTimeSpan.CFileTimeSpan
dev_langs: 
  - C++
helpviewer_keywords: 
  - CFileTimeSpan class, constructor
ms.assetid: af7c9870-d758-4195-99fc-8c0c345ea7be
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CFileTimeSpan::CFileTimeSpan
The constructor.  
  
## Syntax  
  
```  
  
      CFileTimeSpan( ) throw( );   
CFileTimeSpan(  
   const CFileTimeSpan& span   
) throw( );  
CFileTimeSpan(  
   LONGLONG nSpan   
) throw( );  
```  
  
#### Parameters  
 `span`  
 An existing `CFileTimeSpan` object.  
  
 `nSpan`  
 A period of time in milliseconds.  
  
## Remarks  
 The `CFileTimeSpan` object can be created using an existing `CFileTimeSpan` object, or expressed as a 64-bit value. The default constructor sets the time span to 0.  
  
## Requirements  
 **Header:** atltime.h  
  
## See Also  
 [CFileTimeSpan Class](../vs140/cfiletimespan-class.md)