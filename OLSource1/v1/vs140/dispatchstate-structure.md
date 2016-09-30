---
title: "DispatchState Structure"
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
  - "concrtrm/concurrency::DispatchState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DispatchState structure"
ms.assetid: 8c52546e-1650-48a0-985f-7e4a0fc26a90
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DispatchState Structure
The             <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> structure is used to transfer state to the             <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> method. It describes the circumstances under which the             <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> method is invoked on an             <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> interface.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[DispatchState::DispatchState Constructor](#dispatchstate__dispatchstate_constructor)|Constructs a new                                         <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[DispatchState::m_dispatchStateSize Data Member](#dispatchstate__m_dispatchstatesize_data_member)|Size of this structure, which is used for versioning.|  
|[DispatchState::m_fIsPreviousContextAsynchronouslyBlocked Data Member](#dispatchstate__m_fispreviouscontextasynchronouslyblocked_data_member)|Tells whether this context has entered the                                         <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> method because the previous context asynchronously blocked. This is used only on the UMS scheduling context, and is set to the value                                         <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> for all other execution contexts.|  
|[DispatchState::m_reserved Data Member](#dispatchstate__m_reserved_data_member)|Bits reserved for future information passing.|  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
##  \<a name="dispatchstate__dispatchstate_constructor">\</a>  DispatchState::DispatchState Constructor  
 Constructs a new                 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="dispatchstate__m_dispatchstatesize_data_member">\</a>  DispatchState::m_dispatchStateSize Data Member  
 Size of this structure, which is used for versioning.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
##  \<a name="dispatchstate__m_fispreviouscontextasynchronouslyblocked_data_member">\</a>  DispatchState::m_fIsPreviousContextAsynchronouslyBlocked Data Member  
 Tells whether this context has entered the                 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> method because the previous context asynchronously blocked. This is used only on the UMS scheduling context, and is set to the value                 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> for all other execution contexts.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="dispatchstate__m_reserved_data_member">\</a>  DispatchState::m_reserved Data Member  
 Bits reserved for future information passing.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [IExecutionContext::Dispatch Method](../vs140/iexecutioncontext-structure.md#iexecutioncontext__dispatch_method)