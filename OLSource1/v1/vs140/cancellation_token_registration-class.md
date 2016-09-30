---
title: "cancellation_token_registration Class"
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
  - "pplcancellation_token/concurrency::cancellation_token_registration"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "cancellation_token_registration class"
ms.assetid: 823d63f4-7233-4d65-8976-6152ccf12d0e
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# cancellation_token_registration Class
The             <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> class represents a callback notification from a             <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. When the             <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> method on a             <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is used to receive notification of when cancellation occurs, a             <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object is returned as a handle to the callback so that the caller can request a specific callback no longer be made through use of the             <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> method.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[cancellation_token_registration::cancellation_token_registration Constructor](#cancellation_token_registration__cancellation_token_registration_constructor)||  
|[cancellation_token_registration::~cancellation_token_registration Destructor](#cancellation_token_registration___dtorcancellation_token_registration_destructor)||  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[cancellation_token_registration::operator!= Operator](#cancellation_token_registration__operator_neq_operator)||  
|[cancellation_token_registration::operator= Operator](#cancellation_token_registration__operator_eq_operator)||  
|[cancellation_token_registration::operator== Operator](#cancellation_token_registration__operator_eq_eq_operator)||  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** pplcancellation_token.h  
  
 **Namespace:** concurrency  
  
##  \<a name="cancellation_token_registration___dtorcancellation_token_registration_destructor">\</a>  cancellation_token_registration::~cancellation_token_registration Destructor  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="cancellation_token_registration__cancellation_token_registration_constructor">\</a>  cancellation_token_registration::cancellation_token_registration Constructor  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
##  \<a name="cancellation_token_registration__operator_neq_operator">\</a>  cancellation_token_registration::operator!= Operator  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
### Return Value  
  
##  \<a name="cancellation_token_registration__operator_eq_operator">\</a>  cancellation_token_registration::operator= Operator  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
### Return Value  
  
##  \<a name="cancellation_token_registration__operator_eq_eq_operator">\</a>  cancellation_token_registration::operator== Operator  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  
### Return Value  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)