---
title: "Elapsed Time: General-Purpose Classes"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "adding dates"
  - "calculating dates and times"
  - "dates, calculating intervals"
  - "elapsed time, calculating"
  - "elapsed time"
  - "time, elapsed"
  - "intervals, date and time"
  - "calculations, date and time"
ms.assetid: e5c5d3d2-ce1d-409e-875c-98848434e716
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Elapsed Time: General-Purpose Classes
The following procedure shows how to calculate the difference between two `CTime` objects and get a `CTimeSpan` result.  
  
#### To calculate elapsed time  
  
1.  Use the `CTime` and `CTimeSpan` objects to calculate the elapsed time, as follows:  
  
     [!code[NVC_ATLMFC_Utilities#174](../VS_csharp/codesnippet/CPP/elapsed-time--general-purpose-classes_1.cpp)]  
  
     Once you have calculated `elapsedTime`, you can use the member functions of `CTimeSpan` to extract the components of the elapsed-time value.  
  
## See Also  
 [Date and Time: General-Purpose Classes](../VS_csharp/date-and-time--general-purpose-classes.md)