---
title: "CSecurityDesc::CSecurityDesc"
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
  - "ATL.CSecurityDesc.CSecurityDesc"
  - "CSecurityDesc::CSecurityDesc"
  - "ATL::CSecurityDesc::CSecurityDesc"
  - "CSecurityDesc.CSecurityDesc"
  - "CSecurityDesc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CSecurityDesc class, constructor"
  - "CSecurityDesc constructor"
ms.assetid: 4faa4b33-9667-4173-b5f4-ddb1fa7684a3
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSecurityDesc::CSecurityDesc
The constructor.  
  
## Syntax  
  
```  
  
      CSecurityDesc( ) throw( );   
CSecurityDesc(  
   const CSecurityDesc & rhs   
) throw(...);  
CSecurityDesc(  
   const SECURITY_DESCRIPTOR & rhs   
) throw(...);  
```  
  
#### Parameters  
 `rhs`  
 The `CSecurityDesc` object or **SECURITY_DESCRIPTOR** structure to assign to the new `CSecurityDesc` object.  
  
## Remarks  
 The `CSecurityDesc` object can optionally be created using a **SECURITY_DESCRIPTOR** structure or a previously defined `CSecurityDesc` object.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CSecurityDesc Class](../vs140/csecuritydesc-class.md)   
 [CSecurityDesc::~CSecurityDesc](../vs140/csecuritydesc--~csecuritydesc.md)   
 [SECURITY_DESCRIPTOR](http://msdn.microsoft.com/library/windows/desktop/aa379561)