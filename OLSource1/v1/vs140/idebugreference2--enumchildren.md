---
title: "IDebugReference2::EnumChildren"
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
  - "IDebugReference2::EnumChildren"
helpviewer_keywords: 
  - "IDebugReference2::EnumChildren"
ms.assetid: 35b3c2f3-69f4-4013-b555-f847221f62e8
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugReference2::EnumChildren
Get a list of selected children of a reference. Reserved for future use.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] A combination of flags from the [DEBUGREF_INFO_FLAGS](../vs140/debugref_info_flags.md) enumeration that specifies which fields in the enumerated [DEBUG_REFERENCE_INFO](../vs140/debug_reference_info.md) structures are to be filled in.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] The radix to be used in formatting any numerical information.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] A combination of flags from the [DBG_ATTRIB_FLAGS](../vs140/dbg_attrib_flags.md) enumeration that is used as a filter in combination with the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter to select which structures are to be enumerated.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [in] A string specifying a filter, such as "MyX", used in combination with the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> parameter to select the structures to be enumerated.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 [in] Maximum time, in milliseconds, to wait before returning from this method. Use <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to wait indefinitely.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 [out] Returns an [IEnumDebugReferenceInfo2](../vs140/ienumdebugreferenceinfo2.md) object that contains a list of the requested child properties.  
  
## Return Value  
 Always returns <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
## See Also  
 [IDebugReference2](../vs140/idebugreference2.md)   
 [DEBUGREF_INFO_FLAGS](../vs140/debugref_info_flags.md)   
 [DBG_ATTRIB_FLAGS](../vs140/dbg_attrib_flags.md)   
 [IEnumDebugReferenceInfo2](../vs140/ienumdebugreferenceinfo2.md)