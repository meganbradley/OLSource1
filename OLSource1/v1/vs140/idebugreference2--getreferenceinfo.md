---
title: "IDebugReference2::GetReferenceInfo"
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
  - "IDebugReference2::GetReferenceInfo"
helpviewer_keywords: 
  - "IDebugReference2::GetReferenceInfo"
ms.assetid: ae611714-f114-4cf2-b5bb-37461e6ff289
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugReference2::GetReferenceInfo
Gets the [DEBUG_REFERENCE_INFO](../vs140/debug_reference_info.md) structure that describes a reference. Reserved for future use.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] A combination of flags from the [DEBUGREF_INFO_FLAGS](../vs140/debugref_info_flags.md) enumeration that determine the fields to be filled out in the [DEBUG_REFERENCE_INFO](../vs140/debug_reference_info.md) structure.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] The radix to be used in formatting any numerical information.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] Maximum time, in milliseconds, to wait before returning from this method. Use <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to wait indefinitely.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [in] An array of [IDebugReference2](../vs140/idebugreference2.md) objects. Reserved for future use; set to a null value.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 [in] The number of reference arguments in the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> array. Reserved for future use; set to 0.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 [out] A [DEBUG_REFERENCE_INFO](../vs140/debug_reference_info.md) structure that is filled in with a description of the property.  
  
## Return Value  
 Always returns <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## See Also  
 [IDebugReference2](../vs140/idebugreference2.md)   
 [DEBUGREF_INFO_FLAGS](../vs140/debugref_info_flags.md)   
 [DEBUG_REFERENCE_INFO](../vs140/debug_reference_info.md)