---
title: "IDebugProperty2::EnumChildren"
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
  - "IDebugProperty2::EnumChildren"
helpviewer_keywords: 
  - "IDebugProperty2::EnumChildren"
ms.assetid: cf79f666-65d1-417c-af7c-9271bac9a267
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProperty2::EnumChildren
Retrieves a list of the children of the property.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] A combination of flags from the [DEBUGPROP_INFO_FLAGS](../vs140/debugprop_info_flags.md) enumeration that specifies which fields in the enumerated [DEBUG_PROPERTY_INFO](../vs140/debug_property_info.md) structures are to be filled in.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] Specifies the radix to be used in formatting any numerical information.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] GUID of the filter used with the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameters to select which <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> children are to be enumerated. For example, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> filters for local variables.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 [in] A combination of flags from the [DBG_ATTRIB_FLAGS](../vs140/dbg_attrib_flags.md) enumeration that specifies what type of objects to enumerate, for example <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> for all methods that might be children of this property. Used in combination with the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> parameters.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 [in] The name of the filter used with the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> parameters to select which <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> children are to be enumerated. For example, setting this parameter to "MyX" filters for all children with the name "MyX."  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 [in] Specifies the maximum time, in milliseconds, to wait before returning from this method. Use <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> to wait indefinitely.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 [out] Returns an [IEnumDebugPropertyInfo2](../vs140/ienumdebugpropertyinfo2.md) object containing a list of the child properties.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>; otherwise returns error code.  
  
## See Also  
 [IDebugProperty2](../vs140/idebugproperty2.md)   
 [DEBUGPROP_INFO_FLAGS](../vs140/debugprop_info_flags.md)   
 [DBG_ATTRIB_FLAGS](../vs140/dbg_attrib_flags.md)   
 [IEnumDebugPropertyInfo2](../vs140/ienumdebugpropertyinfo2.md)