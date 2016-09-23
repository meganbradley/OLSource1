---
title: "ICommandTarget::Initialize"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - Initialize
  - ICommandTarget::Initialize
  - ICommandTarget.Initialize
dev_langs: 
  - C++
helpviewer_keywords: 
  - Initialize method
ms.assetid: f580a1f4-d711-4b22-8651-6c1314536a11
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# ICommandTarget::Initialize
Initializes the command target object.  
  
## Syntax  
  
```  
void Initialize(  
   ICommandSource^ cmdSource  
);  
```  
  
#### Parameters  
 `cmdSource`  
 A handle to the command source object.  
  
## Remarks  
 When you host a user control in an MFC View, [CWinFormsView](../vs140/cwinformsview-class.md) routes commands and update command UI messages to the user control to allow it to handle MFC commands.  
  
 This method initializes the command target object and associates it with the specified command source object `cmdSource`. It should be called in the user control class implementation. At initialization, you should register command handlers with the command source object by calling [ICommandSource::AddCommandHandler](../vs140/icommandsource--addcommandhandler.md) in the `Initialize` implementation. See [How To: Add Command Routing to the Windows Forms Control](../vs140/how-to--add-command-routing-to-the-windows-forms-control.md) for an example of how to use `Initialize` to do this.  
  
## Requirements  
 **Header:** afxwinforms.h  
  
## See Also  
 [ICommandTarget Interface](../vs140/icommandtarget-interface.md)   
 [ICommandSource Interface](../vs140/icommandsource-interface.md)