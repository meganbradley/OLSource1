---
title: "Supporting Notifications"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "notifications [C++], OLE DB consumers"
  - "events [C++], notifications in OLE DB"
  - "OLE DB consumers, notifications"
  - "rowsets, event notifications"
  - "OLE DB provider templates, notifications"
  - "OLE DB providers, notifications"
ms.assetid: 76e875fd-2bfd-4e4e-9f43-dbe5a3fa7382
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Supporting Notifications
## Implementing Connection Point Interfaces on the Provider and Consumer  
 To implement notifications, a provider class must inherit from [IRowsetNotifyCP](../vs140/irowsetnotifycp-class.md) and [IConnectionPointContainer](../vs140/iconnectionpointcontainerimpl-class.md).  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> implements the provider site for the connection point interface [IRowsetNotify](https://msdn.microsoft.com/en-us/library/ms712959.aspx). <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> implements broadcast functions to advise listeners on the connection point **IID_IRowsetNotify** of changes to the contents of the rowset.  
  
 Note that you must also implement and register <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> on the consumer (also known as the sink) using [IRowsetNotifyImpl](../vs140/irowsetnotifyimpl-class.md) so that the consumer can handle notifications. For information about implementing the connection point interface on the consumer, see [Receiving Notifications](../vs140/receiving-notifications.md).  
  
 In addition, the class must also contain a map that defines the connection point entry, like this:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Adding IRowsetNotify  
 To add <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, you need to add <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to your inheritance chain.  
  
 For example, here is the inheritance chain for <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> in [UpdatePV](assetId:///c8bed873-223c-4a7d-af55-f90138c6f38f):  
  
> [!NOTE]
>  The sample code might differ from what is listed here; you should regard the sample code as the more up-to-date version.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Setting COM Map Entries  
 You also need to add the following to the COM map in your rowset:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 These macros allow anyone calling <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> for your connection point container (the basis of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>) to find the requested interface on your provider. For an example of how to use connection points, see the ATL POLYGON sample and tutorial.  
  
### Setting Connection Point Map Entries  
 You also need to add a connection point map. It should look something like:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 This connection point map allows a component looking for the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> interface to find it in your provider.  
  
### Setting Properties  
 You also need to add the following properties to your provider. You only need to add properties based on the interfaces that you support.  
  
|Property|Add if you support|  
|--------------|------------------------|  
|**DBPROP_IConnectionPointContainer**|Always|  
|**DBPROP_NOTIFICATIONGRANULARITY**|Always|  
|**DBPROP_NOTIFICATIONPHASES**|Always|  
|**DBPROP_NOTIFYCOLUMNSET**|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|  
|**DBPROP_NOTIFYROWDELETE**|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|  
|**DBPROP_NOTIFYROWINSERT**|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|  
|**DBPROP_NOTIFYROWSETFETCHPOSITIONCHANGE**|Always|  
|**DBPROP_NOTIFYROWFIRSTCHANGE**|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|  
|**DBPROP_NOTIFYROWSETRELEASE**|Always|  
|**DBPROP_NOTIFYROWUNDOCHANGE**|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|  
|**DBPROP_NOTIFYROWUNDODELETE**|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|  
|**DBPROP_NOTIFYROWUNDOINSERT**|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|  
|**DBPROP_NOTIFYROWUPDATE**|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|  
  
 Most of the implementation for the notifications is already embedded in the OLE DB Provider Templates. Due to a compiler feature in Visual C++ .NET, if you do not add <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> to your inheritance chain, the compiler removes all that code from your compilation stream, thus making your code size smaller.  
  
## See Also  
 [Advanced Provider Techniques](../vs140/advanced-provider-techniques.md)