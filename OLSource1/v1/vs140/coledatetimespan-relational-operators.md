---
title: "COleDateTimeSpan Relational Operators"
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
  - "COleDateTimeSpan"
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
  - "operator <, date time"
  - "<= operator, date/time comparisons"
  - ">= operator, date/time comparisons"
  - "operator<, date time"
  - "operator !=, date time"
  - "operator >=, date time"
  - "operator <=, date time"
  - "> operator, date/time comparisons"
  - "COleDateTimeSpan class, operators"
  - "operator !=, relational operators"
  - "operator ==, date time"
  - "operator>=, date time"
  - "== operator"
ms.assetid: 147a0aee-8fab-444e-96cd-a54ddaff8fc6
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDateTimeSpan Relational Operators
Comparison operators.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *dateSpan*  
 The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to compare.  
  
## Return Value  
 These operators compare two date/time-span values and return **true** if the condition is true; otherwise **false**.  
  
## Remarks  
  
> [!NOTE]
>  An ATLASSERT will occur if either operand is invalid.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#25](../vs140/codesnippet/CPP/coledatetimespan-relational-operators_1.cpp)]  
  
 [!code[NVC_ATLMFC_Utilities#26](../vs140/codesnippet/CPP/coledatetimespan-relational-operators_2.cpp)]  
  
## Requirements  
 **Header:** atlcomtime.h  
  
## See Also  
 [COleDateTimeSpan Class](../vs140/coledatetimespan-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)