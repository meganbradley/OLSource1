---
title: "CHandle::operator ="
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
  - "CHandle::operator="
  - "ATL::CHandle::operator="
  - "ATL.CHandle.operator="
  - "CHandle.operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "= operator, with specific ATL objects"
  - "operator =, handle objects"
  - "operator=, handle objects"
ms.assetid: 115b9c5f-cc92-4a09-b4d4-0d4a31406b89
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHandle::operator =
The assignment operator.  
  
## Syntax  
  
```  
  
      CHandle& operator =(   
   CHandle& h    
) throw( );  
```  
  
#### Parameters  
 `h`  
 `CHandle` will take ownership of the handle `h`.  
  
## Return Value  
 Returns a reference to the new `CHandle` object.  
  
## Remarks  
 If the `CHandle` object currently contains a handle, it will be closed. The `CHandle` object being passed in will have its handle reference set to NULL. This ensures that two `CHandle` objects will never contain the same active handle.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CHandle Class](../vs140/chandle-class.md)   
 [CHandle::Attach](../vs140/chandle--attach.md)