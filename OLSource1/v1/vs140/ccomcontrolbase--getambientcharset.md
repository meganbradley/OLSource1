---
title: "CComControlBase::GetAmbientCharSet"
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
  - "GetAmbientCharSet"
  - "ATL.CComControlBase.GetAmbientCharSet"
  - "CComControlBase.GetAmbientCharSet"
  - "ATL::CComControlBase::GetAmbientCharSet"
  - "CComControlBase::GetAmbientCharSet"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetAmbientCharSet method"
  - "DISPID_AMBIENT_CHARSET property"
ms.assetid: 2be3c8a5-6387-4196-ae8d-e66a74c03867
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComControlBase::GetAmbientCharSet
Retrieves **DISPID_AMBIENT_CHARSET**, the ambient character set for all controls, defined by the container.  
  
## Syntax  
  
```  
  
      HRESULT GetAmbientCharSet(  
   BSTR& bstrCharSet   
);  
```  
  
#### Parameters  
 *bstrCharSet*  
 The property **DISPID_AMBIENT_CHARSET**.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CComControlBase Class](../vs140/ccomcontrolbase-class.md)