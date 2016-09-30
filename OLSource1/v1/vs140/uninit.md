---
title: "UnInit"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 4cd4fc0b-974a-4e61-9ea8-0aaa1a0c52ea
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# UnInit
Finalizes the graphics log file, closes it, and frees resources that were used while the app was actively recording graphics information.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is called automatically when an instance of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> class is destroyed. If the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> instance was not actively recording graphics information, this has no effect.  
  
 After <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> has been called on an instance of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> class, a new graphics log file can be created by calling <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and finalized by calling <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. You can repeat this as many times as you want to use the same <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> instance to create several independent graphics log files.  
  
## See Also  
 [Init](../vs140/init.md)