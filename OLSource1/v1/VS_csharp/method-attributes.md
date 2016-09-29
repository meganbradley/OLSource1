---
title: "Method Attributes"
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
  - "method attributes"
  - "attributes [C++], reference topics"
ms.assetid: b2313352-480d-488b-8c35-6242ffd3a549
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Method Attributes
The following attributes apply to the methods in a class, coclass, or interface.  
  
|Attribute|Description|  
|---------------|-----------------|  
|[bindable](../VS_csharp/bindable.md)|Indicates that the property supports data binding.|  
|[call_as](../VS_csharp/call_as.md)|Enables a nonremotable function to be mapped to a remote function.|  
|[custom](../VS_csharp/custom--c---.md)|Lets you define your own attribute.|  
|[db_column](../VS_csharp/db_column.md)|Binds a specified column to the rowset.|  
|[db_command](../VS_csharp/db_command.md)|Creates an OLE DB command.|  
|[db_param](../VS_csharp/db_param.md)|Associates the specified member variable with an input or output parameter and delimits the variable.|  
|[db_source](../VS_csharp/db_source.md)|Creates a connection to a data source.|  
|[db_table](../VS_csharp/db_table.md)|Opens an OLE DB table.|  
|[defaultbind](../VS_csharp/defaultbind.md)|Indicates the single, bindable property that best represents the object.|  
|[defaultcollelem](../VS_csharp/defaultcollelem.md)|Used for Visual Basic code optimization.|  
|[displaybind](../VS_csharp/displaybind.md)|Indicates a property that should be displayed to the user as bindable.|  
|[helpcontext](../VS_csharp/helpcontext.md)|Specifies a context ID that lets the user view information about this element in the Help file.|  
|[helpfile](../VS_csharp/helpfile.md)|Sets the name of the Help file for a type library.|  
|[helpstring](../VS_csharp/helpstring.md)|Specifies a character string that is used to describe the element to which it applies.|  
|[helpstringcontext](../VS_csharp/helpstringcontext.md)|Specifies the ID of a help topic in an .hlp or .chm file.|  
|[helpstringdll](../VS_csharp/helpstringdll.md)|Specifies the name of the DLL to use to perform document string lookup (localization).|  
|[hidden](../VS_csharp/hidden.md)|Indicates that the item exists but should not be displayed in a user-oriented browser.|  
|[id](../VS_csharp/id.md)|Specifies a DISPID for a member function (either a property or a method, in an interface or dispinterface).|  
|[immediatebind](../VS_csharp/immediatebind.md)|Indicates that the database will be notified immediately of all changes to a property of a data-bound object.|  
|[in](../VS_csharp/in--c---.md)|Indicates that a parameter is to be passed from the calling procedure to the called procedure.|  
|[local](../VS_csharp/local--c---.md)|Allows you to use the MIDL compiler as a header generator when used in the interface header. When used in an individual function, designates a local procedure for which no stubs are generated.|  
|[nonbrowsable](../VS_csharp/nonbrowsable.md)|Indicates that an interface member should not be displayed in a property browser.|  
|[propget](../VS_csharp/propget.md)|Specifies a property accessor function.|  
|[propput](../VS_csharp/propput.md)|Specifies a property-setting function.|  
|[propputref](../VS_csharp/propputref.md)|Specifies a property-setting function that uses a reference instead of a value.|  
|[ptr](../VS_csharp/ptr.md)|Designates a pointer as a full pointer.|  
|[range](../VS_csharp/range--c---.md)|Specifies a range of allowable values for arguments or fields whose values are set at run time.|  
|[requestedit](../VS_csharp/requestedit.md)|Indicates that the property supports the **OnRequestEdit** notification.|  
|[restricted](../VS_csharp/restricted.md)|Specifies that a member of a module, interface, or dispinterface cannot be called arbitrarily.|  
|[satype](../VS_csharp/satype.md)|Specifies the data type of the **SAFEARRAY** structure.|  
|[source](../VS_csharp/source--c---.md)|Specifies the control's source interfaces for connection points on a class. On a property or method, the **source** attribute indicates that the member returns an object or VARIANT that is a source of events.|  
|[synchronize](../VS_csharp/synchronize.md)|Synchronizes access to the target method.|  
|[vararg](../VS_csharp/vararg.md)|Specifies that the function take a variable number of arguments.|  
  
## See Also  
 [Attributes by Usage](../VS_csharp/attributes-by-usage.md)