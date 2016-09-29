---
title: "ComPtr::ReleaseAndGetAddressOf Method"
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
  - "client/Microsoft::WRL::ComPtr::ReleaseAndGetAddressOf"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ReleaseAndGetAddressOf method"
ms.assetid: 3751dcb4-d50e-432c-89e4-e736be34d434
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ComPtr::ReleaseAndGetAddressOf Method
Releases the interface associated with this ComPtr and then retrieves the address of the [ptr_](../VS_csharp/comptr--ptr_-data-member.md) data member, which contains a pointer to the interface that was released.  
  
## Syntax  
  
```  
T** ReleaseAndGetAddressOf();  
```  
  
## Return Value  
 The address of the [ptr_](../VS_csharp/comptr--ptr_-data-member.md) data member of this ComPtr.  
  
## Requirements  
 **Header:** client.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [ComPtr Class](../VS_csharp/comptr-class.md)   
 [ComPtr::ptr_ Data Member](../VS_csharp/comptr--ptr_-data-member.md)