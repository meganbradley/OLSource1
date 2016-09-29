---
title: "Implements::CanCastTo Method"
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
  - "implements/Microsoft::WRL::Implements::CanCastTo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CanCastTo method"
ms.assetid: a8e85c7d-4dcd-446d-bebc-a97da46ce44a
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Implements::CanCastTo Method
Gets a pointer to the specified interface.  
  
## Syntax  
  
```  
__forceinline HRESULT CanCastTo(  
   REFIID riid,  
   _Deref_out_ void **ppv  
);  
```  
  
#### Parameters  
 `riid`  
 A reference to an interface ID.  
  
 `ppv`  
 If successful, a pointer to the interface specified by `riid`.  
  
## Return Value  
 S_OK if successful; otherwise, an HRESULT that indicates the error, such as E_NOINTERFACE.  
  
## Remarks  
 This is an internal helper function that performs a QueryInterface operation.  
  
## Requirements  
 **Header:** implements.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [Implements Structure](../VS_csharp/implements-structure.md)