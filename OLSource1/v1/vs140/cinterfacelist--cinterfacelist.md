---
title: "CInterfaceList::CInterfaceList"
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
  - "ATL::CInterfaceList::CInterfaceList"
  - "ATL.CInterfaceList.CInterfaceList"
  - "CInterfaceList"
  - "CInterfaceList::CInterfaceList"
  - "CInterfaceList.CInterfaceList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CInterfaceList constructor"
  - "CInterfaceList class, constructor"
ms.assetid: e6bd874f-0917-4026-a591-72f2c925d25a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CInterfaceList::CInterfaceList
The constructor for the interface list.  
  
## Syntax  
  
```  
  
      CInterfaceList(  
   UINT nBlockSize = 10   
) throw( );  
```  
  
#### Parameters  
 `nBlockSize`  
 The block size, with a default of 10.  
  
## Remarks  
 The block size is a measure of the amount of memory allocated when a new element is required. Larger block sizes reduce calls to memory allocation routines, but use more resources.  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CInterfaceList Class](../vs140/cinterfacelist-class.md)