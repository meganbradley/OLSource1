---
title: "CCmdTarget::OnCmdMsg"
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
  - "CCmdTarget.OnCmdMsg"
  - "CCmdTarget::OnCmdMsg"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CCmdTarget class, operations"
  - "OnCmdMsg method"
ms.assetid: da8e361e-c454-4f61-b6f3-4e8b2a99ba30
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCmdTarget::OnCmdMsg
Called by the framework to route and dispatch command messages and to handle the update of command user-interface objects.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Contains the command ID.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Identifies the command notification code. See **Remarks** for more information about values for <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Used according to the value of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. See **Remarks** for more information about <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 If not **NULL**, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> fills in the **pTarget** and **pmf** members of the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> structure instead of dispatching the command. Typically, this parameter should be **NULL**.  
  
## Return Value  
 Nonzero if the message is handled; otherwise 0.  
  
## Remarks  
 This is the main implementation routine of the framework command architecture.  
  
 At run time, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> dispatches a command to other objects or handles the command itself by calling the root class <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, which does the actual message-map lookup. For a complete description of the default command routing, see [Message Handling and Mapping Topics](../vs140/message-handling-and-mapping.md).  
  
 On rare occasions, you may want to override this member function to extend the framework's standard command routing. Refer to [Technical Note 21](../vs140/tn021--command-and-message-routing.md) for advanced details of the command-routing architecture.  
  
 If you override <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, you must supply the appropriate value for <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, the command notification code, and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, which depends on the value of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. The following table lists their corresponding values:  
  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder> value|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder> value|  
|-------------------|--------------------|  
|CN_COMMAND|[CCmdUI](../vs140/ccmdui-class.md)*|  
|CN_EVENT|AFX_EVENT*|  
|CN_UPDATE_COMMAND_UI|CCmdUI*|  
|CN_OLECOMMAND|[COleCmdUI](../vs140/colecmdui-class.md)*|  
|CN_OLE_UNREGISTER|NULL|  
  
## Example  
 [!code[NVC_MFCDocView#44](../vs140/codesnippet/CPP/ccmdtarget--oncmdmsg_1.cpp)]  
  
 [!code[NVC_MFCDocView#45](../vs140/codesnippet/CPP/ccmdtarget--oncmdmsg_2.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CCmdTarget Class](../vs140/ccmdtarget-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CCmdUI Class](../vs140/ccmdui-class.md)   
 [COleCmdUI Class](../vs140/colecmdui-class.md)