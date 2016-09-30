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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[ICommandUI::Check](../vs140/icommandui--check.md)|Sets the user interface item for this command to the appropriate check state.|  
|[ICommandUI::ContinueRouting](../vs140/icommandui--continuerouting.md)|Tells the command-routing mechanism to continue routing the current message down the chain of handlers.|  
|[ICommandUI::Enabled](../vs140/icommandui--enabled.md)|Enables or disables the user interface item for this command.|  
|[ICommandUI::ID](../vs140/icommandui--id.md)|Gets the ID of the user interface object represented by the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.|  
|[ICommandUI::Index](../vs140/icommandui--index.md)|Gets the index of the user interface object represented by the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.|  
|[ICommandUI::Radio](../vs140/icommandui--radio.md)|Sets the user interface item for this command to the appropriate check state.|  
|[ICommandUI::Text](../vs140/icommandui--text.md)|Sets the text of the user interface item for this command.|  
  
## Remarks  
 This interface provides methods and properties that manage user interface commands. <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is similar to [CCmdUI](../vs140/ccmdui-class.md), except that <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is used for MFC applications that interoperate with .NET components.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is used within an <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> handler in an [ICommandTarget](../vs140/icommandtarget-interface.md)-derived class. When a user of an application activates (selects or clicks) a menu, each menu item is displayed as enabled or disabled. The target of each menu command provides this information by implementing an <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> handler. For each of the command user interface objects in your application, use the Properties window to create a message-map entry and function prototype for each handler.  
  
 For more information on how the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> interface is used in command routing, see [How To: Add Command Routing to the Windows Forms Control](../vs140/how-to--add-command-routing-to-the-windows-forms-control.md).  
  
 For more information on using Windows Forms, see [Using Windows Forms in MFC](../vs140/using-a-windows-form-user-control-in-mfc.md).  
  
 For more information on how user interface commands are managed in MFC, see [CCmdUI](../vs140/ccmdui-class.md).  
  
## Requirements  
 **Header:** afxwinforms.h (defined in assembly atlmfc\lib\mfcmifc80.dll)  
  
## See Also  
 [CCmdUI Class](../vs140/ccmdui-class.md)