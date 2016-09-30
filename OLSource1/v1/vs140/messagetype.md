---
title: "MESSAGETYPE"
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
  - "MESSAGETYPE"
helpviewer_keywords: 
  - "MESSAGETYPE enumeration"
ms.assetid: 800cc77d-3c27-4763-a9df-552a9384bd49
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# MESSAGETYPE
Specifies the message type and reason.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Members  
 MT_OUTPUTSTRING  
 Indicates that the message should be sent to the output window. This is mutually exclusive from <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 MT_MESSAGEBOX  
 Indicates that the message should be shown in a message box. This is mutually exclusive from <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 MT_TYPE_MASK  
 A mask value to isolate the destination for the message.  
  
 MT_REASON_EXCEPTION  
 Indicates that a message box is being shown as a result of an exception. This is mutually exclusive from <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 MT_REASON_TRACEPOINT  
 Indicates that a message box is being shown as a result of hitting a tracepoint. This is mutually exclusive to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 MT_REASON_MASK  
 A mask value to isolate the reason for the message being shown.  
  
## Remarks  
 These values are returned from the [GetMessage](../vs140/idebugmessageevent2--getmessage.md) and [IDebugErrorEvent2::GetErrorMessage](../vs140/idebugerrorevent2--geterrormessage.md) methods.  
  
 One of the reason values can be combined with one of the output destination values using a bitwise <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations (Visual Studio Debugging SDK)](../vs140/enumerations--visual-studio-debugging-.md)   
 [GetMessage](../vs140/idebugmessageevent2--getmessage.md)   
 [IDebugErrorEvent2::GetErrorMessage](../vs140/idebugerrorevent2--geterrormessage.md)