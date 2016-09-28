---
title: "marker_series::marker_series Constructor"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "cvmarkersobj/Concurrency::diagnostic::marker_series::marker_series"
helpviewer_keywords: 
  - "Concurrency::diagnostic::marker_series constructor"
ms.assetid: 042c7d23-f1d8-4e09-9e76-a21c30243790
caps.latest.revision: 7
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# marker_series::marker_series Constructor
Initializes a new instance of the `marker_series` class.  
  
## Syntax  
  
```  
marker_series();  
marker_series(  
   _In_ LPCTSTR _SeriesName  
);  
marker_series(  
   _In_ const GUID* _ProviderGuid  
);  
marker_series(  
   _In_ const GUID* _ProviderGuid,  
   _In_ LPCTSTR _SeriesName  
);  
```  
  
#### Parameters  
 `_SeriesName`  
 The name of the series to create.  
  
 `_ProviderGuid`  
 The GUID of the series provider.  
  
## Requirements  
 **Header:** cvmarkersobj.h  
  
 **Namespace:** Concurrency::diagnostic  
  
## See Also  
 [marker_series Class](../vs140/marker_series-class.md)