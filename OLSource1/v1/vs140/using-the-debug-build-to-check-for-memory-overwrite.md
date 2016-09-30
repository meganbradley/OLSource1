---
title: "Using the Debug Build to Check for Memory Overwrite"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "memory, overwrites"
ms.assetid: 1345eb4d-24ba-4595-b1cc-2da66986311e
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using the Debug Build to Check for Memory Overwrite
To use the debug build to check for memory overwrite, you must first rebuild your project for debug. Then, go to the very beginning of your application's <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function and add the following line:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The debug memory allocator puts guard bytes around all memory allocations. However, these guard bytes don't do any good unless you check whether they have been changed (which would indicate a memory overwrite). Otherwise, this just provides a buffer that might, in fact, allow you to get away with a memory overwrite.  
  
 By turning on the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, you will force MFC to make a call to the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function every time a call to **new** or **delete** is made. If a memory overwrite was detected, it will generate a TRACE message that looks similar to the following:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 If you see one of these messages, you need to step through your code to determine where the damage occurred. To isolate more precisely where the memory overwrite occurred, you can make explicit calls to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> yourself. For example:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 If the first ASSERT succeeds and the second one fails, it means that the memory overwrite must have occurred in the function between the two calls.  
  
 Depending on the nature of your application, you may find that <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> causes your program to run too slowly to even test. The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> variable causes <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to be called for every call to new and delete. In that case, you should scatter your own calls to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>( ) as shown above, and try to isolate the memory overwrite that way.  
  
## See Also  
 [Fixing Release Build Problems](../vs140/fixing-release-build-problems.md)