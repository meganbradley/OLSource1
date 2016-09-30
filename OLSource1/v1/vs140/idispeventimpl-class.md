---
title: "IDispEventImpl Class"
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
  - "IDispEventImpl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDispEventImpl class"
ms.assetid: a64b5288-35cb-4638-aad6-2d15b1c7cf7b
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDispEventImpl Class
This class provides implementations of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> methods.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 A unique identifier for the source object. When <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is the base class for a composite control, use the resource ID of the desired contained control for this parameter. In other cases, use an arbitrary positive integer.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 The user's class, which is derived from <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 The pointer to the IID of the event dispinterface implemented by this class. This interface must be defined in the type library denoted by <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 A pointer to the type library that defines the dispatch interface pointed to by <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. If **&GUID_NULL**, the type library will be loaded from the object sourcing the events.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 The major version of the type library. The default value is 0.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 The minor version of the type library. The default value is 0.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 The class used to manage the type information for <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. The default value is a class of type <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>; however, you can override this template parameter by providing a class of a type other than <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|[IDispEventImpl::_tihclass](../vs140/idispeventimpl-class.md)|The class used to manage the type information. By default, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.|  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[IDispEventImpl::IDispEventImpl](../vs140/idispeventimpl--idispeventimpl.md)|The constructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[IDispEventImpl::GetFuncInfoFromId](../vs140/idispeventimpl--getfuncinfofromid.md)|Locates the function index for the specified dispatch identifier.|  
|[IDispEventImpl::GetIDsOfNames](../vs140/idispeventimpl--getidsofnames.md)|Maps a single member and an optional set of argument names to a corresponding set of integer DISPIDs.|  
|[IDispEventImpl::GetTypeInfo](../vs140/idispeventimpl--gettypeinfo.md)|Retrieves the type information for an object.|  
|[IDispEventImpl::GetTypeInfoCount](../vs140/idispeventimpl--gettypeinfocount.md)|Retrieves the number of type information interfaces.|  
|[IDispEventImpl::GetUserDefinedType](../vs140/idispeventimpl--getuserdefinedtype.md)|Retrieves the basic type of a user-defined type.|  
  
## Remarks  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> provides a way of implementing an event dispinterface without requiring you to supply implementation code for every method/event on that interface. <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> provides implementations of the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> methods. You only need to supply implementations for the events that you are interested in handling.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> works in conjunction with the [event sink map](../vs140/begin_sink_map.md) in your class to route events to the appropriate handler function. To use this class:  
  
 Add a [SINK_ENTRY](../vs140/sink_entry.md) or [SINK_ENTRY_EX](../vs140/sink_entry_ex.md) macro to the event sink map for each event on each object that you want to handle. When using <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> as a base class of a composite control, you can call [AtlAdviseSinkMap](../vs140/atladvisesinkmap.md) to establish and break the connection with the event sources for all entries in the event sink map. In other cases, or for greater control, call [DispEventAdvise](../vs140/idispeventsimpleimpl--dispeventadvise.md) to establish the connection between the source object and the base class. Call [DispEventUnadvise](../vs140/idispeventsimpleimpl--dispeventunadvise.md) to break the connection.  
  
 You must derive from <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> (using a unique value for <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>) for each object for which you need to handle events. You can reuse the base class by unadvising against one source object then advising against a different source object, but the maximum number of source objects that can be handled by a single object at one time is limited by the number of <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> base classes.  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> provides the same functionality as [IDispEventSimpleImpl](../vs140/idispeventsimpleimpl-class.md), except it gets type information about the interface from a type library rather than having it supplied as a pointer to an [_ATL_FUNC_INFO](../vs140/_atl_func_info-structure.md) structure. Use <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> when you do not have a type library describing the event interface or want to avoid the overhead associated with using the type library.  
  
> [!NOTE]
>  <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> provide their own implementation of **IUnknown::QueryInterface** enabling each <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> base class to act as a separate COM identity while still allowing direct access to class members in your main COM object.  
  
 CE ATL implementation of ActiveX event sinks only supports return values of type HRESULT or void from your event handler methods; any other return value is unsupported and its behavior is undefined.  
  
 For more information, see [Supporting IDispEventImpl](../vs140/supporting-idispeventimpl.md).  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
  
 [IDispEventSimpleImpl](../vs140/idispeventsimpleimpl-class.md)  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlcom.h  
  
##  \<a name="idispeventimpl__getfuncinfofromid">\</a>  IDispEventImpl::GetFuncInfoFromId  
 Locates the function index for the specified dispatch identifier.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 [in] A reference to the ID of the function.  
  
 *dispidMember*  
 [in] The dispatch ID of the function.  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 [in] The locale context of the function ID.  
  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 [in] The structure indicating how the function is called.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> value.  
  
##  \<a name="idispeventimpl__getidsofnames">\</a>  IDispEventImpl::GetIDsOfNames  
 Maps a single member and an optional set of argument names to a corresponding set of integer DISPIDs, which can be used on subsequent calls to [IDispatch::Invoke](assetId:///964ade8e-9d8a-4d32-bd47-aa678912a54d).  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 See [IDispatch::GetIDsOfNames](assetId:///6f6cf233-3481-436e-8d6a-51f93bf91619) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="idispeventimpl__gettypeinfo">\</a>  IDispEventImpl::GetTypeInfo  
 Retrieves the type information for an object, which can then be used to get the type information for an interface.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="idispeventimpl__gettypeinfocount">\</a>  IDispEventImpl::GetTypeInfoCount  
 Retrieves the number of type information interfaces that an object provides (either 0 or 1).  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 See [IDispatch::GetTypeInfoCount](assetId:///da876d53-cb8a-465c-a43e-c0eb272e2a12) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="idispeventimpl__getuserdefinedtype">\</a>  IDispEventImpl::GetUserDefinedType  
 Retrieves the basic type of a user-defined type.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 [in] A pointer to the [ITypeInfo](assetId:///f3356463-3373-4279-bae1-953378aa2680) interface containing the user-defined type.  
  
 *hrt*  
 [in] A handle to the type description to be retrieved.  
  
### Return Value  
 The type of variant.  
  
### Remarks  
 See [ITypeInfo::GetRefTypeInfo](assetId:///61d3b31d-6591-4e55-9e82-5246a168be00).  
  
##  \<a name="idispeventimpl__idispeventimpl">\</a>  IDispEventImpl::IDispEventImpl  
 The constructor. Stores the values of the class template parameters <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
##  \<a name="idispeventimpl__tihclass">\</a>  IDispEventImpl::tihclass  
 This typedef is an instance of the class template parameter <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Remarks  
 By default, the class is <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> manages the type information for the class.  
  
## See Also  
 [_ATL_FUNC_INFO Structure](../vs140/_atl_func_info-structure.md)   
 [IDispatchImpl Class](../vs140/idispatchimpl-class.md)   
 [IDispEventSimpleImpl Class](../vs140/idispeventsimpleimpl-class.md)   
 [SINK_ENTRY](../vs140/sink_entry.md)   
 [SINK_ENTRY_EX](../vs140/sink_entry_ex.md)   
 [SINK_ENTRY_INFO](../vs140/sink_entry_info.md)   
 [Class Overview](../vs140/atl-class-overview.md)