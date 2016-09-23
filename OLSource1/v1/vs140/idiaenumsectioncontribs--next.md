---
title: "IDiaEnumSectionContribs::Next"
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
helpviewer_keywords: 
  - IDiaEnumSectionContribs::Next method
ms.assetid: a6bb2adb-ee6d-4f3c-ab5b-e89361c8880e
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IDiaEnumSectionContribs::Next
Retrieves a specified number of section contributions in the enumeration sequence.  
  
## Syntax  
  
```cpp#  
HRESULT Next(   
   ULONG                celt,   
   IDiaSectionContrib** rgelt,  
   ULONG*               pceltFetched  
);  
```  
  
#### Parameters  
 celt  
 [in] The number of section contributions in the enumerator to be retrieved.  
  
 rgelt  
 [out] An array that is to be filled with the [IDiaSectionContrib](../vs140/idiasectioncontrib.md) objects that represent the desired section contributions.  
  
 pceltFetched  
 [out] Returns the number of section contributions in the enumerator fetched.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if there are no more section contributions. Otherwise, returns an error code.  
  
## See Also  
 [IDiaEnumSectionContribs](../vs140/idiaenumsectioncontribs.md)   
 [IDiaSectionContrib](../vs140/idiasectioncontrib.md)