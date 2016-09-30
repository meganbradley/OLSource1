---
title: "DEBUGPROP_INFO_FLAGS"
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
  - "DEBUGPROP_INFO_FLAGS"
helpviewer_keywords: 
  - "DBGPROP_INFO_FLAGS enumeration"
ms.assetid: 1c7fe777-615e-4929-9ed4-970d9fe0eb81
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# DEBUGPROP_INFO_FLAGS
Specifies what information to retrieve about a debug property object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Members  
 DEBUGPROP_INFO_FULLNAME  
 Initialize/use the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> field.  
  
 DEBUGPROP_INFO_NAME  
 Initialize/use the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> field.  
  
 DEBUGPROP_INFO_TYPE  
 Initialize/use the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> field.  
  
 DEBUGPROP_INFO_VALUE  
 Initialize/use the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> field.  
  
 DEBUGPROP_INFO_ATTRIB  
 Initialize/use the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> field.  
  
 DEBUGPROP_INFO_PROP,  
 Initialize/use the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> field that contains an [IDebugProperty2](../vs140/idebugproperty2.md) interface.  
  
 DEBUGPROP_INFO_VALUE_AUTOEXPAND  
 Specifies that the value field should contain the auto-expanded value, if available, for this type of object.  
  
 DEBUGPROP_INFO_VALUE_NOFUNCEVAL  
 Deprecated.  
  
 DEBUGPROP_INFO_VALUE_RAW  
 Do not return any beautified values or members (that is, do not format the values).  
  
 DEBUGPROP_INFO_VALUE_NO_TOSTRING  
 Do not return any special synthesized values (for example, do not call <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> on an object to produce a value).  
  
 DEBUGPROP_INFO_NONE  
 Specifies that no flags are set.  
  
 DEBUGPROP_INFO_STANDARD  
 Initialize/use the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> fields.  
  
 DEBUGPROP_INFO_All  
 Indicates a mask of all flags.  
  
## Remarks  
 These values are passed to the [IDebugProperty2::GetPropertyInfo](../vs140/idebugproperty2--getpropertyinfo.md), [IDebugProperty2::EnumChildren](../vs140/idebugproperty2--enumchildren.md), and [IDebugStackFrame2::EnumProperties](../vs140/idebugstackframe2--enumproperties.md) methods to indicate which fields are to be initialized the [DEBUG_PROPERTY_INFO](../vs140/debug_property_info.md) structure.  
  
 These values are also used for the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> member of the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> structure to indicate which fields of the structure are used and valid when the structure is returned.  
  
 These values may be combined with a bitwise <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations (Visual Studio Debugging SDK)](../vs140/enumerations--visual-studio-debugging-.md)   
 [IDebugProperty2](../vs140/idebugproperty2.md)   
 [IDebugProperty2::GetPropertyInfo](../vs140/idebugproperty2--getpropertyinfo.md)   
 [IDebugProperty2::EnumChildren](../vs140/idebugproperty2--enumchildren.md)   
 [IDebugStackFrame2::EnumProperties](../vs140/idebugstackframe2--enumproperties.md)   
 [DEBUG_PROPERTY_INFO](../vs140/debug_property_info.md)