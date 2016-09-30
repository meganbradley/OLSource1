---
title: "Command Window"
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
  - "VS.CommandWindow"
helpviewer_keywords: 
  - "IDE, Command window"
  - "Mark mode in Command window"
  - "Command window"
  - "Command mode in Command window"
  - "IDE Command window"
ms.assetid: 48711628-1909-4713-a73e-d7b714c77f8a
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Command Window
The **Command** window is used to execute commands or aliases directly in the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] integrated development environment (IDE). You can execute both menu commands and commands that do not appear on any menu. To display the **Command** window, choose **Other Windows** from the **View** menu, and select **Command Window**.  
  
## Displaying the Values of Variables  
 To check the value of a variable <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, use the [Print Command](../vs140/print-command.md):  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The question mark (?) is an alias for <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, so this command can also be written:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Both versions of this command will return the value of the variable <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Entering Commands  
 The greater than symbol (<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>) appears at the left edge of the Command window as a prompt for new lines. Use the UP ARROW and DOWN ARROW keys to scroll through previously issued commands.  
  
|Task|Solution|Example|  
|----------|--------------|-------------|  
|Evaluate an expression.|Preface the expression with a question mark (<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>).|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|  
|Switch to an Immediate window.|Enter <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> into the window without the greater than sign (>)|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|  
|Switch back to the Command window from an Immediate window.|Enter <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> into the window.|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|  
  
 The following shortcuts help you navigate while in Command mode.  
  
|Action|Cursor location|Keybinding|  
|------------|---------------------|----------------|  
|Cycle through the list of previously entered commands.|Input line|UP ARROW & DOWN ARROW|  
|Scroll up the window.|Command window contents|CTRL+UP ARROW|  
|Scroll down the window.|Command window contents|DOWN ARROW or CTRL+DOWN ARROW|  
  
> [!TIP]
>  You can copy all or part of a previous command to the input line by scrolling to it, highlighting all or part of it, and then pressing ENTER.  
  
## Mark Mode  
 When you click on any previous line in the **Command** window, you shift automatically into Mark mode. This allows you to select, edit, and copy the text of previous commands as you would in any text editor, and paste them into the current line.  
  
## The Equals (=) Sign  
 The window used to enter the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> command determines whether an equals sign (=) is interpreted as a comparison operator or as an assignment operator.  
  
 In the **Command** window, an equals sign (=) is interpreted as a comparison operator. You cannot use assignment operators in the **Command** window. So, for example, if the values of variables <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> are different, then the command  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 will return a value of <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
 In the **Immediate** window, by contrast, an equals sign (=) is interpreted as an assignment operator. So, for example, the command  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 will assign to variable <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> the value of variable <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
## Parameters, Switches, and Values  
 Some [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] commands commands have required and optional arguments, switches and values. Certain rules apply when dealing with such commands. The following is an example of a rich command to clarify the terminology.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 In this example,  
  
-   <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is the command  
  
-   <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> are switches (prefaced with the slash [/] character)  
  
-   <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is the value of the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> switch; the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> switch has no value  
  
-   <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> are parameters  
  
    > [!NOTE]
    >  Any command, parameter, switch, or value that contains spaces must have double quotation marks on either side.  
  
 The position of switches and parameters can be interchanged freely on the command line with the exception of the [Shell](../vs140/shell-command.md) command, which requires its switches and parameters in a specific order.  
  
 Nearly every switch supported by a command has two forms: a short (one character) form and a long form. Multiple short-form switches can be combined into a group. For example, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> can be expressed alternately as <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
 If short-form switches are combined into a group and given a value, that value applies to every switch. For example, <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> equates to <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>. An error occurs if any of the switches in the group does not accept a value.  
  
## Escape Characters  
 A caret (^) character in a command line means that the character immediately following it is interpreted literally, rather than as a control character. This can be used to embed straight quotation marks ("), spaces, leading slashes, carets, or any other literal characters in a parameter or switch value, with the exception of switch names. For example,  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A caret functions the same whether it is inside or outside quotation marks. If a caret is the last character on the line, it is ignored. The example shown here demonstrates how to search for the pattern “^t”.  
  
## Use Quotes for Path Names with Spaces  
 If, for example, you want to open a file that has a path containing spaces, you must put double quotes around the path or path segment that contains spaces: **C:\\"Program Files"** or **"C:\Program Files"**.  
  
## See Also  
 [Predefined Visual Studio Command Aliases](../vs140/visual-studio-command-aliases.md)   
 [Visual Studio Commands with Arguments](../vs140/visual-studio-commands.md)