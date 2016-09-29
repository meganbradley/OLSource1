---
title: "collate::collate"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "collate.collate"
  - "locale/std::collate::collate"
  - "collate"
  - "std::collate::collate"
  - "collate::collate"
  - "std.collate.collate"
  - "Collate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "collate method"
  - "collate class, constructor"
ms.assetid: 3629d77a-3e3b-4a44-ac69-c007d9b9c2b9
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# collate::collate
The constructor for objects of class collate that serves as a locale facet to handle string sorting conventions.  
  
## Syntax  
  
```  
public:  
    explicit collate(  
        size_t _Refs = 0  
    );  
protected:  
    collate(  
        const char * _Locname,  
        size_t _Refs = 0  
    );  
```  
  
#### Parameters  
 `_Refs`  
 Integer value used to specify the type of memory management for the object.  
  
 `_Locname`  
 The name of the locale.  
  
## Remarks  
 The possible values for the `_Refs` parameter and their significance are:  
  
-   0: The lifetime of the object is managed by the locales that contain it.  
  
-   1: The lifetime of the object must be manually managed.  
  
-   \> 0: These values are not defined.  
  
 The constructor initializes its base object with **locale::**[facet](../vs140/facet-class.md)(`_Refs`).  
  
## Requirements  
 **Header:** <locale\>  
  
 **Namespace:** std  
  
## See Also  
 [collate Class](../vs140/collate-class.md)