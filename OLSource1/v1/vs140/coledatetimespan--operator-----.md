---
title: "COleDateTimeSpan::operator +, -"
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
  - "COleDateTimeSpan::operator+-"
  - "COleDateTimeSpan::operator-"
  - "COleDateTimeSpan::operator+"
  - "COleDateTimeSpan.operator-"
  - "COleDateTimeSpan.operator+-"
  - "COleDateTimeSpan.operator+"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "- operator, date/time calculations"
  - "+ operator, date/time calculations"
  - "COleDateTimeSpan class, operators"
ms.assetid: f062d36d-5128-4967-8a51-0c580c2c80a4
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDateTimeSpan::operator +, -
Add, subtract, and change sign for <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> values.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The first two operators let you add and subtract date/time-span values. The third lets you change the sign of a date/time-span value.  
  
 If either of the operands is null, the status of the resulting <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> value is null.  
  
 If either of the operands is invalid and the other is not null, the status of the resulting <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> value is invalid.  
  
 For more information on the valid, invalid, and null status values, see the [m_status](../vs140/coledatetimespan--m_status.md) member variable.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#23](../vs140/codesnippet/CPP/coledatetimespan--operator-----_1.cpp)]  
  
## Requirements  
 **Header:** atlcomtime.h  
  
## See Also  
 [COleDateTimeSpan Class](../vs140/coledatetimespan-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDateTimeSpan::operator +=, -=](../vs140/coledatetimespan--operator--=---=.md)