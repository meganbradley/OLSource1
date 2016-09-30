---
title: "List Call Stack Command"
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
  - "debug.listcallstack"
helpviewer_keywords: 
  - "list call stack command"
  - "Debug.ListCallStack command"
ms.assetid: a8b20bf2-81d2-4069-aea8-23e6b15b4347
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# List Call Stack Command
Displays the current call stack.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Optional. Sets the current stack frame and displays no output.  
  
## Switches  
 Each switch can be invoked using either its complete form or a short form.  
  
 /Count:<CodeContentPlaceHolder>5\</CodeContentPlaceHolder> [or] /C:<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Optional. Maximum number of call stacks to display. The default value is unlimited.  
  
 /ShowTypes:<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>8\</CodeContentPlaceHolder> [or] /T:<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Optional. Specifies whether to display parameter types. Default value is <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 /ShowNames:<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>13\</CodeContentPlaceHolder> [or] /N:<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 Optional. Specifies whether to display parameter names. Default value is <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
 /ShowValues:<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>18\</CodeContentPlaceHolder> [or] /V:<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 Optional. Specifies whether to display parameter values. Default value is <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
 /ShowModule:<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>23\</CodeContentPlaceHolder> [or] /M:<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 Optional. Specifies whether to display the module name. Default value is <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
 /ShowLineOffset:<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>28\</CodeContentPlaceHolder> [or] /#:<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 Optional. Specifies whether to display the line offset. Default value is <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
 /ShowByteOffset:<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>33\</CodeContentPlaceHolder> [or] /B:<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 Optional. Specifies whether to display the byte offset. Default value is <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.  
  
 /ShowLanguage:<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>38\</CodeContentPlaceHolder> [or] /L:<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 Optional. Specifies whether to display the language. Default value is <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>.  
  
 /IncludeCallsAcrossThreads:<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>43\</CodeContentPlaceHolder> [or] /I:<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 Optional. Specifies whether to include calls to or from other threads. Default value is <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>.  
  
 /ShowExternalCode:<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 Optional. Specifies whether to display Just My Code for the callstack. When Just My Code is off, all non-user code is displayed. When Just My Code is on, non-user code is displayed as <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> in the callstack output.  
  
 Thread:<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 Optional. Displays the callstack for thread <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>. If no thread is specified, diplays the callstack for the current thread.  
  
## Remarks  
 Changes made to the arguments or switches apply to future invocations of this command. If you issue Debug.ListCallStackby itself, the entire call stack displays. If you specify an index, for example,  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 then the current stack frame is set to that frame (in this case, the second frame).  
  
 You can also write this command using its pre-defined alias, kb. For example, you can enter  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 to set the current stack frame to the second frame.  
  
## Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [List Disassembly Command](../vs140/list-disassembly-command.md)   
 [List Threads Command](../vs140/list-threads-command.md)   
 [Visual Studio Commands](../vs140/visual-studio-commands.md)   
 [Command Window](../vs140/command-window.md)   
 [Find/Command Box](../vs140/find-command-box.md)   
 [Visual Studio Command Aliases](../vs140/visual-studio-command-aliases.md)