---
title: "IEnumOnSTLImpl::Skip"
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
  - "ATL.IEnumOnSTLImpl.Skip"
  - "Skip"
  - "IEnumOnSTLImpl.Skip"
  - "ATL::IEnumOnSTLImpl::Skip"
  - "IEnumOnSTLImpl::Skip"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Skip method"
ms.assetid: 497fb05d-9940-487a-8c89-9c7d4158d1ef
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IEnumOnSTLImpl::Skip
This method provides the implementation of the [IEnumXXXX::Skip](https://msdn.microsoft.com/en-us/library/ms690392.aspx) method.  
  
## Syntax  
  
```  
  
      STDMETHOD(Skip)(  
   ULONG celt   
);  
```  
  
#### Parameters  
 `celt`  
 [in] The number of elements to skip.  
  
## Return Value  
 A standard `HRESULT` value.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [IEnumOnSTLImpl Class](../vs140/ienumonstlimpl-class.md)