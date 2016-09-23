---
title: "HString::Set Method"
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
  - corewrappers/Microsoft::WRL::Wrappers::HString::Set
dev_langs: 
  - C++
ms.assetid: c9b3d613-95c4-48b0-999d-f5baf0804faf
caps.latest.revision: 6
translation.priority.ht: 
  - de-de
  - ja-jp
---
# HString::Set Method
Sets the value of the current HString object to the specified wide-character string or HString parameter.  
  
## Syntax  
  
```  
  
HRESULT Set(  
          const wchar_t* str) throw();  
HRESULT Set(   
          const wchar_t* str,   
          unsigned int len  
           ) throw();  
HRESULT Set(  
          const HSTRING& hstr  
           ) throw();  
```  
  
#### Parameters  
 `str`  
 A wide-character string.  
  
 `len`  
 The maximum length of the `str` parameter that is assigned to the current HString object.  
  
 `hstr`  
 An existing HString object.  
  
## Requirements  
 **Header:** corewrappers.h  
  
 **Namespace:** Microsoft::WRL::Wrappers  
  
## See Also  
 [HString Class](../vs140/hstring-class.md)