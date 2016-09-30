---
title: "IDebugMessageEvent2::GetMessage"
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
  - "IDebugMessageEvent2::GetMessage"
helpviewer_keywords: 
  - "GetMessage method"
  - "IDebugMessageEvent2::GetMessage method"
ms.assetid: 9fca7285-f7f1-422d-8565-92bf0e0db60a
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugMessageEvent2::GetMessage
Gets the message to be displayed.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] Returns a value from the [MESSAGETYPE](../vs140/messagetype.md) enumeration that describes the type of the message.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Returns the message.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [out] Returns the type of the message, using the conventions of the Win32 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function. See the [AfxMessageBox](../vs140/afxmessagebox.md) function for details.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [in, out] Returns the help file name. May be a null (C++) or empty (C#) value if there is no help file.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 [in, out] Returns the help identifier. May be 0 if there is no help associated with this message.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## See Also  
 [IDebugMessageEvent2](../vs140/idebugmessageevent2.md)   
 [MESSAGETYPE](../vs140/messagetype.md)   
 [AfxMessageBox](../vs140/afxmessagebox.md)