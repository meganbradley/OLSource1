---
title: "CAtlException::CAtlException"
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
  - CAtlException.CAtlException
  - ATL.CAtlException.CAtlException
  - ATL::CAtlException::CAtlException
  - CAtlException::CAtlException
dev_langs: 
  - C++
helpviewer_keywords: 
  - CAtlException constructor
  - CAtlException class, constructor
ms.assetid: f40fe36b-722f-4e8b-bdbc-f9a3a991ff24
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAtlException::CAtlException
The constructor.  
  
## Syntax  
  
```  
  
      CAtlException(  
   HRESULT hr   
) throw( );  
CAtlException( ) throw( );  
```  
  
#### Parameters  
 `hr`  
 The `HRESULT` error code.  
  
## Requirements  
 **Header:** atlexcept.h  
  
## See Also  
 [CAtlException Class](../vs140/catlexception-class.md)   
 [AtlThrow](../vs140/atlthrow.md)