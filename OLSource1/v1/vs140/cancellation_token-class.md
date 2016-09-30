---
title: "cancellation_token Class"
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
  - "pplcancellation_token/concurrency::cancellation_token"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "cancellation_token class"
ms.assetid: 2787df2b-e9d3-440e-bfd0-841a46a9835f
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# cancellation_token Class
The             <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> class represents the ability to determine whether some operation has been requested to cancel. A given token can be associated with a             <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>,             <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, or             <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to provide implicit cancellation. It can also be polled for cancellation or have a callback registered for if and when the associated             <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is canceled.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[cancellation_token::cancellation_token Constructor](#cancellation_token__cancellation_token_constructor)||  
|[cancellation_token::~cancellation_token Destructor](#cancellation_token___dtorcancellation_token_destructor)||  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[cancellation_token::deregister_callback Method](#cancellation_token__deregister_callback_method)|Removes a callback previously registered via the                                         <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> method based on the                                         <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object returned at the time of registration.|  
|[cancellation_token::is_cancelable Method](#cancellation_token__is_cancelable_method)|Returns an indication of whether this token can be canceled or not.|  
|[cancellation_token::is_canceled Method](#cancellation_token__is_canceled_method)|Returns                                         <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> if the token has been canceled.|  
|[cancellation_token::none Method](#cancellation_token__none_method)|Returns a cancellation token which can never be subject to cancellation.|  
|[cancellation_token::register_callback Method](#cancellation_token__register_callback_method)|Registers a callback function with the token. If and when the token is canceled, the callback will be made. Note that if the token is already canceled at the point where this method is called, the callback will be made immediately and synchronously.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[cancellation_token::operator!= Operator](#cancellation_token__operator_neq_operator)||  
|[cancellation_token::operator= Operator](#cancellation_token__operator_eq_operator)||  
|[cancellation_token::operator== Operator](#cancellation_token__operator_eq_eq_operator)||  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** pplcancellation_token.h  
  
 **Namespace:** concurrency  
  
##  \<a name="cancellation_token___dtorcancellation_token_destructor">\</a>  cancellation_token::~cancellation_token Destructor  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="cancellation_token__cancellation_token_constructor">\</a>  cancellation_token::cancellation_token Constructor  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  
##  \<a name="cancellation_token__deregister_callback_method">\</a>  cancellation_token::deregister_callback Method  
 Removes a callback previously registered via the                 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> method based on the                 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object returned at the time of registration.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object corresponding to the callback to be deregistered. This token must have been previously returned from a call to the                                 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> method.  
  
##  \<a name="cancellation_token__is_cancelable_method">\</a>  cancellation_token::is_cancelable Method  
 Returns an indication of whether this token can be canceled or not.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 An indication of whether this token can be canceled or not.  
  
##  \<a name="cancellation_token__is_canceled_method">\</a>  cancellation_token::is_canceled Method  
 Returns                 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> if the token has been canceled.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 The value                         <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> if the token has been canceled; otherwise, the value                         <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
##  \<a name="cancellation_token__none_method">\</a>  cancellation_token::none Method  
 Returns a cancellation token which can never be subject to cancellation.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 A cancellation token that cannot be canceled.  
  
##  \<a name="cancellation_token__operator_neq_operator">\</a>  cancellation_token::operator!= Operator  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
  
### Return Value  
  
##  \<a name="cancellation_token__operator_eq_operator">\</a>  cancellation_token::operator= Operator  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
  
### Return Value  
  
##  \<a name="cancellation_token__operator_eq_eq_operator">\</a>  cancellation_token::operator== Operator  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
  
### Return Value  
  
##  \<a name="cancellation_token__register_callback_method">\</a>  cancellation_token::register_callback Method  
 Registers a callback function with the token. If and when the token is canceled, the callback will be made. Note that if the token is already canceled at the point where this method is called, the callback will be made immediately and synchronously.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 The type of the function object that will be called back when this                                 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> is canceled.  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 The function object that will be called back when this                                 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> is canceled.  
  
### Return Value  
 A                         <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> object which can be utilized in the                         <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> method to deregister a previously registered callback and prevent it from being made. The method will throw an                         [invalid_operation](../vs140/invalid_operation-class.md) exception if it is called on a                         <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object that was created using the                         [cancellation_token::none](#cancellation_token__none_method) method.  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)