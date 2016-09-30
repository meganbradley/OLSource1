---
title: "ON_COMMAND_EX"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "ON_COMMAND_EX"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "message mapping macros"
  - "ON_COMMAND_EX macro"
ms.assetid: 0bb49090-aee8-4203-87c8-dd001d3dd26e
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ON_COMMAND_EX
This macro maps a command message to an extended command-handler member function.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The command ID.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The name of the message-handler function to which the command is mapped.  
  
## Remarks  
 An extended form of command message handlers is available for advanced uses. The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> macro is used for such message handlers, and it provides a superset of the [ON_COMMAND](../vs140/on_command.md) functionality. Extended command-handler member functions take a single parameter, a **UINT** containing the command ID, and return a **BOOL**. The return value should be TRUE to indicate that the command has been handled; otherwise routing will continue to other command target objects.  
  
 For more information, see Technical Note [TN006: Message Maps](../vs140/tn006--message-maps.md).  
  
## Requirements  
 Header file: afxmsg_.h  
  
## See Also  
 [ON_COMMAND](../vs140/on_command.md)   
 [TN006: Message Maps](../vs140/tn006--message-maps.md)