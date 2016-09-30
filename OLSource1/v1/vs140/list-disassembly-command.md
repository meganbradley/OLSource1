---
title: "List Disassembly Command"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "debug.listdisassembly"
helpviewer_keywords: 
  - "Debug.ListDisassembly command"
  - "list disassembly command"
ms.assetid: eb363e35-e86a-4121-966f-991210c27e2a
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# List Disassembly Command
Begins the debug process and allows you to specify how errors are handled.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Switches  
 Each switch can be invoked using either its complete form or a short form.  
  
 /count: <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> [or] /c: <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> [or] /length: <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> [or] /l: <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Optional. Number of instructions to display. Default value is 8.  
  
 /endaddress: <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> [or] /e: <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Optional. Address at which to stop disassembly.  
  
 /codebytes:<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>9\</CodeContentPlaceHolder> [or] /bytes:<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>11\</CodeContentPlaceHolder> [or] /b:<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 Optional. Indicates whether to display code bytes. Default value is <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
 /source:<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>16\</CodeContentPlaceHolder> [or] /s:<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 Optional. Indicates whether to display source code. Default value is <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
 /symbolnames:<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>21\</CodeContentPlaceHolder> [or] /names:<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>23\</CodeContentPlaceHolder> [or] /n:<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 Optional. Indicates whether to display symbols names. Default value is <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
 [/linenumbers:<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>]  
 Optional. Enables the viewing of line numbers associated with the source code. The /source switch must have a value of <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> to use the /linenumbers switch.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [List Call Stack Command](../vs140/list-call-stack-command.md)   
 [List Threads Command](../vs140/list-threads-command.md)   
 [Visual Studio Commands](../vs140/visual-studio-commands.md)   
 [Command Window](../vs140/command-window.md)   
 [Find/Command Box](../vs140/find-command-box.md)   
 [Visual Studio Command Aliases](../vs140/visual-studio-command-aliases.md)