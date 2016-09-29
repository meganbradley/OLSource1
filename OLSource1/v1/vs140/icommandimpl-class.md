---
title: "ICommandImpl Class"
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
  - "ICommandImpl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ICommandImpl class"
ms.assetid: ef285fef-0d66-45e6-a762-b03357098e3b
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ICommandImpl Class
Provides implementation for the [ICommand](https://msdn.microsoft.com/en-us/library/ms709737.aspx) interface.  
  
## Syntax  
  
```  
template <class T, class CommandBase = ICommand>   
class ATL_NO_VTABLE ICommandImpl : public CommandBase  
```  
  
#### Parameters  
 `T`  
 Your class, derived from `ICommandImpl`.  
  
 `CommandBase`  
 A command interface. The default is `ICommand`.  
  
## Members  
  
### Methods  
  
|||  
|-|-|  
|[CancelExecution](../vs140/icommandimpl--cancelexecution.md)|Cancels the current command execution.|  
|[Cancel](../vs140/icommandimpl--cancel.md)|Cancels the current command execution.|  
|[CreateRowset](../vs140/icommandimpl--createrowset.md)|Creates a rowset object.|  
|[Execute](../vs140/icommandimpl--execute.md)|Executes the command.|  
|[GetDBSession](../vs140/icommandimpl--getdbsession.md)|Returns an interface pointer to the session that created the command.|  
|[ICommandImpl](../vs140/icommandimpl--icommandimpl.md)|The constructor.|  
  
### Data Members  
  
|||  
|-|-|  
|[m_bCancel](../vs140/icommandimpl--m_bcancel.md)|Indicates whether the command is to be canceled.|  
|[m_bCancelWhenExecuting](../vs140/icommandimpl--m_bcancelwhenexecuting.md)|Indicates whether the command is to be canceled when executing.|  
|[m_bIsExecuting](../vs140/icommandimpl--m_bisexecuting.md)|Indicates whether the command is currently executing.|  
  
## Remarks  
 A mandatory interface on the command object.  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [OLE DB Provider Templates](../vs140/ole-db-provider-templates--c---.md)   
 [OLE DB Provider Template Architecture](../vs140/ole-db-provider-template-architecture.md)