---
title: "Date and Time: General-Purpose Classes"
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
  - "date and time classes"
  - "time classes"
ms.assetid: b8115d7f-428a-4c41-9970-18502f2caca2
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Date and Time: General-Purpose Classes
This article describes how to take advantage of the class library general-purpose services related to date and time management. Procedures described include:  
  
-   [Getting the current time](../VS_csharp/current-time--general-purpose-classes.md)  
  
-   [Calculating elapsed time](../VS_csharp/elapsed-time--general-purpose-classes.md)  
  
-   [Formatting a string representation of a date/time](../VS_csharp/formatting-time-values--general-purpose-classes.md)  
  
 The `CTime` class provides a way to represent date and time information easily. The `CTimeSpan` class represents elapsed time, such as the difference between two `CTime` objects.  
  
> [!NOTE]
>  CTime objects can be used to represent dates between January 1, 1970, and January 18, 2038. `CTime` objects have a resolution of 1 second. `CTime` is based on the `time_t` data type, defined in the *Run-Time Library Reference*.  
  
## See Also  
 [Date and Time](../VS_csharp/date-and-time.md)