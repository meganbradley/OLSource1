---
title: "Calculating Necessary Values"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "helper functions, calculating necessary values"
ms.assetid: 4f037d0f-881a-4a48-a9d2-9f8872dfccb7
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Calculating Necessary Values
Two critical pieces of information need to be calculated by the delay helper routine. To that end, there are two inline functions in delayhlp.cpp for calculating this information.  
  
-   The first calculates the index of the current import into the three different tables (import address table (IAT), bound import address table (BIAT), and unbound import address table (UIAT)).  
  
-   The second counts the number of imports in a valid IAT.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Understanding the Helper Function](../vs140/understanding-the-helper-function.md)