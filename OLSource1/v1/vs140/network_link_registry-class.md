---
title: "network_link_registry Class"
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
  - "agents/concurrency::network_link_registry"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "network_link_registry class"
ms.assetid: 3e7b4097-09f1-4252-964e-b15b8f7f7fc6
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# network_link_registry Class
The             <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> abstract base class manages the links between source and target blocks.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The block data type being stored in the                         <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|A type that provides a pointer to a                                         <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> element in a                                         <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|A type that provides a reference to a                                         <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> element stored in a                                         <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object for reading and performing const operations.|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|A type that provides an iterator that can read or modify any element in a                                         <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object.|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|A type that represents the block type stored in the                                         <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[network_link_registry::add Method](#network_link_registry__add_method)|When overridden in a derived class, adds a link to the                                         <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object.|  
|[network_link_registry::begin Method](#network_link_registry__begin_method)|When overridden in a derived class, returns an iterator to the first element in the                                         <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object.|  
|[network_link_registry::contains Method](#network_link_registry__contains_method)|When overridden in a derived class, searches the                                         <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object for a specified block.|  
|[network_link_registry::count Method](#network_link_registry__count_method)|When overridden in a derived class, returns the number of items in the                                         <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object.|  
|[network_link_registry::remove Method](#network_link_registry__remove_method)|When overridden in a derived class, removes a specified block from the                                         <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object.|  
  
## Remarks  
 The                 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is not safe for concurrent access.  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
##  \<a name="network_link_registry__add_method">\</a>  network_link_registry::add Method  
 When overridden in a derived class, adds a link to the                 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 A pointer to a block to be added.  
  
##  \<a name="network_link_registry__begin_method">\</a>  network_link_registry::begin Method  
 When overridden in a derived class, returns an iterator to the first element in the                 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 An iterator addressing the first element in the                         <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object.  
  
### Remarks  
 The end state of the iterator is indicated by a                         <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> link.  
  
##  \<a name="network_link_registry__contains_method">\</a>  network_link_registry::contains Method  
 When overridden in a derived class, searches the                 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object for a specified block.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 A pointer to a block that is being searched for in the                                 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> object.  
  
### Return Value  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> if the block was found,                         <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> otherwise.  
  
##  \<a name="network_link_registry__count_method">\</a>  network_link_registry::count Method  
 When overridden in a derived class, returns the number of items in the                 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 The number of items in the                         <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object.  
  
##  \<a name="network_link_registry__remove_method">\</a>  network_link_registry::remove Method  
 When overridden in a derived class, removes a specified block from the                 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 A pointer to a block to be removed, if found.  
  
### Return Value  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> if the link was found and removed,                         <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> otherwise.  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [single_link_registry Class](../vs140/single_link_registry-class.md)   
 [multi_link_registry Class](../vs140/multi_link_registry-class.md)