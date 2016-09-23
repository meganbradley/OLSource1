---
title: "IRowsetNotifyImpl Class"
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
  - ATL.IRowsetNotifyImpl
  - ATL::IRowsetNotifyImpl
  - IRowsetNotifyImpl
dev_langs: 
  - C++
helpviewer_keywords: 
  - IRowsetNotifyImpl class
ms.assetid: fbfd0cb2-38ff-4b42-899a-8de902f834b8
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IRowsetNotifyImpl Class
Implements and registers [IRowsetNotify](https://msdn.microsoft.com/en-us/library/ms712959.aspx) on the consumer (also known as the "sink") so that it can handle notifications.  
  
## Syntax  
  
```  
class ATL_NO_VTABLE IRowsetNotifyImpl : public IRowsetNotify  
```  
  
## Members  
  
### Methods  
  
|||  
|-|-|  
|[OnFieldChange](../vs140/irowsetnotifyimpl--onfieldchange.md)|Notifies the consumer of any change to the value of a column.|  
|[OnRowChange](../vs140/irowsetnotifyimpl--onrowchange.md)|Notifies the consumer of the first change to a row or of any change that affects the entire row.|  
|[OnRowsetChange](../vs140/irowsetnotifyimpl--onrowsetchange.md)|Notifies the consumer of any change affecting the entire rowset.|  
  
## Remarks  
 See [Receiving Notifications](../vs140/receiving-notifications.md) about implementing the connection point interface on the consumer.  
  
 `IRowsetNotifyImpl` provides a dummy implementation for `IRowsetNotify`, with empty functions for the `IRowsetNotify` methods [OnFieldChange](https://msdn.microsoft.com/en-us/library/ms715961.aspx), [OnRowChange](https://msdn.microsoft.com/en-us/library/ms722694.aspx), and [OnRowsetChange](https://msdn.microsoft.com/en-us/library/ms722669.aspx). If you inherit from this class when you implement an `IRowsetNotify` interface, you can implement only the methods you need. You also need to provide empty implementations for the other methods yourself.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [OLE DB Consumer Templates](../vs140/ole-db-consumer-templates--c---.md)   
 [OLE DB Consumer Templates](../vs140/ole-db-consumer-templates--c---.md)   
 [IRowsetNotify](https://msdn.microsoft.com/en-us/library/ms712959.aspx)   
 [IRowsetNotifyCP Class](../vs140/irowsetnotifycp-class.md)