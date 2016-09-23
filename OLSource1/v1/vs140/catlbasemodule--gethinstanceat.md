---
title: "CAtlBaseModule::GetHInstanceAt"
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
  - CAtlBaseModule.GetHInstanceAt
  - ATL.CAtlBaseModule.GetHInstanceAt
  - GetHInstanceAt
  - ATL::CAtlBaseModule::GetHInstanceAt
  - CAtlBaseModule::GetHInstanceAt
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetHInstanceAt method
ms.assetid: 2a490c2f-91b1-4849-97bc-5d652316707c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAtlBaseModule::GetHInstanceAt
Returns a handle to a specified resource instance.  
  
## Syntax  
  
```  
  
      HINSTANCE GetHInstanceAt(  
   int i  
) throw( );  
```  
  
#### Parameters  
 *i*  
 The number of the resource instance.  
  
## Return Value  
 Returns the handle to the resource instance, or NULL if no corresponding resource instance exists.  
  
## Requirements  
 **Header:** atlcore.h  
  
## See Also  
 [CAtlBaseModule Class](../vs140/catlbasemodule-class.md)   
 [CAtlBaseModule::AddResourceInstance](../vs140/catlbasemodule--addresourceinstance.md)