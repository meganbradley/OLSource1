---
title: "VSG_DEFAULT_RUN_FILENAME"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: ea549d2f-c857-458c-93c7-bc5a2d11d15d
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# VSG_DEFAULT_RUN_FILENAME
Defines the default file name of the graphics log file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The file name given by default to the graphics log file when graphics information is captured programmatically.  
  
## Value  
 A string literal that represents the file name of the graphics log file. By default, L"default.vsglog".  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Remarks  
 If the preprocessor symbol <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is defined, then the file name is relative to the current directory of the captured app, or is an absolute path; otherwise, it's relative to the user's temporary files directory and can't be an absolute path.  
  
 To change the defined file name, you must redefine it before you include <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> in your program.  
  
## Example  
 This example shows how to change the capture file's default file name:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [DONT_SAVE_VSGLOG_TO_TEMP](../vs140/dont_save_vsglog_to_temp.md)