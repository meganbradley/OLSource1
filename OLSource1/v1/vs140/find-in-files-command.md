---
title: "Find in Files Command"
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
  - "edit.findinfiles"
helpviewer_keywords: 
  - "Edit.FindInFiles command"
  - "find in files command"
ms.assetid: 2fc78bfe-b339-4599-97f9-4cafd8a194d9
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Find in Files Command
Search files using a subset of the options available on the **Find in Files** tab of the **Find and Replace** window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Required. The text to match.  
  
## Switches  
 /case or /c  
 Optional. Matches occur only if the uppercase and lowercase characters exactly match those specified in the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> argument.  
  
 /ext: <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Optional. Specifies the file extensions for the files to be searched. If not specified, the previous extension is used if one was previously entered.  
  
 /lookin: <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Optional. Directory to search. If the path contains spaces, enclose the entire path in quotation marks.  
  
 /names or /n  
 Optional. Displays a list of file names that contain matches.  
  
 /options or /t  
 Optional. Displays a list of the current find option settings and does not perform a search.  
  
 /regex or /r  
 Optional. Uses pre-defined special characters in the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> argument as notations that represent patterns of text rather than the literal characters. For a complete list of regular expression characters, see [Regular Expressions](../vs140/using-regular-expressions-in-visual-studio.md).  
  
 /reset or /e  
 Optional. Returns the find options to their default settings and does not perform a search.  
  
 /stop  
 Optional. Halts the current search operation if one is in progress. Search ignores all other arguments when <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> has been specified. For example, to stop the current search you would enter the following:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 /sub or /s  
 Optional. Searches the subfolders within the directory specified in the /lookin:<CodeContentPlaceHolder>9\</CodeContentPlaceHolder> argument.  
  
 /text2 or /2  
 Optional. Displays the results of the search in the Find Results 2 window.  
  
 /wild or /l  
 Optional. Uses pre-defined special characters in the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> argument as notations to represent a character or sequence of characters.  
  
 /word or /w  
 Optional. Searches only for whole words.  
  
## Example  
 This example searches for btnCancel in all .cls files located in the folder "My Visual Studio Projects" and displays the match information in the Find Results 2 Window.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [Find in Files Tab, Find and Replace Window](../vs140/find-in-files.md)   
 [Command Window](../vs140/command-window.md)   
 [Find/Command Box](../vs140/find-command-box.md)   
 [Visual Studio Commands](../vs140/visual-studio-commands.md)   
 [Visual Studio Command Aliases](../vs140/visual-studio-command-aliases.md)