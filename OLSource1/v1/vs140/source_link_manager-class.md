---
title: "source_link_manager Class"
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
  - "agents/concurrency::source_link_manager"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "source_link_manager class"
ms.assetid: 287487cf-e0fe-4c35-aa3c-24f081d1ddae
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# source_link_manager Class
The             <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object manages messaging block network links to             <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> blocks.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 The network link registry.  
  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|A type that provides a pointer to a                                         <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> element in a                                         <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object.|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|A type that provides a reference to a                                         <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> element stored in a                                         <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object for reading and performing const operations.|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|A type that provides an iterator that can read or modify any element in the                                         <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object.|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|The type of link registry being managed by the                                         <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object.|  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[source_link_manager::source_link_manager Constructor](#source_link_manager__source_link_manager_constructor)|Constructs a                                         <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object.|  
|[source_link_manager::~source_link_manager Destructor](#source_link_manager___dtorsource_link_manager_destructor)|Destroys the                                         <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[source_link_manager::add Method](#source_link_manager__add_method)|Adds a source link to the                                         <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object.|  
|[source_link_manager::begin Method](#source_link_manager__begin_method)|Returns an iterator to the first element in the                                         <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object.|  
|[source_link_manager::contains Method](#source_link_manager__contains_method)|Searches the                                         <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> within this                                         <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object for a specified block.|  
|[source_link_manager::count Method](#source_link_manager__count_method)|Counts the number of linked blocks in the                                         <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object.|  
|[source_link_manager::reference Method](#source_link_manager__reference_method)|Acquires a reference on the                                         <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object.|  
|[source_link_manager::register_target_block Method](#source_link_manager__register_target_block_method)|Registers the target block that holds this                                         <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> object.|  
|[source_link_manager::release Method](#source_link_manager__release_method)|Releases the reference on the                                         <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> object.|  
|[source_link_manager::remove Method](#source_link_manager__remove_method)|Removes a link from the                                         <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> object.|  
|[source_link_manager::set_bound Method](#source_link_manager__set_bound_method)|Sets the maximum number of source links that can be added to this                                         <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> object.|  
  
## Remarks  
 Currently, the source blocks are reference counted. This is a wrapper on a                 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object that allows concurrent access to the links and provides the ability to reference the links through callbacks. Message blocks (                <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>s or                 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>s) should use this class for their source links.  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
##  \<a name="source_link_manager__add_method">\</a>  source_link_manager::add Method  
 Adds a source link to the                 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 A pointer to a block to be added.  
  
##  \<a name="source_link_manager__begin_method">\</a>  source_link_manager::begin Method  
 Returns an iterator to the first element in the                 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 An iterator addressing the first element in the                         <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> object.  
  
### Remarks  
 The end state of the iterator is indicated by a                         <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> link.  
  
##  \<a name="source_link_manager__contains_method">\</a>  source_link_manager::contains Method  
 Searches the                 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> within this                 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> object for a specified block.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 A pointer to a block that is to be searched for in the                                 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> object.  
  
### Return Value  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> if the specified block was found,                         <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> otherwise.  
  
##  \<a name="source_link_manager__count_method">\</a>  source_link_manager::count Method  
 Counts the number of linked blocks in the                 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 The number of linked blocks in the                         <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> object.  
  
##  \<a name="source_link_manager__reference_method">\</a>  source_link_manager::reference Method  
 Acquires a reference on the                 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
##  \<a name="source_link_manager__register_target_block_method">\</a>  source_link_manager::register_target_block Method  
 Registers the target block that holds this                 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 The target block holding this                                 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> object.  
  
##  \<a name="source_link_manager__release_method">\</a>  source_link_manager::release Method  
 Releases the reference on the                 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
##  \<a name="source_link_manager__remove_method">\</a>  source_link_manager::remove Method  
 Removes a link from the                 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 A pointer to a block to be removed, if found.  
  
### Return Value  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> if the link was found and removed,                         <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> otherwise.  
  
##  \<a name="source_link_manager__set_bound_method">\</a>  source_link_manager::set_bound Method  
 Sets the maximum number of source links that can be added to this                 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 The maximum number of links.  
  
##  \<a name="source_link_manager__source_link_manager_constructor">\</a>  source_link_manager::source_link_manager Constructor  
 Constructs a                 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
##  \<a name="source_link_manager___dtorsource_link_manager_destructor">\</a>  source_link_manager::~source_link_manager Destructor  
 Destroys the                 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [single_link_registry Class](../vs140/single_link_registry-class.md)   
 [multi_link_registry Class](../vs140/multi_link_registry-class.md)