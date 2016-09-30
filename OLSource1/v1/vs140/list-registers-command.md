---
title: "List Registers Command"
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
  - "debug.listregisters"
helpviewer_keywords: 
  - "list registers command"
  - "Debug.ListRegisters command"
  - "ListRegisters command"
ms.assetid: 19a9d789-f6c9-46b3-b1f6-4934fc33e055
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# List Registers Command
Displays the value of the selected registers and lets you modify the list of registers to show.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Switches  
 /Display [{<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>}...]  
 Displays the values of the specified <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. If no <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is specified, the default list of registers is displayed. If no switch is specified, the behavior is the same. For example:  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
 is equivalent to  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
 /List  
 Displays all register groups in the list.  
  
 /Watch [{<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>}...]  
 Adds one or more <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> values to the list.  
  
 /Unwatch [{<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>}...]  
 Removes one or more <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> values from the list.  
  
## Remarks  
 The alias <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> can be used in place of <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
## Example  
 This example uses the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> alias <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> to display the values of the register group <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Visual Studio Commands with Arguments](../vs140/visual-studio-commands.md)   
 [Debugging Basics: Registers Window](../vs140/debugging-basics--registers-window.md)   
 [How to: Use the Registers Window](../vs140/how-to--use-the-registers-window.md)