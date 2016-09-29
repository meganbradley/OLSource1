---
title: "COleDateTime Relational Operators"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "COleDateTime Relational Operators"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator >, date time"
  - "!= operator"
  - "operator<=, date time"
  - "operator!=, date time"
  - "operator!=, relational operators"
  - "< operator, date/time comparisons"
  - "operator==, date time"
  - "COleDateTime class, operators"
  - "operator <, date time"
  - "<= operator, date/time comparisons"
  - ">= operator, date/time comparisons"
  - "relational operators, COleDateTime"
  - "operator<, date time"
  - "operator !=, date time"
  - "operator >=, date time"
  - "operator <=, date time"
  - "> operator, date/time comparisons"
  - "operator !=, relational operators"
  - "operator ==, date time"
  - "operator>=, date time"
  - "== operator"
ms.assetid: 205c4fd0-5966-4e71-ad78-b8a4fd6777c9
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDateTime Relational Operators
Comparison operators.  
  
## Syntax  
  
```  
  
      bool operator ==(  
   const COleDateTime& date   
) const throw( );  
bool operator !=(  
   const COleDateTime& date   
) const throw( );  
bool operator <(  
   const COleDateTime& date   
) const throw( );  
bool operator >(  
   const COleDateTime& date   
) const throw( );  
bool operator <=(  
   const COleDateTime& date   
) const throw( );  
bool operator >=(  
   const COleDateTime& date   
) const throw( );  
```  
  
#### Parameters  
 `date`  
 The **COleDateTime** object to be compared.  
  
## Return values  
 These operators compare two date/time values and return **true** if the condition is true; otherwise **false**.  
  
## Remarks  
  
> [!NOTE]
>  An ATLASSERT will occur if either of the two operands is invalid.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#13](../vs140/codesnippet/CPP/coledatetime-relational-operators_1.cpp)]  
  
## Example  
 The operators **>=**, **<=**, **>**, and **<**, will assert if the `COleDateTime` object is set to null.  
  
 [!code[NVC_ATLMFC_Utilities#170](../vs140/codesnippet/CPP/coledatetime-relational-operators_2.cpp)]  
  
## Requirements  
 **Header:** atlcomtime.h  
  
## See Also  
 [COleDateTime Class](../vs140/coledatetime-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDateTime::GetStatus](../vs140/coledatetime--getstatus.md)