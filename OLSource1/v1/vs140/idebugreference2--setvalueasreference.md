---
title: "IDebugReference2::SetValueAsReference"
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
  - "IDebugReference2::SetValueAsReference"
helpviewer_keywords: 
  - "IDebugReference2::SetValueAsReference"
ms.assetid: 94a545d2-16b9-45e9-b2e7-4e49ff90aad0
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugReference2::SetValueAsReference
Sets the value of a reference from another reference. Reserved for future use.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] An array of [IDebugReference2](../vs140/idebugreference2.md) objects used to determine how to set the reference value.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] The number of references in the array.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] An [IDebugReference2](../vs140/idebugreference2.md) object from which to set the property value.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [in] Maximum time, in milliseconds, to wait before returning from this method. Use <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to wait indefinitely.  
  
## Return Value  
 Always returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## See Also  
 [IDebugReference2](../vs140/idebugreference2.md)