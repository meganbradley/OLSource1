---
title: "ActivationFactory::GetIids Method"
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
  - module/Microsoft::WRL::ActivationFactory::GetIids
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetIids method
ms.assetid: 0983d709-d155-4d65-aae4-5b2c8bb0fede
caps.latest.revision: 7
translation.priority.ht: 
  - de-de
  - ja-jp
---
# ActivationFactory::GetIids Method
Retrieves an array of implemented interface IDs.  
  
## Syntax  
  
```  
STDMETHOD(  
   GetIids  
)(_Out_ ULONG *iidCount, _Deref_out_ _Deref_post_cap_(*iidCount) IID **iids);  
```  
  
#### Parameters  
 `iidCount`  
 When this operation completes, the number of interace IDs in the `iids` array.  
  
 `iids`  
 When this operation completes, an array of implemented interface IDs.  
  
## Return Value  
 S_OK if successful; otherwise, an HRESULT that describes the failure. E_OUTOFMEMORY is a possible failure HRESULT.  
  
## Requirements  
 **Header:** module.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [ActivationFactory Class](../vs140/activationfactory-class.md)