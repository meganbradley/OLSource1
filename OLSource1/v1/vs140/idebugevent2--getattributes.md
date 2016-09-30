---
title: "IDebugEvent2::GetAttributes"
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
  - "IDebugEvent2::GetAttributes"
helpviewer_keywords: 
  - "IDebugEvent2::GetAttributes"
ms.assetid: 2ac5b5fb-da17-43f7-811a-313f677e60d7
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugEvent2::GetAttributes
Gets the attributes for this debug event.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] A combination of flags from the [EVENTATTRIBUTES](../vs140/eventattributes.md) enumeration.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 The [IDebugEvent2](../vs140/idebugevent2.md) interface is common to all events. This method describes the type of event; for example, is the event synchronous or asynchronous and is it a stopping event.  
  
## See Also  
 [IDebugEvent2](../vs140/idebugevent2.md)   
 [EVENTATTRIBUTES](../vs140/eventattributes.md)