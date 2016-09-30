---
title: "IDebugCoreServer3::EnableAutoAttach"
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
  - "IDebugCoreServer3::EnableAutoAttach"
helpviewer_keywords: 
  - "IDebugCoreServer3::EnableAutoAttach"
ms.assetid: 06aa633b-263b-4e08-8844-9a52d5120b94
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugCoreServer3::EnableAutoAttach
Enables automatic attaching for the specified debug engines.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] Array of GUIDs for each debug engine to mark as auto-attaching.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] The number of engines specified in <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [in] The starting URL to use when auto-attaching.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [out] ID of the session that was auto-attached.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>; otherwise returns error code. One error code is <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, which indicates that the auto-attach class factory has not been registered.  
  
## Remarks  
 When a program associated with the specified URL is started, the specified debug engines are automatically started and attached.  
  
## See Also  
 [IDebugCoreServer3](../vs140/idebugcoreserver3.md)