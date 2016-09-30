---
title: "cancellation_token_source Class"
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
  - "pplcancellation_token/concurrency::cancellation_token_source"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "cancellation_token_source class"
ms.assetid: 3548b1a0-12b0-4334-95db-4bf57141c066
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# cancellation_token_source Class
The             <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> class represents the ability to cancel some cancelable operation.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[cancellation_token_source::cancellation_token_source Constructor](#cancellation_token_source__cancellation_token_source_constructor)|Overloaded. Constructs a new                                         <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. The source can be used to flag cancellation of some cancelable operation.|  
|[cancellation_token_source::~cancellation_token_source Destructor](#cancellation_token_source___dtorcancellation_token_source_destructor)||  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[cancellation_token_source::cancel Method](#cancellation_token_source__cancel_method)|Cancels the token. Any                                         <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>,                                         <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, or                                         <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> which utilizes the token will be canceled upon this call and throw an exception at the next interruption point.|  
|[cancellation_token_source::create_linked_source Method](#cancellation_token_source__create_linked_source_method)|Overloaded. Creates a                                         <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> which is canceled when the provided token is canceled.|  
|[cancellation_token_source::get_token Method](#cancellation_token_source__get_token_method)|Returns a cancellation token associated with this source. The returned token can be polled for cancellation or provide a callback if and when cancellation occurs.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[cancellation_token_source::operator!= Operator](#cancellation_token_source__operator_neq_operator)||  
|[cancellation_token_source::operator= Operator](#cancellation_token_source__operator_eq_operator)||  
|[cancellation_token_source::operator== Operator](#cancellation_token_source__operator_eq_eq_operator)||  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** pplcancellation_token.h  
  
 **Namespace:** concurrency  
  
##  \<a name="cancellation_token_source___dtorcancellation_token_source_destructor">\</a>  cancellation_token_source::~cancellation_token_source Destructor  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="cancellation_token_source__cancel_method">\</a>  cancellation_token_source::cancel Method  
 Cancels the token. Any                 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>,                 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, or                 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> which utilizes the token will be canceled upon this call and throw an exception at the next interruption point.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
##  \<a name="cancellation_token_source__cancellation_token_source_constructor">\</a>  cancellation_token_source::cancellation_token_source Constructor  
 Constructs a new                 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. The source can be used to flag cancellation of some cancelable operation.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  
##  \<a name="cancellation_token_source__create_linked_source_method">\</a>  cancellation_token_source::create_linked_source Method  
 Creates a                 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> which is canceled when the provided token is canceled.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 A token whose cancellation will cause cancellation of the returned token source. Note that the returned token source can also be canceled independently of the source contained in this parameter.  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 The STL iterator corresponding to the beginning of the range of tokens to listen for cancellation of.  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 The STL iterator corresponding to the ending of the range of tokens to listen for cancellation of.  
  
### Return Value  
 A                         <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> which is canceled when the token provided by the                         <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> parameter is canceled.  
  
##  \<a name="cancellation_token_source__get_token_method">\</a>  cancellation_token_source::get_token Method  
 Returns a cancellation token associated with this source. The returned token can be polled for cancellation or provide a callback if and when cancellation occurs.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 A cancellation token associated with this source.  
  
##  \<a name="cancellation_token_source__operator_neq_operator">\</a>  cancellation_token_source::operator!= Operator  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
  
### Return Value  
  
##  \<a name="cancellation_token_source__operator_eq_operator">\</a>  cancellation_token_source::operator= Operator  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
  
### Return Value  
  
##  \<a name="cancellation_token_source__operator_eq_eq_operator">\</a>  cancellation_token_source::operator== Operator  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
  
### Return Value  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)