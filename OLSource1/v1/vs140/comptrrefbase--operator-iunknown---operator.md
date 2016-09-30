---
title: "ComPtrRefBase::operator IUnknown** Operator"
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
  - "client/Microsoft::WRL::Details::ComPtrRefBase::operator IUnknown**"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator IUnknown** operator"
ms.assetid: c2950abf-a7aa-480a-ba41-615703e7f931
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ComPtrRefBase::operator IUnknown** Operator
Supports the WRL infrastructure and is not intended to be used directly from your code.  
  
## Syntax  
  
```  
operator IUnknown**() const;  
```  
  
## Remarks  
 Casts the current [ptr_](../vs140/comptrrefbase--ptr_-data-member.md) data member to a pointer-to-a-pointer-to the IUnknown interface.  
  
 An error is emitted if the current ComPtrRefBase doesn't derive from IUnknown.  
  
## Requirements  
 **Header:** client.h  
  
 **Namespace:** Microsoft::WRL::Details  
  
## See Also  
 [ComPtrRefBase Class](../vs140/comptrrefbase-class.md)   
 [Microsoft::WRL::Details Namespace](../vs140/microsoft--wrl--details-namespace.md)