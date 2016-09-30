---
title: "CTime::operator +, -"
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
  - "CTime::operator+-"
  - "CTime::operator+"
  - "CTime.operator+-"
  - "CTime.operator+"
  - "CTime.operator-"
  - "CTime::operator-"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "- operator, date/time calculations"
  - "+ operator, date/time calculations"
  - "CTime class, operators"
ms.assetid: af3087f8-61ac-4987-b573-bff0fc13def3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTime::operator +, -
These operators add and subtract <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> objects.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *timeSpan*  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object to be added or subtracted.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object to be subtracted.  
  
## Return Value  
 A <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object representing the result of the operation.  
  
## Remarks  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> objects represent absolute time, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> objects represent relative time. The first two operators allow you to add and subtract <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> objects to and from <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> objects. The third operator allows you to subtract one <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object from another to yield a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#159](../vs140/codesnippet/CPP/ctime--operator-----_1.cpp)]  
  
## Requirements  
 **Header:** atltime.h  
  
## See Also  
 [CTime Class](../vs140/ctime-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)