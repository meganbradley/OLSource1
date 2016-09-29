---
title: "CComUnkArray::begin"
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
  - "CComUnkArray<nMaxSize>.begin"
  - "ATL.CComUnkArray.begin"
  - "ATL.CComUnkArray<nMaxSize>.begin"
  - "CComUnkArray<1>::begin"
  - "CComUnkArray<nMaxSize>::begin"
  - "CComUnkArray<1>.begin"
  - "ATL.CComUnkArray<1>.begin"
  - "ATL::CComUnkArray<nMaxSize>::begin"
  - "CComUnkArray::begin"
  - "ATL::CComUnkArray<1>::begin"
  - "ATL::CComUnkArray::begin"
  - "CComUnkArray.begin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "begin method"
ms.assetid: 0e184f0f-5306-436a-9de4-f99b5170f927
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComUnkArray::begin
Returns a pointer to the beginning of the collection of **IUnknown** interface pointers.  
  
## Syntax  
  
```  
  
IUnknown** begin( );  
```  
  
## Return Value  
 A pointer to an **IUnknown** interface pointer.  
  
## Remarks  
 The collection contains pointers to interfaces stored locally as **IUnknown**. You cast each **IUnknown** interface to the real interface type and then call through it. You do not need to query for the interface first.  
  
 Before using the **IUnknown** interface, you should check that it is not **NULL**.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComUnkArray Class](../vs140/ccomunkarray-class.md)   
 [CComUnkArray::end](../vs140/ccomunkarray--end.md)   
 [CComDynamicUnkArray::begin](../vs140/ccomdynamicunkarray--begin.md)