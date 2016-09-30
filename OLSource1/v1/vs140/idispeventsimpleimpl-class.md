---
title: "IDispEventSimpleImpl Class"
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
  - "IDispEventSimpleImpl"
  - "ATL::IDispEventSimpleImpl"
  - "ATL.IDispEventSimpleImpl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDispEventSimpleImpl class"
ms.assetid: 971d82b7-a921-47fa-a4d8-909bed377ab0
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDispEventSimpleImpl Class
This class provides implementations of the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> methods, without getting type information from a type library.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 A unique identifier for the source object. When <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is the base class for a composite control, use the resource ID of the desired contained control for this parameter. In other cases, use an arbitrary positive integer.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 The user's class, which is derived from <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 The pointer to the IID of the event dispinterface implemented by this class.  
  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[IDispEventSimpleImpl::Advise](../vs140/idispeventsimpleimpl--advise.md)|Establishes a connection with the default event source.|  
|[IDispEventSimpleImpl::DispEventAdvise](../vs140/idispeventsimpleimpl--dispeventadvise.md)|Establishes a connection with the event source.|  
|[IDispEventSimpleImpl::DispEventUnadvise](../vs140/idispeventsimpleimpl--dispeventunadvise.md)|Breaks the connection with the event source.|  
|[IDispEventSimpleImpl::GetIDsOfNames](../vs140/idispeventsimpleimpl--getidsofnames.md)|Returns **E_NOTIMPL**.|  
|[IDispEventSimpleImpl::GetTypeInfo](../vs140/idispeventsimpleimpl--gettypeinfo.md)|Returns **E_NOTIMPL**.|  
|[IDispEventSimpleImpl::GetTypeInfoCount](../vs140/idispeventsimpleimpl--gettypeinfocount.md)|Returns **E_NOTIMPL**.|  
|[IDispEventSimpleImpl::Invoke](../vs140/idispeventsimpleimpl--invoke.md)|Calls the event handlers listed in the event sink map.|  
|[IDispEventSimpleImpl::Unadvise](../vs140/idispeventsimpleimpl--unadvise.md)|Breaks the connection with the default event source.|  
  
## Remarks  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> provides a way of implementing an event dispinterface without requiring you to supply implementation code for every method/event on that interface. <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> provides implementations of the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> methods. You only need to supply implementations for the events that you are interested in handling.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> works in conjunction with the [event sink map](../vs140/begin_sink_map.md) in your class to route events to the appropriate handler function. To use this class:  
  
-   Add a [SINK_ENTRY_INFO](../vs140/sink_entry_info.md) macro to the event sink map for each event on each object that you want to handle.  
  
-   Supply type information for each event by passing a pointer to an [_ATL_FUNC_INFO](../vs140/_atl_func_info-structure.md) structure as a parameter to each entry. On the x86 platform, the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> value must be CC_CDECL with the callback function calling method of __stdcall.  
  
-   Call [DispEventAdvise](../vs140/idispeventsimpleimpl--dispeventadvise.md) to establish the connection between the source object and the base class.  
  
-   Call [DispEventUnadvise](../vs140/idispeventsimpleimpl--dispeventunadvise.md) to break the connection.  
  
 You must derive from <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> (using a unique value for <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>) for each object for which you need to handle events. You can reuse the base class by unadvising against one source object then advising against a different source object, but the maximum number of source objects that can be handled by a single object at one time is limited by the number of <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> base classes.  
  
 **IDispEventSimplImpl** provides the same functionality as [IDispEventImpl](../vs140/idispeventimpl-class.md), except it does not get type information about the interface from a type library. The wizards generate code based only on <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, but you can use <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> by adding the code by hand. Use <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> when you don't have a type library describing the event interface or want to avoid the overhead associated with using the type library.  
  
> [!NOTE]
>  <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> provide their own implementation of **IUnknown::QueryInterface** enabling each <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> base class to act as a separate COM identity while still allowing direct access to class members in your main COM object.  
  
 CE ATL implementation of ActiveX event sinks only supports return values of type HRESULT or void from your event handler methods; any other return value is unsupported and its behavior is undefined.  
  
 For more information, see [Supporting IDispEventImpl](../vs140/supporting-idispeventimpl.md).  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlcom.h  
  
##  \<a name="idispeventsimpleimpl__advise">\</a>  IDispEventSimpleImpl::Advise  
 Call this method to establish a connection with the event source represented by *pUnk*.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 *pUnk*  
 [in] A pointer to the **IUnknown** interface of the event source object.  
  
### Return Value  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> or any failure <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> value.  
  
### Remarks  
 Once the connection is established, events fired from *pUnk* will be routed to handlers in your class by way of the event sink map.  
  
> [!NOTE]
>  If your class derives from multiple <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> classes, you will need to disambiguate calls to this method by scoping the call with the particular base class you are interested in.  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> establishes a connection with the default event source, it gets the IID of the default event source of the object as determined by [AtlGetObjectSourceInterface](../vs140/atlgetobjectsourceinterface.md).  
  
##  \<a name="idispeventsimpleimpl__dispeventadvise">\</a>  IDispEventSimpleImpl::DispEventAdvise  
 Call this method to establish a connection with the event source represented by *pUnk*.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 *pUnk*  
 [in] A pointer to the **IUnknown** interface of the event source object.  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 A pointer to the IID of the event source object.  
  
### Return Value  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> or any failure <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> value.  
  
### Remarks  
 Subsequently, events fired from *pUnk* will be routed to handlers in your class by way of the event sink map.  
  
> [!NOTE]
>  If your class derives from multiple <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> classes, you will need to disambiguate calls to this method by scoping the call with the particular base class you are interested in.  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> establishes a connection with the event source specified in <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>.  
  
##  \<a name="idispeventsimpleimpl__dispeventunadvise">\</a>  IDispEventSimpleImpl::DispEventUnadvise  
 Breaks the connection with the event source represented by *pUnk*.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 *pUnk*  
 [in] A pointer to the **IUnknown** interface of the event source object.  
  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 A pointer to the IID of the event source object.  
  
### Return Value  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> or any failure <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> value.  
  
### Remarks  
 Once the connection is broken, events will no longer be routed to the handler functions listed in the event sink map.  
  
> [!NOTE]
>  If your class derives from multiple <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> classes, you will need to disambiguate calls to this method by scoping the call with the particular base class you are interested in.  
  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> breaks a connection that was established with the event source specified in <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>.  
  
##  \<a name="idispeventsimpleimpl__getidsofnames">\</a>  IDispEventSimpleImpl::GetIDsOfNames  
 This implementation of **IDispatch::GetIDsOfNames** returns **E_NOTIMPL**.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 See [IDispatch::GetIDsOfNames](assetId:///6f6cf233-3481-436e-8d6a-51f93bf91619) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="idispeventsimpleimpl__gettypeinfo">\</a>  IDispEventSimpleImpl::GetTypeInfo  
 This implementation of **IDispatch::GetTypeInfo** returns **E_NOTIMPL**.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 See [IDispatch::GetTypeInfo](assetId:///cc1ec9aa-6c40-4e70-819c-a7c6dd6b8c99) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="idispeventsimpleimpl__gettypeinfocount">\</a>  IDispEventSimpleImpl::GetTypeInfoCount  
 This implementation of **IDispatch::GetTypeInfoCount** returns **E_NOTIMPL**.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Remarks  
 See [IDispatch::GetTypeInfoCount](assetId:///da876d53-cb8a-465c-a43e-c0eb272e2a12) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="idispeventsimpleimpl__invoke">\</a>  IDispEventSimpleImpl::Invoke  
 This implementation of **IDispatch::Invoke** calls the event handlers listed in the event sink map.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Remarks  
 See [IDispatch::Invoke](assetId:///964ade8e-9d8a-4d32-bd47-aa678912a54d).  
  
##  \<a name="idispeventsimpleimpl__unadvise">\</a>  IDispEventSimpleImpl::Unadvise  
 Breaks the connection with the event source represented by *pUnk*.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 *pUnk*  
 [in] A pointer to the **IUnknown** interface of the event source object.  
  
### Return Value  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> or any failure <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> value.  
  
### Remarks  
 Once the connection is broken, events will no longer be routed to the handler functions listed in the event sink map.  
  
> [!NOTE]
>  If your class derives from multiple <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> classes, you will need to disambiguate calls to this method by scoping the call with the particular base class you are interested in.  
  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> breaks a connection that was established with the default event source specified in <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>.  
  
 **Unavise** breaks a connection with the default event source, it gets the IID of the default event source of the object as determined by [AtlGetObjectSourceInterface](../vs140/atlgetobjectsourceinterface.md).  
  
## See Also  
 [_ATL_FUNC_INFO Structure](../vs140/_atl_func_info-structure.md)   
 [IDispatchImpl Class](../vs140/idispatchimpl-class.md)   
 [IDispEventImpl Class](../vs140/idispeventimpl-class.md)   
 [SINK_ENTRY_INFO](../vs140/sink_entry_info.md)   
 [Class Overview](../vs140/atl-class-overview.md)