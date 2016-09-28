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
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Class Attributes
The following attributes apply to the [class](../vs140/class--c---.md) C++ keyword.  
  
|Attribute|Description|  
|---------------|-----------------|  
|[aggregatable](../vs140/aggregatable.md)|Indicates that the class supports aggregation.|  
|[aggregates](../vs140/aggregates.md)|Indicates that a control aggregates the target class.|  
|[appobject](../vs140/appobject.md)|Identifies the coclass as an application object, which is associated with a full .exe application, and indicates that the functions and properties of the coclass are globally available in this type library.|  
|[case](../vs140/case--c---.md)|Used with the [switch_type](../vs140/switch_type.md) attribute in a union.|  
|[coclass](../vs140/coclass.md)|Creates an ActiveX control.|  
|[com_interface_entry](../vs140/com_interface_entry--c---.md)|Adds an interface entry to a COM map.|  
|[control](../vs140/control.md)|Specifies that the user-defined type is a control.|  
|[custom](../vs140/custom--c---.md)|Lets you define your own attribute.|  
|[db_command](../vs140/db_command.md)|Creates an OLE DB command.|  
|[db_param](../vs140/db_param.md)|Associates the specified member variable with an input or output parameter and delimits the variable.|  
|[db_source](../vs140/db_source.md)|Creates a connection to a data source.|  
|[db_table](../vs140/db_table.md)|Opens an OLE DB table.|  
|[default](../vs140/default--c---.md)|Indicates that the custom or dispinterface defined within a coclass represents the default programmability interface.|  
|[defaultvtable](../vs140/defaultvtable.md)|Defines an interface as the default vtable interface for a control.|  
|[event_receiver](../vs140/event_receiver.md)|Creates an event receiver.|  
|[event_source](../vs140/event_source.md)|Creates an event source.|  
|[helpcontext](../vs140/helpcontext.md)|Specifies a context ID that lets the user view information about this element in the Help file.|  
|[helpfile](../vs140/helpfile.md)|Sets the name of the Help file for a type library.|  
|[helpstringcontext](../vs140/helpstringcontext.md)|Specifies the ID of a help topic in an .hlp or .chm file.|  
|[helpstring](../vs140/helpstring.md)|Specifies a character string that is used to describe the element to which it applies.|  
|[hidden](../vs140/hidden.md)|Indicates that the item exists but should not be displayed in a user-oriented browser.|  
|[implements](../vs140/implements--c---.md)|Specifies dispatch interfaces that are forced to be members of the IDL coclass.|  
|[implements_category](../vs140/implements_category.md)|Specifies implemented component categories for the class.|  
|[module](../vs140/module--c---.md)|Defines the library block in the .idl file.|  
|[noncreatable](../vs140/noncreatable.md)|Defines an object that cannot be instantiated by itself.|  
|[progid](../vs140/progid.md)|Defines the ProgID for a control.|  
|[registration_script](../vs140/registration_script.md)|Executes the specified registration script.|  
|[requestedit](../vs140/requestedit.md)|Indicates that the property supports the **OnRequestEdit** notification.|  
|[source](../vs140/source--c---.md)|Specifies the control's source interfaces for connection points on a class. On a property or method, the **source** attribute indicates that the member returns an object or VARIANT that is a source of events.|  
|[support_error_info](../vs140/support_error_info.md)|Supports error reporting for the target object.|  
|[threading](../vs140/threading--c---.md)|Specifies the threading model for a control.|  
|[uuid](../vs140/uuid--c---attributes-.md)|Specifies the unique ID for a class or interface.|  
|[version](../vs140/version--c---.md)|Identifies a particular version among multiple versions of a class.|  
|[vi_progid](../vs140/vi_progid.md)|Specifies a version-independent form of the ProgID.|  
  
## See Also  
 [Attributes by Usage](../vs140/attributes-by-usage.md)