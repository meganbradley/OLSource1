---
title: "IDebugProperty2::SetValueAsString"
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
  - "IDebugProperty2::SetValueAsString"
helpviewer_keywords: 
  - "IDebugProperty2::SetValueAsString"
ms.assetid: 9e6a5054-41b7-4223-b509-b93689d366a5
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProperty2::SetValueAsString
Sets the value of a property from a given string.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] A string containing the value to be set.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] A radix to be used in interpreting any numerical information. This can be 0 to attempt to determine the radix automatically.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] Specifies the maximum time, in milliseconds, to wait before returning from this method. Use <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to wait indefinitely.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>; otherwise returns error code. The following table shows other possible values.  
  
|Value|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|The string could not be converted into a property value, or the property value could not be set.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|The property is read-only.|  
  
## See Also  
 [IDebugProperty2](../vs140/idebugproperty2.md)