---
title: "CConnectionPoint Class"
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
  - "CConnectionPoint"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CConnectionPoint class"
ms.assetid: f0f23a1e-5e8c-41a9-aa6c-1a4793b28e8f
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CConnectionPoint Class
Defines a special type of interface used to communicate with other OLE objects, called a "connection point."  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CConnectionPoint::CConnectionPoint](#cconnectionpoint__cconnectionpoint)|Constructs a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CConnectionPoint::GetConnections](#cconnectionpoint__getconnections)|Retrieves all connection points in a connection map.|  
|[CConnectionPoint::GetContainer](#cconnectionpoint__getcontainer)|Retrieves the container of the control that owns the connection map.|  
|[CConnectionPoint::GetIID](#cconnectionpoint__getiid)|Retrieves the interface ID of a connection point.|  
|[CConnectionPoint::GetMaxConnections](#cconnectionpoint__getmaxconnections)|Retrieves the maximum number of connection points supported by a control.|  
|[CConnectionPoint::GetNextConnection](#cconnectionpoint__getnextconnection)|Retrieves a pointer to the connection element at <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.|  
|[CConnectionPoint::GetStartPosition](#cconnectionpoint__getstartposition)|Starts a map iteration by returning a **POSITION** value that can be passed to a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> call.|  
|[CConnectionPoint::OnAdvise](#cconnectionpoint__onadvise)|Called by the framework when establishing or breaking connections.|  
|[CConnectionPoint::QuerySinkInterface](#cconnectionpoint__querysinkinterface)|Retrieves a pointer to the requested sink interface.|  
  
## Remarks  
 Unlike normal OLE interfaces, which are used to implement and expose the functionality of an OLE control, a connection point implements an outgoing interface that is able to initiate actions on other objects, such as firing events and change notifications.  
  
 A connection consists of two parts: the object calling the interface, called the "source," and the object implementing the interface, called the "sink." By exposing a connection point, a source allows sinks to establish connections to itself. Through the connection point mechanism, a source object obtains a pointer to the sink's implementation of a set of member functions. For example, to fire an event implemented by the sink, the source can call the appropriate method of the sink's implementation.  
  
 By default, a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>-derived class implements two connection points: one for events and one for property change notifications. These connections are used, respectively, for event firing and for notifying a sink (for example, the control's container) when a property value has changed. Support is also provided for OLE controls to implement additional connection points. For each additional connection point implemented in your control class, you must declare a "connection part" that implements the connection point. If you implement one or more connection points, you also need to declare a single "connection map" in your control class.  
  
 The following example demonstrates a simple connection map and one connection point for the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> OLE control, consisting of two fragments of code: the first portion declares the connection map and point; the second implements this map and point. The first fragment is inserted into the declaration of the control class, under the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> section:  
  
 [!code[NVC_MFCConnectionPoints#7](../vs140/codesnippet/CPP/cconnectionpoint-class_1.h)]  
  
 The <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> macros declare an embedded class, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> (derived from <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>) that implements this particular connection point. If you want to override any <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> member functions, or add member functions of your own, declare them between these two macros. For example, the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> macro overrides the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> member function when placed between these two macros.  
  
 The second code fragment is inserted into the implementation file (.CPP) of your control class. This code implements the connection map, which includes the additional connection point, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>:  
  
 [!code[NVC_MFCConnectionPoints#2](../vs140/codesnippet/CPP/cconnectionpoint-class_2.cpp)]  
  
 Once these code fragments have been inserted, the Sample OLE control exposes a connection point for the **ISampleSink** interface.  
  
 Typically, connection points support "multicasting", which is the ability to broadcast to multiple sinks connected to the same interface. The following code fragment demonstrates how to accomplish multicasting by iterating through each sink on a connection point:  
  
 [!code[NVC_MFCConnectionPoints#4](../vs140/codesnippet/CPP/cconnectionpoint-class_3.cpp)]  
  
 This example retrieves the current set of connections on the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> connection point with a call to <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>. It then iterates through the connections and calls <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> on every active connection.  
  
 For more information on using <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, see the article [Connection Points](../vs140/connection-points.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxdisp.h  
  
##  \<a name="cconnectionpoint__cconnectionpoint">\</a>  CConnectionPoint::CConnectionPoint  
 Constructs a <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="cconnectionpoint__getconnections">\</a>  CConnectionPoint::GetConnections  
 Call this function to retrieve all active connections for a connection point.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to an array of active connections (sinks). Some of the pointers in the array may be NULL. Each non-NULL pointer in this array can be safely converted to a pointer to the sink interface using a cast operator.  
  
##  \<a name="cconnectionpoint__getcontainer">\</a>  CConnectionPoint::GetContainer  
 Called by the framework to retrieve the **IConnectionPointContainer** for the connection point.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 If successful, a pointer to the container; otherwise **NULL**.  
  
### Remarks  
 This function is typically implemented by the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> macro.  
  
##  \<a name="cconnectionpoint__getiid">\</a>  CConnectionPoint::GetIID  
 Called by the framework to retrieve the interface ID of a connection point.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 A reference to the connection point's interface ID.  
  
### Remarks  
 Override this function to return the interface ID for this connection point.  
  
##  \<a name="cconnectionpoint__getmaxconnections">\</a>  CConnectionPoint::GetMaxConnections  
 Called by the framework to retrieve the maximum number of connections supported by the connection point.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 The maximum number of connections supported by the control, or -1 if no limit.  
  
### Remarks  
 The default implementation returns -1, indicating no limit.  
  
 Override this function if you want to limit the number of sinks that can connect to your control.  
  
##  \<a name="cconnectionpoint__getnextconnection">\</a>  CConnectionPoint::GetNextConnection  
 Retrieves a pointer to the connection element at <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 Specifies a reference to a **POSITION** value returned by a previous <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> or [GetStartPosition](#cconnectionpoint__getstartposition) call.  
  
### Return Value  
 A pointer to the connection element specified by <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, or NULL.  
  
### Remarks  
 This function is most useful for iterating through all the elements in the connection map. When iterating, skip any NULLs returned from this function.  
  
### Example  
 [!code[NVC_MFCConnectionPoints#4](../vs140/codesnippet/CPP/cconnectionpoint-class_3.cpp)]  
  
##  \<a name="cconnectionpoint__getstartposition">\</a>  CConnectionPoint::GetStartPosition  
 Starts a map iteration by returning a **POSITION** value that can be passed to a [GetNextConnection](#cconnectionpoint__getnextconnection) call.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 A **POSITION** value that indicates a starting position for iterating the map; or **NULL** if the map is empty.  
  
### Remarks  
 The iteration sequence is not predictable; therefore, the "first element in the map" has no special significance.  
  
### Example  
  See the example for [CConnectionPoint::GetNextConnection](#cconnectionpoint__getnextconnection).  
  
##  \<a name="cconnectionpoint__onadvise">\</a>  CConnectionPoint::OnAdvise  
 Called by the framework when a connection is being established or broken.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 **TRUE**, if a connection is being established; otherwise **FALSE**.  
  
### Remarks  
 The default implementation does nothing.  
  
 Override this function if you want notification when sinks connect to or disconnect from your connection point.  
  
##  \<a name="cconnectionpoint__querysinkinterface">\</a>  CConnectionPoint::QuerySinkInterface  
 Retrieves a pointer to the requested sink interface.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 The identifier of the sink interface being requested.  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 A pointer to the interface pointer identified by <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>. If the object does not support this interface, \* <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> is set to **NULL**.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> value.  
  
## See Also  
 [Base Class](../vs140/ccmdtarget-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)