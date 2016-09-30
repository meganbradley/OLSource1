---
title: "single_link_registry Class"
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
  - "agents/concurrency::single_link_registry"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "single_link_registry class"
ms.assetid: 09540a4e-c34e-4ff9-af49-21b8612b6ab3
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# single_link_registry Class
The             <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object is a             <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> that manages only a single source or target block.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The block data type being stored in the                         <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[single_link_registry::single_link_registry Constructor](#single_link_registry__single_link_registry_constructor)|Constructs a                                         <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object.|  
|[single_link_registry::~single_link_registry Destructor](#single_link_registry___dtorsingle_link_registry_destructor)|Destroys the                                         <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[single_link_registry::add Method](#single_link_registry__add_method)|Adds a link to the                                         <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object. (Overrides                                         [network_link_registry::add](../vs140/network_link_registry-class.md#network_link_registry__add_method).)|  
|[single_link_registry::begin Method](#single_link_registry__begin_method)|Returns an iterator to the first element in the                                         <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object. (Overrides                                         [network_link_registry::begin](../vs140/network_link_registry-class.md#network_link_registry__begin_method).)|  
|[single_link_registry::contains Method](#single_link_registry__contains_method)|Searches the                                         <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object for a specified block. (Overrides                                         [network_link_registry::contains](../vs140/network_link_registry-class.md#network_link_registry__contains_method).)|  
|[single_link_registry::count Method](#single_link_registry__count_method)|Counts the number of items in the                                         <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object. (Overrides                                         [network_link_registry::count](../vs140/network_link_registry-class.md#network_link_registry__count_method).)|  
|[single_link_registry::remove Method](#single_link_registry__remove_method)|Removes a link from the                                         <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object. (Overrides                                         [network_link_registry::remove](../vs140/network_link_registry-class.md#network_link_registry__remove_method).)|  
  
## Inheritance Hierarchy  
 [network_link_registry](../vs140/network_link_registry-class.md)  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
##  \<a name="single_link_registry__add_method">\</a>  single_link_registry::add Method  
 Adds a link to the                 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 A pointer to a block to be added.  
  
### Remarks  
 The method throws an                         [invalid_link_target](../vs140/invalid_link_target-class.md) exception if there is already a link in this registry.  
  
##  \<a name="single_link_registry__begin_method">\</a>  single_link_registry::begin Method  
 Returns an iterator to the first element in the                 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 An iterator addressing the first element in the                         <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object.  
  
### Remarks  
 The end state is indicated by a                         <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> link.  
  
##  \<a name="single_link_registry__contains_method">\</a>  single_link_registry::contains Method  
 Searches the                 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object for a specified block.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 A pointer to a block that is to be searched for in the                                 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object.  
  
### Return Value  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> if the link was found,                         <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> otherwise.  
  
##  \<a name="single_link_registry__count_method">\</a>  single_link_registry::count Method  
 Counts the number of items in the                 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 The number of items in the                         <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object.  
  
##  \<a name="single_link_registry__remove_method">\</a>  single_link_registry::remove Method  
 Removes a link from the                 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 A pointer to a block to be removed, if found.  
  
### Return Value  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> if the link was found and removed,                         <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> otherwise.  
  
##  \<a name="single_link_registry__single_link_registry_constructor">\</a>  single_link_registry::single_link_registry Constructor  
 Constructs a                 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
##  \<a name="single_link_registry___dtorsingle_link_registry_destructor">\</a>  single_link_registry::~single_link_registry Destructor  
 Destroys the                 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Remarks  
 The method throws an                         [invalid_operation](../vs140/invalid_operation-class.md) exception if it is called before the link is removed.  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [multi_link_registry Class](../vs140/multi_link_registry-class.md)