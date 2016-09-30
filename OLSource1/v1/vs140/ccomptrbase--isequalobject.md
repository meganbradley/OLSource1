---
title: "CComPtrBase::IsEqualObject"
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
  - "ATL.CComPtrBase.IsEqualObject"
  - "CComPtrBase.IsEqualObject"
  - "ATL.CComPtrBase<T>.IsEqualObject"
  - "IsEqualObject"
  - "CComPtrBase::IsEqualObject"
  - "CComPtrBase<T>::IsEqualObject"
  - "ATL::CComPtrBase::IsEqualObject"
  - "ATL::CComPtrBase<T>::IsEqualObject"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsEqualObject method"
ms.assetid: 77c77285-13dc-45e8-a8d9-2dc482553199
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComPtrBase::IsEqualObject
Call this method to check if the specified **IUnknown** points to the same object associated with the `CComPtrBase` object.  
  
## Syntax  
  
```  
  
      bool IsEqualObject(  
   IUnknown* pOther   
) throw( );  
```  
  
#### Parameters  
 `pOther`  
 The **IUnknown \*** to compare.  
  
## Return Value  
 Returns true if the objects are identical, false otherwise.  
  
## Requirements  
 **Header:** atlcomcli.h  
  
## See Also  
 [CComPtrBase Class](../vs140/ccomptrbase-class.md)