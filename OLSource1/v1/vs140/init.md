---
title: "Init"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: c55ddec8-9101-4673-979b-4109caca9146
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Init
Prepares the in-app component of graphics diagnostics to actively capture and record graphics information to a graphics log file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A callable entity—such as a function, function pointer, lambda, or function object—that takes as parameters the length of a buffer composed of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and a pointer to that buffer, and returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. When invoked, the callable entity determines the file name that will be used to record graphics information, and writes it to the specified buffer before returning.  
  
## Remarks  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> function is called automatically when an instance of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> class is constructed by specifying the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter of its constructor as <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>; otherwise, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> must be called explicitly before you can actively capture and record graphics information.  
  
 You can finalize and close the active graphics log file by calling <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, and then capture and record more graphics information to a new graphics log file by calling <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> again. You can repeat this as many times as you want to create several independent graphics log files by using the same <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> instance.  
  
## See Also  
 [UnInit](../vs140/init.md)