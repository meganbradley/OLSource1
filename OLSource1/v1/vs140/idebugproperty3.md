---
title: "IDebugProperty3"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - IDebugProperty3
helpviewer_keywords: 
  - IDebugProperty3 interface
ms.assetid: 8f9be68d-4490-4eca-8f6b-8a10ed77e226
caps.latest.revision: 16
translation.priority.mt: 
  - de-de
  - ja-jp
---
# IDebugProperty3
This interface provides support for:  
  
-   Retrieving an arbitrarily long string associated with the property.  
  
-   Associating a unique ID with the property.  
  
-   Retrieving a list of custom viewers for the property.  
  
-   Setting the value of a property with the ability to report any resulting errors  
  
## Syntax  
  
```  
IDebugProperty3 : IDebugProperty2  
```  
  
## Notes for Implementers  
 The debug engine (DE) implements this interface on the same object that implements [IDebugProperty2](../vs140/idebugproperty2.md) to provide support for long strings, property IDs, and custom viewers.  
  
## Notes for Callers  
 Call [QueryInterface](../vs140/queryinterface.md) on an `IDebugProperty2` interface to obtain this interface.  
  
## Methods in Vtable Order  
 In addition to the methods inherited from `IDebugProperty2`, the `IDebugProperty3` interface exposes the following methods.  
  
|Method|Description|  
|------------|-----------------|  
|[GetStringCharLength](../vs140/idebugproperty3--getstringcharlength.md)|Returns the length of the string associated with the property.|  
|[GetStringChars](../vs140/idebugproperty3--getstringchars.md)|Returns the string in a user-supplied buffer.|  
|[CreateObjectID](../vs140/idebugproperty3--createobjectid.md)|Creates a unique ID for this property.|  
|[DestroyObjectID](../vs140/idebugproperty3--destroyobjectid.md)|Destroys the unique ID for this property.|  
|[GetCustomViewerCount](../vs140/idebugproperty3--getcustomviewercount.md)|Returns the number of custom viewers that this property can be viewed with.|  
|[GetCustomViewerList](../vs140/idebugproperty3--getcustomviewerlist.md)|Returns the list of custom viewers that this property can be viewed with.|  
|[SetValueAsStringWithError](../vs140/idebugproperty3--setvalueasstringwitherror.md)|Sets the value of this property, returning an error message if anything went wrong.|  
  
## Remarks  
 [IDebugProperty3::SetValueAsStringWithError](../vs140/idebugproperty3--setvalueasstringwitherror.md) is the preferred way for the session debug manager (SDM) to set a property's value.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../vs140/core-interfaces.md)   
 [IDebugProperty2](../vs140/idebugproperty2.md)   
 [IDebugCustomViewer](../vs140/idebugcustomviewer.md)