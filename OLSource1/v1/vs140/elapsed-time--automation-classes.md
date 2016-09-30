---
title: "Elapsed Time: Automation Classes"
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
  - "elapsed time, calculating in Automation"
  - "Automation classes, elapsed time"
  - "time, elapsed"
  - "intervals, date and time"
  - "calculations, date and time"
ms.assetid: 26b34b37-c10e-4b91-82c3-1dc5ffb5361f
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Elapsed Time: Automation Classes
This procedure shows how to calculate the difference between two <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> objects and get a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> result.  
  
#### To calculate elapsed time  
  
1.  Create two <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> objects.  
  
2.  Set one of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> objects to the current time.  
  
3.  Perform some time-consuming task.  
  
4.  Set the other <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object to the current time.  
  
5.  Take the difference between the two times.  
  
     [!code[NVC_ATLMFC_Utilities#178](../vs140/codesnippet/CPP/elapsed-time--automation-classes_1.cpp)]  
  
## See Also  
 [Date and Time: Automation Support](../vs140/date-and-time--automation-support.md)