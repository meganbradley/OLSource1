---
title: "Replace In Files Command"
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
  - "edit.replaceinfiles"
helpviewer_keywords: 
  - "Edit.ReplaceInFiles command"
  - "Replace In Files command"
  - "ReplaceInFiles command"
ms.assetid: f116066a-4f65-4f2c-94ef-12cbd8cfb598
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Replace In Files Command
Replaces text in files using a subset of the options available on the **Replace in Files** tab of the **Find and Replace** window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Required. The text to match.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Required. The text to substitute for the matched text.  
  
## Switches  
 /all or /a  
 Optional. Replaces all occurrences of the search text with the replacement text.  
  
 /case or /c  
 Optional. Matches occur only if when the uppercase and lowercase characters exactly match those specified in the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> argument.  
  
 /ext: <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Optional. Specifies the file extensions for the files to be searched.  
  
 /keep or /k  
 Optional. Specifies that all modified files are left open.  
  
 /lookin: <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Optional. Directory to search. If the path contains spaces, enclose the entire path in quotation marks.  
  
 /options or /t  
 Optional. Displays a list of the current find option settings and does not perform a search.  
  
 /regex or /r  
 Optional. Uses pre-defined special characters in the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> argument as notations that represent patterns of text rather than the literal characters. For a complete list of regular expression characters, see [Regular Expressions](../vs140/using-regular-expressions-in-visual-studio.md).  
  
 /reset or /e  
 Optional. Returns the find options to their default settings and does not perform a search.  
  
 /stop  
 Optional. Halts the current search operation if one is in progress. Replace ignores all other arguments when <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> has been specified. For example, to stop the current replacement you would enter the following:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 /sub or /s  
 Optional. Searches the subfolders within the directory specified in the /lookin:<CodeContentPlaceHolder>10\</CodeContentPlaceHolder> argument.  
  
 /text2 or /2  
 Optional. Displays the results of the replacement in the **Find Results 2** window.  
  
 /wild or /l  
 Optional. Uses pre-defined special characters in the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> argument as notations to represent a character or sequence of characters.  
  
 /word or /w  
 Optional. Searches for only whole words.  
  
## Example  
 This example searches for <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and replaces it with <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> in all .cls files located in the folder "my visual studio projects" and displays the replacement information in the **Find Results 2** window.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [Finding and Replacing Text](../vs140/finding-and-replacing-text.md)   
 [Replace in Files Tab, Find and Replace Window](../vs140/replace-in-files.md)   
 [Command Window](../vs140/command-window.md)   
 [Find/Command Box](../vs140/find-command-box.md)   
 [Visual Studio Commands](../vs140/visual-studio-commands.md)   
 [Visual Studio Command Aliases](../vs140/visual-studio-command-aliases.md)