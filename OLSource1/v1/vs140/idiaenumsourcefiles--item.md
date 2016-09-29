---
title: "IDiaEnumSourceFiles::Item"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaEnumSourceFiles::Item method"
ms.assetid: 3c19d7ed-0232-4b0e-9b10-f33ed9e0c93b
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaEnumSourceFiles::Item
Retrieves a source file by means of an index.  
  
## Syntax  
  
```cpp#  
HRESULT Item (   
   DWORD            index,  
   IDiaSourceFile** sourceFile  
);  
```  
  
#### Parameters  
 index  
 [in] Index of the [IDiaSourceFile](../vs140/idiasourcefile.md) object to be retrieved. The index is in the range 0 to `count`-1, where `count` is returned by the [IDiaEnumSourceFiles::get_Count](../vs140/idiaenumsourcefiles--get_count.md) method.  
  
 sourceFile  
 [out] Returns an [IDiaSourceFile](../vs140/idiasourcefile.md) object representing the desired source file.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDiaEnumSourceFiles](../vs140/idiaenumsourcefiles.md)   
 [IDiaSourceFile](../vs140/idiasourcefile.md)