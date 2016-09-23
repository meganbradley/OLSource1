---
title: "Overloading the &gt;&gt; Operator for Your Own Classes"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
helpviewer_keywords: 
  - operator>>
  - operator>>, overloading for your own classes
  - operator >>, overloading for your own classes
ms.assetid: 40dab4e0-3f97-4745-9cc8-b86e740fa246
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Overloading the &gt;&gt; Operator for Your Own Classes
Input streams use the extraction (`>>`) operator for the standard types. You can write similar extraction operators for your own types; your success depends on using white space precisely.  
  
 Here is an example of an extraction operator for the `Date` class presented earlier:  
  
```  
istream& operator>> ( istream& is, Date& dt )  
{  
   is >> dt.mo >> dt.da >> dt.yr;  
   return is;  
}  
```  
  
## See Also  
 [Input Streams](../vs140/input-streams.md)