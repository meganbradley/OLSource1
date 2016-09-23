---
title: "Overflow (Visual Basic Run-Time Error)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-visual-basic
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - vbrERRID_Overflow
dev_langs: 
  - VB
ms.assetid: c6a23279-3086-412a-bcff-ff8ed2cb8c6f
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Overflow (Visual Basic Run-Time Error)
An overflow results when you attempt an assignment that exceeds the limits of the assignment's target.  
  
### To correct this error  
  
1.  Make sure that results of assignments, calculations, and data type conversions are not too large to be represented within the range of variables allowed for that type of value, and assign the value to a variable of a type that can hold a larger range of values, if necessary.  
  
2.  Make sure assignments to properties fit the range of the property to which they are made.  
  
3.  Make sure that numbers used in calculations that are coerced into integers do not have results larger than integers.  
  
## See Also  
 <xref:System.Int32.MaxValue?qualifyHint=True>   
 <xref:System.Double.MaxValue?qualifyHint=True>   
 [Data Type Summary (Visual Basic)](../vs140/data-type-summary--visual-basic-.md)   
 [Types of Errors](../vs140/error-types--visual-basic-.md)