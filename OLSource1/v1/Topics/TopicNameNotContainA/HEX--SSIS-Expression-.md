---
title: "HEX (SSIS Expression)"
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - integration-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: f5d471ee-aeef-421c-b6e1-55b9676c3842
caps.latest.revision: 37
manager: jhubbard
---
# HEX (SSIS Expression)
Returns a string representing the hexadecimal value of an integer.  
  
## Syntax  
  
```  
  
HEX(integer_expression)  
```  
  
## Arguments  
 *integer_expression*  
 Is a signed or unsigned integer.  
  
## Result Types  
 DT_WSTR  
  
## Remarks  
 HEX returns null if *integer_expression* is null.  
  
 The *integer_expression* argument must evaluate to an integer. For more information, see [Integration Services Data Types](../../Topics/TopicNameNotContainA/Integration-Services-Data-Types.md).  
  
 The return result does not include qualifiers such as the 0x prefix. To include a prefix, use the + (Concatenate) operator. For more information, see [+ (Concatenate) (SSIS Expression)](../../Topics/TopicNameNotContainA/---Concatenate---SSIS-Expression-.md).  
  
 The letters A – F, used in HEX notations, appear as uppercase characters.  
  
 The length of the resulting string for integer data types is as follows:  
  
-   DT_I1 and DT_UI1 return a string with a maximum length of 2.  
  
-   DT_I2 and DT_UI2 return a string with a maximum length of 4.  
  
-   DT_I4 and DT_UI4 return a string with a maximum length of 8.  
  
-   DT_I8 and DT_UI8 return a string with a maximum length of 16.  
  
## Expression Examples  
 This example uses a numeric literal. The function returns the value 190.  
  
```  
HEX(400)   
```  
  
 This example uses the **ReorderPoint** column. The column data type is **smallint**. If **ReorderPoint** is 750, the function returns 2EE.  
  
```  
HEX(ReorderPoint)   
```  
  
 This example uses **LocaleID**, a system variable. If **LocaleID** is 1033, the function returns 409.  
  
```  
HEX(@LocaleID)  
```  
  
## See Also  
 [Functions (SSIS Expression)](../../Topics/TopicNameNotContainA/Functions--SSIS-Expression-.md)