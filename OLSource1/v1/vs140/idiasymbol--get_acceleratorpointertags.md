---
title: "IDiaSymbol::get_acceleratorPointerTags"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
ms.assetid: 30e13cee-e511-49ec-affd-99b0097071b2
caps.latest.revision: 7
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IDiaSymbol::get_acceleratorPointerTags
Returns all accelerator pointer tag values that correspond to a C++ AMP accelerator stub function.  
  
## Syntax  
  
```cpp  
HRESULT get_acceleratorPointerTags(   
   DWORD          cnt,  
   DWORD*         pcnt,  
   DWORD*         pPointerTags);  
```  
  
#### Parameters  
 `cnt`  
 [in] The size of the output array `pPointerTags`.  
  
 `pcnt`  
 [out] The count of accelerator pointer tags in the C++ AMP accelerator stub function.  
  
 `pPointerTags`  
 [out] A `DWORD` array pointer that is filled with the accelerator pointer tag values in the C++ AMP accelerator stub function.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
## Remarks  
 This method is called on an `IDiaSymbol` interface that corresponds to a C++ AMP accelerator stub function.  
  
## See Also  
 [IDiaSymbol](../vs140/idiasymbol.md)