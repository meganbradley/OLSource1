---
title: "IDebugCoreServer3::QueryIsLocal"
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
  - "IDebugCoreServer3::QueryIsLocal"
helpviewer_keywords: 
  - "IDebugCoreServer3::QueryIsLocal"
ms.assetid: cca030de-f853-4ed7-b2fb-395f08a6b884
caps.latest.revision: 10
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugCoreServer3::QueryIsLocal
Determines if the server is local to the caller.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Return Value  
 Returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to indicate the server is local. Returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if the server is running from an instance of msvsmon.exe, which is typically used for remote debugging.  
  
## See Also  
 [IDebugCoreServer3](../vs140/idebugcoreserver3.md)