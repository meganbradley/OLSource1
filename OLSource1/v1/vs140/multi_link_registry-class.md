---
title: "multi_link_registry Class"
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
  - "agents/concurrency::multi_link_registry"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "multi_link_registry class"
ms.assetid: b2aa73a8-e8a6-4255-b117-d07530c328b2
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multi_link_registry Class
The             <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object is a             <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> that manages multiple source blocks or multiple target blocks.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 The block data type being stored in the                         <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[multi_link_registry::multi_link_registry Constructor](#multi_link_registry__multi_link_registry_constructor)|Constructs a                                         <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object.|  
|[multi_link_registry::~multi_link_registry Destructor](#multi_link_registry___dtormulti_link_registry_destructor)|Destroys the                                         <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[multi_link_registry::add Method](#multi_link_registry__add_method)|Adds a link to the                                         <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object. (Overrides                                         [network_link_registry::add](../vs140/network_link_registry-class.md#network_link_registry__add_method).)|  
|[multi_link_registry::begin Method](#multi_link_registry__begin_method)|Returns an iterator to the first element in the                                         <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object. (Overrides                                         [network_link_registry::begin](../vs140/network_link_registry-class.md#network_link_registry__begin_method).)|  
|[multi_link_registry::contains Method](#multi_link_registry__contains_method)|Searches the                                         <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object for a specified block. (Overrides                                         [network_link_registry::contains](../vs140/network_link_registry-class.md#network_link_registry__contains_method).)|  
|[multi_link_registry::count Method](#multi_link_registry__count_method)|Counts the number of items in the                                         <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object. (Overrides                                         [network_link_registry::count](../vs140/network_link_registry-class.md#network_link_registry__count_method).)|  
|[multi_link_registry::remove Method](#multi_link_registry__remove_method)|Removes a link from the                                         <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object. (Overrides                                         [network_link_registry::remove](../vs140/network_link_registry-class.md#network_link_registry__remove_method).)|  
|[multi_link_registry::set_bound Method](#multi_link_registry__set_bound_method)|Sets an upper bound on the number of links that the                                         <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object can hold.|  
  
## Inheritance Hierarchy  
 [network_link_registry](../vs140/network_link_registry-class.md)  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
##  \<a name="multi_link_registry__add_method">\</a>  multi_link_registry::add Method  
 Adds a link to the                 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 A pointer to a block to be added.  
  
### Remarks  
 The method throws an                         [invalid_link_target](../vs140/invalid_link_target-class.md) exception if the link is already present in the registry, or if a bound has already been set with the                         <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> function and a link has since been removed.  
  
##  \<a name="multi_link_registry__begin_method">\</a>  multi_link_registry::begin Method  
 Returns an iterator to the first element in the                 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 An iterator addressing the first element in the                         <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object.  
  
### Remarks  
 The end state is indicated by a                         <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> link.  
  
##  \<a name="multi_link_registry__contains_method">\</a>  multi_link_registry::contains Method  
 Searches the                 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object for a specified block.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 A pointer to a block that is to be searched for in the                                 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object.  
  
### Return Value  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> if the specified block was found,                         <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> otherwise.  
  
##  \<a name="multi_link_registry__count_method">\</a>  multi_link_registry::count Method  
 Counts the number of items in the                 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 The number of items in the                         <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> object.  
  
##  \<a name="multi_link_registry__multi_link_registry_constructor">\</a>  multi_link_registry::multi_link_registry Constructor  
 Constructs a                 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
##  \<a name="multi_link_registry___dtormulti_link_registry_destructor">\</a>  multi_link_registry::~multi_link_registry Destructor  
 Destroys the                 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Remarks  
 The method throws an                         [invalid_operation](../vs140/invalid_operation-class.md) exception if called before all links are removed.  
  
##  \<a name="multi_link_registry__remove_method">\</a>  multi_link_registry::remove Method  
 Removes a link from the                 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 A pointer to a block to be removed, if found.  
  
### Return Value  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> if the link was found and removed,                         <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> otherwise.  
  
##  \<a name="multi_link_registry__set_bound_method">\</a>  multi_link_registry::set_bound Method  
 Sets an upper bound on the number of links that the                 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> object can hold.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 The maximum number of links that the                                 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> object can hold.  
  
### Remarks  
 After a bound is set, unlinking an entry will cause the                         <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> object to enter an immutable state where further calls to                         <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> will throw an                         <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> exception.  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [single_link_registry Class](../vs140/single_link_registry-class.md)