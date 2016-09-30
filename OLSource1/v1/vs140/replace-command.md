---
title: "Replace Command"
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
  - "edit.replace"
helpviewer_keywords: 
  - "Edit.Replace command"
  - "Replace command"
ms.assetid: a15767f1-5a3d-44f5-8c77-7b0f1157f340
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Replace Command
Replaces text in files using a subset of the options available on the **Replace in Files** tab of the **Find and Replace** window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Required. The text to match.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Required. The text to substitute for the matched text.  
  
## Switches  
 /all or /a  
 Optional. Replaces all occurrences of the search text with the replacement text.  
  
 /case or /c  
 Optional. Matches occur only if when the uppercase and lowercase characters exactly match those specified in the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> argument.  
  
 /doc or /d  
 Optional. Searches the current document only. Specify only one of the available search scopes, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 /hidden or /h  
 Optional. Searches concealed and collapsed text, such as the metadata of a design-time control, a hidden region of an outlined document, or a collapsed class or method.  
  
 /open or /o  
 Optional. Searches all open documents as if they were one document. Specify only one of the available search scopes, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 /options or /t  
 Optional. Displays a list of the current find option settings and does not perform a search.  
  
 /proc or /p  
 Optional. Searches the current procedure only. Specify only one of the available search scopes, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
 /regex or /r  
 Optional. Uses pre-defined special characters in the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> argument as notations that represent patterns of text rather than the literal characters. For a complete list of regular expression characters, see [Regular Expressions](../vs140/using-regular-expressions-in-visual-studio.md).  
  
 /reset or /e  
 Optional. Returns the find options to their default settings and does not perform a search.  
  
 /sel or /s  
 Optional. Searches the current selection only. Specify only one of the available search scopes, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
 /up or /u  
 Optional. Searches from the current location in the file toward the top of the file. By default, searches begin at the current location in the file and advance toward the bottom of the file.  
  
 /wild or /l  
 Optional. Uses pre-defined special characters in the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> argument as notations to represent a character or sequence of characters.  
  
 /word or /w  
 Optional. Searches only for whole words.  
  
## Example  
 This example replaces <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> in all open documents.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Finding and Replacing Text](../vs140/finding-and-replacing-text.md)   
 [Command Window](../vs140/command-window.md)   
 [Find/Command Box](../vs140/find-command-box.md)   
 [Visual Studio Commands](../vs140/visual-studio-commands.md)   
 [Visual Studio Command Aliases](../vs140/visual-studio-command-aliases.md)