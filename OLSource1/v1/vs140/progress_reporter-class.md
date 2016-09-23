---
title: "progress_reporter Class"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - ppltasks/concurrency::progress_reporter
dev_langs: 
  - C++
helpviewer_keywords: 
  - progress_reporter class
ms.assetid: b836efab-2d05-4649-b6fa-d15236f1f813
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# progress_reporter Class
The progress reporter class allows reporting progress notifications of a specific type. Each progress_reporter object is bound to a particular asynchronous action or operation.  
  
## Syntax  
  
```  
template<  
   typename             _ProgressType  
>  
class progress_reporter;  
```  
  
#### Parameters  
 `_ProgressType`  
 The payload type of each progress notification reported through the progress reporter.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[progress_reporter::progress_reporter Constructor](#progress_reporter__progress_reporter_constructor)||  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[progress_reporter::report Method](#progress_reporter__report_method)|Sends a progress report to the asynchronous action or operation to which this progress reporter is bound.|  
  
## Remarks  
 This type is only available to Windows Store apps.  
  
## Inheritance Hierarchy  
 `progress_reporter`  
  
## Requirements  
 **Header:** ppltasks.h  
  
 **Namespace:** concurrency  
  
##  <a name="progress_reporter__progress_reporter_constructor"></a>  progress_reporter::progress_reporter Constructor  
  
```  
progress_reporter();  
```  
  
##  <a name="progress_reporter__report_method"></a>  progress_reporter::report Method  
 Sends a progress report to the asynchronous action or operation to which this progress reporter is bound.  
  
```  
void report(  
   const _ProgressType&                 _Val  
) const;  
```  
  
### Parameters  
 `_Val`  
 The payload to report through a progress notification.  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [create_async Function](concurrency_namespace_Functions)