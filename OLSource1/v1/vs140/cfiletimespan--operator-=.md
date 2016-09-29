---
title: "CFileTimeSpan::operator ="
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
  - "ATL.CFileTimeSpan.operator="
  - "CFileTimeSpan::operator="
  - "ATL::CFileTimeSpan::operator="
  - "CFileTimeSpan.operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "= operator, with specific ATL objects"
  - "operator =, date time"
  - "operator=, date time"
  - "= operator, with specific MFC objects"
ms.assetid: 78b588d7-40c8-4b0f-aef5-fa07c395321b
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFileTimeSpan::operator =
The assignment operator.  
  
## Syntax  
  
```  
  
      CFileTimeSpan& operator =(  
   const CFileTimeSpan& span   
) throw( );  
```  
  
#### Parameters  
 `span`  
 A `CFileTimeSpan` object.  
  
## Return Value  
 Returns the updated `CFileTimeSpan` object.  
  
## Requirements  
 **Header:** atltime.h  
  
## See Also  
 [CFileTimeSpan Class](../vs140/cfiletimespan-class.md)