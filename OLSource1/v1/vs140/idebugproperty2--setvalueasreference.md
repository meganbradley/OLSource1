---
title: "IDebugProperty2::SetValueAsReference"
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
  - "IDebugProperty2::SetValueAsReference"
helpviewer_keywords: 
  - "IDebugProperty2::SetValueAsReference method"
ms.assetid: 341b1b89-4ab8-4e1c-abe2-fb955df5c6b0
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProperty2::SetValueAsReference
Sets the value of this property to the value of the given reference.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] An array of arguments to pass to the managed code property setter. If the property setter does not take arguments or if this [IDebugProperty2](../vs140/idebugproperty2.md) object does not refer to such a property setter, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> should be a null value. This parameter is typically a null value.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] The number of arguments in the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> array.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [in] A reference, in the form of an [IDebugReference2](../vs140/idebugreference2.md) object, to the value to use to set this property.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 [in] How long to take to set the value, in milliseconds. A typical value is <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. This affects the length of time that any possible evaluation can take.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>; otherwise returns an error code, typically one of the following:  
  
|Error|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Setting the value from a reference is not supported.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|The value cannot be set, as this property refers to a method.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|The value is read-only and cannot be set.|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|The method is not implemented.|  
  
## See Also  
 [IDebugProperty2](../vs140/idebugproperty2.md)   
 [IDebugReference2](../vs140/idebugreference2.md)