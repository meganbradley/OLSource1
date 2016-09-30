---
title: "Implementing and Registering a Port Supplier"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "debugging [Debugging SDK], registering port suppliers"
  - "port suppliers, registering"
ms.assetid: fb057052-ee16-4272-8e16-a4da5dda0ad4
caps.latest.revision: 21
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Implementing and Registering a Port Supplier
The role of a port supplier is to track and supply ports, which in turn manage processes. At the time a port needs to be created, the port supplier is instantiated using CoCreate with the port supplier's GUID (the session debug manager [SDM] will use the port supplier the user selected or the port supplier specified by the project system). The SDM will then call [CanAddPort](../vs140/idebugportsupplier2--canaddport.md) to see if any ports can be added. If a port can be added, a new port is requested by calling [AddPort](../vs140/idebugportsupplier2--addport.md) and passing it an [IDebugPortRequest2](../vs140/idebugportrequest2.md) that describes the port. <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> will return a new port represented by an [IDebugPort2](../vs140/idebugport2.md) interface.  
  
## Discussion  
 A port is created by a port supplier, which is in turn associated with a machine or debug server. A server can enumerate its port suppliers through the[EnumPortSuppliers](../vs140/idebugcoreserver2--enumportsuppliers.md) method, and a port supplier can enumerate its ports through the [EnumPorts](../vs140/idebugportsupplier2--enumports.md) method.  
  
 In addition to the typical COM registration, a port supplier must register itself with Visual Studio by placing its CLSID and name in specific registry locations. A Debugging SDK helper function called <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> handles this chore: it is called once for each item to be registered, thus:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 A port supplier unregisters itself by calling <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> (another Debugging SDK helper function) once for each item that was registered, thus:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
> [!NOTE]
>  The [Debugging SDK Helpers](../vs140/sdk-helpers-for-debugging.md)<CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> are static functions defined in dbgmetric.h and compiled into ad2de.lib. The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> helpers are also defined in dbgmetric.h.  
  
 A port supplier can supply its name and GUID through the methods [GetPortSupplierName](../vs140/idebugportsupplier2--getportsuppliername.md) and [GetPortSupplierId](../vs140/idebugportsupplier2--getportsupplierid.md), respectively.  
  
## See Also  
 [Implementing a Port Supplier](../vs140/implementing-a-port-supplier.md)   
 [Debugging SDK Helpers](../vs140/sdk-helpers-for-debugging.md)   
 [Port Suppliers](../vs140/port-suppliers.md)