---
title: "Find Command"
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
  - "edit.find"
helpviewer_keywords: 
  - "Find command"
  - "Edit.Find command"
ms.assetid: f0c705dc-2b97-423d-abbf-5584d4827208
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Find Command
Searches files using a subset of the options available on the **Find in Files** tab of the **Find and Replace** window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Required. The text to match.  
  
## Switches  
 /case or /c  
 Optional. Matches occur only if the uppercase and lowercase characters exactly match those specified in the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> argument.  
  
 /doc or /d  
 Optional. Searches the current document only. Specify only one of the available search scopes, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 /markall or /m  
 Optional. Places a graphic on each line that contains a search match within the current document.  
  
 /open or /o  
 Optional. Searches all open documents as if they were one document. Specify only one of the available search scopes, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 /options or /t  
 Optional. Displays a list of the current find option settings and does not perform a search.  
  
 /proc or /p  
 Optional. Searches the current procedure only. Specify only one of the available search scopes, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
 /reset or /e  
 Optional. Returns the find options to their default settings and does not perform a search.  
  
 /sel or /s  
 Optional. Searches the current selection only. Specify only one of the available search scopes, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
 /up or /u  
 Optional. Searches from the current location in the file toward the beginning of the file. By default, searches begin at the current location in the file and searches towards the end of the file.  
  
 /regex or /r  
 Optional. Uses pre-defined special characters in the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> argument as notations that represent patterns of text rather than the literal characters. For a complete list of regular expression characters, see [Regular Expressions](../vs140/using-regular-expressions-in-visual-studio.md).  
  
 /wild or /l  
 Optional. Uses pre-defined special characters in the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> argument as notations to represent a character or sequence of characters.  
  
 /word or /w  
 Optional. Searches only for whole words.  
  
## Example  
 This example performs a case-sensitive search for the word "somestring" in the currently selected section of code.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Command Window](../vs140/command-window.md)   
 [Find/Command Box](../vs140/find-command-box.md)   
 [Visual Studio Commands](../vs140/visual-studio-commands.md)   
 [Visual Studio Command Aliases](../vs140/visual-studio-command-aliases.md)