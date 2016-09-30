---
title: "IEEDataStorage"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IEEDataStorage"
helpviewer_keywords: 
  - "IEEDataStorage interface"
ms.assetid: 704e932d-2325-410e-89c4-ce88c6ec19da
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IEEDataStorage
This interface represents an array of bytes.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Notes for Implementers  
 The expression evaluator (EE) implements this interface to represent an array of bytes (used by type visualizers to retrieve and change data through the [IPropertyProxyEESide](../vs140/ipropertyproxyeeside.md) interface). The EE typically implements this interface to support external type visualizers.  
  
## Notes for Callers  
 The methods on the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> interface all return this interface. Call [IPropertyProxyProvider::GetPropertyProxy](../vs140/ipropertyproxyprovider--getpropertyproxy.md) to obtain the [IPropertyProxyEESide](../vs140/ipropertyproxyeeside.md) interface. Call [QueryInterface](../vs140/queryinterface.md) on an [IDebugProperty3](../vs140/idebugproperty3.md) interface to obtain the [IPropertyProxyProvider](../vs140/ipropertyproxyprovider.md) interface.  
  
## Methods in Vtable order  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> interface implements the following methods:  
  
|Method|Description|  
|------------|-----------------|  
|[GetData](../vs140/ieedatastorage--getdata.md)|Retrieves the specified number of data bytes to a supplied buffer.|  
|[GetSize](../vs140/ieedatastorage--getsize.md)|Retrieves the number of data bytes available.|  
  
## Remarks  
 This interface is used by a type visualizer to access data held by a specific object. The data is treated as an array of bytes, allowing the type visualizer to manipulate it in whatever way is required to present it to the user.  
  
 A custom viewer can also use this interface, if desired, although more typically, a custom viewer would use a custom interface, [IDebugProperty2::GetMemoryBytes](../vs140/idebugproperty2--getmemorybytes.md) or [IDebugProperty3::GetStringChars](../vs140/idebugproperty3--getstringchars.md) (for string-oriented data).  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../vs140/core-interfaces.md)   
 [IPropertyProxyEESide](../vs140/ipropertyproxyeeside.md)   
 [Type Visualizer and Custom Viewer](../vs140/type-visualizer-and-custom-viewer.md)