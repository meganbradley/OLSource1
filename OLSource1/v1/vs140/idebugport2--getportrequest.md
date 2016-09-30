---
title: "IDebugPort2::GetPortRequest"
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
  - "IDebugPort2::GetPortRequest"
helpviewer_keywords: 
  - "IDebugPort2::GetPortRequest"
ms.assetid: 14abf847-0675-4fa8-872e-971e00c84224
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugPort2::GetPortRequest
Gets the description of a port that was previously used to create the port (if available).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] Returns an [IDebugPortRequest2](../vs140/idebugportrequest2.md) object representing the request that was used to create the port.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>; otherwise, returns an error code.  Returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if a port was not created using an [IDebugPortRequest2](../vs140/idebugportrequest2.md) port request.  
  
## See Also  
 [IDebugPort2](../vs140/idebugport2.md)   
 [IDebugPortRequest2](../vs140/idebugportrequest2.md)   
 [AddPort](../vs140/idebugportsupplier2--addport.md)