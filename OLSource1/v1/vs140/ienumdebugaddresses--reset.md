---
title: "IEnumDebugAddresses::Reset"
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
  - "IEnumDebugAddresses::Reset"
helpviewer_keywords: 
  - "IEnumDebugAddresses::Reset method"
ms.assetid: 3a9d7f20-5bc6-4e13-8e91-5af4092e092f
caps.latest.revision: 9
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IEnumDebugAddresses::Reset
This method resets the enumeration to the first element.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 None  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 After this method is called, the next call to [IEnumDebugAddresses::Next](../vs140/ienumdebugaddresses--next.md) returns the first element of the enumeration.  
  
## See Also  
 [IEnumDebugAddresses](../vs140/ienumdebugaddresses.md)   
 [IEnumDebugAddresses::Next](../vs140/ienumdebugaddresses--next.md)