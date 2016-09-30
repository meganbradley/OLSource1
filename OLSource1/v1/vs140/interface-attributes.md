---
title: "Interface Attributes"
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
  - "attributes [C++], reference topics"
  - "interface attributes"
ms.assetid: 27fcdfee-abce-4585-8b53-ee31635356e8
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Interface Attributes
The following attributes apply to the [interface (or __interface)](../vs140/__interface.md) C++ keyword.  
  
|Attribute|Description|  
|---------------|-----------------|  
|[async_uuid](../vs140/async_uuid.md)|Specifies the UUID that directs the MIDL compiler to define both synchronous and asynchronous versions of a COM interface.|  
|[custom](../vs140/custom--c---.md)|Lets you define your own attributes.|  
|[dispinterface](../vs140/dispinterface.md)|Places an interface in the .idl file as a dispatch interface.|  
|[dual](../vs140/dual.md)|Places an interface in the .idl file as a dual interface.|  
|[export](../vs140/export.md)|Causes a data structure to be placed in the .idl file.|  
|[helpcontext](../vs140/helpcontext.md)|Specifies a context ID that lets the user view information about this element in the Help file.|  
|[helpfile](../vs140/helpfile.md)|Sets the name of the Help file for a type library.|  
|[helpstring](../vs140/helpstring.md)|Specifies a character string that is used to describe the element to which it applies.|  
|[helpstringcontext](../vs140/helpstringcontext.md)|Specifies the ID of a help topic in an .hlp or .chm file.|  
|[helpstringdll](../vs140/helpstringdll.md)|Specifies the name of the DLL to use to perform document string lookup (localization).|  
|[hidden](../vs140/hidden.md)|Indicates that the item exists but should not be displayed in a user-oriented browser.|  
|[library_block](../vs140/library_block.md)|Places a construct inside the .idl file's library block.|  
|[local](../vs140/local--c---.md)|Allows you to use the MIDL compiler as a header generator when used in the interface header. When used in an individual function, designates a local procedure for which no stubs are generated.|  
|[nonextensible](../vs140/nonextensible.md)|Specifies that the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> implementation includes only the properties and methods listed in the interface description and cannot be extended with additional members at run time. This attribute is only valid on a [dual](../vs140/dual.md) interface.|  
|[odl](../vs140/odl.md)|Identifies an interface as an Object Description Language (ODL) interface.|  
|[object](../vs140/object--c---.md)|Identifies a custom interface.|  
|[oleautomation](../vs140/oleautomation.md)|Indicates that an interface is compatible with Automation.|  
|[pointer_default](../vs140/pointer_default.md)|Specifies the default pointer attribute for all pointers except top-level pointers that appear in parameter lists.|  
|[ptr](../vs140/ptr.md)|Designates a pointer as a full pointer.|  
|[restricted](../vs140/restricted.md)|Designates which members of the library cannot be called arbitrarily.|  
|[uuid](../vs140/uuid--c---attributes-.md)|Provides the unique ID for the library|  
  
 You must observe these rules for defining an interface:  
  
-   Default calling convention is [__stdcall](../vs140/__stdcall.md).  
  
-   A GUID is supplied for you if you do not supply one.  
  
-   No overloaded methods are allowed.  
  
 When not specifying the [uuid](../vs140/uuid--c---attributes-.md) attribute and using the same interface name in different attribute projects, the same GUID is generated.  
  
## See Also  
 [Attributes by Usage](../vs140/attributes-by-usage.md)