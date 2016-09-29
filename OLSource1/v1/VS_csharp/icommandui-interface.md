---
title: "ICommandUI Interface"
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
  - "ICommandUI"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ICommandUI interface"
ms.assetid: 134afe8d-dcdf-47ca-857a-a166a6b665dd
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ICommandUI Interface
Manages user interface commands.  
  
## Syntax  
  
```  
interface class ICommandUI  
```  
  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[ICommandUI::Check](../VS_csharp/icommandui--check.md)|Sets the user interface item for this command to the appropriate check state.|  
|[ICommandUI::ContinueRouting](../VS_csharp/icommandui--continuerouting.md)|Tells the command-routing mechanism to continue routing the current message down the chain of handlers.|  
|[ICommandUI::Enabled](../VS_csharp/icommandui--enabled.md)|Enables or disables the user interface item for this command.|  
|[ICommandUI::ID](../VS_csharp/icommandui--id.md)|Gets the ID of the user interface object represented by the `ICommandUI` object.|  
|[ICommandUI::Index](../VS_csharp/icommandui--index.md)|Gets the index of the user interface object represented by the `ICommandUI` object.|  
|[ICommandUI::Radio](../VS_csharp/icommandui--radio.md)|Sets the user interface item for this command to the appropriate check state.|  
|[ICommandUI::Text](../VS_csharp/icommandui--text.md)|Sets the text of the user interface item for this command.|  
  
## Remarks  
 This interface provides methods and properties that manage user interface commands. `ICommandUI` is similar to [CCmdUI](../VS_csharp/ccmdui-class.md), except that `ICommandUI` is used for MFC applications that interoperate with .NET components.  
  
 `ICommandUI` is used within an `ON_UPDATE_COMMAND_UI` handler in an [ICommandTarget](../VS_csharp/icommandtarget-interface.md)-derived class. When a user of an application activates (selects or clicks) a menu, each menu item is displayed as enabled or disabled. The target of each menu command provides this information by implementing an `ON_UPDATE_COMMAND_UI` handler. For each of the command user interface objects in your application, use the Properties window to create a message-map entry and function prototype for each handler.  
  
 For more information on how the `ICommandUI` interface is used in command routing, see [How To: Add Command Routing to the Windows Forms Control](../VS_csharp/how-to--add-command-routing-to-the-windows-forms-control.md).  
  
 For more information on using Windows Forms, see [Using Windows Forms in MFC](../VS_csharp/using-a-windows-form-user-control-in-mfc.md).  
  
 For more information on how user interface commands are managed in MFC, see [CCmdUI](../VS_csharp/ccmdui-class.md).  
  
## Requirements  
 **Header:** afxwinforms.h (defined in assembly atlmfc\lib\mfcmifc80.dll)  
  
## See Also  
 [CCmdUI Class](../VS_csharp/ccmdui-class.md)