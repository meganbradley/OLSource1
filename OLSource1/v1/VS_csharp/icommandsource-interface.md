---
title: "ICommandSource Interface"
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
  - "ICommandSource"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ICommandSource interface"
ms.assetid: a4b1f698-c09f-4ba8-9b13-0e74a0a4967e
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ICommandSource Interface
Manages commands sent from a command source object to a user control.  
  
## Syntax  
  
```  
interface class ICommandSource  
```  
  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[ICommandSource::AddCommandHandler](../VS_csharp/icommandsource--addcommandhandler.md)|Adds a command handler to a command source object.|  
|[ICommandSource::AddCommandRangeHandler](../VS_csharp/icommandsource--addcommandrangehandler.md)|Adds a group of command handlers to a command source object.|  
|[ICommandSource::AddCommandRangeUIHandler](../VS_csharp/icommandsource--addcommandrangeuihandler.md)|Adds a group of user interface command message handlers to a command source object.|  
|[ICommandSource::AddCommandUIHandler](../VS_csharp/icommandsource--addcommanduihandler.md)|Adds a user interface command message handler to a command source object.|  
|[ICommandSource::PostCommand](../VS_csharp/icommandsource--postcommand.md)|Posts a message without waiting for it to be processed.|  
|[ICommandSource::RemoveCommandHandler](../VS_csharp/icommandsource--removecommandhandler.md)|Removes a command handler from a command source object.|  
|[ICommandSource::RemoveCommandRangeHandler](../VS_csharp/icommandsource--removecommandrangehandler.md)|Removes a group of command handlers from a command source object.|  
|[ICommandSource::RemoveCommandRangeUIHandler](../VS_csharp/icommandsource--removecommandrangeuihandler.md)|Removes a group of user interface command message handlers from a command source object.|  
|[ICommandSource::RemoveCommandUIHandler](../VS_csharp/icommandsource--removecommanduihandler.md)|Removes a user interface command message handler from a command source object.|  
|[ICommandSource::SendCommand](../VS_csharp/icommandsource--sendcommand.md)|Sends a message and waits for it to be processed before returning.|  
  
## Remarks  
 When you host a user control in an MFC View, [CWinFormsView](../VS_csharp/cwinformsview-class.md) routes commands and update command UI messages to the user control to allow it to handle MFC commands (for example, frame menu items and toolbar buttons). By implementing [ICommandTarget](../VS_csharp/icommandtarget-interface.md), you give the user control a reference to the `ICommandSource` object.  
  
 See [How To: Add Command Routing to the Windows Forms Control](../VS_csharp/how-to--add-command-routing-to-the-windows-forms-control.md) for an example of how to use `ICommandTarget`.  
  
 For more information on using Windows Forms, see [Using Windows Forms in MFC](../VS_csharp/using-a-windows-form-user-control-in-mfc.md).  
  
## Requirements  
 **Header:** afxwinforms.h (defined in assembly atlmfc\lib\mfcmifc80.dll)  
  
## See Also  
 [How To: Add Command Routing to the Windows Forms Control](../VS_csharp/how-to--add-command-routing-to-the-windows-forms-control.md)   
 [ICommandTarget Interface](../VS_csharp/icommandtarget-interface.md)