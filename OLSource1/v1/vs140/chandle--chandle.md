---
title: "CHandle::CHandle"
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
  - "CHandle.CHandle"
  - "CHandle::CHandle"
  - "ATL::CHandle::CHandle"
  - "ATL.CHandle.CHandle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CHandle class, constructor"
  - "CHandle constructor"
ms.assetid: 5332e35e-0265-4e9e-a0a6-5bf7d5f12ce8
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHandle::CHandle
The constructor.  
  
## Syntax  
  
```  
  
      CHandle( ) throw( );   
CHandle(  
   CHandle& h   
) throw( );  
explicit CHandle(  
   HANDLE h   
) throw( );  
```  
  
#### Parameters  
 `h`  
 An existing handle or `CHandle`.  
  
## Remarks  
 Creates a new `CHandle` object, optionally using an existing handle or `CHandle` object.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CHandle Class](../vs140/chandle-class.md)   
 [CHandle::Attach](../vs140/chandle--attach.md)