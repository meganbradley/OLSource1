---
title: "IDebugProperty2::GetPropertyInfo"
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
  - "IDebugProperty2::GetPropertyInfo"
helpviewer_keywords: 
  - "IDebugProperty2::GetPropertyInfo"
ms.assetid: 39d6e942-df72-4c84-a5d9-a386d112714c
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProperty2::GetPropertyInfo
Gets the [DEBUG_PROPERTY_INFO](../vs140/debug_property_info.md) structure that describes a property.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] A combination of values from the [DEBUGPROP_INFO_FLAGS](../vs140/debugprop_info_flags.md) enumeration that specifies which fields are to be filled out in the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> structure.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] Radix to be used in formatting any numerical information.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [in] Specifies the maximum time, in milliseconds, to wait before returning from this method. Use <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to wait indefinitely.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 [in, out] Reserved for future use; set to a null value.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 [in] Reserved for future use; set to zero.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 [out] A [DEBUG_PROPERTY_INFO](../vs140/debug_property_info.md) structure that is filled in with the description of the property.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>; otherwise returns error code.  
  
## See Also  
 [IDebugProperty2](../vs140/idebugproperty2.md)   
 [DEBUGPROP_INFO_FLAGS](../vs140/debugprop_info_flags.md)   
 [IDebugReference2](../vs140/idebugreference2.md)   
 [DEBUG_PROPERTY_INFO](../vs140/debug_property_info.md)