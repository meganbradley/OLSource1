---
title: "CThreadPool::Initialize"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "ATL::CThreadPool::Initialize"
  - "ATL.CThreadPool.Initialize"
  - "Initialize"
  - "CThreadPool.Initialize"
  - "CThreadPool::Initialize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Initialize method"
ms.assetid: 78eeeb4f-8ecb-46a9-8d65-832ebe2e9379
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CThreadPool::Initialize
Call this method to initialize the thread pool.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The worker parameter to be passed to the worker thread object's <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, **Execute**, and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> methods.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The requested number of threads in the pool.  
  
 If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is negative, its absolute value will be multiplied by the number of processors in the machine to get the total number of threads.  
  
 If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is zero, [ATLS_DEFAULT_THREADSPERPROC](../vs140/atls_default_threadsperproc.md) will be multiplied by the number of processors in the machine to get the total number of threads.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The stack size for each thread in the pool.  
  
 *hCompletion*  
 The handle of an object to associate with the completion port.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Requirements  
 **Header:** atlutil.h  
  
## See Also  
 [CThreadPool Class](../vs140/cthreadpool-class.md)