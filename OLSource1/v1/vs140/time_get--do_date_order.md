---
title: "time_get::do_date_order"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "std::time_get::do_date_order"
  - "time_get::do_date_order"
  - "std.time_get.do_date_order"
  - "do_date_order"
  - "time_get.do_date_order"
  - "xloctime/std::time_get::do_date_order"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "do_date_order method"
ms.assetid: 274525ce-d1f4-43c2-8761-9d59841ea9ce
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# time_get::do_date_order
A protected virtual member function that is called to return the date order used by a facet.  
  
## Syntax  
  
```  
  
virtual dateorder do  
_  
date  
_  
order( ) const;  
  
```  
  
## Return Value  
 The date order used by a facet.  
  
## Remarks  
 The virtual protected member function returns a value of type **time_base::dateorder**, which describes the order in which date components are matched by [do_get_date](../vs140/time_get--do_get_date.md). In this implementation, the value is **time_base::mdy**, corresponding to dates of the form December 2, 1979.  
  
## Example  
 See the example for [date_order](../vs140/time_get--date_order.md), which calls `do_date_order`.  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [time_get Class](../vs140/time_get-class.md)