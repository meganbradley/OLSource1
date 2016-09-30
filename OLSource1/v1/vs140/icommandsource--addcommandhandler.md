---
title: "ICommandSource::AddCommandHandler"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "ICommandSource.AddCommandHandler"
  - "ICommandSource::AddCommandHandler"
  - "AddCommandHandler"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddCommandHandler method"
ms.assetid: 0829f789-bf15-4c62-ab41-9ae32925d78d
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ICommandSource::AddCommandHandler
Adds a command handler to a command source object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The command ID.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A handle to the command handler method.  
  
## Remarks  
 This method adds the command handler <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to the command source object and maps the handler to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 See [How To: Add Command Routing to the Windows Forms Control](../vs140/how-to--add-command-routing-to-the-windows-forms-control.md) for an example of how to use <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxwinforms.h  
  
## See Also  
 [ICommandSource Interface](../vs140/icommandsource-interface.md)   
 [ICommandSource::RemoveCommandHandler](../vs140/icommandsource--removecommandhandler.md)