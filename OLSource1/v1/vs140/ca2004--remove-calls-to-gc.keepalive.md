---
title: "CA2004: Remove calls to GC.KeepAlive"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "RemoveCallsToGCKeepAlive"
  - "CA2004"
helpviewer_keywords: 
  - "RemoveCallsToGCKeepAlive"
  - "CA2004"
ms.assetid: bc543b5b-23eb-4b45-abc2-9325cd254ac2
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CA2004: Remove calls to GC.KeepAlive
|||  
|-|-|  
|TypeName|RemoveCallsToGCKeepAlive|  
|CheckId|CA2004|  
|Category|Microsoft.Reliability|  
|Breaking Change|Non-breaking|  
  
## Cause  
 Classes use <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> but still contain calls to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Rule Description  
 If you are converting to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> usage, remove all calls to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> (object). In this case, classes should not have to call <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>,assuming they do not have a finalizer but rely on <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to complete the OS handle for them.  Although the cost of leaving in a call to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> might be negligible as measured by performance, the perception that a call to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is either necessary or sufficient to solve a lifetime issue that might no longer exist makes the code harder to maintain.  
  
## How to Fix Violations  
 Remove calls to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## When to Suppress Warnings  
 You can suppress this warning only if it is not technically correct to convert to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> usage in your class.