---
title: "CAccessToken::SetDefaultDacl"
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
  - ATL::CAccessToken::SetDefaultDacl
  - ATL.CAccessToken.SetDefaultDacl
  - CAccessToken::SetDefaultDacl
  - SetDefaultDacl
  - CAccessToken.SetDefaultDacl
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetDefaultDacl method
ms.assetid: a847b188-93d8-4ed0-8cc1-4b9f9c878a5d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAccessToken::SetDefaultDacl
Call this method to set the default DACL of the `CAccessToken` object.  
  
## Syntax  
  
```  
  
      bool SetDefaultDacl(  
   const CDacl& rDacl  
) throw(...);  
```  
  
#### Parameters  
 `rDacl`  
 The new default [CDacl Class](../vs140/cdacl-class.md) information.  
  
## Return Value  
 Returns true on success, false on failure.  
  
## Remarks  
 The default DACL is the DACL that is used by default when new objects are created with this access token in effect.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CAccessToken Class](../vs140/caccesstoken-class.md)   
 [CAccessToken::GetDefaultDacl](../vs140/caccesstoken--getdefaultdacl.md)