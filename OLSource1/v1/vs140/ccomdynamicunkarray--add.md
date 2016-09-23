---
title: "CComDynamicUnkArray::Add"
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
  - CComDynamicUnkArray.Add
  - ATL.CComDynamicUnkArray.Add
  - CComDynamicUnkArray::Add
  - ATL::CComDynamicUnkArray::Add
dev_langs: 
  - C++
helpviewer_keywords: 
  - Add method [ATL]
ms.assetid: 29fc9e5e-ba08-4a91-9b84-b6877467a689
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CComDynamicUnkArray::Add
Call this method to add an **IUnknown** pointer to the array.  
  
## Syntax  
  
```  
  
      DWORD Add(  
   IUnknown* pUnk   
);  
```  
  
#### Parameters  
 *pUnk*  
 The **IUnknown** pointer to add to the array.  
  
## Return Value  
 Returns the cookie associated with the newly added pointer.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComDynamicUnkArray Class](../vs140/ccomdynamicunkarray-class.md)   
 [CComDynamicUnkArray::Remove](../vs140/ccomdynamicunkarray--remove.md)