---
title: "IRowsetNotifyCP Class"
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
  - "IRowsetNotifyCP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IRowsetNotifyCP class"
ms.assetid: ccef402b-94a0-4c2e-9a13-7e854ef82390
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IRowsetNotifyCP Class
Implements the provider site for the connection point interface [IRowsetNotify](https://msdn.microsoft.com/en-us/library/ms712959.aspx).  
  
## Syntax  
  
```  
template <  
   class T,   
   class ReentrantEventSync = CComSharedMutex   
>  
class IRowsetNotifyCP :   
   public IConnectionPointImpl<  
      T,   
      piid = &__uuidof(IRowsetNotify),   
      CComDynamicUnkArray DynamicUnkArray  
   >,  
   public ReentrantEventSync  
```  
  
#### Parameters  
 `T`  
 A class derived from `IRowsetNotifyCP`.  
  
 `ReentrantEventSync`  
 A mutex class that supports reentrancy (the default is **CComSharedMutex**). A mutex is a synchronization object that allows one thread mutually exclusive access to a resource.  
  
 `piid`  
 A interface ID pointer (**IID\***) for an **IRowsetNotify** connection point interface. The default value is **&__uuidof(IRowsetNotify)**.  
  
 `DynamicUnkArray`  
 An array of type [CComDynamicUnkArray](../VS_csharp/ccomdynamicunkarray-class.md), which is a dynamically allocated array of **IUnknown** pointers to the client sink interfaces.  
  
## Members  
  
### Methods  
  
|||  
|-|-|  
|[Fire_OnFieldChange](../VS_csharp/irowsetnotifycp--fire_onfieldchange.md)|Notifies the consumer of a change to the value of a column.|  
|[Fire_OnRowChange](../VS_csharp/irowsetnotifycp--fire_onrowchange.md)|Notifies the consumer of a change affecting the rows.|  
|[Fire_OnRowsetChange](../VS_csharp/irowsetnotifycp--fire_onrowsetchange.md)|Notifies the consumer of a change affecting the entire rowset.|  
  
## Remarks  
 `IRowsetNotifyCP` implements broadcast functions to advise listeners on the connection point **IID_IRowsetNotify** of changes to the contents of the rowset.  
  
 Note that you must also implement and register `IRowsetNotify` on the consumer (also known as the "sink") using [IRowsetNotifyImpl](../VS_csharp/irowsetnotifyimpl-class.md) so that the consumer can handle notifications. See [Receiving Notifications](../VS_csharp/receiving-notifications.md) about implementing the connection point interface on the consumer.  
  
 For detailed information on implementing notifications, see "Supporting Notifications" in [Creating an Updatable Provider](../VS_csharp/creating-an-updatable-provider.md).  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [OLE DB Provider Templates](../VS_csharp/ole-db-provider-templates--c---.md)   
 [OLE DB Provider Template Architecture](../VS_csharp/ole-db-provider-template-architecture.md)   
 [Notifications (COM)](http://msdn.microsoft.com/library/windows/desktop/ms678433)   
 [Overview of Notifications (OLE DB)](https://msdn.microsoft.com/en-us/library/ms725406.aspx)   
 [BEGIN_CONNECTION_POINT_MAP](../VS_csharp/begin_connection_point_map.md)   
 [END_CONNECTION_POINT_MAP](../VS_csharp/end_connection_point_map.md)   
 [CONNECTION_POINT_ENTRY](../VS_csharp/connection_point_entry.md)   
 [Creating an Updatable Provider](../VS_csharp/creating-an-updatable-provider.md)