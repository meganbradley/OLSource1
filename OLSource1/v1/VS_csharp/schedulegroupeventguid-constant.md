---
title: "ScheduleGroupEventGuid Constant"
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
  - "concrt/concurrency::ScheduleGroupEventGuid"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ScheduleGroupEventGuid constant"
ms.assetid: 548cde87-1467-49d0-af54-59e0cbfbdcb2
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ScheduleGroupEventGuid Constant
A category GUID describing ETW events fired by the Concurrency Runtime that are directly related to schedule groups.  
  
## Syntax  
  
```  
const __declspec(selectany) GUID ScheduleGroupEventGuid = { 0xE8A3BF1F, 0xA86B, 0x4390, { 0x9C, 0x60, 0x53, 0x90, 0xB9, 0x69, 0xD2, 0x2C } };  
```  
  
## Remarks  
 This category of events is not currently fired by the Concurrency Runtime.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../VS_csharp/concurrency-namespace.md)   
 [ScheduleGroup Class](../VS_csharp/schedulegroup-class.md)