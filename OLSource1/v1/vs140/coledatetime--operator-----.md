---
title: "COleDateTime::operator +, -"
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
  - "COleDateTime.operator+ -"
  - "COleDateTime::operator+"
  - "COleDateTime.operator-"
  - "COleDateTime.operator+-"
  - "COleDateTime::operator+-"
  - "COleDateTime.operator+"
  - "COleDateTime::operator-"
  - "COleDateTime::operator+ -"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "- operator, date/time calculations"
  - "COleDateTime class, operators"
  - "+ operator, date/time calculations"
ms.assetid: fb8a99e5-9292-40fc-a5c1-d489d96b931c
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDateTime::operator +, -
Add and subtract **ColeDateTime** values.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> objects represent absolute times. [COleDateTimeSpan](../vs140/coledatetimespan-class.md) objects represent relative times. The first two operators allow you to add and subtract a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> value from a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> value. The third operator allows you to subtract one <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> value from another to yield a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> value.  
  
 If either of the operands is null, the status of the resulting <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> value is null.  
  
 If the resulting <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> value falls outside the bounds of acceptable values, the status of that <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> value is invalid.  
  
 If either of the operands is invalid and the other is not null, the status of the resulting <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> value is invalid.  
  
 The **+** and **-** operators will assert if the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object is set to null. See [COleDateTime Relational Operators](../vs140/coledatetime-relational-operators.md) for an example.  
  
 For more information on the valid, invalid, and null status values, see the [m_status](../vs140/coledatetime--m_status.md) member variable.  
  
 For more information about the bounds for <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> values, see the article [Date and Time: Automation Support](../vs140/date-and-time--automation-support.md).  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#12](../vs140/codesnippet/CPP/coledatetime--operator-----_1.cpp)]  
  
## Requirements  
 **Header:** atlcomtime.h  
  
## See Also  
 [COleDateTime Class](../vs140/coledatetime-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDateTime::operator +=, -=](../vs140/coledatetime--operator--=---=.md)   
 [COleDateTime::GetStatus](../vs140/coledatetime--getstatus.md)   
 [COleDateTimeSpan Class](../vs140/coledatetimespan-class.md)