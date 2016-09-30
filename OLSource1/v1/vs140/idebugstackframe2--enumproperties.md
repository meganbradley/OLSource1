---
title: "IDebugStackFrame2::EnumProperties"
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
  - "IDebugStackFrame2::EnumProperties"
helpviewer_keywords: 
  - "IDebugStackFrame2::EnumProperties"
ms.assetid: 334bb95e-c7e0-4008-9f06-8c3999e47ee8
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugStackFrame2::EnumProperties
Creates an enumerator for properties associated with the stack frame, such as local variables.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] A combination of flags from the [DEBUGPROP_INFO_FLAGS](../vs140/debugprop_info_flags.md) enumeration that specifies which fields in the enumerated [DEBUG_PROPERTY_INFO](../vs140/debug_property_info.md) structures are to be filled in.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] The radix to be used in formatting any numerical information.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] A GUID of a filter used to select which [DEBUG_PROPERTY_INFO](../vs140/debug_property_info.md) structures are to be enumerated, such as <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [in] Maximum time, in milliseconds, to wait before returning from this method. Use <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to wait indefinitely.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 [out] Returns the number of properties enumerated. This is the same as calling the [GetCount](../vs140/ienumdebugpropertyinfo2--getcount.md) method.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 [out] Returns an [IEnumDebugPropertyInfo2](../vs140/ienumdebugpropertyinfo2.md) object containing a list of the desired properties.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 Because this method allows all selected properties to be retrieved with a single call, it is faster than sequentially calling the [IDebugStackFrame2::GetDebugProperty](../vs140/idebugstackframe2--getdebugproperty.md) and [IDebugProperty2::EnumChildren](../vs140/idebugproperty2--enumchildren.md) methods.  
  
## See Also  
 [IDebugStackFrame2](../vs140/idebugstackframe2.md)   
 [DEBUGPROP_INFO_FLAGS](../vs140/debugprop_info_flags.md)   
 [IEnumDebugPropertyInfo2](../vs140/ienumdebugpropertyinfo2.md)   
 [GetCount](../vs140/ienumdebugpropertyinfo2--getcount.md)   
 [IDebugStackFrame2::GetDebugProperty](../vs140/idebugstackframe2--getdebugproperty.md)   
 [IDebugProperty2::EnumChildren](../vs140/idebugproperty2--enumchildren.md)