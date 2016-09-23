---
title: "Method Attributes"
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
  - method attributes
  - attributes [C++], reference topics
ms.assetid: b2313352-480d-488b-8c35-6242ffd3a549
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Method Attributes
The following attributes apply to the methods in a class, coclass, or interface.  
  
|Attribute|Description|  
|---------------|-----------------|  
|[bindable](../vs140/bindable.md)|Indicates that the property supports data binding.|  
|[call_as](../vs140/call_as.md)|Enables a nonremotable function to be mapped to a remote function.|  
|[custom](../vs140/custom--c---.md)|Lets you define your own attribute.|  
|[db_column](../vs140/db_column.md)|Binds a specified column to the rowset.|  
|[db_command](../vs140/db_command.md)|Creates an OLE DB command.|  
|[db_param](../vs140/db_param.md)|Associates the specified member variable with an input or output parameter and delimits the variable.|  
|[db_source](../vs140/db_source.md)|Creates a connection to a data source.|  
|[db_table](../vs140/db_table.md)|Opens an OLE DB table.|  
|[defaultbind](../vs140/defaultbind.md)|Indicates the single, bindable property that best represents the object.|  
|[defaultcollelem](../vs140/defaultcollelem.md)|Used for Visual Basic code optimization.|  
|[displaybind](../vs140/displaybind.md)|Indicates a property that should be displayed to the user as bindable.|  
|[helpcontext](../vs140/helpcontext.md)|Specifies a context ID that lets the user view information about this element in the Help file.|  
|[helpfile](../vs140/helpfile.md)|Sets the name of the Help file for a type library.|  
|[helpstring](../vs140/helpstring.md)|Specifies a character string that is used to describe the element to which it applies.|  
|[helpstringcontext](../vs140/helpstringcontext.md)|Specifies the ID of a help topic in an .hlp or .chm file.|  
|[helpstringdll](../vs140/helpstringdll.md)|Specifies the name of the DLL to use to perform document string lookup (localization).|  
|[hidden](../vs140/hidden.md)|Indicates that the item exists but should not be displayed in a user-oriented browser.|  
|[id](../vs140/id.md)|Specifies a DISPID for a member function (either a property or a method, in an interface or dispinterface).|  
|[immediatebind](../vs140/immediatebind.md)|Indicates that the database will be notified immediately of all changes to a property of a data-bound object.|  
|[in](../vs140/in--c---.md)|Indicates that a parameter is to be passed from the calling procedure to the called procedure.|  
|[local](../vs140/local--c---.md)|Allows you to use the MIDL compiler as a header generator when used in the interface header. When used in an individual function, designates a local procedure for which no stubs are generated.|  
|[nonbrowsable](../vs140/nonbrowsable.md)|Indicates that an interface member should not be displayed in a property browser.|  
|[propget](../vs140/propget.md)|Specifies a property accessor function.|  
|[propput](../vs140/propput.md)|Specifies a property-setting function.|  
|[propputref](../vs140/propputref.md)|Specifies a property-setting function that uses a reference instead of a value.|  
|[ptr](../vs140/ptr.md)|Designates a pointer as a full pointer.|  
|[range](../vs140/range--c---.md)|Specifies a range of allowable values for arguments or fields whose values are set at run time.|  
|[requestedit](../vs140/requestedit.md)|Indicates that the property supports the **OnRequestEdit** notification.|  
|[restricted](../vs140/restricted.md)|Specifies that a member of a module, interface, or dispinterface cannot be called arbitrarily.|  
|[satype](../vs140/satype.md)|Specifies the data type of the **SAFEARRAY** structure.|  
|[source](../vs140/source--c---.md)|Specifies the control's source interfaces for connection points on a class. On a property or method, the **source** attribute indicates that the member returns an object or VARIANT that is a source of events.|  
|[synchronize](../vs140/synchronize.md)|Synchronizes access to the target method.|  
|[vararg](../vs140/vararg.md)|Specifies that the function take a variable number of arguments.|  
  
## See Also  
 [Attributes by Usage](../vs140/attributes-by-usage.md)