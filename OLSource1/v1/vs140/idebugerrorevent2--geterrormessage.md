---
title: "IDebugErrorEvent2::GetErrorMessage"
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
  - "IDebugErrorEvent2::GetErrorMessage"
helpviewer_keywords: 
  - "IDebugErrorEvent2::GetErrorMessage"
ms.assetid: 9e3b0d74-a2dd-4eaa-bd95-21b2f9c79409
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugErrorEvent2::GetErrorMessage
Returns information that allows construction of a human-readable error message.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] Returns a value from the [MESSAGETYPE](../vs140/messagetype.md) enumeration, describing the type of message.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] The format of the final message to the user (see "Remarks" for details).  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [out] The error code the message is about.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [out] Severity of the error (use the MB_XXX constants for <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>; for example, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>).  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 [out] Path to a help file (set to a null value if there is no help file).  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 [out] ID of the help topic to display (set to 0 if there is no help topic).  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 The error message should be formatted along the lines of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> would then be replaced by the caller with the error message derived from the error code (which is returned in <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>). The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> parameter tells the caller how the final error message should be displayed.  
  
## See Also  
 [IDebugErrorEvent2](../vs140/idebugerrorevent2.md)   
 [MESSAGETYPE](../vs140/messagetype.md)