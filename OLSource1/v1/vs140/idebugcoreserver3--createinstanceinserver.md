---
title: "IDebugCoreServer3::CreateInstanceInServer"
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
  - "IDebugCoreServer3::CreateInstanceInServer"
helpviewer_keywords: 
  - "IDebugCoreServer3::CreateInstanceInServer"
ms.assetid: 76f36bae-f6ab-413c-a8a9-8808bfeba05b
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugCoreServer3::CreateInstanceInServer
Creates an instance of a debug engine on the server.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] Path to the dll that implements the CLSID specified in the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter. If this is <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, then COM's <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function is called.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [in] Locale of the debug engine. This can be 0 if the [IDebugEngine2::SetLocale](../vs140/idebugengine2--setlocale.md) method should not be called.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 [in] CLSID of the debug engine to create.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 [in] Interface ID of the specific interface to retrieve from the class object.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 [out] <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> interface from the instantiated object. Cast or marshal this object to the desired interface.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## See Also  
 [IDebugCoreServer3](../vs140/idebugcoreserver3.md)   
 [IDebugEngine2::SetLocale](../vs140/idebugengine2--setlocale.md)