---
title: "ComPtrRefBase::operator IInspectable** Operator"
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
  - "client/Microsoft::WRL::Details::ComPtrRefBase::operator IInspectable**"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator IInspectable** operator"
ms.assetid: 06ac1051-606c-449b-a566-cac78ca53762
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ComPtrRefBase::operator IInspectable** Operator
Supports the WRL infrastructure and is not intended to be used directly from your code.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Casts the current [ptr_](../vs140/comptrrefbase--ptr_-data-member.md) data member to a pointer-to-a-pointer-to the IInspectable interface.  
  
 An error is emitted if the current ComPtrRefBase doesn't derive from IInspectable.  
  
 This cast is available only if **__WRL_CLASSIC_COM\_\_** is defined.  
  
## Requirements  
 **Header:** client.h  
  
 **Namespace:** Microsoft::WRL::Details  
  
## See Also  
 [ComPtrRefBase Class](../vs140/comptrrefbase-class.md)   
 [Microsoft::WRL::Details Namespace](../vs140/microsoft--wrl--details-namespace.md)