---
title: "CDacl::~CDacl"
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
  - "CDacl::~CDacl"
  - "ATL::CDacl::~CDacl"
  - "ATL.CDacl.~CDacl"
  - "CDacl.~CDacl"
  - "~CDacl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "~CDacl destructor"
  - "CDacl class, destructor"
ms.assetid: bde2f775-bc1e-44bc-847b-4dd10344911f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDacl::~CDacl
The destructor.  
  
## Syntax  
  
```  
  
~CDacl ( ) throw( );  
  
```  
  
## Remarks  
 The destructor frees any resources acquired by the object, including all ACEs (access-control entries) using [CDacl::RemoveAllAces](../vs140/cdacl--removeallaces.md).  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CDacl Class](../vs140/cdacl-class.md)   
 [CDacl::CDacl](../vs140/cdacl--cdacl.md)