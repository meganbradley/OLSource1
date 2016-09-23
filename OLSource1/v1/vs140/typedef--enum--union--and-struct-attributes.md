---
title: "Typedef, Enum, Union, and Struct Attributes"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: language-reference
dev_langs: 
  - C++
helpviewer_keywords: 
  - union attributes
  - attributes [C++], reference topics
  - struct attributes
  - typedef attributes
  - enum attributes
ms.assetid: f8a4fe94-dc02-4aed-bc31-3e500d42f4c7
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Typedef, Enum, Union, and Struct Attributes
The following attributes apply to the [typedef](assetId:///cc96cf26-ba93-4179-951e-695d1f5fdcf1), [struct](../vs140/struct--c---.md), and [enum](../vs140/enumerations--c---.md) C++ keywords.  
  
### typedef  
  
|Attribute|Description|  
|---------------|-----------------|  
|[case](../vs140/case--c---.md)|Used with the [switch_type](../vs140/switch_type.md) attribute in a **union**.|  
|[custom](../vs140/custom--c---.md)|Lets you define your own attribute.|  
|[export](../vs140/export.md)|Causes a data structure to be placed in the .idl file.|  
|[first_is](../vs140/first_is.md)|Specifies the index of the first array element to be transmitted.|  
|[helpcontext](../vs140/helpcontext.md)|Specifies a context ID that lets the user view information about this element in the Help file.|  
|[helpfile](../vs140/helpfile.md)|Sets the name of the Help file for a type library.|  
|[helpstring](../vs140/helpstring.md)|Specifies a character string that is used to describe the element to which it applies.|  
|[library_block](../vs140/library_block.md)|Places a construct inside the .idl file's library block.|  
|[ptr](../vs140/ptr.md)|Designates a pointer as a full pointer.|  
|[public](../vs140/public--c---attributes-.md)|Ensures that a typedef will go into the type library even if it is not referenced from within the .idl file.|  
|[ref](../vs140/ref--c---.md)|Identifies a reference pointer.|  
|[switch_is](../vs140/switch_is.md)|Specifies the expression or identifier acting as the union discriminant that selects the union member.|  
|[switch_type](../vs140/switch_type.md)|Identifies the type of the variable used as the union discriminant.|  
|[unique](../vs140/unique--c---.md)|Specifies a unique pointer.|  
|[wire_marshal](../vs140/wire_marshal.md)|Specifies a data type that will be used for transmission instead of an application-specific data type.|  
  
### enum  
  
|Attribute|Description|  
|---------------|-----------------|  
|[custom](../vs140/custom--c---.md)|Lets you define your own attribute.|  
|[export](../vs140/export.md)|Causes a data structure to be placed in the .idl file.|  
|[uuid](../vs140/uuid--c---attributes-.md)|Specifies the unique ID for a class or interface.|  
|[v1_enum](../vs140/v1_enum.md)|Directs that the specified enumerated type be transmitted as a 32-bit entity, rather than the 16-bit default.|  
  
### union  
  
|Attribute|Description|  
|---------------|-----------------|  
|[custom](../vs140/custom--c---.md)|Lets you define your own attribute.|  
|[export](../vs140/export.md)|Causes a data structure to be placed in the .idl file.|  
|[first_is](../vs140/first_is.md)|Specifies the index of the first array element to be transmitted.|  
|[last_is](../vs140/last_is.md)|Specifies the index of the last array element to be transmitted.|  
|[length_is](../vs140/length_is.md)|Specifies the number of array elements to be transmitted.|  
|[max_is](../vs140/max_is.md)|Designates the maximum value for a valid array index.|  
|[size_is](../vs140/size_is.md)|Specifies the size of memory allocated for sized pointers, sized pointers to sized pointers, and single- or multidimensional arrays.|  
|[unique](../vs140/unique--c---.md)|Specifies a unique pointer.|  
|[uuid](../vs140/uuid--c---attributes-.md)|Specifies the unique ID for a class or interface.|  
  
### Nonencapsulated union  
  
|Attribute|Description|  
|---------------|-----------------|  
|[ms_union](../vs140/ms_union.md)|Controls the network data representation alignment of nonencapsulated unions.|  
|[no_injected_text](../vs140/no_injected_text.md)|Prevents the compiler from injecting code as a result of attribute use.|  
  
### struct  
  
|Attribute|Description|  
|---------------|-----------------|  
|[aggregatable](../vs140/aggregatable.md)|Indicates that the class supports aggregation.|  
|[aggregates](../vs140/aggregates.md)|Indicates that a control aggregates the target class.|  
|[appobject](../vs140/appobject.md)|Identifies the coclass as an application object, which is associated with a full .exe application, and indicates that the functions and properties of the coclass are globally available in this type library.|  
|[coclass](../vs140/coclass.md)|Creates an ActiveX control.|  
|[com_interface_entry](../vs140/com_interface_entry--c---.md)|Adds an interface entry to a COM map.|  
|[control](../vs140/control.md)|Specifies that the user-defined type is a control.|  
|[custom](../vs140/custom--c---.md)|Lets you define your own attribute.|  
|[db_column](../vs140/db_column.md)|Binds a specified column to the rowset.|  
|[db_command](../vs140/db_command.md)|Creates an OLE DB command.|  
|[db_param](../vs140/db_param.md)|Associates the specified member variable with an input or output parameter and delimits the variable.|  
|[db_source](../vs140/db_source.md)|Creates a connection to a data source.|  
|[db_table](../vs140/db_table.md)|Opens an OLE DB table.|  
|[default](../vs140/default--c---.md)|Indicates that the custom or dispinterface defined within a coclass represents the default programmability interface.|  
|[defaultvtable](../vs140/defaultvtable.md)|Defines an interface as the default vtable interface for a control.|  
|[event_receiver](../vs140/event_receiver.md)|Creates an event receiver.|  
|[event_source](../vs140/event_source.md)|Creates an event source.|  
|[export](../vs140/export.md)|Causes a data structure to be placed in the .idl file.|  
|[first_is](../vs140/first_is.md)|Specifies the index of the first array element to be transmitted.|  
|[hidden](../vs140/hidden.md)|Indicates that the item exists but should not be displayed in a user-oriented browser.|  
|[implements_category](../vs140/implements_category.md)|Specifies implemented component categories for the class.|  
|[last_is](../vs140/last_is.md)|Specifies the index of the last array element to be transmitted.|  
|[length_is](../vs140/length_is.md)|Specifies the number of array elements to be transmitted.|  
|[max_is](../vs140/max_is.md)|Designates the maximum value for a valid array index.|  
|[requires_category](../vs140/requires_category.md)|Specifies the required component categories of the target class.|  
|[size_is](../vs140/size_is.md)|Specifies the size of memory allocated for sized pointers, sized pointers to sized pointers, and single- or multidimensional arrays.|  
|[source](../vs140/source--c---.md)|On a class, specifies the COM object's source interfaces for connection points. On a property or method, indicates that the member returns an object or VARIANT that is a source of events.|  
|[threading](../vs140/threading--c---.md)|Specifies the threading model for a COM object.|  
|[unique](../vs140/unique--c---.md)|Specifies a unique pointer.|  
|[uuid](../vs140/uuid--c---attributes-.md)|Specifies the unique ID for a class or interface.|  
|[version](../vs140/version--c---.md)|Identifies a particular version among multiple versions of a class.|  
|[vi_progid](../vs140/vi_progid.md)|Specifies a version-independent form of the ProgID.|  
  
## See Also  
 [Attributes by Usage](../vs140/attributes-by-usage.md)