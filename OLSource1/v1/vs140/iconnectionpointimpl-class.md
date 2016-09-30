---
title: "IConnectionPointImpl Class"
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
  - "ATL.IConnectionPointImpl"
  - "IConnectionPointImpl"
  - "ATL::IConnectionPointImpl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "connection points [C++], implementing"
  - "IConnectionPointImpl class"
ms.assetid: 27992115-3b86-45dd-bc9e-54f32876c557
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IConnectionPointImpl Class
This class implements a connection point.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Your class, derived from <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 A pointer to the IID of the interface represented by the connection point object.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 A class that manages the connections. The default value is [CComDynamicUnkArray](../vs140/ccomdynamicunkarray-class.md), which allows unlimited connections. You can also use [CComUnkArray](../vs140/ccomunkarray-class.md), which specifies a fixed number of connections.  
  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[IConnectionPointImpl::Advise](../vs140/iconnectionpointimpl--advise.md)|Establishes a connection between the connection point and a sink.|  
|[IConnectionPointImpl::EnumConnections](../vs140/iconnectionpointimpl--enumconnections.md)|Creates an enumerator to iterate through the connections for the connection point.|  
|[IConnectionPointImpl::GetConnectionInterface](../vs140/iconnectionpointimpl--getconnectioninterface.md)|Retrieves the IID of the interface represented by the connection point.|  
|[IConnectionPointImpl::GetConnectionPointContainer](../vs140/iconnectionpointimpl--getconnectionpointcontainer.md)|Retrieves an interface pointer to the connectable object.|  
|[IConnectionPointImpl::Unadvise](../vs140/iconnectionpointimpl--unadvise.md)|Terminates a connection previously established through <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[IConnectionPointImpl::m_vec](../vs140/iconnectionpointimpl--m_vec.md)|Manages the connections for the connection point.|  
  
## Remarks  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> implements a connection point, which allows an object to expose an outgoing interface to the client. The client implements this interface on an object called a sink.  
  
 ATL uses [IConnectionPointContainerImpl](../vs140/iconnectionpointcontainerimpl-class.md) to implement the connectable object. Each connection point within the connectable object represents an outgoing interface, identified by <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. Class  *CDV* manages the connections between the connection point and a sink. Each connection is uniquely identified by a "cookie."  
  
 For more information about using connection points in ATL, see the article [Connection Points](../vs140/atl-connection-points.md).  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlcom.h  
  
##  \<a name="iconnectionpointimpl__advise">\</a>  IConnectionPointImpl::Advise  
 Establishes a connection between the connection point and a sink.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 Use [Unadvise](../vs140/iconnectionpointimpl--unadvise.md) to terminate the connection call.  
  
 See [IConnectionPoint::Advise](http://msdn.microsoft.com/library/windows/desktop/ms678815) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="iconnectionpointimpl__enumconnections">\</a>  IConnectionPointImpl::EnumConnections  
 Creates an enumerator to iterate through the connections for the connection point.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 See [IConnectionPoint::EnumConnections](http://msdn.microsoft.com/library/windows/desktop/ms680755) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="iconnectionpointimpl__getconnectioninterface">\</a>  IConnectionPointImpl::GetConnectionInterface  
 Retrieves the IID of the interface represented by the connection point.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 See [IConnectionPoint::GetConnectionInterface](http://msdn.microsoft.com/library/windows/desktop/ms693468) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="iconnectionpointimpl__getconnectionpointcontainer">\</a>  IConnectionPointImpl::GetConnectionPointContainer  
 Retrieves an interface pointer to the connectable object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 See [IConnectionPoint::GetConnectionPointContainer](http://msdn.microsoft.com/library/windows/desktop/ms679669) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="iconnectionpointimpl__m_vec">\</a>  IConnectionPointImpl::m_vec  
 Manages the connections between the connection point object and a sink.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 By default, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is of type [CComDynamicUnkArray](../vs140/ccomdynamicunkarray-class.md).  
  
##  \<a name="iconnectionpointimpl__unadvise">\</a>  IConnectionPointImpl::Unadvise  
 Terminates a connection previously established through [Advise](../vs140/iconnectionpointimpl--advise.md).  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Remarks  
 See [IConnectionPoint::Unadvise](http://msdn.microsoft.com/library/windows/desktop/ms686608) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## See Also  
 [IConnectionPoint](http://msdn.microsoft.com/library/windows/desktop/ms694318)   
 [Class Overview](../vs140/atl-class-overview.md)