---
title: "span::span Constructor"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - cvmarkersobj/Concurrency::diagnostic::span::span
helpviewer_keywords: 
  - Concurrency::diagnostic::span constructor
ms.assetid: 8b5578aa-5e5c-4ac7-87c7-ce87c4246e2c
caps.latest.revision: 7
translation.priority.ht: 
  - de-de
  - ja-jp
---
# span::span Constructor
Initializes a new instance of the `span` class.  
  
## Syntax  
  
```  
span(  
   const marker_series& _Series,  
   _In_ LPCTSTR _Format,  
   ...  
);  
span(  
   const marker_series& _Series,  
   marker_importance _Importance,  
   _In_ LPCTSTR _Format,  
   ...  
);  
span(  
   const marker_series& _Series,  
   int _Category,  
   _In_ LPCTSTR _Format,  
   ...  
);  
span(  
   const marker_series& _Series,  
   marker_importance _Importance,  
   int _Category,  
   _In_ LPCTSTR _Format,  
   ...  
);  
```  
  
#### Parameters  
 `_Series`  
 Valid marker series context.  
  
 `_Format`  
 A composite format string that contains text intermixed with zero or more format items, which correspond to objects in the argument list.  
  
 `_Importance`  
 Importance level.  
  
 `_Category`  
 Category.  
  
## Requirements  
 **Header:** cvmarkersobj.h  
  
 **Namespace:** Concurrency::diagnostic  
  
## See Also  
 [span Class](../vs140/span-class.md)