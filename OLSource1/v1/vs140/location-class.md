---
title: "location Class"
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
  - "concrt/concurrency::location"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "location class"
ms.assetid: c3289f51-5bf1-4dff-a18d-d0dab8e5d9c7
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# location Class
An abstraction of a physical location on hardware.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[location::location Constructor](#location__location_constructor)|Overloaded. Constructs a                                         <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.|  
|[location::~location Destructor](#location___dtorlocation_destructor)|Destroys a                                         <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[location::current Method](#location__current_method)|Returns a                                         <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object representing the most specific place the calling thread is executing.|  
|[location::from_numa_node Method](#location__from_numa_node_method)|Returns a                                         <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object which represents a given NUMA node.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[location::operator!= Operator](#location__operator_neq_operator)|Determines whether two                                         <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> objects represent different location.|  
|[location::operator= Operator](#location__operator_eq_operator)|Assigns the contents of a different                                         <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object to this one.|  
|[location::operator== Operator](#location__operator_eq_eq_operator)|Determines whether two                                         <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> objects represent the same location.|  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
##  \<a name="location___dtorlocation_destructor">\</a>  location::~location Destructor  
 Destroys a                 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="location__current_method">\</a>  location::current Method  
 Returns a                 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object representing the most specific place the calling thread is executing.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 A location representing the most specific place the calling thread is executing.  
  
##  \<a name="location__from_numa_node_method">\</a>  location::from_numa_node Method  
 Returns a                 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object which represents a given NUMA node.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 The NUMA node number to construct a location for.  
  
### Return Value  
 A location representing the NUMA node specified by the                         <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> parameter.  
  
##  \<a name="location__location_constructor">\</a>  location::location Constructor  
 Constructs a                 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
  
### Remarks  
 A default constructed location represents the system as a whole.  
  
##  \<a name="location__operator_neq_operator">\</a>  location::operator!= Operator  
 Determines whether two                 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> objects represent different location.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
  
### Return Value  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> if the two locations are different,                         <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> otherwise.  
  
##  \<a name="location__operator_eq_operator">\</a>  location::operator= Operator  
 Assigns the contents of a different                 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object to this one.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 The source                                 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> object.  
  
### Return Value  
  
##  \<a name="location__operator_eq_eq_operator">\</a>  location::operator== Operator  
 Determines whether two                 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> objects represent the same location.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
  
### Return Value  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> if the two locations are identical, and                         <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> otherwise.  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)