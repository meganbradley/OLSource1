---
title: "CComDynamicUnkArray::begin"
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
  - CComDynamicUnkArray::begin
  - ATL::CComDynamicUnkArray::begin
  - ATL.CComDynamicUnkArray.begin
  - CComDynamicUnkArray.begin
dev_langs: 
  - C++
helpviewer_keywords: 
  - begin method
ms.assetid: 4fa7209c-e582-4999-95d2-5805739ecf4b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CComDynamicUnkArray::begin
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
 [CComDynamicUnkArray Class](../vs140/ccomdynamicunkarray-class.md)   
 [CComDynamicUnkArray::end](../vs140/ccomdynamicunkarray--end.md)   
 [CComUnkArray::begin](../vs140/ccomunkarray--begin.md)