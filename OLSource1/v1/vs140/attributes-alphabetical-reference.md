---
title: "Attributes Alphabetical Reference"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "index-page "
f1_keywords: 
  - "vc.attributes"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "attributes [C++]"
ms.assetid: fb2216ef-9fbd-44f4-afed-732aa99450e2
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Attributes Alphabetical Reference
The following attributes are available in Visual C++.  
  
|Attribute|Description|  
|---------------|-----------------|  
|[aggregatable](../vs140/aggregatable.md)|Indicates that a control can be aggregated by another control.|  
|[aggregates](../vs140/aggregates.md)|Indicates that a control aggregates the target class.|  
|[appobject](../vs140/appobject.md)|Identifies the coclass as an application object, which is associated with a full EXE application, and indicates that the functions and properties of the coclass are globally available in this type library.|  
|[async_uuid](../vs140/async_uuid.md)|Specifies the UUID that directs the MIDL compiler to define both synchronous and asynchronous versions of a COM interface.|  
|[attribute](../vs140/attribute.md)|Allows you to create a custom attribute.|  
|[bindable](../vs140/bindable.md)|Indicates that the property supports data binding.|  
|[call_as](../vs140/call_as.md)|Enables a nonremotable function to be mapped to a remote function.|  
|[case](../vs140/case--c---.md)|Used with the [switch_type](../vs140/switch_type.md) attribute in a union.|  
|[coclass](../vs140/coclass.md)|Creates a COM object, which can implement a COM interface.|  
|[com_interface_entry](../vs140/com_interface_entry--c---.md)|Adds an interface entry to a COM map.|  
|[control](../vs140/control.md)|Specifies that the user-defined type is a control.|  
|[cpp_quote](../vs140/cpp_quote.md)|Emits the specified string, without the quote characters, into the generated header file.|  
|[custom](../vs140/custom--c---.md)|Lets you define your own attributes.|  
|[db_accessor](../vs140/db_accessor.md)|Binds columns in a rowset and binds them to the corresponding accessor maps.|  
|[db_column](../vs140/db_column.md)|Binds a specified column to the rowset.|  
|[db_command](../vs140/db_command.md)|Executes an OLE DB command.|  
|[db_param](../vs140/db_param.md)|Associates the specified member variable with an input or output parameter.|  
|[db_source](../vs140/db_source.md)|Creates and encapsulates a connection, through a provider, to a data source.|  
|[db_table](../vs140/db_table.md)|Opens an OLE DB table.|  
|[default](../vs140/default--c---.md)|Indicates that the custom or dispinterface defined within a coclass represents the default programmability interface.|  
|[defaultbind](../vs140/defaultbind.md)|Indicates the single, bindable property that best represents the object.|  
|[defaultcollelem](../vs140/defaultcollelem.md)|Used for Visual Basic code optimization.|  
|[defaultvalue](../vs140/defaultvalue.md)|Allows specification of a default value for a typed optional parameter.|  
|[defaultvtable](../vs140/defaultvtable.md)|Defines an interface as the default vtable interface for a control.|  
|[dispinterface](../vs140/dispinterface.md)|Places an interface in the .idl file as a dispatch interface.|  
|[displaybind](../vs140/displaybind.md)|Indicates a property that should be displayed to the user as bindable.|  
|[dual](../vs140/dual.md)|Places an interface in the .idl file as a dual interface.|  
|[emitidl](../vs140/emitidl.md)|Determines whether all subsequent IDL attributes will be processed and placed in the generated .idl file.|  
|[entry](../vs140/entry.md)|Specifies an exported function or constant in a module by identifying the entry point in the DLL.|  
|[event_receiver](../vs140/event_receiver.md)|Creates an event receiver.|  
|[event_source](../vs140/event_source.md)|Creates an event source.|  
|[export](../vs140/export.md)|Causes a data structure to be placed in the .idl file.|  
|[first_is](../vs140/first_is.md)|Specifies the index of the first array element to be transmitted.|  
|[helpcontext](../vs140/helpcontext.md)|Specifies a context ID that lets the user view information about this element in the Help file.|  
|[helpfile](../vs140/helpfile.md)|Sets the name of the Help file for a type library.|  
|[helpstring](../vs140/helpstring.md)|Specifies the ID of a help topic in an .hlp or .chm file.|  
|[helpstringdll](../vs140/helpstringdll.md)|Specifies the name of the DLL to use to perform document string lookup (localization).|  
|[hidden](../vs140/hidden.md)|Indicates that the item exists but should not be displayed in a user-oriented browser.|  
|[id](../vs140/id.md)|Specifies a DISPID for a member function (either a property or a method, in an interface or dispinterface).|  
|[idl_module](../vs140/idl_module.md)|Specifies an entry point in a DLL.|  
|[idl_quote](../vs140/idl_quote.md)|Allows you to use attributes or IDL constructs that are not supported in the current version of Visual C++.|  
|[iid_is](../vs140/iid_is.md)|Specifies the IID of the COM interface pointed to by an interface pointer.|  
|[immediatebind](../vs140/immediatebind.md)|Indicates that the database will be notified immediately of all changes to a property of a data-bound object.|  
|[implements](../vs140/implements--c---.md)|Specifies dispatch interfaces that are forced to be members of the IDL coclass.|  
|[implements_category](../vs140/implements_category.md)|Specifies implemented component categories for the class.|  
|[import](../vs140/import.md)|Specifies another .idl, .odl, or header file containing definitions you want to reference from your main .idl file.|  
|[importidl](../vs140/importidl.md)|Inserts the specified .idl file into the generated .idl file.|  
|[importlib](../vs140/importlib.md)|Makes types that have already been compiled into another type library available to the type library being created.|  
|[in](../vs140/in--c---.md)|Indicates that a parameter is to be passed from the calling procedure to the called procedure.|  
|[include](../vs140/include--c---.md)|Specifies one or more header files to be included in the generated .idl file.|  
|[includelib](../vs140/includelib--c---.md)|Causes an .idl or .h file to be included in the generated .idl file.|  
|[last_is](../vs140/last_is.md)|Specifies the index of the last array element to be transmitted.|  
|[lcid](../vs140/lcid.md)|Lets you pass a locale identifier to a function.|  
|[length_is](../vs140/length_is.md)|Specifies the number of array elements to be transmitted.|  
|[library_block](../vs140/library_block.md)|Places a construct inside the .idl file's library block.|  
|[licensed](../vs140/licensed.md)|Indicates that the coclass to which it applies is licensed, and must be instantiated using **IClassFactory2**.|  
|[local](../vs140/local--c---.md)|Allows you to use the MIDL compiler as a header generator when used in the interface header. When used in an individual function, designates a local procedure for which no stubs are generated.|  
|[max_is](../vs140/max_is.md)|Designates the maximum value for a valid array index.|  
|[module](../vs140/module--c---.md)|Defines the library block in the .idl file.|  
|[ms_union](../vs140/ms_union.md)|Controls the network data representation alignment of nonencapsulated unions.|  
|[no_injected_text](../vs140/no_injected_text.md)|Prevents the compiler from injecting code as a result of attribute use.|  
|[nonbrowsable](../vs140/nonbrowsable.md)|Indicates that an interface member should not be displayed in a property browser.|  
|[noncreatable](../vs140/noncreatable.md)|Defines an object that cannot be instantiated by itself.|  
|[nonextensible](../vs140/nonextensible.md)|Specifies that the `IDispatch` implementation includes only the properties and methods listed in the interface description and cannot be extended with additional members at run time.|  
|[object](../vs140/object--c---.md)|Identifies a custom interface; synonymous with custom attribute.|  
|[odl](../vs140/odl.md)|Identifies an interface as an Object Description Language (ODL) interface.|  
|[oleautomation](../vs140/oleautomation.md)|Indicates that an interface is compatible with Automation.|  
|[optional](../vs140/optional--c---.md)|Specifies an optional parameter for a member function.|  
|[out](../vs140/out--c---.md)|Identifies pointer parameters that are returned from the called procedure to the calling procedure (from the server to the client).|  
|[pointer_default](../vs140/pointer_default.md)|Specifies the default pointer attribute for all pointers except top-level pointers that appear in parameter lists.|  
|[pragma](../vs140/pragma.md)|Emits the specified string, without the quote characters, into the generated .idl file.|  
|[progid](../vs140/progid.md)|Specifies the ProgID for a COM object.|  
|[propget](../vs140/propget.md)|Specifies a property accessor (get) function.|  
|[propput](../vs140/propput.md)|Specifies a property setting function.|  
|[propputref](../vs140/propputref.md)|Specifies a property setting function that uses a reference instead of a value.|  
|[ptr](../vs140/ptr.md)|Designates a pointer as a full pointer.|  
|[public](../vs140/public--c---attributes-.md)|Ensures that a typedef will go into the type library even if it is not referenced from within the .idl file.|  
|[range](../vs140/range--c---.md)|Specifies a range of allowable values for arguments or fields whose values are set at run time.|  
|[rdx](../vs140/rdx.md)|Creates or modifies a registry key.|  
|[readonly](../vs140/readonly--c---.md)|Prohibits assignment to a variable.|  
|[ref](../vs140/ref--c---.md)|Identifies a reference pointer.|  
|[registration_script](../vs140/registration_script.md)|Executes the specified registration script.|  
|[requestedit](../vs140/requestedit.md)|Indicates that the property supports the **OnRequestEdit** notification.|  
|[requires_category](../vs140/requires_category.md)|Specifies required component categories for the class.|  
|[restricted](../vs140/restricted.md)|Specifies that a library, or member of a module, interface, or dispinterface cannot be called arbitrarily.|  
|[retval](../vs140/retval.md)|Designates the parameter that receives the return value of the member.|  
|[satype](../vs140/satype.md)|Specifies the data type of the **SAFEARRAY**.|  
|[size_is](../vs140/size_is.md)|Specifies the size of memory allocated for sized pointers, sized pointers to sized pointers, and single- or multidimensional arrays.|  
|[source](../vs140/source--c---.md)|Indicates that a member of a class, property, or method is a source of events.|  
|[string](../vs140/string--c---.md)|Indicates that the one-dimensional `char`, `wchar_t`, **byte**, or equivalent array or the pointer to such an array must be treated as a string.|  
|[support_error_info](../vs140/support_error_info.md)|Supports error reporting for the target object.|  
|[switch_is](../vs140/switch_is.md)|Specifies the expression or identifier acting as the union discriminant that selects the union member.|  
|[switch_type](../vs140/switch_type.md)|Identifies the type of the variable used as the union discriminant.|  
|[synchronize](../vs140/synchronize.md)|Synchronizes access to a method.|  
|[threading](../vs140/threading--c---.md)|Specifies the threading model for a COM object.|  
|[transmit_as](../vs140/transmit_as.md)|Instructs the compiler to associate a presented type, which client and server applications manipulate, with a transmitted type.|  
|[uidefault](../vs140/uidefault.md)|Indicates that the type information member is the default member for display in the user interface.|  
|[unique](../vs140/unique--c---.md)|Specifies a unique pointer.|  
|[usesgetlasterror](../vs140/usesgetlasterror.md)|Tells the caller that if there is an error when calling that function, the caller can then call `GetLastError` to retrieve the error code.|  
|[uuid](../vs140/uuid--c---attributes-.md)|Specifies the unique ID for a class or interface.|  
|[v1_enum](../vs140/v1_enum.md)|Directs that the specified enumerated type be transmitted as a 32-bit entity, rather than the 16-bit default.|  
|[vararg](../vs140/vararg.md)|Specifies that the function take a variable number of arguments.|  
|[version](../vs140/version--c---.md)|Identifies a particular version among multiple versions of an interface or class.|  
|[vi_progid](../vs140/vi_progid.md)|Specifies a version-independent form of the ProgID.|  
|[wire_marshal](../vs140/wire_marshal.md)|Specifies a data type that will be used for transmission instead of an application-specific data type.|  
  
## See Also  
 [C++ Attributes Reference](../vs140/c---attributes-reference.md)   
 [Concepts](../vs140/attributed-programming-concepts.md)   
 [Attributes by Group](../vs140/attributes-by-group.md)   
 [Attributes by Usage](../vs140/attributes-by-usage.md)