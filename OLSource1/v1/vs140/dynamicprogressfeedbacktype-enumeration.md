---
title: "DynamicProgressFeedbackType Enumeration"
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
  - "concrt/concurrency::DynamicProgressFeedbackType"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DynamicProgressFeedbackType enumeration"
ms.assetid: 25c43ad3-f0f6-4d70-8358-d33caf1e5820
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DynamicProgressFeedbackType Enumeration
Used by the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> policy to describe whether resources for the scheduler will be rebalanced according to statistical information gathered from the scheduler or only based on virtual processors going in and out of the idle state through calls to the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> methods on the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> interface. For more information on available scheduler policies, see [PolicyElementKey Enumeration](../vs140/policyelementkey-enumeration.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Values  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|The scheduler does not gather progress information. Rebalancing is done based solely on the subscription level of the underlying hardware thread. For more information on subscription levels, see [IExecutionResource::CurrentSubscriptionLevel](../vs140/iexecutionresource--currentsubscriptionlevel-method.md).\<br />\<br /> This value is reserved for use by the runtime.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|The scheduler gathers progress information and passes it to the resource manager. The resource manager will utilize this statistical information to rebalance resources on behalf of the scheduler in addition to the subscription level of the underlying hardware thread. For more information on subscription levels, see [IExecutionResource::CurrentSubscriptionLevel](../vs140/iexecutionresource--currentsubscriptionlevel-method.md).|  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [PolicyElementKey Enumeration](../vs140/policyelementkey-enumeration.md)