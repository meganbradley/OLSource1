---
title: "CvCreateDefaultMarkerSeriesOfDefaultProvider Function"
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
  - "cvmarkers/CvCreateDefaultMarkerSeriesOfDefaultProvider"
helpviewer_keywords: 
  - "CvCreateDefaultMarkerSeriesOfDefaultProvider method"
ms.assetid: 24eb80f8-8fca-4c47-93b5-bb1eb8ffdffd
caps.latest.revision: 6
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CvCreateDefaultMarkerSeriesOfDefaultProvider Function
Creates default marker series of a default provider.  
  
## Syntax  
  
```  
HRESULT CvCreateDefaultMarkerSeriesOfDefaultProvider(  
   _Out_ PCV_PROVIDER* ppProvider,  
   _Out_ PCV_MARKERSERIES* ppMarkerSeries  
);  
```  
  
#### Parameters  
 `ppProvider`  
 Address of provider object variable. Address cannot be NULL, the variable can have any value.  
  
 `ppMarkerSeries`  
 Address of marker series object variable. Address cannot be NULL, the variable can have any value.  
  
## Return Value  
 S_OK when both provider and marker series are successfully created or error code in case there were any errors. Use SUCCEEDED/FAILED macros to check for error condition.  
  
## Requirements  
 **Header:** cvmarkers.h  
  
## See Also  
 [Native Reference](../vs140/c---library-reference.md)