---
title: "IProvideClassInfo2Impl::_tih"
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
  - "_tih"
  - "IProvideClassInfo2Impl::_tih"
  - "IProvideClassInfo2Impl._tih"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "_tih method"
  - "tih method"
ms.assetid: e350706e-4edb-4f09-a846-1dabbd41665c
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IProvideClassInfo2Impl::_tih
This static data member is an instance of the class template parameter, `tihclass`, which by default is `CComTypeInfoHolder`.  
  
## Syntax  
  
```  
  
static   
tihclass  
 _tih;  
  
```  
  
## Remarks  
 `_tih` manages the type information for the coclass.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [IProvideClassInfo2Impl Class](../VS_csharp/iprovideclassinfo2impl-class.md)