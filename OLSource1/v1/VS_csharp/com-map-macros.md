---
title: "COM Map Macros"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COM interfaces, COM map macros"
ms.assetid: 0f33656d-321f-4996-90cc-9a7f21ab73c3
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COM Map Macros
These macros define COM interface maps.  
  
|||  
|-|-|  
|[BEGIN_COM_MAP](../VS_csharp/begin_com_map.md)|Marks the beginning of the COM interface map entries.|  
|[COM_INTERFACE_ENTRY](../VS_csharp/com_interface_entry-macros.md)|Enters interfaces into the COM interface map.|  
|[COM_INTERFACE_ENTRY2](../VS_csharp/com_interface_entry2.md)|Use this macro to disambiguate two branches of inheritance.|  
|[COM_INTERFACE_ENTRY_IID](../VS_csharp/com_interface_entry_iid.md)|Use this macro to enter the interface into the COM map and specify its IID.|  
|[COM_INTERFACE_ENTRY2_IID](../VS_csharp/com_interface_entry2_iid.md)|Same as [COM_INTERFACE_ENTRY2](../VS_csharp/com_interface_entry2.md), except you can specify a different IID.|  
|[COM_INTERFACE_ENTRY_AGGREGATE](../VS_csharp/com_interface_entry_aggregate.md)|When the interface identified by `iid` is queried for, `COM_INTERFACE_ENTRY_AGGREGATE` forwards to `punk`.|  
|[COM_INTERFACE_ENTRY_AGGREGATE_BLIND](../VS_csharp/com_interface_entry_aggregate_blind.md)|Same as [COM_INTERFACE_ENTRY_AGGREGATE](../VS_csharp/com_interface_entry_aggregate.md), except that querying for any IID results in forwarding the query to `punk`.|  
|[COM_INTERFACE_ENTRY_AUTOAGGREGATE](../VS_csharp/com_interface_entry_autoaggregate.md)|Same as [COM_INTERFACE_ENTRY_AGGREGATE](../VS_csharp/com_interface_entry_aggregate.md), except if `punk` is **NULL**, it automatically creates the aggregate described by the `clsid`.|  
|[COM_INTERFACE_ENTRY_AUTOAGGREGATE_BLIND](../VS_csharp/com_interface_entry_autoaggregate_blind.md)|Same as [COM_INTERFACE_ENTRY_AUTOAGGREGATE](../VS_csharp/com_interface_entry_autoaggregate.md), except that querying for any IID results in forwarding the query to `punk`, and if `punk` is **NULL**, automatically creating the aggregate described by the `clsid`.|  
|[COM_INTERFACE_ENTRY_BREAK](../VS_csharp/com_interface_entry_break.md)|Causes your program to call [DebugBreak](http://msdn.microsoft.com/library/windows/desktop/ms679297) when the specified interface is queried for.|  
|[COM_INTERFACE_ENTRY_CACHED_TEAR_OFF](../VS_csharp/com_interface_entry_cached_tear_off.md)|Saves the interface-specific data for every instance.|  
|[COM_INTERFACE_ENTRY_TEAR_OFF](../VS_csharp/com_interface_entry_tear_off.md)|Exposes your tear-off interfaces.|  
|[COM_INTERFACE_ENTRY_CHAIN](../VS_csharp/com_interface_entry_chain.md)|Processes the COM map of the base class when the processing reaches this entry in the COM map.|  
|[COM_INTERFACE_ENTRY_FUNC](../VS_csharp/com_interface_entry_func.md)|A general mechanism for hooking into ATL's `QueryInterface` logic.|  
|[COM_INTERFACE_ENTRY_FUNC_BLIND](../VS_csharp/com_interface_entry_func_blind.md)|Same as [COM_INTERFACE_ENTRY_FUNC](../VS_csharp/com_interface_entry_func.md), except that querying for any IID results in a call to `func`.|  
|[COM_INTERFACE_ENTRY_NOINTERFACE](../VS_csharp/com_interface_entry_nointerface.md)|Returns **E_NOINTERFACE** and terminates COM map processing when the specified interface is queried for.|  
|[END_COM_MAP](../VS_csharp/end_com_map.md)|Marks the end of the COM interface map entries.|  
  
## See Also  
 [Macros](../VS_csharp/atl-macros.md)   
 [COM Map Global Functions](../VS_csharp/com-map-global-functions.md)