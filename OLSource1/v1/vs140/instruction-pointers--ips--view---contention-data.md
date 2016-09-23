---
title: "Instruction Pointers (IPs) View - Contention Data"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
helpviewer_keywords: 
  - Instruction Pointers view
ms.assetid: f5e49c24-d4cf-4f87-977d-37e3223d1196
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Instruction Pointers (IPs) View - Contention Data
The IPs view of contention data lists data for the assembly instructions that were blocked from executing in the profiling run.  
  
 The following table explains the values of the columns in the Instruction Pointers view.  
  
|Column|Description|  
|------------|-----------------|  
|**Exclusive Blocked Time**|The blocked time in this function.|  
|**Exclusive Blocked Time %**|The percentage of blocked time while the instruction was executed.|  
|**Exclusive Contentions**|The number of contentions that occurred while the instruction was executed.|  
|**Exclusive Contentions %**|The percentage of all contentions in the profiling run that occurred while the instruction was executed.|  
|**Function Address**|The starting memory address of the function in the loaded binary.|  
|**Function Name**|The name of the function that contains the instruction.|  
|**Instruction Address**|The memory address of the instruction in the loaded binary.|  
|**Function Line Number**|The line number of the start of this function in the source file.|  
|**Module Name**|The name of the module that contains the instruction.|  
|**Module Path**|The path of the module that contains the instruction.|  
|**Process ID**|The process ID (PID) of the profiled process.|  
|**Process Name**|The name of the process.|  
|**Source Character Begin**|The offset of the character in the source file line at which this instruction starts.|  
|**Source Character End**|The offset of the character in the source file line at which this instruction ends.|  
|**Source File**|The source file that contains the instruction.|  
|**Source Line Begin**|The line number in the source file at which this instruction starts.|  
|**Source Line End**|The line number in the source file at which this instruction ends.|  
  
## See Also  
 [How to: Customize Profiling Tools Report Views](../vs140/how-to--customize-report-view-columns.md)   
 [Instruction Pointers (IPs) View](../vs140/instruction-pointers--ips--view.md)   
 [Instruction Pointers (IPs) View - Profiler .NET Memory Sampling Data](../vs140/instruction-pointers--ips--view---.net-memory-sampling-data.md)   
 [Instruction Pointers (IPs) View - Profiler Sampling Data](../vs140/instruction-pointers--ips--view---sampling-data.md)