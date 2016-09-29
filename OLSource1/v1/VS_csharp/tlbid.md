---
title: "tlbid"
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
  - "tlbid"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "tlbid attribute"
ms.assetid: 54b06785-191b-4e77-a9a5-485f2b4acb09
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# tlbid
**C++ Specific**  
  
 Allows for loading libraries other than the primary type library.  
  
## Syntax  
  
```  
tlbid(number)  
```  
  
#### Parameters  
 `number`  
 The number of the type library in `filename`.  
  
## Remarks  
 If multiple type libraries are built into a single DLL, it possible to load libraries other than the primary type library by using `tlbid`.  
  
 For example:  
  
```  
#import <MyResource.dll> tlbid(2)  
```  
  
 is equivalent to:  
  
```  
LoadTypeLib("MyResource.dll\\2");  
```  
  
 **END C++ Specific**  
  
## See Also  
 [#import Attributes](../VS_csharp/sharpimport-attributes--c---.md)   
 [The #import Directive](../VS_csharp/sharpimport-directive--c---.md)