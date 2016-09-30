---
title: "IExecutionContext::GetProxy Method"
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
  - "concrtrm/concurrency::IExecutionContext::GetProxy"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetProxy method"
ms.assetid: a76a574d-4bb8-4a87-b741-b300c057f861
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IExecutionContext::GetProxy Method
Returns an interface to the thread proxy that is executing this context.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 An <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> interface. If the execution context's thread proxy has not been initialized with a call to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, the function must return <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Remarks  
 The Resource Manager will invoke the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> method on an execution context, with an <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> interface as a parameter, prior to entering the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> method on the on the context. You are expected to store this argument and return it on calls to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [IExecutionContext Structure](../vs140/iexecutioncontext-structure.md)   
 [IExecutionContext::SetProxy Method](../vs140/iexecutioncontext--setproxy-method.md)