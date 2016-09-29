---
title: "Class Attributes"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "attributes [C++], class attributes"
  - "class attributes"
ms.assetid: fad04ea1-d8ff-46d4-bb42-2b4500a6ab60
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Class Attributes
The following attributes apply to the [class](../VS_csharp/class--c---.md) C++ keyword.  
  
|Attribute|Description|  
|---------------|-----------------|  
|[aggregatable](../VS_csharp/aggregatable.md)|Indicates that the class supports aggregation.|  
|[aggregates](../VS_csharp/aggregates.md)|Indicates that a control aggregates the target class.|  
|[appobject](../VS_csharp/appobject.md)|Identifies the coclass as an application object, which is associated with a full .exe application, and indicates that the functions and properties of the coclass are globally available in this type library.|  
|[case](../VS_csharp/case--c---.md)|Used with the [switch_type](../VS_csharp/switch_type.md) attribute in a union.|  
|[coclass](../VS_csharp/coclass.md)|Creates an ActiveX control.|  
|[com_interface_entry](../VS_csharp/com_interface_entry--c---.md)|Adds an interface entry to a COM map.|  
|[control](../VS_csharp/control.md)|Specifies that the user-defined type is a control.|  
|[custom](../VS_csharp/custom--c---.md)|Lets you define your own attribute.|  
|[db_command](../VS_csharp/db_command.md)|Creates an OLE DB command.|  
|[db_param](../VS_csharp/db_param.md)|Associates the specified member variable with an input or output parameter and delimits the variable.|  
|[db_source](../VS_csharp/db_source.md)|Creates a connection to a data source.|  
|[db_table](../VS_csharp/db_table.md)|Opens an OLE DB table.|  
|[default](../VS_csharp/default--c---.md)|Indicates that the custom or dispinterface defined within a coclass represents the default programmability interface.|  
|[defaultvtable](../VS_csharp/defaultvtable.md)|Defines an interface as the default vtable interface for a control.|  
|[event_receiver](../VS_csharp/event_receiver.md)|Creates an event receiver.|  
|[event_source](../VS_csharp/event_source.md)|Creates an event source.|  
|[helpcontext](../VS_csharp/helpcontext.md)|Specifies a context ID that lets the user view information about this element in the Help file.|  
|[helpfile](../VS_csharp/helpfile.md)|Sets the name of the Help file for a type library.|  
|[helpstringcontext](../VS_csharp/helpstringcontext.md)|Specifies the ID of a help topic in an .hlp or .chm file.|  
|[helpstring](../VS_csharp/helpstring.md)|Specifies a character string that is used to describe the element to which it applies.|  
|[hidden](../VS_csharp/hidden.md)|Indicates that the item exists but should not be displayed in a user-oriented browser.|  
|[implements](../VS_csharp/implements--c---.md)|Specifies dispatch interfaces that are forced to be members of the IDL coclass.|  
|[implements_category](../VS_csharp/implements_category.md)|Specifies implemented component categories for the class.|  
|[module](../VS_csharp/module--c---.md)|Defines the library block in the .idl file.|  
|[noncreatable](../VS_csharp/noncreatable.md)|Defines an object that cannot be instantiated by itself.|  
|[progid](../VS_csharp/progid.md)|Defines the ProgID for a control.|  
|[registration_script](../VS_csharp/registration_script.md)|Executes the specified registration script.|  
|[requestedit](../VS_csharp/requestedit.md)|Indicates that the property supports the **OnRequestEdit** notification.|  
|[source](../VS_csharp/source--c---.md)|Specifies the control's source interfaces for connection points on a class. On a property or method, the **source** attribute indicates that the member returns an object or VARIANT that is a source of events.|  
|[support_error_info](../VS_csharp/support_error_info.md)|Supports error reporting for the target object.|  
|[threading](../VS_csharp/threading--c---.md)|Specifies the threading model for a control.|  
|[uuid](../VS_csharp/uuid--c---attributes-.md)|Specifies the unique ID for a class or interface.|  
|[version](../VS_csharp/version--c---.md)|Identifies a particular version among multiple versions of a class.|  
|[vi_progid](../VS_csharp/vi_progid.md)|Specifies a version-independent form of the ProgID.|  
  
## See Also  
 [Attributes by Usage](../VS_csharp/attributes-by-usage.md)