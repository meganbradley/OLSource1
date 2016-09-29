---
title: "ATL Macros Alphabetical Reference"
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
  - "macros, ATL"
ms.assetid: a272684a-9ce7-43cb-93af-a48279ef82ed
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ATL Macros Alphabetical Reference
In this section, reference topics for the ATL macros are organized alphabetically. To find a particular macro by category, see [ATL Macros](../VS_csharp/atl-macros.md).  
  
|Macro|Description|  
|-----------|-----------------|  
|[_ATL_ALL_WARNINGS](../VS_csharp/_atl_all_warnings.md)|A symbol which enables errors in projects converted from previous versions of ATL.|  
|[_ATL_APARTMENT_THREADED](../VS_csharp/_atl_apartment_threaded.md)|Define if one or more of your objects use apartment threading.|  
|[_ATL_CSTRING_EXPLICIT_CONSTRUCTORS](../VS_csharp/_atl_cstring_explicit_constructors.md)|Makes certain `CString` constructors explicit, preventing any unintentional conversions.|  
|[_ATL_DEBUG_INTERFACES](../VS_csharp/_atl_debug_interfaces.md)|Define this macro before including any ATL header files to trace all `AddRef` and **Release** calls on your components' interfaces to the output window.|  
|[_ATL_DEBUG_QI](../VS_csharp/_atl_debug_qi.md)|Writes all calls to `QueryInterface` to the output window.|  
|[_ATL_FREE_THREADED](../VS_csharp/_atl_free_threaded.md)|Define if one or more of your objects use free or neutral threading.|  
|[_ATL_MIXED](../VS_csharp/_atl_mixed.md)|Tells the compiler that your ATL application is comprised of native and **/clr** compilands.|  
|[_ATL_MULTI_THREADED](../VS_csharp/_atl_multi_threaded.md)|A symbol that indicates the project will have objects that are marked as Both, Free or Neutral. The macro [_ATL_FREE_THREADED](../VS_csharp/_atl_free_threaded.md) should be used in new code.|  
|[_ATL_NO_COM_SUPPORT](../VS_csharp/_atl_no_com_support.md)|A symbol which prevents COM-related code from being compiled with your project.|  
|[_ATL_NO_AUTOMATIC_NAMESPACE](../VS_csharp/_atl_no_automatic_namespace.md)|A symbol which prevents the default use of namespace as ATL.|  
|[_ATL_NO_VARIANT_THROW](../VS_csharp/_atl_no_variant_throw.md)|Suppresses the [CComVariant Class](../VS_csharp/ccomvariant-class.md) from throwing exceptions.|  
|[_ATL_SECURE_NO_WARNINGS](../VS_csharp/_atl_secure_no_warnings.md)|Suppresses compiler warnings for the use of deprecated ATL functions.|  
|[_ATL_STATIC_REGISTRY](../VS_csharp/_atl_static_registry.md)|A symbol that indicates you want the registration code for your object to be in the object to avoid a dependency on ATL.DLL.|  
|[_ATLCATCH](../VS_csharp/_atlcatch.md)|Statement(s) to handle errors occurring in the associated `_ATLTRY`|  
|[_ATLCATCHALL](../VS_csharp/_atlcatchall.md)|Statement(s) to handle errors occurring in the associated `_ATLTRY`.|  
|[_ATLTRY](../VS_csharp/_atltry.md)|Marks a guarded code section where an error could possibly occur.|  
|[ATL_ESC Flags](../VS_csharp/atl_esc-flags.md)|These flags are used to control the behavior of [EscapeXML](../VS_csharp/escapexml.md).|  
|[ALT_MSG_MAP](../VS_csharp/alt_msg_map.md)|Marks the beginning of an alternate message map.|  
|[ATL and MFC String Conversion Macros](../VS_csharp/atl-and-mfc-string-conversion-macros.md)|String conversion macros valid for both ATL and MFC.|  
|[ATLASSERT](../VS_csharp/atlassert.md)|The `ATLASSERT` macro performs the same functionality as the [_ASSERTE](../VS_csharp/_assert--_asserte--_assert_expr-macros.md) macro found in the C run-time library.|  
|[ATL_NOINLINE](../VS_csharp/atl_noinline.md)|A symbol that indicates a function should not be inlined.|  
|[ATL_NO_VTABLE](../VS_csharp/atl_no_vtable.md)|A symbol that prevents the vtable pointer from being initialized in the class's constructor and destructor.|  
|[ATL_URL Flags](../VS_csharp/atl_url-flags.md)|These flags modify the behavior of [AtlEscapeUrl](../VS_csharp/atlescapeurl.md) and [AtlCanonicalizeUrl](../VS_csharp/atlcanonicalizeurl.md).|  
|[ATL_URL_SCHEME](../VS_csharp/atl_url_scheme.md)|The members of this enumeration provide constants for the schemes understood by [CUrl](../VS_csharp/curl-class.md).|  
|[ATL_WORKER_THREAD_WAIT](../VS_csharp/atl_worker_thread_wait.md)|This macro defines the default value in milliseconds that [CWorkerThread::Shutdown](../Topic/CWorkerThread::Shutdown.md) will wait for the worker thread to shut down.|  
|[ATLS_DEFAULT_THREADPOOLSHUTDOWNTIMEOUT](../VS_csharp/atls_default_threadpoolshutdowntimeout.md)|This macro defines the default time in milliseconds that [CThreadPool](../VS_csharp/cthreadpool-class.md) will wait for a thread to shut down.|  
|[ATLS_DEFAULT_THREADSPERPROC](../VS_csharp/atls_default_threadsperproc.md)|This macro defines the default number of threads per processor used by [CThreadPool](../VS_csharp/cthreadpool-class.md).|  
|[ATLSMTP_QPENCODE Flags](../VS_csharp/atlsmtp_qpencode-flags.md)|These flags describe how quoted-printable encoding is to be performed by [QPEncode](../VS_csharp/qpencode.md).|  
|[ATLSMTP_UUENCODE Flags](../VS_csharp/atlsmtp_uuencode-flags.md)|These flags describe how uuencoding is to be performed by [UUEncode](../VS_csharp/uuencode.md).|  
|[ATLTRACE](../VS_csharp/atltrace--atl-.md)|Reports warnings to an output device, such as the debugger window, according to the indicated flags and levels. Included for backward compatibility.|  
|[ATLTRACE2](../VS_csharp/atltrace2.md)|Reports warnings to an output device, such as the debugger window, according to the indicated flags and levels.|  
|[ATLTRACENOTIMPL](../VS_csharp/atltracenotimpl.md)|In debug builds of ATL, sends the string "`funcname` is not implemented" to the dump device and returns **E_NOTIMPL**.|  
|[BEGIN_CATEGORY_MAP](../VS_csharp/begin_category_map.md)|Marks the beginning of the category map.|  
|[BEGIN_COM_MAP](../VS_csharp/begin_com_map.md)|The COM map is the mechanism that exposes interfaces on an object to a client through `QueryInterface`.|  
|[BEGIN_CONNECTION_POINT_MAP](../VS_csharp/begin_connection_point_map.md)|Marks the beginning of the connection point map entries.|  
|[BEGIN_EXTENSION_SNAPIN_NODEINFO_MAP](../VS_csharp/begin_extension_snapin_nodeinfo_map.md)|Marks the beginning of the snap-in extension data class map.|  
|[BEGIN_MSG_MAP](../VS_csharp/begin_msg_map.md)|Marks the beginning of the default message map.|  
|[BEGIN_PROP_MAP](../VS_csharp/begin_prop_map.md)|Marks the beginning of the object's property map.|  
|[BEGIN_RDX_MAP](../VS_csharp/begin_rdx_map.md)|Marks the beginning of the Registry Data Exchange map.|  
|[BEGIN_SERVICE_MAP](../VS_csharp/begin_service_map.md)|Marks the beginning of the service map.|  
|[BEGIN_SINK_MAP](../VS_csharp/begin_sink_map.md)|Declares the beginning of the event sink map for the composite control.|  
|[BEGIN_SNAPINTOOLBARID_MAP](../VS_csharp/begin_snapintoolbarid_map.md)|Declares the beginning of the toolbar ID map for the Snap-In object.|  
|[CHAIN_MSG_MAP](../VS_csharp/chain_msg_map.md)|Defines an entry in a message map.|  
|[CHAIN_MSG_MAP_ALT](../VS_csharp/chain_msg_map_alt.md)|Defines an entry in a message map.|  
|[CHAIN_MSG_MAP_ALT_MEMBER](../VS_csharp/chain_msg_map_alt_member.md)|Defines an entry in a message map.|  
|[CHAIN_MSG_MAP_DYNAMIC](../VS_csharp/chain_msg_map_dynamic.md)|Defines an entry in a message map.|  
|[CHAIN_MSG_MAP_MEMBER](../VS_csharp/chain_msg_map_member.md)|Defines an entry in a message map.|  
|[COM_INTERFACE_ENTRY Macros](../VS_csharp/com_interface_entry-macros.md)|These macros enter an object's interfaces into its COM map so that they can be accessed by `QueryInterface`.|  
|[COM_INTERFACE_ENTRY](../VS_csharp/com-interface-entry-points.md)|Enters interfaces into the COM interface map.|  
|[COM_INTERFACE_ENTRY2](../VS_csharp/com_interface_entry2.md)|Use this macro to disambiguate two branches of inheritance.|  
|[COM_INTERFACE_ENTRY2_IID](../VS_csharp/com_interface_entry2_iid.md)|Same as [COM_INTERFACE_ENTRY2](../VS_csharp/com_interface_entry2.md), except you can specify a different IID.|  
|[COM_INTERFACE_ENTRY_AGGREGATE](../VS_csharp/com_interface_entry_aggregate.md)|When the interface identified by `iid` is queried for, `COM_INTERFACE_ENTRY_AGGREGATE` forwards to `punk`.|  
|[COM_INTERFACE_ENTRY_AGGREGATE_BLIND](../VS_csharp/com_interface_entry_aggregate_blind.md)|Same as [COM_INTERFACE_ENTRY_AGGREGATE](../VS_csharp/com_interface_entry_aggregate.md), except that querying for any IID results in forwarding the query to `punk`.|  
|[COM_INTERFACE_ENTRY_AUTOAGGREGATE](../VS_csharp/com_interface_entry_autoaggregate.md)|Same as [COM_INTERFACE_ENTRY_AGGREGATE](../VS_csharp/com_interface_entry_aggregate.md), except if `punk` is **NULL**, it automatically creates the aggregate described by the `clsid`.|  
|[COM_INTERFACE_ENTRY_AUTOAGGREGATE_BLIND](../VS_csharp/com_interface_entry_autoaggregate_blind.md)|Same as [COM_INTERFACE_ENTRY_AUTOAGGREGATE](../VS_csharp/com_interface_entry_autoaggregate.md), except that querying for any IID results in forwarding the query to `punk`, and if `punk` is **NULL**, automatically creating the aggregate described by the `clsid`.|  
|[COM_INTERFACE_ENTRY_BREAK](../VS_csharp/com_interface_entry_break.md)|Causes your program to call [DebugBreak](http://msdn.microsoft.com/library/windows/desktop/ms679297) when the specified interface is queried for.|  
|[COM_INTERFACE_ENTRY_CACHED_TEAR_OFF](../VS_csharp/com_interface_entry_cached_tear_off.md)|Saves the interface-specific data for every instance.|  
|[COM_INTERFACE_ENTRY_CHAIN](../VS_csharp/com_interface_entry_chain.md)|Processes the COM map of the base class when the processing reaches this entry in the COM map.|  
|[COM_INTERFACE_ENTRY_FUNC](../VS_csharp/com_interface_entry_func.md)|A general mechanism for hooking into ATL's `QueryInterface` logic.|  
|[COM_INTERFACE_ENTRY_FUNC_BLIND](../VS_csharp/com_interface_entry_func_blind.md)|Same as [COM_INTERFACE_ENTRY_FUNC](../VS_csharp/com_interface_entry_func.md), except that querying for any IID results in a call to `func`.|  
|[COM_INTERFACE_ENTRY_IID](../VS_csharp/com_interface_entry_iid.md)|Use this macro to enter the interface into the COM map and specify its IID.|  
|[COM_INTERFACE_ENTRY_NOINTERFACE](../VS_csharp/com_interface_entry_nointerface.md)|Returns **E_NOINTERFACE** and terminates COM map processing when the specified interface is queried for.|  
|[COM_INTERFACE_ENTRY_TEAR_OFF](../VS_csharp/com_interface_entry_tear_off.md)|Exposes your tear-off interfaces.|  
|[COMMAND_CODE_HANDLER](../VS_csharp/command_code_handler.md)|Similar to [COMMAND_HANDLER](../VS_csharp/command_handler.md), but maps a [WM_COMMAND](http://msdn.microsoft.com/library/windows/desktop/ms647591) message based only on the notification code.|  
|[COMMAND_HANDLER](../VS_csharp/command_handler.md)|Defines an entry in a message map.|  
|[COMMAND_ID_HANDLER](../VS_csharp/command_id_handler.md)|Similar to [COMMAND_HANDLER](../VS_csharp/command_handler.md), but maps a [WM_COMMAND](http://msdn.microsoft.com/library/windows/desktop/ms647591) message based only on the identifier of the menu item, control, or accelerator.|  
|[COMMAND_RANGE_CODE_HANDLER](../VS_csharp/command_range_code_handler.md)|Similar to [COMMAND_RANGE_HANDLER](../VS_csharp/command_range_handler.md), but maps [WM_COMMAND](http://msdn.microsoft.com/library/windows/desktop/ms647591) messages with a specific notification code from a range of controls to a single handler function.|  
|[COMMAND_RANGE_HANDLER](../VS_csharp/command_range_handler.md)|Similar to [COMMAND_HANDLER](../VS_csharp/command_handler.md), but maps [WM_COMMAND](http://msdn.microsoft.com/library/windows/desktop/ms647591) messages from a range of controls to a single handler function.|  
|[CONNECTION_POINT_ENTRY](../VS_csharp/connection_point_entry.md)|Enters a connection point for the specified interface into the connection point map so that it can be accessed.|  
|[DECLARE_AGGREGATABLE](../VS_csharp/declare_aggregatable.md)|Specifies that your object can be aggregated.|  
|[DECLARE_CLASSFACTORY](../VS_csharp/declare_classfactory.md)|Declares [CComClassFactory](../VS_csharp/ccomclassfactory-class.md) to be the class factory.|  
|[DECLARE_CLASSFACTORY2](../VS_csharp/declare_classfactory2.md)|Declares [CComClassFactory2](../VS_csharp/ccomclassfactory2-class.md) to be the class factory.|  
|[DECLARE_CLASSFACTORY_AUTO_THREAD](../VS_csharp/declare_classfactory_auto_thread.md)|Declares [CComClassFactoryAutoThread](../VS_csharp/ccomclassfactoryautothread-class.md) to be the class factory.|  
|[DECLARE_CLASSFACTORY_EX](../VS_csharp/declare_classfactory_ex.md)|Declares `cf` to be the class factory.|  
|[DECLARE_CLASSFACTORY_SINGLETON](../VS_csharp/declare_classfactory_singleton.md)|Declares [CComClassFactorySingleton](../VS_csharp/ccomclassfactorysingleton-class.md) to be the class factory.|  
|[DECLARE_EMPTY_MSG_MAP](../VS_csharp/declare_empty_msg_map.md)|Declares an empty message map.|  
|[DECLARE_GET_CONTROLLING_UNKNOWN](../VS_csharp/declare_get_controlling_unknown.md)|Declares a virtual function `GetControllingUnknown`.|  
|[DECLARE_LIBID](../VS_csharp/declare_libid.md)|Provides a way for ATL to obtain the *libid* of the type library.|  
|[DECLARE_NO_REGISTRY](../VS_csharp/declare_no_registry.md)|Use `DECLARE_NO_REGISTRY` if you want to avoid any default ATL registration for the class in which this macro appears.|  
|[DECLARE_NOT_AGGREGATABLE](../VS_csharp/declare_not_aggregatable.md)|Specifies that your object cannot be aggregated.|  
|[DECLARE_OBJECT_DESCRIPTION](../VS_csharp/declare_object_description.md)|Allows you to specify a text description for your class object.|  
|[DECLARE_OLEMISC_STATUS](../VS_csharp/declare_olemisc_status.md)|Used in ATL ActiveX controls to set the OLEMISC flags.|  
|[DECLARE_ONLY_AGGREGATABLE](../VS_csharp/declare_only_aggregatable.md)|Specifies that your object must be aggregated.|  
|[DECLARE_POLY_AGGREGATABLE](../VS_csharp/declare_poly_aggregatable.md)|Specifies that an instance of **CComPolyObject <** *x* **>** is created when your object is created.|  
|[DECLARE_PROTECT_FINAL_CONSTRUCT](../VS_csharp/declare_protect_final_construct.md)|Protects your object from being deleted if (during [FinalConstruct](../Topic/CComObjectRootEx::FinalConstruct.md)) the internal aggregated object increments the reference count then decrements the count to 0.|  
|[DECLARE_REGISTRY](../VS_csharp/declare_registry.md)|Enters the standard class registration into the system registry or removes it from the system registry.|  
|[DECLARE_REGISTRY_APPID_RESOURCEID](../VS_csharp/declare_registry_appid_resourceid.md)|Specifies the information required to automatically register the *appid*.|  
|[DECLARE_REGISTRY_RESOURCE](../VS_csharp/declare_registry_resource.md)|Gets the named resource containing the registry file and runs the script to either enter objects into the system registry or remove them from the system registry.|  
|[DECLARE_REGISTRY_RESOURCEID](../VS_csharp/declare_registry_resourceid.md)|Same as [DECLARE_REGISTRY_RESOURCE](../VS_csharp/declare_registry_resource.md) except that it uses a wizard-generated **UINT** to identify the resource, rather than a string name.|  
|[DECLARE_VIEW_STATUS](../VS_csharp/declare_view_status.md)|Place this macro in an ATL ActiveX control's control class to specify the **VIEWSTATUS** flags to the container.|  
|[DECLARE_WND_CLASS](../VS_csharp/declare_wnd_class.md)|Allows you to specify the name of a new window class. Place this macro in an ATL ActiveX control's control class.|  
|[DECLARE_WND_CLASS_EX](../VS_csharp/declare_wnd_class_ex.md)|Allows you to specify the name of an existing window class on which a new window class will be based. Place this macro in an ATL ActiveX control's control class.|  
|[DECLARE_WND_SUPERCLASS](../VS_csharp/declare_wnd_superclass.md)|Allows you to specify the parameters of a class. Place this macro in an ATL ActiveX control's control class.|  
|[DEFAULT_REFLECTION_HANDLER](../VS_csharp/default_reflection_handler.md)|Provides a default handler for the child window (control) that will receive reflected messages; the handler will properly pass unhandled messages to `DefWindowProc`.|  
|[DEVMODE and TEXTMETRIC String Conversion Macros](../VS_csharp/devmode-and-textmetric-string-conversion-macros.md)|These macros create a copy of a [DEVMODE](http://msdn.microsoft.com/library/windows/desktop/dd183565) or [TEXTMETRIC](http://msdn.microsoft.com/library/windows/desktop/dd145132) structure and convert the strings within the new structure to a new string type.|  
|[END_CATEGORY_MAP](../VS_csharp/end_category_map.md)|Marks the end of the category map.|  
|[END_COM_MAP](../VS_csharp/end_com_map.md)|Ends the definition of your COM interface map.|  
|[END_CONNECTION_POINT_MAP](../VS_csharp/end_connection_point_map.md)|Marks the end of the connection point map entries.|  
|[END_EXTENSION_SNAPIN_NODEINFO_MAP](../VS_csharp/end_extension_snapin_nodeinfo_map.md)|Marks the end of the snap-in extension data class map.|  
|[END_MSG_MAP](../VS_csharp/end_msg_map.md)|Marks the end of a message map.|  
|[END_PROP_MAP](../VS_csharp/end_prop_map.md)|Marks the end of the object's property map.|  
|[END_RDX_MAP](../VS_csharp/end_rdx_map.md)|Marks the end of the Registry Data Exchange map.|  
|[END_SERVICE_MAP](../VS_csharp/end_service_map.md)|Marks the end of the service map.|  
|[END_SINK_MAP](../VS_csharp/end_sink_map.md)|Declares the end of the event sink map for the composite control.|  
|[END_SNAPINTOOLBARID_MAP](../VS_csharp/end_snapintoolbarid_map.md)|Declares the end of the toolbar ID map for the Snap-In object.|  
|[EXTENSION_SNAPIN_DATACLASS](../VS_csharp/extension_snapin_dataclass.md)|Adds a data member to the snap-in extension data class for an **ISnapInItemImpl**-derived class.|  
|[EXTENSION_SNAPIN_NODEINFO_ENTRY](../VS_csharp/extension_snapin_nodeinfo_entry.md)|Adds a snap-in extension data class to the snap-in extension data class map.|  
|[FORWARD_NOTIFICATIONS](../VS_csharp/forward_notifications.md)|Forwards notification messages to the parent window.|  
|[IMPLEMENTED_CATEGORY](../VS_csharp/implemented_category.md)|Add an `IMPLEMENTED_CATEGORY` macro to your component's [category map](../VS_csharp/begin_category_map.md) to specify that it should be registered as implementing the category identified by the `catID` parameter.|  
|[MESSAGE_HANDLER](../VS_csharp/message_handler.md)|Defines an entry in a message map.|  
|[MESSAGE_RANGE_HANDLER](../VS_csharp/message_range_handler.md)|Similar to [MESSAGE_HANDLER](../VS_csharp/message_handler.md), but maps a range of Windows messages to a single handler function.|  
|[NOTIFY_CODE_HANDLER](../VS_csharp/notify_code_handler.md)|Similar to [NOTIFY_HANDLER](../VS_csharp/notify_handler.md), but maps a [WM_NOTIFY](http://msdn.microsoft.com/library/windows/desktop/bb775583) message based only on the notification code.|  
|[NOTIFY_HANDLER](../VS_csharp/notify_handler.md)|Defines an entry in a message map.|  
|[NOTIFY_ID_HANDLER](../VS_csharp/notify_id_handler.md)|Similar to [NOTIFY_HANDLER](../VS_csharp/notify_handler.md), but maps a [WM_NOTIFY](http://msdn.microsoft.com/library/windows/desktop/bb775583) message based only on the control identifier.|  
|[NOTIFY_RANGE_CODE_HANDLER](../VS_csharp/notify_range_code_handler.md)|Similar to [NOTIFY_RANGE_HANDLER](../VS_csharp/notify_range_handler.md), but maps [WM_NOTIFY](http://msdn.microsoft.com/library/windows/desktop/bb775583) messages with a specific notification code from a range of controls to a single handler function.|  
|[NOTIFY_RANGE_HANDLER](../VS_csharp/notify_range_handler.md)|Similar to [NOTIFY_HANDLER](../VS_csharp/notify_handler.md), but maps [WM_NOTIFY](http://msdn.microsoft.com/library/windows/desktop/bb775583) messages from a range of controls to a single handler function.|  
|[OBJECT_ENTRY_AUTO](../VS_csharp/object_entry_auto.md)|Enters an ATL object into the object map, updates the registry, and creates an instance of the object.|  
|[OBJECT_ENTRY_NON_CREATEABLE_EX_AUTO](../VS_csharp/object_entry_non_createable_ex_auto.md)|Allows you to specify that the object should be registered and initialized, but it should not be externally creatable via `CoCreateInstance`.|  
|[PROP_DATA_ENTRY](../VS_csharp/prop_data_entry.md)|Indicates the extent, or dimensions, of an ActiveX control.|  
|[PROP_ENTRY_INTERFACE](../VS_csharp/prop_entry_interface.md)|Use this macro to enter a property description, property DISPID, and list of property page CLSID's into the property map for the object.|  
|[PROP_ENTRY_INTERFACE_CALLBACK](../VS_csharp/prop_entry_interface_callback.md)|Use this macro to enter a property description, property DISPID, and provide a callback function to determine if any CLSID should be added to the property map.|  
|[PROP_ENTRY_INTERFACE_CALLBACK_EX](../VS_csharp/prop_entry_interface_callback_ex.md)|Similar to [PROP_ENTRY_INTERFACE_CALLBACK](../VS_csharp/prop_entry_interface_callback.md), but allows you to specify a particular IID If your object supports multiple dual interfaces.|  
|[PROP_ENTRY_INTERFACE_EX](../VS_csharp/prop_entry_interface_ex.md)|Similar to [PROP_ENTRY_INTERFACE](../VS_csharp/prop_entry_interface.md), but allows you to specify a particular IID If your object supports multiple dual interfaces.|  
|[PROP_ENTRY_TYPE](../VS_csharp/prop_entry_type.md)|Use this macro to enter a property description, property DISPID, and property page CLSID into the object's property map.|  
|[PROP_ENTRY_TYPE_EX](../VS_csharp/prop_entry_type_ex.md)|Similar to [PROP_ENTRY_TYPE](../VS_csharp/prop_entry_type.md), but allows you specify a particular IID if your object supports multiple dual interfaces.|  
|[PROP_PAGE](../VS_csharp/prop_page.md)|Use this macro to enter a property page CLSID into the object's property map.|  
|[RDX_BINARY](../VS_csharp/rdx_binary.md)|Associates the specified registry entry with a specified member variable of type BYTE.|  
|[RDX_CSTRING_TEXT](../VS_csharp/rdx_cstring_text.md)|Associates the specified registry entry with a specified member variable of type CString.|  
|[RDX_DWORD](../VS_csharp/rdx_dword.md)|Associates the specified registry entry with a specified member variable of type DWORD.|  
|[RDX_TEXT](../VS_csharp/rdx_text.md)|Associates the specified registry entry with a specified member variable of type TCHAR.|  
|[REFLECT_NOTIFICATIONS](../VS_csharp/reflect_notifications.md)|Reflects notification messages back to the child window (control) that sent them.|  
|[REFLECTED_COMMAND_CODE_HANDLER](../VS_csharp/reflected_command_code_handler.md)|Similar to [COMMAND_CODE_HANDLER](../VS_csharp/command_code_handler.md), but maps commands reflected from the parent window.|  
|[REFLECTED_COMMAND_HANDLER](../VS_csharp/reflected_command_handler.md)|Similar to [COMMAND_HANDLER](../VS_csharp/command_handler.md), but maps commands reflected from the parent window.|  
|[REFLECTED_COMMAND_ID_HANDLER](../VS_csharp/reflected_command_id_handler.md)|Similar to [COMMAND_ID_HANDLER](../VS_csharp/command_id_handler.md), but maps commands reflected from the parent window.|  
|[REFLECTED_COMMAND_RANGE_CODE_HANDLER](../VS_csharp/reflected_command_range_code_handler.md)|Similar to [COMMAND_RANGE_CODE_HANDLER](../VS_csharp/command_range_code_handler.md), but maps commands reflected from the parent window.|  
|[REFLECTED_COMMAND_RANGE_HANDLER](../VS_csharp/reflected_command_range_handler.md)|Similar to [COMMAND_RANGE_HANDLER](../VS_csharp/command_range_handler.md), but maps commands reflected from the parent window.|  
|[REFLECTED_NOTIFY_CODE_HANDLER](../VS_csharp/reflected_notify_code_handler.md)|Similar to [NOTIFY_CODE_HANDLER](../VS_csharp/notify_code_handler.md), but maps notifications reflected from the parent window.|  
|[REFLECTED_NOTIFY_HANDLER](../VS_csharp/reflected_notify_handler.md)|Similar to [NOTIFY_HANDLER](../VS_csharp/notify_handler.md), but maps notifications reflected from the parent window.|  
|[REFLECTED_NOTIFY_ID_HANDLER](../VS_csharp/reflected_notify_id_handler.md)|Similar to [NOTIFY_ID_HANDLER](../VS_csharp/notify_id_handler.md), but maps notifications reflected from the parent window.|  
|[REFLECTED_NOTIFY_RANGE_CODE_HANDLER](../VS_csharp/reflected_notify_range_code_handler.md)|Similar to [NOTIFY_RANGE_CODE_HANDLER](../VS_csharp/notify_range_code_handler.md), but maps notifications reflected from the parent window.|  
|[REFLECTED_NOTIFY_RANGE_HANDLER](../VS_csharp/reflected_notify_range_handler.md)|Similar to [NOTIFY_RANGE_HANDLER](../VS_csharp/notify_range_handler.md), but maps notifications reflected from the parent window.|  
|[REQUIRED_CATEGORY](../VS_csharp/required_category.md)|Add a `REQUIRED_CATEGORY` macro to your component's [category map](../VS_csharp/begin_category_map.md) to specify that it should be registered as requiring the category identified by the `catID` parameter.|  
|[SERVICE_ENTRY](../VS_csharp/service_entry.md)|Indicates that the object supports the service id specified by *SID*.|  
|[SERVICE_ENTRY_CHAIN](../VS_csharp/service_entry_chain.md)|Instructs [IServiceProviderImpl::QueryService](../VS_csharp/iserviceproviderimpl--queryservice.md) to chain to the object specified by `punk`.|  
|[SINK_ENTRY](../VS_csharp/sink_entry.md)|Declares the handler function (`fn`) for the specified event (`dispid`), of the control identified by `id`.|  
|[SINK_ENTRY_EX](../VS_csharp/sink_entry_ex.md)|Declares the handler function (`fn`) for the specified event (`dispid`), of the dispatch interface (*iid)*, for the control identified by `id`.|  
|[SINK_ENTRY_INFO](../VS_csharp/sink_entry_info.md)|Use the `SINK_ENTRY_INFO` macro within an event sink map to provide the information needed by [IDispEventSimpleImpl](../VS_csharp/idispeventsimpleimpl-class.md) to route events to the relevant handler function.|  
|[SNAPINMENUID](../VS_csharp/snapinmenuid.md)|Use this macro to declare the context menu resource of the Snap-In object.|  
|[SNAPINTOOLBARID_ENTRY](../VS_csharp/snapintoolbarid_entry.md)|Use this macro to enter a toolbar ID into the Snap-In object's toolbar ID map.|  
|[WM_FORWARDMSG](../VS_csharp/wm_forwardmsg.md)|This macro forwards a message received by a window to another window for processing.|  
  
## See Also  
 [Macros](../VS_csharp/atl-macros.md)   
 [ATL COM Desktop Components](../VS_csharp/atl-com-desktop-components.md)   
 [Functions](../VS_csharp/atl-functions.md)   
 [Global Variables](../VS_csharp/atl-global-variables.md)   
 [Structures](../VS_csharp/atl-structures.md)   
 [Typedefs](../VS_csharp/atl-typedefs.md)   
 [Class Overview](../VS_csharp/atl-class-overview.md)